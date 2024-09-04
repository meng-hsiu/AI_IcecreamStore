namespace WindowsFormsApp1
{
    partial class OrdersManage
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
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefreah = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.listAllOrders = new System.Windows.Forms.ListView();
            this.listViewOrderDetail = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Location = new System.Drawing.Point(439, 28);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(121, 29);
            this.cboxType.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(579, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 48);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(46, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(374, 29);
            this.txtSearch.TabIndex = 13;
            // 
            // btnRefreah
            // 
            this.btnRefreah.Location = new System.Drawing.Point(1078, 91);
            this.btnRefreah.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefreah.Name = "btnRefreah";
            this.btnRefreah.Size = new System.Drawing.Size(152, 60);
            this.btnRefreah.TabIndex = 12;
            this.btnRefreah.Text = "重新讀取所有資料";
            this.btnRefreah.UseVisualStyleBackColor = true;
            this.btnRefreah.Click += new System.EventHandler(this.btnRefreah_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.Location = new System.Drawing.Point(1078, 226);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(152, 60);
            this.btnDeleteOrder.TabIndex = 11;
            this.btnDeleteOrder.Text = "刪除選取訂單";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // listAllOrders
            // 
            this.listAllOrders.HideSelection = false;
            this.listAllOrders.Location = new System.Drawing.Point(46, 91);
            this.listAllOrders.Margin = new System.Windows.Forms.Padding(5);
            this.listAllOrders.MultiSelect = false;
            this.listAllOrders.Name = "listAllOrders";
            this.listAllOrders.Size = new System.Drawing.Size(955, 195);
            this.listAllOrders.TabIndex = 8;
            this.listAllOrders.UseCompatibleStateImageBehavior = false;
            this.listAllOrders.View = System.Windows.Forms.View.Details;
            this.listAllOrders.SelectedIndexChanged += new System.EventHandler(this.listAllOrders_SelectedIndexChanged);
            // 
            // listViewOrderDetail
            // 
            this.listViewOrderDetail.HideSelection = false;
            this.listViewOrderDetail.Location = new System.Drawing.Point(46, 318);
            this.listViewOrderDetail.Margin = new System.Windows.Forms.Padding(5);
            this.listViewOrderDetail.MultiSelect = false;
            this.listViewOrderDetail.Name = "listViewOrderDetail";
            this.listViewOrderDetail.Size = new System.Drawing.Size(955, 240);
            this.listViewOrderDetail.TabIndex = 16;
            this.listViewOrderDetail.UseCompatibleStateImageBehavior = false;
            this.listViewOrderDetail.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "訂單總覽";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "訂單詳細資訊";
            // 
            // OrdersManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewOrderDetail);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefreah);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.listAllOrders);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OrdersManage";
            this.Text = "OrdersManage";
            this.Load += new System.EventHandler(this.OrdersManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefreah;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.ListView listAllOrders;
        private System.Windows.Forms.ListView listViewOrderDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}