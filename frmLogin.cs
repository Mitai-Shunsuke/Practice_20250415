using System;
using System.Collections;
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
        #region■プロパティ
        //コンストラクタ
        pgSelectSQL bat = new pgSelectSQL();

        //メインフォーム用
        public static ApplicationContext MainForm;

        #endregion

        #region■ロード
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region■ログインボタン
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
            parameters.Add(new SqlParameter("@CD",txtStaffICD.Text));
            parameters.Add(new SqlParameter("@Pass",txtPass.Text));

            DataTable dt = new DataTable();
            dt = bat.SelectSQL(Query, parameters);
            //実行
            if (dt.Rows.Count > 0)
            {
                this.Hide();

                //メインメニュー画面遷移
                frmMainMenu frmMainMenu = new frmMainMenu(txtStaffICD.Text);

                //★モードレス表示
                frmMainMenu.ShowDialog();
                //frmMainMenu.Show();
                //this.Close();                
            }
            else
            {
                MessageBox.Show("社員CDまたは、パスワードが間違っています。");
            }
        }
        #endregion

        #region■イベント
        //社員名の表示
        private void txtStaffICD_Validated(object sender, EventArgs e)
        {
            if (txtStaffICD.Text == "")
            {
                return;
            }

            //SQL作成
            string Query = CreateSQL_Staff2();

            //パラメータ追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@StaffCD", txtStaffICD.Text));

            //実行
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(Query, parameters);

            if (dt.Rows.Count > 0)
            {
                lblStaffName.Text = dt.Rows[0]["StaffName"].ToString();
            }
            else
            {
                lblStaffName.Text = "";
            }
        }
        #endregion

        #region■入力チェック
        private bool CheckInput()
        {
            //社員CD
            if(txtStaffICD.Text == "")
            {
                MessageBox.Show("社員CDを入力をしてください。");
                return false;
            }
            if(txtStaffICD.Text.Length != 4 || !int.TryParse(txtStaffICD.Text, out int i))
            {
                MessageBox.Show("社員CDは4文字の数字で入力してください。");
                return false;
            }


            //パスワード
            if (txtPass.Text == "")
            {
                MessageBox.Show("パスワードを入力をしてください。");
                return false;
            }
            if(txtPass.Text.Length != 8 || !int.TryParse(txtPass.Text, out int x))
            {
                MessageBox.Show("パスワードは8文字の数字で入力してください。");
                return false;
            }

            return true;
        }
        #endregion

        #region■SQL作成
        //ログイン用
        private string CreateSQL_Staff()
        {
            //SQL作成
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT *");
            sb.AppendLine("FROM IM_STAFF");
            sb.AppendLine("WHERE StaffCD LIKE @CD");
            sb.AppendLine("AND Password LIKE @Pass");

            return sb.ToString();

        }

        //社員名表示用
        private string CreateSQL_Staff2()
        {
            //SQL作成
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT StaffName");
            sb.AppendLine("FROM IM_STAFF");
            sb.AppendLine("WHERE StaffCD LIKE @StaffCD");

            return sb.ToString();
        }
        #endregion        
    }
}
