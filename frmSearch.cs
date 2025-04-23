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
    public partial class frmSearch : Form
    {
        #region■プロパティ
        //コンストラクタ
        pgSelectSQL bat = new pgSelectSQL();

        //検索種類（分類/商品）
        private String Type;

        //入出庫管理画面へ返すCD
        public string valueCD { get; private set; }

        //入出庫管理画面へ返す名称
        public string valueName { get; private set; }

        //反映するかどうかのフラグ
        public bool flg { get; private set; }

        #endregion

        #region■ロード

        public frmSearch(string type)
        {
            InitializeComponent();

            Type = type;

            flg = false;

            //表示設定
            LoadDisplay();

        }


        //初期画面表示
        private void LoadDisplay()
        {
            btnSelection.Enabled = false;
            btnSelection.BackColor = Color.Gray;

            if (Type == "Class")
            {
                lblType.Text = "分類検索";
                this.BackColor = Color.Pink;
            }
            else
            {
                lblType.Text = "商品検索";
                this.BackColor = Color.LightYellow;
            }
        }
        #endregion

        #region■イベント
        //DataGridViewダブルクリック
        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ヘッダーダブルクリックの時は抜ける
            if(e.RowIndex == -1) return;
            if (e.ColumnIndex == -1) return;

            //CDと名称を取得
            valueCD = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            valueName = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();

            //CDと名称を表示
            txtSelectCD.Text = "【" + valueCD + "】";
            txtSelectName.Text = valueName;

            //適応して戻る活性化
            btnSelection.Enabled = true;
            btnSelection.BackColor = Color.DodgerBlue;
        }
        #endregion

        #region■ボタン
        //検索ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            //入力チェック
            if (txtSearch.Text == "")　return;
            
            if (Type == "Class")
            {
                //分類検索
                SearchClass();
            }
            else
            {
                //商品検索
                SearchItem();
            }
        }

        //適用して戻るボタン
        private void btnSelection_Click(object sender, EventArgs e)
        {
            //入出庫管理画面に適応する
            flg = true;
            this.Close();
        }

        //戻るボタン
        private void btnBack_Click(object sender, EventArgs e)
        {
            //入出庫管理画面に適応しない
            this.Close();
        }
        #endregion

        #region■検索処理
        //分類検索
        private void SearchClass()
        {
            string value = txtSearch.Text;

            //SQL作成
            string query = CreateSQL_Class();

            //パラメータ追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ClassName", "%" + value + "%"));
            parameters.Add(new SqlParameter("@ClassCD", "%" + value + "%"));

            //実行
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(query, parameters);

            //表示
            dgv1.DataSource = dt;
        }

        //商品検索
        private void SearchItem()
        {
            string value = txtSearch.Text;

            //SQL作成
            string query = CreateSQL_Item();

            //パラメータ追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ItemName", "%" + value + "%"));
            parameters.Add(new SqlParameter("@ItemCD", "%" + value + "%"));

            //実行
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(query, parameters);

            //表示
            dgv1.DataSource = dt;
        }
        #endregion

        #region■SQL作成
        //分類検索
        private string CreateSQL_Class()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT ");
            sb.AppendLine(" ItemClassCD AS '分類CD'");
            sb.AppendLine(",ItemClassName AS '分類名'");
            sb.AppendLine("FROM IM_ITEM_CLASS");
            sb.AppendLine("WHERE 1= 1");
            sb.AppendLine("AND ItemClassName LIKE @ClassName");

            //数値変換可の場合は全検索
            if(int.TryParse(txtSearch.Text, out int i))
            {
                sb.AppendLine("OR CONVERT(VARCHAR, ItemClassCD) LIKE @ClassCD");
            }            

            return sb.ToString();
        }

        //商品検索
        private string CreateSQL_Item()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT ");
            sb.AppendLine(" ItemCD AS '商品CD'");
            sb.AppendLine(",ItemName AS '商品名'");
            sb.AppendLine("FROM IM_ITEM");
            sb.AppendLine("WHERE 1= 1");
            sb.AppendLine("AND ItemName LIKE @ItemName");            

            //数値変換可の場合は全検索
            if (int.TryParse(txtSearch.Text, out int i))
            {
                sb.AppendLine("OR CONVERT(VARCHAR, ItemCD) LIKE @ItemCD");
            }            

            return sb.ToString();
        }
        #endregion
    }
}
