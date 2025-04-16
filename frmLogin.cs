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
    public partial class frmLogin : Form
    {
        //■プロパティ
        //コンストラクタ
        pgSelectSQL bat = new pgSelectSQL();

        public frmLogin()
        {
            InitializeComponent();
        }

        //■ログインボタン
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //入力チェック
            if(!CheckInput())
            {
                return;
            }

            //SQL取得
            string Query = CreateSQL_Staff();

            //パラメータ追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Name",txtName.Text));
            parameters.Add(new SqlParameter("@Pass",txtPass.Text));

            //実行
            if(bat.SelectSQL(Query, parameters))
            {
                //メインメニュー画面遷移
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.ShowDialog();
            }
        }

        //■入力チェック
        private bool CheckInput()
        {
            //社員名
            if(txtName.Text == "")
            {
                MessageBox.Show("社員名を入力をしてください。");
                return false;
            }


            //パスワード
            if (txtPass.Text == "")
            {
                MessageBox.Show("パスワードを入力をしてください。");
                return false;
            }
            if(txtPass.Text.Length != 4 || !int.TryParse(txtPass.Text, out int i))
            {
                MessageBox.Show("パスワードは4文字の数字で入力してください。");
                return false;
            }

            return true;
        }

        //■SQL作成
        private string CreateSQL_Staff()
        {
            //SQL作成
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT *");
            sb.AppendLine("FROM IM_STAFF");
            sb.AppendLine("WHERE StaffName LIKE @Name");
            sb.AppendLine("AND Password LIKE @Pass");

            return sb.ToString();

        }
    }
}
