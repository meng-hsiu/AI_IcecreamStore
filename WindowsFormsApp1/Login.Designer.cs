namespace WindowsFormsApp1
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblResponse = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEmp = new System.Windows.Forms.RadioButton();
            this.radioPerson = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.btnAccountCheck = new System.Windows.Forms.Button();
            this.lblAccountCheck = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJoinPasswordCheck = new System.Windows.Forms.TextBox();
            this.dateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJoinPassword = new System.Windows.Forms.TextBox();
            this.txtJoinAccount = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.pBoxLogin = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.panelLogin.Controls.Add(this.lblResponse);
            this.panelLogin.Controls.Add(this.groupBox1);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtAccount);
            this.panelLogin.Controls.Add(this.btnRegister);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(6);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(285, 561);
            this.panelLogin.TabIndex = 0;
            // 
            // lblResponse
            // 
            this.lblResponse.ForeColor = System.Drawing.Color.Red;
            this.lblResponse.Location = new System.Drawing.Point(53, 265);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(167, 74);
            this.lblResponse.TabIndex = 7;
            this.lblResponse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEmp);
            this.groupBox1.Controls.Add(this.radioPerson);
            this.groupBox1.Location = new System.Drawing.Point(3, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // radioEmp
            // 
            this.radioEmp.AutoSize = true;
            this.radioEmp.Location = new System.Drawing.Point(178, 19);
            this.radioEmp.Name = "radioEmp";
            this.radioEmp.Size = new System.Drawing.Size(72, 30);
            this.radioEmp.TabIndex = 1;
            this.radioEmp.TabStop = true;
            this.radioEmp.Text = "員工";
            this.radioEmp.UseVisualStyleBackColor = true;
            this.radioEmp.CheckedChanged += new System.EventHandler(this.radioEmp_CheckedChanged);
            // 
            // radioPerson
            // 
            this.radioPerson.AutoSize = true;
            this.radioPerson.Location = new System.Drawing.Point(23, 19);
            this.radioPerson.Name = "radioPerson";
            this.radioPerson.Size = new System.Drawing.Size(72, 30);
            this.radioPerson.TabIndex = 0;
            this.radioPerson.TabStop = true;
            this.radioPerson.Text = "會員";
            this.radioPerson.UseVisualStyleBackColor = true;
            this.radioPerson.CheckedChanged += new System.EventHandler(this.radioPerson_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "密碼:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "帳號:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(53, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 35);
            this.txtPassword.TabIndex = 3;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(53, 153);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(167, 35);
            this.txtAccount.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(79, 473);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 50);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "註冊";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(79, 417);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.AutoScroll = true;
            this.panelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.panelRegister.Controls.Add(this.btnAccountCheck);
            this.panelRegister.Controls.Add(this.lblAccountCheck);
            this.panelRegister.Controls.Add(this.lblCheck);
            this.panelRegister.Controls.Add(this.label8);
            this.panelRegister.Controls.Add(this.txtEmail);
            this.panelRegister.Controls.Add(this.panel1);
            this.panelRegister.Controls.Add(this.btnJoin);
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.txtJoinPasswordCheck);
            this.panelRegister.Controls.Add(this.dateBirthDay);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.txtName);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.txtJoinPassword);
            this.panelRegister.Controls.Add(this.txtJoinAccount);
            this.panelRegister.Controls.Add(this.btnUndo);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRegister.Location = new System.Drawing.Point(699, 0);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(6);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panelRegister.Size = new System.Drawing.Size(285, 561);
            this.panelRegister.TabIndex = 2;
            this.panelRegister.Visible = false;
            // 
            // btnAccountCheck
            // 
            this.btnAccountCheck.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccountCheck.Location = new System.Drawing.Point(222, 291);
            this.btnAccountCheck.Name = "btnAccountCheck";
            this.btnAccountCheck.Size = new System.Drawing.Size(44, 32);
            this.btnAccountCheck.TabIndex = 24;
            this.btnAccountCheck.Text = "檢查";
            this.btnAccountCheck.UseVisualStyleBackColor = true;
            this.btnAccountCheck.Visible = false;
            this.btnAccountCheck.Click += new System.EventHandler(this.btnAccountCheck_Click);
            // 
            // lblAccountCheck
            // 
            this.lblAccountCheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccountCheck.ForeColor = System.Drawing.Color.Red;
            this.lblAccountCheck.Location = new System.Drawing.Point(54, 324);
            this.lblAccountCheck.Name = "lblAccountCheck";
            this.lblAccountCheck.Size = new System.Drawing.Size(167, 32);
            this.lblAccountCheck.TabIndex = 23;
            this.lblAccountCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCheck
            // 
            this.lblCheck.ForeColor = System.Drawing.Color.Red;
            this.lblCheck.Location = new System.Drawing.Point(217, 492);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(34, 35);
            this.lblCheck.TabIndex = 22;
            this.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 26);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(54, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 35);
            this.txtEmail.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(38, 701);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 65);
            this.panel1.TabIndex = 19;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(84, 630);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(108, 42);
            this.btnJoin.TabIndex = 18;
            this.btnJoin.Text = "確認註冊";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "再次確認密碼:";
            // 
            // txtJoinPasswordCheck
            // 
            this.txtJoinPasswordCheck.Location = new System.Drawing.Point(54, 493);
            this.txtJoinPasswordCheck.Name = "txtJoinPasswordCheck";
            this.txtJoinPasswordCheck.PasswordChar = '*';
            this.txtJoinPasswordCheck.Size = new System.Drawing.Size(167, 35);
            this.txtJoinPasswordCheck.TabIndex = 15;
            this.txtJoinPasswordCheck.TextChanged += new System.EventHandler(this.txtJoinPasswordCheck_TextChanged);
            // 
            // dateBirthDay
            // 
            this.dateBirthDay.Location = new System.Drawing.Point(54, 157);
            this.dateBirthDay.Name = "dateBirthDay";
            this.dateBirthDay.Size = new System.Drawing.Size(167, 35);
            this.dateBirthDay.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "生日:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 35);
            this.txtName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "密碼:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "帳號:";
            // 
            // txtJoinPassword
            // 
            this.txtJoinPassword.Location = new System.Drawing.Point(54, 390);
            this.txtJoinPassword.Name = "txtJoinPassword";
            this.txtJoinPassword.PasswordChar = '*';
            this.txtJoinPassword.Size = new System.Drawing.Size(167, 35);
            this.txtJoinPassword.TabIndex = 7;
            // 
            // txtJoinAccount
            // 
            this.txtJoinAccount.Location = new System.Drawing.Point(54, 291);
            this.txtJoinAccount.Name = "txtJoinAccount";
            this.txtJoinAccount.Size = new System.Drawing.Size(167, 35);
            this.txtJoinAccount.TabIndex = 6;
            this.txtJoinAccount.Leave += new System.EventHandler(this.txtJoinAccount_Leave);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::WindowsFormsApp1.Properties.Resources.left;
            this.btnUndo.Location = new System.Drawing.Point(0, 0);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(60, 40);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // pBoxLogin
            // 
            this.pBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBoxLogin.Image = global::WindowsFormsApp1.Properties.Resources.image_fx_ice_cream_shop_pixelart;
            this.pBoxLogin.Location = new System.Drawing.Point(285, 0);
            this.pBoxLogin.Name = "pBoxLogin";
            this.pBoxLogin.Size = new System.Drawing.Size(699, 561);
            this.pBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogin.TabIndex = 1;
            this.pBoxLogin.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.pBoxLogin);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pBoxLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJoinPasswordCheck;
        private System.Windows.Forms.DateTimePicker dateBirthDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJoinPassword;
        private System.Windows.Forms.TextBox txtJoinAccount;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEmp;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblAccountCheck;
        private System.Windows.Forms.Button btnAccountCheck;
        public System.Windows.Forms.RadioButton radioPerson;
    }
}