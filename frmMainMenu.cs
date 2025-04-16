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
        //社員CD
        private int StaffCD;

        #endregion
        public frmMainMenu(string StaffCd)
        {
            InitializeComponent();

            if(int.TryParse(StaffCd,out int i))
            StaffCD = i;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
