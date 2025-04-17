using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlSystem
{
    internal class pgExecuteSQL
    {

        public void ExecuteSQL(string query, List<SqlParameter> parameters)
        {
            string connectionDB = @"Server=(localdb)\MSSQLLocalDB;Database=TEST_DB;Integrated Security=True";

            //SSMS起動
            using (SqlConnection Conn = new SqlConnection(connectionDB))
            {
                try
                {
                    //SSMSログイン
                    Conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, Conn))
                    {
                        // パラメータを追加
                        if (parameters != null && parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        // SQL実行（データ挿入など）
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("エラーが発生しました: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }

}
