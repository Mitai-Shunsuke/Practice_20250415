﻿namespace StockControlSystem
{
    partial class frmSearch
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.txtSelectCD = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSelectName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(102, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(591, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelection.Location = new System.Drawing.Point(649, 658);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(112, 47);
            this.btnSelection.TabIndex = 3;
            this.btnSelection.Text = "適用して戻る";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // txtSelectCD
            // 
            this.txtSelectCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSelectCD.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSelectCD.Location = new System.Drawing.Point(286, 670);
            this.txtSelectCD.Name = "txtSelectCD";
            this.txtSelectCD.ReadOnly = true;
            this.txtSelectCD.Size = new System.Drawing.Size(131, 25);
            this.txtSelectCD.TabIndex = 6;
            this.txtSelectCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(99, 276);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(594, 346);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(99, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "検索結果";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(99, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "検索欄";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSearch.Location = new System.Drawing.Point(194, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(413, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelectName
            // 
            this.txtSelectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSelectName.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSelectName.Location = new System.Drawing.Point(427, 669);
            this.txtSelectName.Name = "txtSelectName";
            this.txtSelectName.ReadOnly = true;
            this.txtSelectName.Size = new System.Drawing.Size(147, 25);
            this.txtSelectName.TabIndex = 13;
            this.txtSelectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Salmon;
            this.btnBack.Location = new System.Drawing.Point(40, 659);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(117, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 110);
            this.panel1.TabIndex = 15;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblType.Location = new System.Drawing.Point(324, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(149, 38);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "（検索種類）";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(191, 672);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "検索結果　：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelectCD);
            this.Controls.Add(this.txtSelectName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSearch";
            this.Text = "検索";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.TextBox txtSelectCD;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtSelectName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label2;
    }
}