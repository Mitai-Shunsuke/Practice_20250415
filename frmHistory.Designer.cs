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
            this.btnHistory = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnFormNowStock = new System.Windows.Forms.Button();
            this.btnFormStockControl = new System.Windows.Forms.Button();
            this.ctrFrmSearchItem1 = new StockControlSystem.CtrFrmSearchItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHistory.Location = new System.Drawing.Point(525, 118);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(149, 34);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "履歴検索";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(23, 170);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(651, 256);
            this.dgv.TabIndex = 7;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnFormNowStock
            // 
            this.btnFormNowStock.BackColor = System.Drawing.Color.Salmon;
            this.btnFormNowStock.Location = new System.Drawing.Point(525, 12);
            this.btnFormNowStock.Name = "btnFormNowStock";
            this.btnFormNowStock.Size = new System.Drawing.Size(149, 34);
            this.btnFormNowStock.TabIndex = 5;
            this.btnFormNowStock.Text = "現在庫管理画面へ";
            this.btnFormNowStock.UseVisualStyleBackColor = false;
            this.btnFormNowStock.Click += new System.EventHandler(this.btnChangeForm_Click);
            // 
            // btnFormStockControl
            // 
            this.btnFormStockControl.BackColor = System.Drawing.Color.Cyan;
            this.btnFormStockControl.Location = new System.Drawing.Point(525, 64);
            this.btnFormStockControl.Name = "btnFormStockControl";
            this.btnFormStockControl.Size = new System.Drawing.Size(149, 35);
            this.btnFormStockControl.TabIndex = 6;
            this.btnFormStockControl.Text = "入出庫管理画面へ";
            this.btnFormStockControl.UseVisualStyleBackColor = false;
            this.btnFormStockControl.Click += new System.EventHandler(this.btnFormStockControl_Click);
            // 
            // ctrFrmSearchItem1
            // 
            this.ctrFrmSearchItem1.Location = new System.Drawing.Point(12, 12);
            this.ctrFrmSearchItem1.Name = "ctrFrmSearchItem1";
            this.ctrFrmSearchItem1.Size = new System.Drawing.Size(507, 151);
            this.ctrFrmSearchItem1.TabIndex = 1;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 464);
            this.Controls.Add(this.btnFormStockControl);
            this.Controls.Add(this.btnFormNowStock);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.ctrFrmSearchItem1);
            this.Name = "frmHistory";
            this.Text = "入出庫履歴";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CtrFrmSearchItem ctrFrmSearchItem1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnFormNowStock;
        private System.Windows.Forms.Button btnFormStockControl;
    }
}