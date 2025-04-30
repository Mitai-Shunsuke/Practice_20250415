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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace StockControlSystem
{
    public partial class frmNowStocks : Form
    {
        #region■プロパティ
        //コンストラクタ
        pgSelectSQL bat = new pgSelectSQL();

        #endregion

        #region■ロード
        //メイン画面から遷移
        public frmNowStocks()
        {
            InitializeComponent();

            //分類コントロール表示
            ctrFrmSearchClass1.Visible = true;

            //初期画面表示
            InitializeFromMainmenu();
        }

        //入出庫履歴画面からの遷移
        public frmNowStocks(string itemCD, string itemName)
        {
            InitializeComponent();

            //商品コントロール表示
            ctrFrmSearchItem1.Visible = true;
            ctrFrmSearchItem1.txtItemCD.Text = itemCD;
            ctrFrmSearchItem1.txtItemName.Text = itemName;

            //初期画面表示
            InitializeFromHistory();

            //検索後の画面で表示
            btnSearch_Click(null, null);
        }

        //メインメニューから遷移
        private void InitializeFromMainmenu()
        {
            //条件①（入出庫）
            pnlIO.BackColor = Color.Gainsboro;
            radioBtnIn.Checked = true;
            radioBtnIn.Enabled = false;
            radioBtnOut.Enabled = false;

            //条件②（分類か商品）
            pnlItem.BackColor = Color.Gainsboro;
            radioBtnClass1.Checked = true;
            radioBtnClass1.Enabled = false;
            radioBtnItem1.Enabled = false;
            
            //条件③（期間）
            pnlDate.BackColor = Color.Gainsboro;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            chkBoxDateStart.Checked = true;
            chkBoxDateEnd.Checked = true;
            chkBoxDateStart.Enabled = false;
            chkBoxDateEnd.Enabled = false;
        }

        //履歴画面から遷移
        private void InitializeFromHistory()
        {
            //条件①（入出庫）
            pnlIO.BackColor = Color.Gainsboro;
            radioBtnIn.Checked = true;
            radioBtnIn.Enabled = false;
            radioBtnOut.Enabled = false;

            //条件②（分類か商品）
            pnlItem.BackColor = Color.Honeydew;
            checkBoxItem.Checked = true;
            radioBtnItem1.Checked = true;

            //条件③（期間）
            pnlDate.BackColor = Color.Gainsboro;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            chkBoxDateStart.Checked = true;
            chkBoxDateEnd.Checked = true;
            chkBoxDateStart.Enabled = false;
            chkBoxDateEnd.Enabled = false;
        }
        #endregion

        #region■イベント
        //チェックボタン（入出庫指定）
        private void checkBoxIO_CheckedChanged(object sender, EventArgs e)
        {
            //背景色
            pnlIO.BackColor = checkBoxIO.Checked ? Color.Honeydew : Color.Gainsboro;

            bool IOCheck = checkBoxIO.Checked;
            radioBtnIn.Enabled = IOCheck;
            radioBtnOut.Enabled = IOCheck;
        }

        //チェックボタン（商品分類、商品）
        private void checkBoxItem_CheckedChanged(object sender, EventArgs e)
        {
            //背景色
            pnlItem.BackColor = checkBoxItem.Checked ? Color.Honeydew : Color.Gainsboro;

            bool ItemCheck = checkBoxItem.Checked;
            radioBtnClass1.Enabled = ItemCheck;
            radioBtnItem1.Enabled = ItemCheck;
        }

        //チェックボタン（登録期間）
        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            //背景色
            pnlDate.BackColor = checkBoxDate.Checked ? Color.Honeydew : Color.Gainsboro;

            //カレンダー有効化
            bool dateChecked = checkBoxDate.Checked;
            dtpStart.Enabled = dateChecked;
            dtpEnd.Enabled = dateChecked;
            chkBoxDateStart.Enabled = dateChecked;
            chkBoxDateEnd.Enabled = dateChecked;

        }

        //チェックボックス（カレンダー開始）
        private void chkBoxDateStart_CheckedChanged(object sender, EventArgs e)
        {
            //開始カレンダー有効化
            dtpStart.Enabled = chkBoxDateStart.Checked ? true : false;
        }

        //チェックボックス（カレンダー終了）
        private void chkBoxDateEnd_CheckedChanged(object sender, EventArgs e)
        {
            //終了カレンダー有効化
            dtpEnd.Enabled = chkBoxDateEnd.Checked ? true : false;
        }

        //DataGridViewのセル選択変更
        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ////背景色をすべて白色にする
            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    row.DefaultCellStyle.BackColor = Color.White;
            //}

            ////行背景色を変える
            //dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
        }

        //DataGridViewダブルクリック
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //起動中のフォーム名を取得
            List<string> OpenForms = new List<string>();
            OpenForms = GetOpenFromName();
            if(OpenForms.Contains("frmHistory"))
            {
                MessageBox.Show("履歴画面はすでに開いています。複数同時に開くことはできません。");
                return;
            }

            //商品CDと名称取得
            string dgvItemCD = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            string dgvItemName = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();

            frmHistory frmHistory = new frmHistory(dgvItemCD, dgvItemName);
            frmHistory.ShowDialog();
            frmHistory.Dispose();
        }

        //チェックボタン（分類）
        private void radioBtnClass1_CheckedChanged(object sender, EventArgs e)
        {
            ctrFrmSearchClass1.Visible = radioBtnClass1.Checked;
            ctrFrmSearchItem1.Visible = !radioBtnClass1.Checked;
        }

        //チェックボタン（商品）

        private void radioBtnItem1_CheckedChanged(object sender, EventArgs e)
        {
            ctrFrmSearchClass1.Visible = !radioBtnItem1.Checked;
            ctrFrmSearchItem1.Visible = radioBtnItem1.Checked;
        }
        #endregion

        #region■ボタン
        //検索ボタン
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //日付チェック
            if (!CheckDate()) return;

            //SQL作成
            string query = CreateSQL_Select();

            //パラメータ追加
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters = AddParameter();

            //実行
            DataTable dt = new DataTable();
            dt = bat.SelectSQL(query, parameters);

            //表示
            dgv.DataSource = dt;     
            
            dgv.DefaultCellStyle.BackColor= Color.White;
        }
        #endregion

        #region■SQL作成
        private string CreateSQL_Select()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine(" ItemClassCD AS '分類CD'");
            sb.AppendLine(",ItemClassName AS '商品分類'");
            sb.AppendLine(",ItemCD AS '商品CD'");
            sb.AppendLine(",ItemName AS '商品名'");

            if (checkBoxIO.Checked && radioBtnIn.Checked)
            {
                sb.AppendLine(",SUM(入庫数) AS '入庫数'");
            }
            else if (checkBoxIO.Checked && radioBtnOut.Checked)
            {
                sb.AppendLine(",SUM(出庫数) AS '出庫数'");
            }
            else
            {
                sb.AppendLine(",SUM(初期在庫数 + 入庫数 - 出庫数) AS '在庫数'");
            }

            sb.AppendLine("FROM");
            sb.AppendLine("(");
            sb.AppendLine("	SELECT ");
            sb.AppendLine("	 IC.ItemClassCD");
            sb.AppendLine("	,IC.ItemClassName");
            sb.AppendLine("	,H.ItemCD");
            sb.AppendLine("	,I.ItemName");
            sb.AppendLine("	,SUM(CASE WHEN H.Remarks LIKE N'初期在庫' THEN H.Moving ELSE 0 END) AS '初期在庫数'");
            sb.AppendLine("	,SUM(CASE WHEN H.IsReceived = 'True' AND H.Remarks NOT LIKE N'初期在庫' THEN H.Moving ELSE 0 END) AS '入庫数'");
            sb.AppendLine("	,SUM(CASE WHEN H.IsReceived = 'False' AND H.Remarks NOT LIKE N'初期在庫' THEN H.Moving ELSE 0 END) AS '出庫数'");
            sb.AppendLine("	FROM ID_IO_HISTORY H");
            sb.AppendLine("	INNER JOIN IM_ITEM I ON H.ItemCD = I.ItemCD");            

            //②分類CD条件
            if (checkBoxItem.Checked && radioBtnClass1.Checked)
            {
                sb.AppendLine("	INNER JOIN IM_ITEM_CLASS IC ON IC.ItemClassCD = I.ItemClassCD AND I.ItemClassCD = @ClassCD");
            }
            else
            {
                sb.AppendLine("	INNER JOIN IM_ITEM_CLASS IC ON IC.ItemClassCD = I.ItemClassCD");
            }
            
            sb.AppendLine(" WHERE 1=1");

            //①入出庫条件（ラジオボタン）
            if (checkBoxIO.Checked && radioBtnIn.Checked)
            {
                sb.AppendLine("AND H.Remarks NOT LIKE N'初期在庫'");
                sb.AppendLine("	AND H.IsReceived = 'True' ");
            }
            else if (checkBoxIO.Checked && radioBtnOut.Checked)
            {
                sb.AppendLine("AND H.Remarks NOT LIKE N'初期在庫'");
                sb.AppendLine("	AND H.IsReceived = 'False' ");
            }

            //②商品CD条件
            if(checkBoxItem.Checked && radioBtnItem1.Checked)
            {
                sb.AppendLine("AND H.ItemCD LIKE @ItemCD");
            }
            
            //③日付期間条件
            if(checkBoxDate.Checked)
            {
                if (chkBoxDateStart.Checked)
                {
                    sb.AppendLine("	AND @startDate<= H.IODate");
                }

                if(chkBoxDateEnd.Checked)
                {
                    sb.AppendLine("	AND H.IODate <= @endDate");
                }              
            }

            sb.AppendLine("	GROUP BY  IC.ItemClassCD");
            sb.AppendLine("	,IC.ItemClassName");
            sb.AppendLine("	,H.ItemCD");
            sb.AppendLine("	,I.ItemName");
            sb.AppendLine(")X");
            sb.AppendLine("GROUP BY  ItemClassCD");
            sb.AppendLine(",ItemClassName");
            sb.AppendLine(",ItemCD ");
            sb.AppendLine(",ItemName");

            return sb.ToString();
        }
        #endregion

        #region■パラメータ追加
        private List<SqlParameter> AddParameter()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            //②分類または商品条件
            if (checkBoxItem.Checked)
            {
                string classCD = ctrFrmSearchClass1.txtClassCD.Text;
                string itemCD = ctrFrmSearchItem1.txtItemCD.Text;
                parameters.Add(new SqlParameter("@ClassCD", classCD));
                parameters.Add(new SqlParameter("@ItemCD", "%" + itemCD + "%"));
            }

            //③日付条件
            if (checkBoxDate.Checked)
            {
                parameters.Add(new SqlParameter("@startDate", dtpStart.Value.ToString("yyyy/MM/dd")));
                parameters.Add(new SqlParameter("@endDate", dtpEnd.Value.ToString("yyyy/MM/dd")));
            }

            return parameters;
        }
        #endregion

        #region■入力チェック
        //検索条件チェック（日付）
        private bool CheckDate()
        {
            if (checkBoxDate.Checked)
            {
                if(dtpStart.Value == dtpEnd.Value)
                {
                    return true;
                }
                else if (dtpStart.Value > dtpEnd.Value)
                {
                    MessageBox.Show("入出庫期間を修正してください。");
                    return false;
                }
            }            
            return true;
        }
        #endregion

        #region■起動中Form名取得
        private List<string> GetOpenFromName()
        {
            List<string> list = new List<string>();

            foreach(Form form in Application.OpenForms)
            {
                list.Add(form.Name);
            }
            return list;
        }
        #endregion
    }
}
