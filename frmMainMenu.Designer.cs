namespace StockControlSystem
{
    partial class frmMainMenu
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
            this.btnStockControl = new System.Windows.Forms.Button();
            this.btnIOControl = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStockControl
            // 
            this.btnStockControl.BackColor = System.Drawing.Color.Salmon;
            this.btnStockControl.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStockControl.Location = new System.Drawing.Point(213, 78);
            this.btnStockControl.Name = "btnStockControl";
            this.btnStockControl.Size = new System.Drawing.Size(374, 76);
            this.btnStockControl.TabIndex = 0;
            this.btnStockControl.Text = "現在庫管理";
            this.btnStockControl.UseVisualStyleBackColor = false;
            // 
            // btnIOControl
            // 
            this.btnIOControl.BackColor = System.Drawing.Color.Cyan;
            this.btnIOControl.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnIOControl.Location = new System.Drawing.Point(213, 187);
            this.btnIOControl.Name = "btnIOControl";
            this.btnIOControl.Size = new System.Drawing.Size(374, 76);
            this.btnIOControl.TabIndex = 1;
            this.btnIOControl.Text = "入出庫管理";
            this.btnIOControl.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Yellow;
            this.btnHistory.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnHistory.Location = new System.Drawing.Point(213, 294);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(374, 76);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "入出庫履歴";
            this.btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(12, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "終了";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnIOControl);
            this.Controls.Add(this.btnStockControl);
            this.Name = "frmMainMenu";
            this.Text = "メインメニュー";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockControl;
        private System.Windows.Forms.Button btnIOControl;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnClose;
    }
}