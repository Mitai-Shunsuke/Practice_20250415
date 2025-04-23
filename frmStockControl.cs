using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

        //社員CD
        private int StaffCd;

        //選択中のセル行
        private int cellRow;

        #endregion

        public frmStockControl(int StaffCD)
        {
            InitializeComponent();

            StaffCd = StaffCD;

            //dataGridViewの入力形式
            SettingComboBox();
        }

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
                }
                else
                {
                    //選択日付なし
                    DateTime nowTime = DateTime.Now;
                    frmDateTimePicker frmDateTimePicker = new frmDateTimePicker(nowTime);
                    frmDateTimePicker.ShowDialog();

                    string Date = frmDateTimePicker.Date.ToString("yyyy/MM/dd");
                    dataGridView1.CurrentCell.Value = Date;
                }
            }
        }
        #endregion

        #region■ボタン
        //追加ボタン（分類）
        private void btnAddGrid_Class_Click(object sender, EventArgs e)
        {
            //入力チェック（空白）
            if (ctrFrmSearchClass1.txtClassName.Text == "")
            {
                return;
            }

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
            if (ctrFrmSearchItem1.txtItemName.Text == "")
            {
                return;
            }

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
            //データの有無
            if(dataGridView1.Rows.Count == 0)
            {
                return;
            }

            //SQL作成
            string query = CreateSQL_INSERT();

            //パラメータ取得
            List<List<SqlParameter>> allParam = new List<List<SqlParameter>>();
            allParam = AddParameters();
            if(allParam == null )
            {
                return;
            }

            //実行
            bat1.ExecuteMultipleSQL(query, allParam);

            dataGridView1.Rows.Clear();

            MessageBox.Show("データ登録が完了しました。");
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
                if (parameter.Count < 6)
                {
                    return null;
                }

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
    }
}
