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

namespace StockControlSystem
{
    public partial class frmHistory : Form
    {
        #region■プロパティ
        //コンストラクタ
        pgSelectSQL bat = new pgSelectSQL();


        #endregion
        public frmHistory()
        {
            InitializeComponent();

            //ラジオボタン
            radioBtnIn.Enabled = false;
            radioBtnOut.Enabled = false;

            //背景色
            pnlIO.BackColor = Color.Gainsboro;
            pnlItem.BackColor = Color.Gainsboro;
            pnlDate.BackColor = Color.Gainsboro;
        }

        #region■イベント
        //チェックボタン（入出庫）
        private void checkBoxIO_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxIO.Checked)
            {
                radioBtnIn.Enabled = true;
                radioBtnOut.Enabled = true;
                pnlIO.BackColor = Color.Honeydew;
            }
            else
            {
                radioBtnIn.Enabled = false;
                radioBtnOut.Enabled = false;
                pnlIO.BackColor= Color.Gainsboro;
            }
        }

        //チェックボタン（商品分類、商品）
        private void checkBoxItem_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxItem.Checked)
            {
                pnlItem.BackColor = Color.Honeydew;
            }
            else
            {
                pnlItem.BackColor = Color.Gainsboro;
            }
        }

        //チェックボタン（登録期間）
        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                pnlDate.BackColor = Color.Honeydew;
            }
            else
            {
                pnlDate.BackColor = Color.Gainsboro;
            }
        }
        #endregion


        #region■ボタン
        //検索ボタン
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //SQL作成
            string query = CreateSQL_Select();

            //パラメータ追加
            List<SqlParameter> parameters = new List<SqlParameter>();

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
            
            if(checkBoxIO.Checked && radioBtnIn.Checked && radioBtnOut.Checked)
            {

            }
            else if(checkBoxIO.Checked && radioBtnIn.Checked)
            {

            }
            else if(checkBoxIO.Checked && radioBtnOut.Checked)
            {

            }
            else
            {

            }
            sb.AppendLine(",SUM(初期在庫数 + 入庫数 - 出庫数) AS '在庫数'");
            sb.AppendLine("FROM");
            sb.AppendLine("(");
            sb.AppendLine("	SELECT ");
            sb.AppendLine("	 IC.ItemClassCD");
            sb.AppendLine("	,IC.ItemClassName");
            sb.AppendLine("	,H.ItemCD");
            sb.AppendLine("	,I.ItemName");
            sb.AppendLine("	,SUM(CASE WHEN Remarks LIKE N'初期在庫' THEN Moving ELSE 0 END) AS '初期在庫数'");
            sb.AppendLine("	,SUM(CASE WHEN IsReceived = 'True' AND Remarks NOT LIKE N'初期在庫' THEN Moving ELSE 0 END) AS '入庫数'");
            sb.AppendLine("	,SUM(CASE WHEN IsReceived = 'False' AND Remarks NOT LIKE N'初期在庫' THEN Moving ELSE 0 END) AS '出庫数'");
            sb.AppendLine("	FROM ID_IO_HISTORY H");
            sb.AppendLine("	INNER JOIN IM_ITEM I ON H.ItemCD = I.ItemCD");
            sb.AppendLine("	INNER JOIN IM_ITEM_CLASS IC ON IC.ItemClassCD = I.ItemClassCD");
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

        #region■デバッグ用（入出庫管理画面ボタン）
        private void btnDebug_Click(object sender, EventArgs e)
        {
            frmStockControl frmStockControl = new frmStockControl(1000);
            frmStockControl.ShowDialog();
        }

        #endregion
    }
}
