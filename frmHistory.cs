using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlSystem
{
    public partial class frmHistory : Form
    {

        #region■プロパティ
        //コンストラクタ
        pgSelectSQL bat = new pgSelectSQL();

        //現在庫管理画面を開いているか
        private bool IsOpenNowStock = false;

        #endregion

        #region■ロード
        //メインメニュー画面から遷移
        public frmHistory()
        {
            InitializeComponent();
        }

        //現在庫管理画面から遷移
        public frmHistory(string dgvItemCD, string dgvItemName)
        {
            InitializeComponent();

            IsOpenNowStock = true;

            //商品コントロール設定
            ctrFrmSearchItem1.txtItemCD.Text = dgvItemCD;
            ctrFrmSearchItem1.txtItemName.Text = dgvItemName;

            //現在庫管理画面からは検索後の画面で起動
            btnHistory_Click(null,null);
        }

        #endregion

        #region■ボタン
        //現在庫管理画面へボタン
        private void btnChangeForm_Click(object sender, EventArgs e)
        {
            if (IsOpenNowStock)
            {
                MessageBox.Show("現在庫画面はすでに開いています。複数同時に開くことはできません。");
                return; 
            }

            string ItemCD = ctrFrmSearchItem1.txtItemCD.Text;
            string ItemName = ctrFrmSearchItem1.txtItemName.Text;

            frmNowStocks frmNowStocks = new frmNowStocks(ItemCD, ItemName);
            frmNowStocks.ShowDialog();
            frmNowStocks.Dispose();

            IsOpenNowStock = false;
        }

        //履歴検索ボタン
        private void btnHistory_Click(object sender, EventArgs e)
        {
            //入力チェック
            if(ctrFrmSearchItem1.txtItemCD.Text == "") return;

            //SQL作成
            String query = CreateSQL();

            //パラメータ追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ItemCD" , ctrFrmSearchItem1.txtItemCD.Text));

            //実行
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(query, parameters);

            //表示
            dgv.DataSource = dt;

            //入出庫管理画面ボタン有効化
            btnChangeForm.Enabled = dt.Rows.Count > 0 ? true : false;

        }
        #endregion

        #region■SQL作成
        private string CreateSQL()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine(" IODate AS '日付'");
            sb.AppendLine(",CASE WHEN IsReceived = 'True' THEN Moving ELSE 0 END AS '入庫'");
            sb.AppendLine(",CASE WHEN IsReceived = 'False' THEN Moving ELSE 0 END AS '出庫'");
            sb.AppendLine(",SUM(入庫数 - 出庫数) OVER (PARTITION BY ItemCD ORDER BY IODate, HistoryCD) AS 'この時点の在庫数'");
            sb.AppendLine(",Remarks AS '備考'");
            sb.AppendLine("FROM (");
            sb.AppendLine("	SELECT ");
            sb.AppendLine("	 IODate");
            sb.AppendLine("	,ItemCD");
            sb.AppendLine("	,IsReceived");
            sb.AppendLine("	,Moving");
            sb.AppendLine("	,Remarks");
            sb.AppendLine("	,HistoryCD");
            sb.AppendLine("	,CASE WHEN IsReceived = 'True' THEN Moving ELSE 0 END AS 入庫数");
            sb.AppendLine("	,CASE WHEN IsReceived = 'False' THEN Moving ELSE 0 END AS 出庫数");
            sb.AppendLine("	FROM ID_IO_HISTORY");
            sb.AppendLine("	WHERE ItemCD = @ItemCD");
            sb.AppendLine(") X");
            sb.AppendLine("ORDER BY IODate, HistoryCD");

            return sb.ToString();
        }
        #endregion
    }
}
