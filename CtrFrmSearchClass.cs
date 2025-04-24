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
    public partial class CtrFrmSearchClass : UserControl
    {
        #region■プロパティ
        //コンストラクタ
        pgSelectSQL bat = new pgSelectSQL();

        pgExecuteSQL bat1 = new pgExecuteSQL();

        public string ClassCD;

        #endregion

        #region■ロード
        public CtrFrmSearchClass()
        {
            InitializeComponent();
        }

        #endregion

        #region■イベント
        //分類CD入力
        private void txtClassCD_Validated(object sender, EventArgs e)
        {
            //入力チェック
            if (!checkInput())
            {
                return;
            }

            ClassCD = txtClassCD.Text;

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
            sb.AppendLine("WHERE I.ItemClassCD = @ItemClassCD ");

            return sb.ToString();
        }
        #endregion

        #region■入力チェック
        //分類CD
        private bool checkInput()
        {
            //空白チェック
            if(txtClassCD.Text == "")return false;

            //数字チェック
            if (!int.TryParse(txtClassCD.Text, out int i))
            {
                MessageBox.Show("分類CDは数字で入力してください。");
                return false;
            }

            return true;
        }
        #endregion
    }
}
