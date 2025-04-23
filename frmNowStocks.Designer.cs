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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxIO = new System.Windows.Forms.CheckBox();
            this.checkBoxItem = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.radioBtnIn = new System.Windows.Forms.RadioButton();
            this.radioBtnOut = new System.Windows.Forms.RadioButton();
            this.pnlIO = new System.Windows.Forms.Panel();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.radioBtnItem = new System.Windows.Forms.RadioButton();
            this.radioBtnClass = new System.Windows.Forms.RadioButton();
            this.ctrFrmSearchItem1 = new StockControlSystem.CtrFrmSearchItem();
            this.ctrFrmSearch1 = new StockControlSystem.CtrFrmSearchClass();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlIO.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearch.Location = new System.Drawing.Point(19, 384);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(936, 52);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(936, 306);
            this.dataGridView1.TabIndex = 1;
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
            this.checkBoxItem.Location = new System.Drawing.Point(273, 14);
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
            this.checkBoxDate.Location = new System.Drawing.Point(12, 216);
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
            this.radioBtnIn.Location = new System.Drawing.Point(66, 44);
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
            this.radioBtnOut.Location = new System.Drawing.Point(66, 100);
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
            this.pnlIO.Size = new System.Drawing.Size(230, 165);
            this.pnlIO.TabIndex = 8;
            // 
            // pnlItem
            // 
            this.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItem.Controls.Add(this.radioBtnItem);
            this.pnlItem.Controls.Add(this.radioBtnClass);
            this.pnlItem.Controls.Add(this.ctrFrmSearchItem1);
            this.pnlItem.Controls.Add(this.ctrFrmSearch1);
            this.pnlItem.Location = new System.Drawing.Point(280, 21);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(675, 357);
            this.pnlItem.TabIndex = 9;
            // 
            // radioBtnItem
            // 
            this.radioBtnItem.AutoSize = true;
            this.radioBtnItem.Location = new System.Drawing.Point(5, 221);
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
            this.radioBtnClass.Location = new System.Drawing.Point(3, 62);
            this.radioBtnClass.Name = "radioBtnClass";
            this.radioBtnClass.Size = new System.Drawing.Size(96, 19);
            this.radioBtnClass.TabIndex = 12;
            this.radioBtnClass.TabStop = true;
            this.radioBtnClass.Text = "分類で絞る";
            this.radioBtnClass.UseVisualStyleBackColor = true;
            this.radioBtnClass.CheckedChanged += new System.EventHandler(this.radioBtnClass_CheckedChanged);
            // 
            // ctrFrmSearchItem1
            // 
            this.ctrFrmSearchItem1.Location = new System.Drawing.Point(121, 179);
            this.ctrFrmSearchItem1.Name = "ctrFrmSearchItem1";
            this.ctrFrmSearchItem1.Size = new System.Drawing.Size(507, 151);
            this.ctrFrmSearchItem1.TabIndex = 11;
            // 
            // ctrFrmSearch1
            // 
            this.ctrFrmSearch1.Location = new System.Drawing.Point(116, 17);
            this.ctrFrmSearch1.Name = "ctrFrmSearch1";
            this.ctrFrmSearch1.Size = new System.Drawing.Size(422, 156);
            this.ctrFrmSearch1.TabIndex = 10;
            // 
            // pnlDate
            // 
            this.pnlDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDate.Controls.Add(this.dtpStart);
            this.pnlDate.Controls.Add(this.label1);
            this.pnlDate.Controls.Add(this.dtpEnd);
            this.pnlDate.Location = new System.Drawing.Point(19, 226);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(230, 152);
            this.pnlDate.TabIndex = 9;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(14, 26);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "～";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(14, 103);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 2;
            // 
            // frmNowStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 760);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.checkBoxItem);
            this.Controls.Add(this.checkBoxIO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.pnlIO);
            this.Name = "frmNowStocks";
            this.Text = "現在庫管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlIO.ResumeLayout(false);
            this.pnlIO.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.pnlItem.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private CtrFrmSearchClass ctrFrmSearch1;
        private CtrFrmSearchItem ctrFrmSearchItem1;
        private System.Windows.Forms.RadioButton radioBtnItem;
        private System.Windows.Forms.RadioButton radioBtnClass;
    }
}