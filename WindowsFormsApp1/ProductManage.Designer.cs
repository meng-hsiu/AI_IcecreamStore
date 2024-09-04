namespace WindowsFormsApp1
{
    partial class ProductManage
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
            this.listAllitem = new System.Windows.Forms.ListView();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnChangeItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnRefreah = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listAllitem
            // 
            this.listAllitem.HideSelection = false;
            this.listAllitem.Location = new System.Drawing.Point(57, 102);
            this.listAllitem.Margin = new System.Windows.Forms.Padding(5);
            this.listAllitem.MultiSelect = false;
            this.listAllitem.Name = "listAllitem";
            this.listAllitem.Size = new System.Drawing.Size(670, 462);
            this.listAllitem.TabIndex = 0;
            this.listAllitem.UseCompatibleStateImageBehavior = false;
            this.listAllitem.View = System.Windows.Forms.View.Details;
            // 
            // btnNewItem
            // 
            this.btnNewItem.Location = new System.Drawing.Point(790, 124);
            this.btnNewItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(152, 60);
            this.btnNewItem.TabIndex = 1;
            this.btnNewItem.Text = "新增";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnChangeItem
            // 
            this.btnChangeItem.Location = new System.Drawing.Point(790, 238);
            this.btnChangeItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangeItem.Name = "btnChangeItem";
            this.btnChangeItem.Size = new System.Drawing.Size(152, 60);
            this.btnChangeItem.TabIndex = 2;
            this.btnChangeItem.Text = "修改";
            this.btnChangeItem.UseVisualStyleBackColor = true;
            this.btnChangeItem.Click += new System.EventHandler(this.btnChangeItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(790, 504);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(152, 60);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "刪除選取商品";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Visible = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnRefreah
            // 
            this.btnRefreah.Location = new System.Drawing.Point(790, 382);
            this.btnRefreah.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefreah.Name = "btnRefreah";
            this.btnRefreah.Size = new System.Drawing.Size(152, 60);
            this.btnRefreah.TabIndex = 4;
            this.btnRefreah.Text = "重新讀取資料";
            this.btnRefreah.UseVisualStyleBackColor = true;
            this.btnRefreah.Click += new System.EventHandler(this.btnRefreah_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(57, 42);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(374, 29);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(590, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 48);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Location = new System.Drawing.Point(450, 42);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(121, 29);
            this.cboxType.TabIndex = 7;
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 609);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefreah);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnChangeItem);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.listAllitem);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductManage";
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.ProductManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listAllitem;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnChangeItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnRefreah;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboxType;
    }
}