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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddGrid_Class = new System.Windows.Forms.Button();
            this.btnAddGrid_Item = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrFrmSearchClass1 = new StockControlSystem.CtrFrmSearchClass();
            this.ctrFrmSearchItem1 = new StockControlSystem.CtrFrmSearchItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInsert.Location = new System.Drawing.Point(962, 459);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(110, 71);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "登録";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Location = new System.Drawing.Point(962, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 71);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "1行削除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "備考欄";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 81;
            // 
            // Moving
            // 
            this.Moving.HeaderText = "移動数";
            this.Moving.MinimumWidth = 6;
            this.Moving.Name = "Moving";
            this.Moving.Width = 81;
            // 
            // Date
            // 
            this.Date.HeaderText = "入出庫日";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 96;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "商品名";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 81;
            // 
            // ItemCD
            // 
            this.ItemCD.HeaderText = "商品CD";
            this.ItemCD.MinimumWidth = 6;
            this.ItemCD.Name = "ItemCD";
            this.ItemCD.Width = 86;
            // 
            // ItemClassName
            // 
            this.ItemClassName.HeaderText = "商品分類";
            this.ItemClassName.MinimumWidth = 6;
            this.ItemClassName.Name = "ItemClassName";
            this.ItemClassName.Width = 96;
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
            this.Moving,
            this.Remarks});
            this.dataGridView1.Location = new System.Drawing.Point(28, 185);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 345);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // btnAddGrid_Class
            // 
            this.btnAddGrid_Class.BackColor = System.Drawing.Color.Yellow;
            this.btnAddGrid_Class.Location = new System.Drawing.Point(185, 129);
            this.btnAddGrid_Class.Name = "btnAddGrid_Class";
            this.btnAddGrid_Class.Size = new System.Drawing.Size(110, 34);
            this.btnAddGrid_Class.TabIndex = 7;
            this.btnAddGrid_Class.Text = "表に追加";
            this.btnAddGrid_Class.UseVisualStyleBackColor = false;
            this.btnAddGrid_Class.Click += new System.EventHandler(this.btnAddGrid_Class_Click);
            // 
            // btnAddGrid_Item
            // 
            this.btnAddGrid_Item.BackColor = System.Drawing.Color.Yellow;
            this.btnAddGrid_Item.Location = new System.Drawing.Point(709, 129);
            this.btnAddGrid_Item.Name = "btnAddGrid_Item";
            this.btnAddGrid_Item.Size = new System.Drawing.Size(110, 34);
            this.btnAddGrid_Item.TabIndex = 8;
            this.btnAddGrid_Item.Text = "表に追加";
            this.btnAddGrid_Item.UseVisualStyleBackColor = false;
            this.btnAddGrid_Item.Click += new System.EventHandler(this.btnAddGrid_Item_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(446, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "商品コードから1件追加";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "商品分類をまとめて追加";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrFrmSearchClass1
            // 
            this.ctrFrmSearchClass1.Location = new System.Drawing.Point(12, 22);
            this.ctrFrmSearchClass1.Name = "ctrFrmSearchClass1";
            this.ctrFrmSearchClass1.Size = new System.Drawing.Size(421, 157);
            this.ctrFrmSearchClass1.TabIndex = 15;
            // 
            // ctrFrmSearchItem1
            // 
            this.ctrFrmSearchItem1.Location = new System.Drawing.Point(449, 24);
            this.ctrFrmSearchItem1.Name = "ctrFrmSearchItem1";
            this.ctrFrmSearchItem1.Size = new System.Drawing.Size(507, 151);
            this.ctrFrmSearchItem1.TabIndex = 16;
            // 
            // frmStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddGrid_Class);
            this.Controls.Add(this.btnAddGrid_Item);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctrFrmSearchClass1);
            this.Controls.Add(this.ctrFrmSearchItem1);
            this.Name = "frmStockControl";
            this.Text = "入出庫管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moving;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemClassName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddGrid_Class;
        private System.Windows.Forms.Button btnAddGrid_Item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CtrFrmSearchClass ctrFrmSearchClass1;
        private CtrFrmSearchItem ctrFrmSearchItem1;
    }
}