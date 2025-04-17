using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        //ロード処理フラグ
        private bool IsLoading = true;

        #endregion

        public frmStockControl(int StaffCD)
        {
            InitializeComponent();

            StaffCd = StaffCD;

            //dataGridViewの入力形式
            SettingComboBox();
            
            IsLoading = false;
        }

        #region■イベント
        //分類CD
        private void txtClassCD_Validated(object sender, EventArgs e)
        {
            //入力チェック
            if(!checkInput("Class"))
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
            if(dt.Rows.Count > 0)
            {
                txtClassName.Text = dt.Rows[0]["ItemClassName"].ToString();
            }
            else
            {
                MessageBox.Show($"分類CD：「{txtClassCD.Text}」は、存在しません。");
            }
        }

        //商品CD
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

            //
            //if (dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.LightCyan)
            //{
            //    //水色→白色
            //    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            //}
            //else
            //{
            //    //白色→水色
            //    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
            //}

        }

        //DataGridViewのダブルクリック

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //セル取得
            int cellColumn = e.ColumnIndex;

            //「入出庫日」列かどうか
            if (cellColumn == 3)
            {
                frmDateTimePicker frmDateTimePicker = new frmDateTimePicker();
                frmDateTimePicker.ShowDialog();

                string Date = frmDateTimePicker.Date.ToString("yyyy/MM/dd");
                dataGridView1.CurrentCell.Value = Date;
            }
        }
        #endregion

        #region■ボタン

        //追加ボタン（分類）
        private void btnAddGrid_Class_Click(object sender, EventArgs e)
        {
            //入力チェック（空白）
            if(txtClassName.Text == "")
            {
                return;
            }

            //SQL作成
            string query = CreateSQL_Select(true);

            //パラメーター追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ItemClassCD", txtClassCD.Text));

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
            if (txtItemName.Text == "")
            {
                return;
            }

            //SQL作成
            string query = CreateSQL_Select(false);

            //パラメーター追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ItemCD", txtItemCD.Text));

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
            //List<SqlParameter> parameters = AddParameter();
            //データ分繰り返し→★別メソッド
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                //商品CD
                if (int.TryParse(row.Cells[1].Value?.ToString(), out int itemCD))
                {
                    parameters.Add(new SqlParameter("@ItemCD", itemCD));
                }

                //日付
                if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime IODate))
                {
                    parameters.Add(new SqlParameter("@IODate", IODate));
                }

                //入出庫区分
                if (row.Cells[4].Value.ToString() == "入庫")
                {
                    int IsReceived = 1;
                    parameters.Add(new SqlParameter("@IsReceived", IsReceived));
                }
                else
                {
                    int IsReceived = 0;
                    parameters.Add(new SqlParameter("@IsReceived", IsReceived));
                }

                //移動数
                if (int.TryParse(row.Cells[5].Value?.ToString(), out int moving))
                {
                    parameters.Add(new SqlParameter("@Moving", moving));
                }

                //社員CD
                parameters.Add(new SqlParameter("@StaffCD", StaffCd));

                //実行
                bat1.ExecuteSQL(query, parameters);
            }

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
        //CD入力と追加
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

        private string CreateSQL_INSERT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("INSERT INTO ID_IO_HISTORY");
            sb.AppendLine("(IODate,ItemCD,IsReceived,Moving,StaffCD)");
            sb.AppendLine("VALUES");
            sb.AppendLine("(@IODate,@ItemCD,@IsReceived,@Moving,@StaffCD)");


            return sb.ToString();
        }
        #endregion

        #region■パラメータ追加
        //private List<SqlParameter> AddParamereter()
        //{

        //}
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
            if(text == "")
            {
                return false;
            }

            //数字チェック
            if(!int.TryParse(text, out int i))
            {
                MessageBox.Show($"{Error}は数字で入力してください。");
                return false;
            }

            return true;
        }

        #endregion

        #region■DataGridViewへ追加
        private void AddDataGridView(DataTable dt)
        {
            //最大列数取得
            //int maxRow = dt.Rows.Count;

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
