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
            this.ctrFrmSearchItem1 = new StockControlSystem.CtrFrmSearchItem();
            this.btnChangeForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHistory.Location = new System.Drawing.Point(525, 118);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(149, 34);
            this.btnHistory.TabIndex = 2;
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
            this.dgv.TabIndex = 3;
            // 
            // ctrFrmSearchItem1
            // 
            this.ctrFrmSearchItem1.Location = new System.Drawing.Point(12, 12);
            this.ctrFrmSearchItem1.Name = "ctrFrmSearchItem1";
            this.ctrFrmSearchItem1.Size = new System.Drawing.Size(507, 151);
            this.ctrFrmSearchItem1.TabIndex = 1;
            // 
            // btnChangeForm
            // 
            this.btnChangeForm.BackColor = System.Drawing.Color.Aqua;
            this.btnChangeForm.Location = new System.Drawing.Point(525, 65);
            this.btnChangeForm.Name = "btnChangeForm";
            this.btnChangeForm.Size = new System.Drawing.Size(149, 34);
            this.btnChangeForm.TabIndex = 4;
            this.btnChangeForm.Text = "現在庫管理画面へ";
            this.btnChangeForm.UseVisualStyleBackColor = false;
            this.btnChangeForm.Click += new System.EventHandler(this.btnChangeForm_Click);
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 464);
            this.Controls.Add(this.btnChangeForm);
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
        private System.Windows.Forms.Button btnChangeForm;
    }
}