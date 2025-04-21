namespace StockControlSystem
{
    partial class frmHistory
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
            this.btnDebug = new System.Windows.Forms.Button();
            this.checkBoxIO = new System.Windows.Forms.CheckBox();
            this.checkBoxItem = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.radioBtnIn = new System.Windows.Forms.RadioButton();
            this.radioBtnOut = new System.Windows.Forms.RadioButton();
            this.pnlIO = new System.Windows.Forms.Panel();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.pnlDate = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearch.Location = new System.Drawing.Point(48, 399);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(809, 52);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 469);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 279);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.Orchid;
            this.btnDebug.Location = new System.Drawing.Point(864, 14);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(77, 47);
            this.btnDebug.TabIndex = 2;
            this.btnDebug.Text = "デバッグ用";
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // checkBoxIO
            // 
            this.checkBoxIO.AutoSize = true;
            this.checkBoxIO.Location = new System.Drawing.Point(48, 29);
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
            this.checkBoxItem.Location = new System.Drawing.Point(48, 121);
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
            this.checkBoxDate.Location = new System.Drawing.Point(48, 307);
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
            this.radioBtnIn.Location = new System.Drawing.Point(150, 23);
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
            this.radioBtnOut.Location = new System.Drawing.Point(329, 23);
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
            this.pnlIO.Location = new System.Drawing.Point(55, 38);
            this.pnlIO.Name = "pnlIO";
            this.pnlIO.Size = new System.Drawing.Size(802, 66);
            this.pnlIO.TabIndex = 8;
            // 
            // pnlItem
            // 
            this.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItem.Location = new System.Drawing.Point(55, 128);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(802, 173);
            this.pnlItem.TabIndex = 9;
            // 
            // pnlDate
            // 
            this.pnlDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDate.Location = new System.Drawing.Point(55, 315);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(802, 66);
            this.pnlDate.TabIndex = 9;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 760);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.checkBoxItem);
            this.Controls.Add(this.checkBoxIO);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlIO);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.pnlDate);
            this.Name = "frmHistory";
            this.Text = "入出庫管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlIO.ResumeLayout(false);
            this.pnlIO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.CheckBox checkBoxIO;
        private System.Windows.Forms.CheckBox checkBoxItem;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.RadioButton radioBtnIn;
        private System.Windows.Forms.RadioButton radioBtnOut;
        private System.Windows.Forms.Panel pnlIO;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Panel pnlDate;
    }
}