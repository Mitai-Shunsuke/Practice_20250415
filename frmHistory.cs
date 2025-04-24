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

        #endregion

        #region■ロード
        public frmHistory()
        {
            InitializeComponent();
        }
        #endregion

        #region■ボタン
        //履歴表示ボタン
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

        }
        #endregion

        #region■SQL作成
        private string CreateSQL()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine(" H.IODate AS '日付'");
            sb.AppendLine(",(CASE WHEN H.IsReceived = 'True' THEN H.Moving ELSE 0 END) AS '入庫'");
            sb.AppendLine(",(CASE WHEN H.IsReceived = 'False' THEN H.Moving ELSE 0 END) AS '出庫'");
            sb.AppendLine(",H.Remarks AS '備考'");
            sb.AppendLine("FROM ID_IO_HISTORY H");
            sb.AppendLine("WHERE H.ItemCD = @ItemCD");

            return sb.ToString();
        }
        #endregion

        #region■

        #endregion

    }
}
