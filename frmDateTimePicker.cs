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
        //前の画面に渡すための日付
        public DateTime Date { get; private set; }

        //戻るボタン用日付
        private DateTime selectionDate;
        #endregion

        public frmDateTimePicker(DateTime selectedDate)
        {
            InitializeComponent();
            dateTimePicker1.Value = selectedDate;
            selectionDate = selectedDate;
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
            Date = selectionDate;
            this.Close();
        }
        #endregion
    }
}
