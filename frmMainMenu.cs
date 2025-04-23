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
    public partial class frmMainMenu : Form
    {
        #region■プロパティ

        frmLogin bat = new frmLogin();

        //社員CD
        private int StaffCD;

        #endregion

        #region■ロード
        public frmMainMenu(string StaffCd)
        {
            InitializeComponent();

            if (int.TryParse(StaffCd,out int i))
            StaffCD = i;


        }
        #endregion

        #region■ボタン
        //現在庫管理ボタン
        private void btnStockControl_Click(object sender, EventArgs e)
        {
            frmNowStocks frmHistory = new frmNowStocks();
            frmHistory.ShowDialog();
        }
        //入出庫管理ボタン
        private void btnIOControl_Click(object sender, EventArgs e)
        {
            frmStockControl frmStockControl = new frmStockControl(StaffCD);
            frmStockControl.ShowDialog();
        }

        //入出庫履歴
        private void btnHistory_Click(object sender, EventArgs e)
        {
            
        }

        //終了ボタン
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
