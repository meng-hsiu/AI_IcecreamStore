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
            this.lboxOrder = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.panelCart = new System.Windows.Forms.Panel();
            this.panelOrderHistory = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panelButtons.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.panelOrderHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxOrder
            // 
            this.lboxOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(205)))));
            this.lboxOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboxOrder.FormattingEnabled = true;
            this.lboxOrder.ItemHeight = 26;
            this.lboxOrder.Location = new System.Drawing.Point(0, 0);
            this.lboxOrder.Name = "lboxOrder";
            this.lboxOrder.Size = new System.Drawing.Size(784, 342);
            this.lboxOrder.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 35);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "優惠碼:";
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
            this.panelOrder.Controls.Add(this.btnCheckOrder);
            this.panelOrder.Controls.Add(this.lboxOrder);
            this.panelOrder.Controls.Add(this.textBox1);
            this.panelOrder.Controls.Add(this.label2);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 50);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(784, 711);
            this.panelOrder.TabIndex = 5;
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
            this.panelOrderHistory.Controls.Add(this.listBox2);
            this.panelOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderHistory.Location = new System.Drawing.Point(0, 50);
            this.panelOrderHistory.Name = "panelOrderHistory";
            this.panelOrderHistory.Size = new System.Drawing.Size(784, 711);
            this.panelOrderHistory.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(205)))));
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 26;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(784, 711);
            this.listBox2.TabIndex = 0;
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
            this.panelOrder.PerformLayout();
            this.panelCart.ResumeLayout(false);
            this.panelOrderHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Panel panelOrderHistory;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnCheckOrder;
    }
}