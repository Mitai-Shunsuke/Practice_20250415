namespace StockControlSystem
{
    partial class frmNowStocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.checkBoxIO = new System.Windows.Forms.CheckBox();
            this.checkBoxItem = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.radioBtnIn = new System.Windows.Forms.RadioButton();
            this.radioBtnOut = new System.Windows.Forms.RadioButton();
            this.pnlIO = new System.Windows.Forms.Panel();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.radioBtnItem = new System.Windows.Forms.RadioButton();
            this.radioBtnClass = new System.Windows.Forms.RadioButton();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.chkBoxDateEnd = new System.Windows.Forms.CheckBox();
            this.chkBoxDateStart = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlIO.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearch.Location = new System.Drawing.Point(656, 314);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 52);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(19, 401);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(756, 347);
            this.dgv.TabIndex = 1;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // checkBoxIO
            // 
            this.checkBoxIO.AutoSize = true;
            this.checkBoxIO.Location = new System.Drawing.Point(12, 12);
            this.checkBoxIO.Name = "checkBoxIO";
            this.checkBoxIO.Size = new System.Drawing.Size(137, 19);
            this.checkBoxIO.TabIndex = 3;
            this.checkBoxIO.Text = "入出庫で絞り込む";
            this.checkBoxIO.UseVisualStyleBackColor = true;
            this.checkBoxIO.CheckedChanged += new System.EventHandler(this.checkBoxIO_CheckedChanged);
            // 
            // checkBoxItem
            // 
            this.checkBoxItem.AutoSize = true;
            this.checkBoxItem.Location = new System.Drawing.Point(12, 86);
            this.checkBoxItem.Name = "checkBoxItem";
            this.checkBoxItem.Size = new System.Drawing.Size(218, 19);
            this.checkBoxItem.TabIndex = 4;
            this.checkBoxItem.Text = "商品分類または商品で絞り込む";
            this.checkBoxItem.UseVisualStyleBackColor = true;
            this.checkBoxItem.CheckedChanged += new System.EventHandler(this.checkBoxItem_CheckedChanged);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(12, 292);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(167, 19);
            this.checkBoxDate.TabIndex = 5;
            this.checkBoxDate.Text = "入出庫期間で絞り込む";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // radioBtnIn
            // 
            this.radioBtnIn.AutoSize = true;
            this.radioBtnIn.Location = new System.Drawing.Point(46, 18);
            this.radioBtnIn.Name = "radioBtnIn";
            this.radioBtnIn.Size = new System.Drawing.Size(83, 19);
            this.radioBtnIn.TabIndex = 6;
            this.radioBtnIn.TabStop = true;
            this.radioBtnIn.Text = "入庫のみ";
            this.radioBtnIn.UseVisualStyleBackColor = true;
            // 
            // radioBtnOut
            // 
            this.radioBtnOut.AutoSize = true;
            this.radioBtnOut.Location = new System.Drawing.Point(208, 18);
            this.radioBtnOut.Name = "radioBtnOut";
            this.radioBtnOut.Size = new System.Drawing.Size(83, 19);
            this.radioBtnOut.TabIndex = 7;
            this.radioBtnOut.TabStop = true;
            this.radioBtnOut.Text = "出庫のみ";
            this.radioBtnOut.UseVisualStyleBackColor = true;
            // 
            // pnlIO
            // 
            this.pnlIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIO.Controls.Add(this.radioBtnOut);
            this.pnlIO.Controls.Add(this.radioBtnIn);
            this.pnlIO.Location = new System.Drawing.Point(19, 21);
            this.pnlIO.Name = "pnlIO";
            this.pnlIO.Size = new System.Drawing.Size(631, 53);
            this.pnlIO.TabIndex = 8;
            // 
            // pnlItem
            // 
            this.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItem.Controls.Add(this.pnlControl);
            this.pnlItem.Controls.Add(this.radioBtnItem);
            this.pnlItem.Controls.Add(this.radioBtnClass);
            this.pnlItem.Location = new System.Drawing.Point(19, 93);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(631, 189);
            this.pnlItem.TabIndex = 9;
            // 
            // pnlControl
            // 
            this.pnlControl.Location = new System.Drawing.Point(46, 43);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(563, 141);
            this.pnlControl.TabIndex = 14;
            // 
            // radioBtnItem
            // 
            this.radioBtnItem.AutoSize = true;
            this.radioBtnItem.Location = new System.Drawing.Point(208, 17);
            this.radioBtnItem.Name = "radioBtnItem";
            this.radioBtnItem.Size = new System.Drawing.Size(96, 19);
            this.radioBtnItem.TabIndex = 13;
            this.radioBtnItem.TabStop = true;
            this.radioBtnItem.Text = "商品で絞る";
            this.radioBtnItem.UseVisualStyleBackColor = true;
            this.radioBtnItem.CheckedChanged += new System.EventHandler(this.radioBtnItem_CheckedChanged);
            // 
            // radioBtnClass
            // 
            this.radioBtnClass.AutoSize = true;
            this.radioBtnClass.Location = new System.Drawing.Point(46, 17);
            this.radioBtnClass.Name = "radioBtnClass";
            this.radioBtnClass.Size = new System.Drawing.Size(96, 19);
            this.radioBtnClass.TabIndex = 12;
            this.radioBtnClass.TabStop = true;
            this.radioBtnClass.Text = "分類で絞る";
            this.radioBtnClass.UseVisualStyleBackColor = true;
            this.radioBtnClass.CheckedChanged += new System.EventHandler(this.radioBtnClass_CheckedChanged);
            // 
            // pnlDate
            // 
            this.pnlDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDate.Controls.Add(this.chkBoxDateEnd);
            this.pnlDate.Controls.Add(this.chkBoxDateStart);
            this.pnlDate.Controls.Add(this.checkBox1);
            this.pnlDate.Controls.Add(this.dtpStart);
            this.pnlDate.Controls.Add(this.label1);
            this.pnlDate.Controls.Add(this.dtpEnd);
            this.pnlDate.Location = new System.Drawing.Point(19, 302);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(631, 64);
            this.pnlDate.TabIndex = 9;
            // 
            // chkBoxDateEnd
            // 
            this.chkBoxDateEnd.AutoSize = true;
            this.chkBoxDateEnd.Location = new System.Drawing.Point(305, 23);
            this.chkBoxDateEnd.Name = "chkBoxDateEnd";
            this.chkBoxDateEnd.Size = new System.Drawing.Size(18, 17);
            this.chkBoxDateEnd.TabIndex = 5;
            this.chkBoxDateEnd.UseVisualStyleBackColor = true;
            this.chkBoxDateEnd.CheckedChanged += new System.EventHandler(this.chkBoxDateEnd_CheckedChanged);
            // 
            // chkBoxDateStart
            // 
            this.chkBoxDateStart.AutoSize = true;
            this.chkBoxDateStart.Location = new System.Drawing.Point(21, 24);
            this.chkBoxDateStart.Name = "chkBoxDateStart";
            this.chkBoxDateStart.Size = new System.Drawing.Size(18, 17);
            this.chkBoxDateStart.TabIndex = 4;
            this.chkBoxDateStart.UseVisualStyleBackColor = true;
            this.chkBoxDateStart.CheckedChanged += new System.EventHandler(this.chkBoxDateStart_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-61, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(46, 21);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(257, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "～";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(329, 21);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "検索結果";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNowStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 760);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.checkBoxItem);
            this.Controls.Add(this.checkBoxIO);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.pnlIO);
            this.Controls.Add(this.pnlDate);
            this.Name = "frmNowStocks";
            this.Text = "現在庫管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlIO.ResumeLayout(false);
            this.pnlIO.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.pnlItem.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.CheckBox checkBoxIO;
        private System.Windows.Forms.CheckBox checkBoxItem;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.RadioButton radioBtnIn;
        private System.Windows.Forms.RadioButton radioBtnOut;
        private System.Windows.Forms.Panel pnlIO;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnItem;
        private System.Windows.Forms.RadioButton radioBtnClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkBoxDateEnd;
        private System.Windows.Forms.CheckBox chkBoxDateStart;
        private System.Windows.Forms.UserControl CtrFrmSearchClass1;
        private System.Windows.Forms.UserControl CtrFrmSearchItem1;
        private CtrFrmSearchItem ctrFrmSearchItem1;
    }
}