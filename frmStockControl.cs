﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace StockControlSystem
{
    public partial class frmStockControl : Form
    {
        #region■プロパティ
        //コンストラクタ
        pgSelectSQL bat = new pgSelectSQL();

        pgExecuteSQL bat1 = new pgExecuteSQL();

        //DB接続用
        private string conectDB = ConfigurationManager.AppSettings["connectionDB"];

        //社員CD
        private int StaffCd;

        //選択中のセル行
        private int cellRow;

        //履歴画面から遷移時のItemCD
        private string hItemCD;

        //履歴画面から起動時のデータ保持用
        private DataTable InitializeDt;

        #endregion

        #region■ロード
        public frmStockControl(int StaffCD)
        {
            InitializeComponent();

            StaffCd = StaffCD;

            //登録ボタン表示
            btnInsert.Visible = true;

            //dataGridViewの入力形式
            SettingComboBox();
        }

        public frmStockControl(string itemCD)
        {
            InitializeComponent();

            //上半分非表示（テスト）
            label1.Visible = false;
            label2.Visible = false;
            btnAddGrid_Class.Visible = false;
            btnAddGrid_Item.Visible = false;
            ctrFrmSearchClass1.Visible = false;
            ctrFrmSearchItem1.Visible = false;

            //更新ボタン表示
            btnUpdate.Visible = true;

            hItemCD = itemCD;

            //DataGridViewに表示
            InitializeFromHistory(itemCD);
        }

        //履歴画面から遷移時の初期表示
        private void InitializeFromHistory(string itemCD)
        {
            // SQL作成
            string query = CeateSQL_DeleteHisutory();

            //パラメータ追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ItemCD", itemCD));

            //実行結果
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(query, parameters);

            if(dt.Rows.Count > 0)
            {
                //初期データを保持
                InitializeDt = dt;

                //表示
                ShowDataGridView(dt, true);
                btnBackInit.Visible = true;
            }
            
        }
        #endregion

        #region■イベント
        //DataGridViewのセル選択変更
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //背景色をすべて白色にする
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            cellRow = e.RowIndex;

            //行背景色を変える
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
        }

        //DataGridViewのダブルクリック
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            //セル取得
            int cellColumn = e.ColumnIndex;

            //セル値取得
            if (cellColumn == 3)
            {
                if (DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out DateTime selectedDate))
                {
                    //選択日付あり
                    frmDateTimePicker frmDateTimePicker = new frmDateTimePicker(selectedDate);
                    frmDateTimePicker.ShowDialog();

                    string Date = frmDateTimePicker.Date.ToString("yyyy/MM/dd");
                    dataGridView1.CurrentCell.Value = Date;

                    frmDateTimePicker.Dispose();
                }
                else
                {
                    //選択日付なし
                    DateTime nowTime = DateTime.Now;
                    frmDateTimePicker frmDateTimePicker = new frmDateTimePicker(nowTime);
                    frmDateTimePicker.ShowDialog();

                    string Date = frmDateTimePicker.Date.ToString("yyyy/MM/dd");
                    dataGridView1.CurrentCell.Value = Date;

                    frmDateTimePicker.Dispose();
                }
            }
        }
        #endregion

        #region■ボタン
        //追加ボタン（分類）
        private void btnAddGrid_Class_Click(object sender, EventArgs e)
        {
            //入力チェック（空白）
            if (ctrFrmSearchClass1.txtClassName.Text == "") return;

            //SQL作成
            string query = CreateSQL_Select(true);

            //パラメーター追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ItemClassCD", ctrFrmSearchClass1.txtClassCD.Text));
            
            //実行
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(query, parameters);

            //追加
            AddDataGridView(dt);
        }

        //追加ボタン（商品）
        private void btnAddGrid_Item_Click(object sender, EventArgs e)
        {
            //入力チェック（空白）
            if (ctrFrmSearchItem1.txtItemName.Text == "") return;

            //SQL作成
            string query = CreateSQL_Select(false);

            //パラメーター追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ItemCD", ctrFrmSearchItem1.txtItemCD.Text));

            //実行
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(query, parameters);

            //追加
            AddDataGridView(dt);
        }

        //登録ボタン
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conectDB))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {

                    InsertData(conn, tran);
                    tran.Commit();
                    MessageBox.Show("データ処理が完了しました。");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("登録中にエラー：" + ex.Message);
                }
            }
        }

        //履歴更新ボタン
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //確認メッセージ
            DialogResult result = MessageBox.Show("更新しますか？", "確認", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;            
                        
            using (SqlConnection conn = new SqlConnection(conectDB))
            {
                conn.Open();
                //トランザクション開始
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 既存のデータを全削除
                    string query = CreateSQL_Delete();
                    List<SqlParameter> parameters = new List<SqlParameter>();
                    parameters.Add(new SqlParameter("@ItemCD", hItemCD));

                    //実行（トランザクション付き）
                    bat1.ExecuteSingleSQL(query, parameters, conn, tran);

                    //トランザクションを渡す
                    InsertData(conn, tran);

                    //コミット
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    //ロールバック
                    tran.Rollback();
                    MessageBox.Show("履歴更新中にエラーが発生しました：" + ex.Message);
                }
            }

            this.Close();
        }

        //更新処理用
        private void InsertData(SqlConnection conn, SqlTransaction tran)
        {
            if (dataGridView1.Rows.Count == 0) return;

            //SQL作成
            string query = CreateSQL_INSERT();
            
            //パラメータ追加
            List<List<SqlParameter>> allParam = AddParameters();
            if (allParam == null) return;

            //実行
            bat1.ExecuteMultipleSQL(query, allParam, conn, tran); // tran付きに変更

            dataGridView1.Rows.Clear();
        }

        //一行削除ボタン
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //注意メッセージ
            DialogResult result = MessageBox.Show("削除しますか？","注意",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                //選択行を取得
                int selctionRow = cellRow;

                dataGridView1.Rows.RemoveAt(cellRow);
            }
        }

        //元に戻すボタン
        private void btnBackInit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("すべて元に戻しますか？","注意", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK) ShowDataGridView(InitializeDt, false); //表を初期化
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

        //登録ボタン（ID_IO_HISTORYテーブル）
        private string CreateSQL_INSERT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INSERT INTO ID_IO_HISTORY");
            sb.AppendLine("(IODate,ItemCD,IsReceived,Moving,StaffCD,Remarks)");
            sb.AppendLine("VALUES");
            sb.AppendLine("(@IODate,@ItemCD,@IsReceived,@Moving,@StaffCD,@Remarks)");

            return sb.ToString();
        }

        //履歴画面からの検索結果
        private string CeateSQL_DeleteHisutory()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT ");
            sb.AppendLine(" C.ItemClassName AS '商品分類'");
            sb.AppendLine(",H.ItemCD AS '商品CD'");
            sb.AppendLine(",I.ItemName AS '商品名'");
            sb.AppendLine(",H.IODate AS '入出庫日'");
            sb.AppendLine(",(CASE WHEN H.IsReceived = 'True' THEN N'入庫' ELSE N'出庫'END) AS '区別'");
            sb.AppendLine(",H.Moving AS '移動数'");
            sb.AppendLine(",H.Remarks AS '備考欄'");
            sb.AppendLine("FROM ID_IO_HISTORY H");
            sb.AppendLine("INNER JOIN IM_ITEM I ON H.ItemCD = I.ItemCD");
            sb.AppendLine("INNER JOIN IM_ITEM_CLASS C ON C.ItemClassCD = I.ItemClassCD");
            sb.AppendLine("WHERE H.ItemCD = @ItemCD");
            sb.AppendLine("ORDER BY H.IODate,H.HistoryCD");

            return sb.ToString();
        }

        //テーブルのデータを削除
        private string CreateSQL_Delete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DELETE FROM ID_IO_HISTORY ");
            sb.AppendLine("WHERE ItemCD = @ItemCD");

            return sb.ToString();
        }
        #endregion

        #region■パラメータ追加
        private List<List<SqlParameter>> AddParameters()
        {
            List<List<SqlParameter>> allParams = new List<List<SqlParameter>>();

            //各行のparameter
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                List<SqlParameter> parameter = new List<SqlParameter>();

                //パラメータ追加
                if(!AddParam(parameter, GetSqlParameterInt(row, 1, "商品CD", "ItemCD")) ||
                    !AddParam(parameter, GetSqlParameterDatetime(row, 3, "日付")) ||
                    !AddParam(parameter, GetSqlParameterKbn(row, 4, "区分")) ||
                    !AddParam(parameter, GetSqlParameterInt(row, 5, "移動数", "Moving")) ||
                    !AddParam(parameter, GetSqlParameterRemarks(row, 6, "備考")))
                {
                    return null;
                }
                
                AddParam(parameter, GetSqlParameterStaffCD());//StaffCD
                
                //６項目すべて有効なときだけ追加
                if (parameter.Count < 6) return null;

                allParams.Add(parameter);
            }

            //DataGridView全てのパラメータを追加
            return allParams;
        }
        #endregion

        #region■行単位でパラメータ追加

        //Int型変換&パラメータ追加
        private SqlParameter GetSqlParameterInt(DataGridViewRow row, int colIndex, string colName, string pName)
        {
            if (int.TryParse(row.Cells[colIndex].Value?.ToString(), out int oResult))
            {
                //値はoResultに入ってるのでそのまま終了でOK
                return new SqlParameter("@" + pName, oResult);
            }
            else
            {
                MessageBox.Show(colName + "の値が不正です");
                //★そのセルにフォーカスを移す
                dataGridView1[colIndex, row.Index].Selected = true;
                return null;
            }
        }

        //DateTime型変換&パラメータ追加
        private SqlParameter GetSqlParameterDatetime(DataGridViewRow row, int colIndex, string colName)
        {
            if (DateTime.TryParse(row.Cells[colIndex].Value?.ToString(), out DateTime oResult))
            {
                //値はoResultに入ってるのでそのまま終了でOK
                return new SqlParameter("@IODate", oResult);
            }
            else
            {
                MessageBox.Show(colName + "の値が不正です");
                //★そのセルにフォーカスを移す
                dataGridView1[colIndex, row.Index].Selected = true;
                return null;
            }
        }

        //StaffCD用パラメータ追加
        private SqlParameter GetSqlParameterStaffCD()
        {
            return new SqlParameter("@StaffCd", StaffCd);
        }

        //区分用パラメータ追加
        private SqlParameter GetSqlParameterKbn(DataGridViewRow row, int colIndex, string colName)
        {
            if(row.Cells[colIndex].Value == null)
            {
                MessageBox.Show(colName + "を選択してください。");
                //★そのセルにフォーカスを移す
                dataGridView1[colIndex, row.Index].Selected = true;
                return null;
            }
            else if (row.Cells[colIndex].Value.ToString() == "入庫")
            {
                return new SqlParameter("@IsReceived", "True");
            }
            else
            {
                return new SqlParameter("@IsReceived", "False");
            }
        }

        //備考用パラメータ追加
        private SqlParameter GetSqlParameterRemarks(DataGridViewRow row, int colIndex, string colName)
        {
            if(row.Cells[colIndex].Value == null)
            {
                return new SqlParameter("@Remarks", "");
            }

            return new SqlParameter("@Remarks", row.Cells[colIndex].Value.ToString());
        }

        //パラメータ追加
        private bool AddParam(List<SqlParameter> parameter, SqlParameter p)
        {
            if (p == null)
            {                
                return false;
            }

            parameter.Add(p);
            return true;
        }
        #endregion

        #region■DataGridViewへ追加
        private void AddDataGridView(DataTable dt)
        {
            string className;
            string itemCD;
            string itemName;

            //dt.rows.countで回す
            foreach(DataRow row in dt.Rows)
            {
                //分類名
                className = row["ItemClassName"].ToString();

                //商品CD
                itemCD = row["ItemCD"].ToString();

                //商品名
                itemName = row["ItemName"].ToString();

                //Add
                dataGridView1.Rows.Add(className, itemCD, itemName);
            }
        }

        #endregion

        #region■DataGridViewの表示設定
        //行番号表示
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // 行番号を描画するための設定
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString(); // 1から始まる番号にする
                e.Graphics.DrawString(
                    rowNumber,
                    dataGridView1.DefaultCellStyle.Font,
                    b,
                    e.RowBounds.Location.X + 10, // 左端からのオフセット
                    e.RowBounds.Location.Y + 4   // 上からのオフセット
                );
            }
        }

        //区別の表示
        private void SettingComboBox()
        {
            //ComboBoxを作成
            DataGridViewComboBoxColumn cmbColumn = new DataGridViewComboBoxColumn();
            cmbColumn.HeaderText = "区別";
            cmbColumn.Name = "区別";
            cmbColumn.Items.Add("入庫");
            cmbColumn.Items.Add("出庫");

            //列の挿入インデックス
            dataGridView1.Columns.Insert(4, cmbColumn);
        }
        #endregion

        #region■DataGridViewの表示（履歴画面から）
        //Type:True 通常表示。False 元に戻すボタン
        private void ShowDataGridView(DataTable dt, bool type)
        {
            if(type)SettingComboBox(); dataGridView1.Rows.Clear(); //区別列作成

            foreach (DataRow row in dt.Rows)
            {
                //新しい行追加
                int rowIndex = dataGridView1.Rows.Add();
                
                //カラムごとに記入
                dataGridView1.Rows[rowIndex].Cells[0].Value = row["商品分類"].ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = row["商品CD"].ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = row["商品名"].ToString();

                //カレンダー作成
                if(DateTime.TryParse(row["入出庫日"].ToString(), out DateTime date))
                dataGridView1.Rows[rowIndex].Cells[3].Value = date.ToString("yyyy/MM/dd");                
                dataGridView1.Rows[rowIndex].Cells[4].Value = row["区別"].ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = row["移動数"].ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = row["備考欄"].ToString();
            }
        }
        #endregion
    }
}
