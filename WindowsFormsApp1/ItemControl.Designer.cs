namespace WindowsFormsApp1
{
    partial class ItemControl
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.picboxItem = new System.Windows.Forms.PictureBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPic = new System.Windows.Forms.Button();
            this.lblstate = new System.Windows.Forms.Label();
            this.txtstate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(896, 426);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "儲存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(456, 76);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 29);
            this.txtID.TabIndex = 3;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(456, 131);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(187, 29);
            this.txtPname.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(456, 192);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(187, 29);
            this.txtPrice.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(456, 262);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(187, 29);
            this.txtType.TabIndex = 6;
            // 
            // picboxItem
            // 
            this.picboxItem.Location = new System.Drawing.Point(54, 76);
            this.picboxItem.Name = "picboxItem";
            this.picboxItem.Size = new System.Drawing.Size(296, 265);
            this.picboxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxItem.TabIndex = 8;
            this.picboxItem.TabStop = false;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(688, 76);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(352, 309);
            this.txtdesc.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(371, 79);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 21);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "商品ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "商品名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "價格:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "類型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "商品描述";
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(105, 361);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(176, 54);
            this.btnPic.TabIndex = 15;
            this.btnPic.Text = "選取圖片";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(392, 326);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(42, 21);
            this.lblstate.TabIndex = 17;
            this.lblstate.Text = "狀態";
            // 
            // txtstate
            // 
            this.txtstate.Location = new System.Drawing.Point(456, 323);
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(65, 29);
            this.txtstate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "0:停售 1:正常 其餘:錯誤";
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 518);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.txtstate);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.picboxItem);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ItemControl";
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.ItemControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtPname;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtType;
        public System.Windows.Forms.PictureBox picboxItem;
        public System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Label lblstate;
        public System.Windows.Forms.TextBox txtstate;
        private System.Windows.Forms.Label label5;
    }
}