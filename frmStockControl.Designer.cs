namespace StockControlSystem
{
    partial class frmStockControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchClass1 = new System.Windows.Forms.Button();
            this.btnAddGrid_Class = new System.Windows.Forms.Button();
            this.btnSearchClass2 = new System.Windows.Forms.Button();
            this.btnAddGrid_Item = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassCD = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemCD = new System.Windows.Forms.TextBox();
            this.txtClassCD2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ItemClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemClassName,
            this.ItemCD,
            this.ItemName,
            this.Date,
            this.Moving});
            this.dataGridView1.Location = new System.Drawing.Point(47, 198);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 291);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品分類をまとめて追加";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(686, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品コードから1件追加";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchClass1
            // 
            this.btnSearchClass1.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearchClass1.Location = new System.Drawing.Point(180, 141);
            this.btnSearchClass1.Name = "btnSearchClass1";
            this.btnSearchClass1.Size = new System.Drawing.Size(110, 34);
            this.btnSearchClass1.TabIndex = 3;
            this.btnSearchClass1.Text = "分類検索";
            this.btnSearchClass1.UseVisualStyleBackColor = false;
            // 
            // btnAddGrid_Class
            // 
            this.btnAddGrid_Class.BackColor = System.Drawing.Color.Yellow;
            this.btnAddGrid_Class.Location = new System.Drawing.Point(335, 141);
            this.btnAddGrid_Class.Name = "btnAddGrid_Class";
            this.btnAddGrid_Class.Size = new System.Drawing.Size(110, 34);
            this.btnAddGrid_Class.TabIndex = 4;
            this.btnAddGrid_Class.Text = "表に追加";
            this.btnAddGrid_Class.UseVisualStyleBackColor = false;
            this.btnAddGrid_Class.Click += new System.EventHandler(this.btnAddGrid_Class_Click);
            // 
            // btnSearchClass2
            // 
            this.btnSearchClass2.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearchClass2.Location = new System.Drawing.Point(920, 141);
            this.btnSearchClass2.Name = "btnSearchClass2";
            this.btnSearchClass2.Size = new System.Drawing.Size(110, 34);
            this.btnSearchClass2.TabIndex = 8;
            this.btnSearchClass2.Text = "分類検索";
            this.btnSearchClass2.UseVisualStyleBackColor = false;
            // 
            // btnAddGrid_Item
            // 
            this.btnAddGrid_Item.BackColor = System.Drawing.Color.Yellow;
            this.btnAddGrid_Item.Location = new System.Drawing.Point(1072, 141);
            this.btnAddGrid_Item.Name = "btnAddGrid_Item";
            this.btnAddGrid_Item.Size = new System.Drawing.Size(110, 34);
            this.btnAddGrid_Item.TabIndex = 9;
            this.btnAddGrid_Item.Text = "表に追加";
            this.btnAddGrid_Item.UseVisualStyleBackColor = false;
            this.btnAddGrid_Item.Click += new System.EventHandler(this.btnAddGrid_Item_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInsert.Location = new System.Drawing.Point(1072, 418);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(110, 71);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "登録";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.40704F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.59296F));
            this.tableLayoutPanel1.Controls.Add(this.txtClassName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtClassCD, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassName.Location = new System.Drawing.Point(133, 51);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(256, 22);
            this.txtClassName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(129, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "分類名";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(4, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "分類CD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClassCD
            // 
            this.txtClassCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassCD.Location = new System.Drawing.Point(13, 51);
            this.txtClassCD.Name = "txtClassCD";
            this.txtClassCD.Size = new System.Drawing.Size(100, 22);
            this.txtClassCD.TabIndex = 1;
            this.txtClassCD.Validated += new System.EventHandler(this.txtClassCD_Validated);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0198F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.9802F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel2.Controls.Add(this.txtItemName, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtItemCD, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtClassCD2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(689, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.77778F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.22222F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(493, 84);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemName.Location = new System.Drawing.Point(204, 52);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(285, 22);
            this.txtItemName.TabIndex = 7;
            // 
            // txtItemCD
            // 
            this.txtItemCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemCD.Location = new System.Drawing.Point(100, 52);
            this.txtItemCD.Name = "txtItemCD";
            this.txtItemCD.Size = new System.Drawing.Size(97, 22);
            this.txtItemCD.TabIndex = 6;
            this.txtItemCD.Validated += new System.EventHandler(this.txtItemCD_Validated);
            // 
            // txtClassCD2
            // 
            this.txtClassCD2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassCD2.Location = new System.Drawing.Point(4, 52);
            this.txtClassCD2.Name = "txtClassCD2";
            this.txtClassCD2.ReadOnly = true;
            this.txtClassCD2.Size = new System.Drawing.Size(89, 22);
            this.txtClassCD2.TabIndex = 5;
            this.txtClassCD2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Location = new System.Drawing.Point(204, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 37);
            this.label7.TabIndex = 4;
            this.label7.Text = "商品名";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(100, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "商品CD";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "分類CD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Location = new System.Drawing.Point(1072, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 71);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "1行削除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ItemClassName
            // 
            this.ItemClassName.HeaderText = "商品分類";
            this.ItemClassName.MinimumWidth = 6;
            this.ItemClassName.Name = "ItemClassName";
            this.ItemClassName.Width = 96;
            // 
            // ItemCD
            // 
            this.ItemCD.HeaderText = "商品CD";
            this.ItemCD.MinimumWidth = 6;
            this.ItemCD.Name = "ItemCD";
            this.ItemCD.Width = 86;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "商品名";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 81;
            // 
            // Date
            // 
            this.Date.HeaderText = "入出庫日";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 96;
            // 
            // Moving
            // 
            this.Moving.HeaderText = "移動数";
            this.Moving.MinimumWidth = 6;
            this.Moving.Name = "Moving";
            this.Moving.Width = 81;
            // 
            // frmStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 501);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAddGrid_Item);
            this.Controls.Add(this.btnSearchClass2);
            this.Controls.Add(this.btnAddGrid_Class);
            this.Controls.Add(this.btnSearchClass1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStockControl";
            this.Text = "入出庫管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchClass1;
        private System.Windows.Forms.Button btnAddGrid_Class;
        private System.Windows.Forms.Button btnSearchClass2;
        private System.Windows.Forms.Button btnAddGrid_Item;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassCD;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCD;
        private System.Windows.Forms.TextBox txtClassCD2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moving;
    }
}