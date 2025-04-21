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

        //実行件数
        private int results;

        //■1つずつ作成&実行
        public void ExecuteSingleSQL(string query, List<SqlParameter> parameters)
        {
            //SSMS起動
            using (SqlConnection Conn = new SqlConnection(conectDB))
            {
                //SSMSログイン
                Conn.Open();

                try
                {
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

        //■まとめて実行
        public void ExecuteMultipleSQL(string query, List<List<SqlParameter>> allParam)
        {
            //SSMS起動
            using (SqlConnection Conn = new SqlConnection(conectDB))
            {
                //SSMSログイン
                Conn.Open();
                //トランザクション開始
                SqlTransaction tran = Conn.BeginTransaction();

                try
                {
                    //登録件数（完了後のメッセージ用）
                    int total = 0;

                    foreach (var param in allParam)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, Conn, tran))
                        {
                            cmd.Parameters.AddRange(param.ToArray());
                            total += cmd.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();
                    MessageBox.Show($"更新件数は、 {total}件です。");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("エラーが発生しました: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }

}
