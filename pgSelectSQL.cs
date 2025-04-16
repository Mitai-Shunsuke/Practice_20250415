using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlSystem
{
    internal class pgSelectSQL
    {
        //SELECT文の実行
        public DataTable SelectSQL(string Query, List<SqlParameter> Parameters)
        {
            string connectionDB = @"Server=(localdb)\MSSQLLocalDB;Database=TEST_DB;Integrated Security=True";
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionDB))
                {
                    //SSMS起動
                    conn.Open();

                    //SSMSのNewクエリを作成
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        //SQL作成
                        cmd.CommandText = Query;
                        //パラメータを追加
                        cmd.Parameters.AddRange(Parameters.ToArray());
                        //SqlDataReaderの取得
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            //データをDataTableに読み込み
                            dt.Load(reader);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"データ取得中にエラーが生じました:{ ex.Message}");
            }
            return dt;
        }
    }
}
