using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlSystem
{
    public partial class frmDateTimePicker : Form
    {
        #region■プロパティ
        //日付
        public DateTime Date { get; private set; }
        #endregion
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        #region■ボタン
        //決定ボタン
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //日付取得
            Date = dateTimePicker1.Value;

            this.Close();
        }

        //戻るボタン
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
