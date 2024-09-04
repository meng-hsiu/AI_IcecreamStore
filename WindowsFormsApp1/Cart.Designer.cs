namespace WindowsFormsApp1
{
    partial class Cart
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveIt = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.panelCart = new System.Windows.Forms.Panel();
            this.panelOrderHistory = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnOrderHistory);
            this.panelButtons.Controls.Add(this.btnOrder);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(784, 50);
            this.panelButtons.TabIndex = 4;
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnOrderHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderHistory.Location = new System.Drawing.Point(170, 0);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(170, 50);
            this.btnOrderHistory.TabIndex = 1;
            this.btnOrderHistory.Text = "歷史訂單";
            this.btnOrderHistory.UseVisualStyleBackColor = false;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(0, 0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(170, 50);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "目前訂單";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.btnRemoveAll);
            this.panelOrder.Controls.Add(this.btnRemoveIt);
            this.panelOrder.Controls.Add(this.listViewOrder);
            this.panelOrder.Controls.Add(this.btnCheckOrder);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 50);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(784, 711);
            this.panelOrder.TabIndex = 5;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.ForeColor = System.Drawing.Color.IndianRed;
            this.btnRemoveAll.Location = new System.Drawing.Point(189, 555);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(151, 50);
            this.btnRemoveAll.TabIndex = 7;
            this.btnRemoveAll.Text = "刪除所有項目";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveIt
            // 
            this.btnRemoveIt.Location = new System.Drawing.Point(12, 555);
            this.btnRemoveIt.Name = "btnRemoveIt";
            this.btnRemoveIt.Size = new System.Drawing.Size(158, 50);
            this.btnRemoveIt.TabIndex = 6;
            this.btnRemoveIt.Text = "刪除所選項目";
            this.btnRemoveIt.UseVisualStyleBackColor = true;
            this.btnRemoveIt.Click += new System.EventHandler(this.btnRemoveIt_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(205)))));
            this.listViewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(0, 0);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(784, 549);
            this.listViewOrder.TabIndex = 5;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOrder.Location = new System.Drawing.Point(509, 620);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(247, 68);
            this.btnCheckOrder.TabIndex = 4;
            this.btnCheckOrder.Text = "確認訂單";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // panelCart
            // 
            this.panelCart.Controls.Add(this.panelOrder);
            this.panelCart.Controls.Add(this.panelOrderHistory);
            this.panelCart.Controls.Add(this.panelButtons);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCart.Location = new System.Drawing.Point(0, 0);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(784, 761);
            this.panelCart.TabIndex = 4;
            // 
            // panelOrderHistory
            // 
            this.panelOrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.panelOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderHistory.Location = new System.Drawing.Point(0, 50);
            this.panelOrderHistory.Name = "panelOrderHistory";
            this.panelOrderHistory.Size = new System.Drawing.Size(784, 711);
            this.panelOrderHistory.TabIndex = 4;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.panelCart);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Cart";
            this.Text = "購物車";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cart_FormClosed);
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            this.panelCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Panel panelOrderHistory;
        private System.Windows.Forms.Button btnCheckOrder;
        public System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveIt;
    }
}