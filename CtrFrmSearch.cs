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
    public partial class CtrFrmSearch : UserControl
    {
        #region■プロパティ
        //コンストラクタ
        pgSelectSQL bat = new pgSelectSQL();

        pgExecuteSQL bat1 = new pgExecuteSQL();

        #endregion

        #region■ロード
        public CtrFrmSearch()
        {
            InitializeComponent();
        }

        #endregion

        #region■イベント
        //分類CD入力
        private void txtClassCD_Validated(object sender, EventArgs e)
        {
            //入力チェック
            if (!checkInput("Class"))
            {
                return;
            }

            //SQL作成
            String query = CreateSQL_Select(true);

            //パラメーター追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ItemClassCD", txtClassCD.Text));

            //実行
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(query, parameters);

            //表示
            if (dt.Rows.Count > 0)
            {
                txtClassName.Text = dt.Rows[0]["ItemClassName"].ToString();
            }
            else
            {
                MessageBox.Show($"分類CD：「{txtClassCD.Text}」は、存在しません。");
            }
        }

        //商品CD入力
        private void txtItemCD_Validated(object sender, EventArgs e)
        {
            //入力チェック
            if (!checkInput("Item"))
            {
                return;
            }

            //SQL作成
            String query = CreateSQL_Select(false);

            //パラメーター追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ItemCD", txtItemCD.Text));

            //実行
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(query, parameters);

            //表示
            if (dt.Rows.Count > 0)
            {
                txtClassCD2.Text = dt.Rows[0]["ItemClassCD"].ToString();
                txtItemName.Text = dt.Rows[0]["ItemName"].ToString();
            }
            else
            {
                MessageBox.Show($"分類CD：「{txtItemCD.Text}」は、存在しません。");
            }
        }
        #endregion

        #region■ボタン
        //検索ボタン（分類）
        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch("Class");
            frmSearch.ShowDialog();

            //検索値を適応
            if (frmSearch.flg == true)
            {
                txtClassCD.Text = frmSearch.valueCD;
                txtClassName.Text = frmSearch.valueName;
            }

            frmSearch.Dispose();
        }

        //検索ボタン（商品）
        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch("Item");
            frmSearch.ShowDialog();

            //検索値を適応
            if (frmSearch.flg == true)
            {
                txtItemCD.Text = frmSearch.valueCD;
                txtItemName.Text = frmSearch.valueName;
            }

            frmSearch.Dispose();
        }
        #endregion

        #region■SQL作成
        //CD入力と追加（IM_ITEMテーブル、IM_ITEM_CLASSテーブル）
        private string CreateSQL_Select(bool IsClass)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT ");
            sb.AppendLine(" C.ItemClassCD");
            sb.AppendLine(",C.ItemClassName");
            sb.AppendLine(",I.ItemCD");
            sb.AppendLine(",I.ItemName");
            sb.AppendLine("FROM IM_ITEM I");
            sb.AppendLine("INNER JOIN IM_ITEM_CLASS C ON I.ItemClassCD = C.ItemClassCD ");

            //true = 分類。False = 商品。
            if (IsClass)
            {
                sb.AppendLine("WHERE I.ItemClassCD = @ItemClassCD ");
            }
            else
            {
                sb.AppendLine("WHERE ItemCD = @ItemCD");
            }

            return sb.ToString();
        }
        #endregion

        #region■入力チェック
        //分類CD、商品CD
        private bool checkInput(string btnCategory)
        {
            string text;
            string Error;
            if (btnCategory == "Class")
            {
                text = txtClassCD.Text;
                Error = "分類CD";
            }
            else
            {
                text = txtItemCD.Text;
                Error = "商品CD";
            }

            //空白チェック
            if (text == "")
            {
                return false;
            }

            //数字チェック
            if (!int.TryParse(text, out int i))
            {
                MessageBox.Show($"{Error}は数字で入力してください。");
                return false;
            }

            return true;
        }
        #endregion
    }
}
