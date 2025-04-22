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
        public frmNowStocks()
        {
            InitializeComponent();

            //ラジオボタン
            radioBtnIn.Checked = true;
            radioBtnIn.Enabled = false;
            radioBtnOut.Enabled = false;

            //背景色
            pnlIO.BackColor = Color.Gainsboro;
            pnlItem.BackColor = Color.Gainsboro;
            pnlDate.BackColor = Color.Gainsboro;

            //カレンダー
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
        }
        #endregion

        #region■イベント
        //チェックボタン（入出庫指定）
        private void checkBoxIO_CheckedChanged(object sender, EventArgs e)
        {
            //背景色
            pnlIO.BackColor = checkBoxItem.Checked ? Color.Honeydew : Color.Gainsboro;

            //ボタン有効化
            if (checkBoxIO.Checked)
            {
                radioBtnIn.Enabled = true;
                radioBtnOut.Enabled = true;
            }
            else
            {
                radioBtnIn.Enabled = false;
                radioBtnOut.Enabled = false;
            }
        }

        //チェックボタン（商品分類、商品）
        private void checkBoxItem_CheckedChanged(object sender, EventArgs e)
        {
            //背景色
            pnlDate.BackColor = checkBoxItem.Checked ? Color.Honeydew : Color.Gainsboro;

        }

        //チェックボタン（登録期間）
        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            //背景色
            pnlDate.BackColor = checkBoxDate.Checked ? Color.Honeydew : Color.Gainsboro;

            //カレンダー有効化
            if (checkBoxDate.Checked)
            {
                dtpStart.Enabled = true;
                dtpEnd.Enabled = true;
            }
            else
            {
                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
            }
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
            dataGridView1.DataSource = dt;
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
            sb.AppendLine("	INNER JOIN IM_ITEM_CLASS IC ON IC.ItemClassCD = I.ItemClassCD");
            sb.AppendLine("WHERE 1=1");

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
            
            //③日付期間条件
            if(checkBoxDate.Checked)
            {
                sb.AppendLine("	AND @startDate<= H.IODate");
                sb.AppendLine("	AND H.IODate <= @endDate");
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

            //③日付
            if(checkBoxDate.Checked)
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

        #region■デバッグ用（入出庫管理画面ボタン）
        private void btnDebug_Click(object sender, EventArgs e)
        {
            frmStockControl frmStockControl = new frmStockControl(1000);
            frmStockControl.ShowDialog();
        }

        #endregion

    }
}
