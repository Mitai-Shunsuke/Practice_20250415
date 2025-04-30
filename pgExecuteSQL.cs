using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace StockControlSystem
{

    internal class pgExecuteSQL
    {

        //DB接続パス
        private string conectDB = ConfigurationManager.AppSettings["connectionDB"];

        //■1つずつ作成&実行
        public void ExecuteSingleSQL(string query, List<SqlParameter> parameters, SqlConnection conn, SqlTransaction tran)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn, tran))
                {
                    if (parameters != null && parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    //コミットは呼び出し元
                    cmd.ExecuteNonQuery(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラーが発生しました: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        //■まとめて実行
        public void ExecuteMultipleSQL(string query, List<List<SqlParameter>> allParam, SqlConnection conn, SqlTransaction tran)
        {
            //SSMS起動
            using (SqlConnection Conn = new SqlConnection(conectDB))
            {
                //SSMSログイン
                Conn.Open();

                try
                {
                    //登録件数（完了後のメッセージ用）
                    int total = 0;

                    foreach (var param in allParam)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, Conn))
                        {
                            cmd.Parameters.AddRange(param.ToArray());
                            total += cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    //tran.Rollback();
                    MessageBox.Show("エラーが発生しました: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
