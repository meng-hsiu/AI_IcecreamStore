namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCart = new System.Windows.Forms.Button();
            this.panelItemList = new System.Windows.Forms.Panel();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnPopsicle = new System.Windows.Forms.Button();
            this.btnSundae = new System.Windows.Forms.Button();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnItemList = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.picBoxSearch = new System.Windows.Forms.PictureBox();
            this.picBoxMinimize = new System.Windows.Forms.PictureBox();
            this.picBoxFullScreen = new System.Windows.Forms.PictureBox();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIceCream = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelsundae = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPopsicle = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDrink = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBLeft = new System.Windows.Forms.Panel();
            this.panelBInner = new System.Windows.Forms.Panel();
            this.panelBTOP = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelBBottom = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelItemList.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.paneltitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelIceCream.SuspendLayout();
            this.panelsundae.SuspendLayout();
            this.panelPopsicle.SuspendLayout();
            this.panelDrink.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.panelMenu.Controls.Add(this.btnCart);
            this.panelMenu.Controls.Add(this.panelItemList);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnItemList);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(1, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 763);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 501);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(217, 63);
            this.btnCart.TabIndex = 9;
            this.btnCart.Text = "購物車";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // panelItemList
            // 
            this.panelItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.panelItemList.Controls.Add(this.btnDrink);
            this.panelItemList.Controls.Add(this.btnPopsicle);
            this.panelItemList.Controls.Add(this.btnSundae);
            this.panelItemList.Controls.Add(this.btnIceCream);
            this.panelItemList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItemList.Location = new System.Drawing.Point(0, 249);
            this.panelItemList.Name = "panelItemList";
            this.panelItemList.Size = new System.Drawing.Size(217, 252);
            this.panelItemList.TabIndex = 8;
            this.panelItemList.Visible = false;
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnDrink.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDrink.Image = global::WindowsFormsApp1.Properties.Resources.cup_straw_swoosh;
            this.btnDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrink.Location = new System.Drawing.Point(0, 189);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDrink.Size = new System.Drawing.Size(217, 63);
            this.btnDrink.TabIndex = 8;
            this.btnDrink.Text = "飲料";
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnPopsicle
            // 
            this.btnPopsicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnPopsicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPopsicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopsicle.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPopsicle.Image = global::WindowsFormsApp1.Properties.Resources.popsicle;
            this.btnPopsicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopsicle.Location = new System.Drawing.Point(0, 126);
            this.btnPopsicle.Name = "btnPopsicle";
            this.btnPopsicle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPopsicle.Size = new System.Drawing.Size(217, 63);
            this.btnPopsicle.TabIndex = 7;
            this.btnPopsicle.Text = "冰棒";
            this.btnPopsicle.UseVisualStyleBackColor = false;
            this.btnPopsicle.Click += new System.EventHandler(this.btnPopsicle_Click);
            // 
            // btnSundae
            // 
            this.btnSundae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnSundae.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSundae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSundae.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSundae.Image = global::WindowsFormsApp1.Properties.Resources.bowl_scoop;
            this.btnSundae.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSundae.Location = new System.Drawing.Point(0, 63);
            this.btnSundae.Name = "btnSundae";
            this.btnSundae.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSundae.Size = new System.Drawing.Size(217, 63);
            this.btnSundae.TabIndex = 6;
            this.btnSundae.Text = "聖代";
            this.btnSundae.UseVisualStyleBackColor = false;
            this.btnSundae.Click += new System.EventHandler(this.btnSundae_Click);
            // 
            // btnIceCream
            // 
            this.btnIceCream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnIceCream.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIceCream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIceCream.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIceCream.Image = global::WindowsFormsApp1.Properties.Resources.ice_cream;
            this.btnIceCream.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIceCream.Location = new System.Drawing.Point(0, 0);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnIceCream.Size = new System.Drawing.Size(217, 63);
            this.btnIceCream.TabIndex = 5;
            this.btnIceCream.Text = "霜淇淋";
            this.btnIceCream.UseVisualStyleBackColor = false;
            this.btnIceCream.Click += new System.EventHandler(this.btnIceCream_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Image = global::WindowsFormsApp1.Properties.Resources.sign_out_alt;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 700);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(217, 63);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnItemList
            // 
            this.btnItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnItemList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemList.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnItemList.Image = global::WindowsFormsApp1.Properties.Resources.apps_sort;
            this.btnItemList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemList.Location = new System.Drawing.Point(0, 186);
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Size = new System.Drawing.Size(217, 63);
            this.btnItemList.TabIndex = 4;
            this.btnItemList.Text = "商品清單";
            this.btnItemList.UseVisualStyleBackColor = false;
            this.btnItemList.Click += new System.EventHandler(this.btnItemList_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(176)))), ((int)(((byte)(127)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Image = global::WindowsFormsApp1.Properties.Resources.house_chimney;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 123);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(217, 63);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "首頁";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 123);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.paneltitle.Controls.Add(this.picBoxSearch);
            this.paneltitle.Controls.Add(this.picBoxMinimize);
            this.paneltitle.Controls.Add(this.picBoxFullScreen);
            this.paneltitle.Controls.Add(this.picBoxExit);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(219, 1);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1057, 30);
            this.paneltitle.TabIndex = 1;
            this.paneltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitle_MouseDown);
            this.paneltitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltitle_MouseMove);
            this.paneltitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneltitle_MouseUp);
            // 
            // picBoxSearch
            // 
            this.picBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.picBoxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxSearch.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.picBoxSearch.Location = new System.Drawing.Point(897, 0);
            this.picBoxSearch.Name = "picBoxSearch";
            this.picBoxSearch.Size = new System.Drawing.Size(40, 30);
            this.picBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSearch.TabIndex = 2;
            this.picBoxSearch.TabStop = false;
            this.picBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoxSearch_MouseClick);
            this.picBoxSearch.MouseLeave += new System.EventHandler(this.picBoxSearch_MouseLeave);
            this.picBoxSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxSearch_MouseMove);
            // 
            // picBoxMinimize
            // 
            this.picBoxMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxMinimize.Image = global::WindowsFormsApp1.Properties.Resources.minimize_32dp_E8EAED_FILL0_wght400_GRAD0_opsz40;
            this.picBoxMinimize.Location = new System.Drawing.Point(937, 0);
            this.picBoxMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxMinimize.Name = "picBoxMinimize";
            this.picBoxMinimize.Size = new System.Drawing.Size(40, 30);
            this.picBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMinimize.TabIndex = 4;
            this.picBoxMinimize.TabStop = false;
            this.picBoxMinimize.Visible = false;
            this.picBoxMinimize.Click += new System.EventHandler(this.picBoxMinimize_Click);
            this.picBoxMinimize.MouseLeave += new System.EventHandler(this.picBoxMinimize_MouseLeave);
            this.picBoxMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxMinimize_MouseMove);
            // 
            // picBoxFullScreen
            // 
            this.picBoxFullScreen.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxFullScreen.Image = global::WindowsFormsApp1.Properties.Resources.fullscreen_32dp_E8EAED_FILL0_wght400_GRAD0_opsz40;
            this.picBoxFullScreen.Location = new System.Drawing.Point(977, 0);
            this.picBoxFullScreen.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxFullScreen.Name = "picBoxFullScreen";
            this.picBoxFullScreen.Size = new System.Drawing.Size(40, 30);
            this.picBoxFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFullScreen.TabIndex = 3;
            this.picBoxFullScreen.TabStop = false;
            this.picBoxFullScreen.Visible = false;
            this.picBoxFullScreen.Click += new System.EventHandler(this.picBoxFullScreen_Click);
            this.picBoxFullScreen.MouseLeave += new System.EventHandler(this.picBoxFullScreen_MouseLeave);
            this.picBoxFullScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxFullScreen_MouseMove);
            // 
            // picBoxExit
            // 
            this.picBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.picBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxExit.Image = global::WindowsFormsApp1.Properties.Resources.close_32dp_E8EAED_FILL0_wght400_GRAD0_opsz40;
            this.picBoxExit.Location = new System.Drawing.Point(1017, 0);
            this.picBoxExit.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(40, 30);
            this.picBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxExit.TabIndex = 0;
            this.picBoxExit.TabStop = false;
            this.picBoxExit.Visible = false;
            this.picBoxExit.Click += new System.EventHandler(this.picBoxExit_Click);
            this.picBoxExit.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.picBoxExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelHome.Location = new System.Drawing.Point(219, 31);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1057, 733);
            this.panelHome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1057, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HomePage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelIceCream
            // 
            this.panelIceCream.Controls.Add(this.label2);
            this.panelIceCream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIceCream.Location = new System.Drawing.Point(219, 1);
            this.panelIceCream.Name = "panelIceCream";
            this.panelIceCream.Size = new System.Drawing.Size(1057, 763);
            this.panelIceCream.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(556, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "霜淇淋";
            // 
            // panelsundae
            // 
            this.panelsundae.Controls.Add(this.label3);
            this.panelsundae.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsundae.Location = new System.Drawing.Point(219, 1);
            this.panelsundae.Name = "panelsundae";
            this.panelsundae.Size = new System.Drawing.Size(1057, 763);
            this.panelsundae.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(328, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "聖代";
            // 
            // panelPopsicle
            // 
            this.panelPopsicle.Controls.Add(this.label4);
            this.panelPopsicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPopsicle.Location = new System.Drawing.Point(219, 1);
            this.panelPopsicle.Name = "panelPopsicle";
            this.panelPopsicle.Size = new System.Drawing.Size(1057, 763);
            this.panelPopsicle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(166, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "冰棒";
            // 
            // panelDrink
            // 
            this.panelDrink.Controls.Add(this.panel1);
            this.panelDrink.Controls.Add(this.label5);
            this.panelDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrink.Location = new System.Drawing.Point(219, 31);
            this.panelDrink.Name = "panelDrink";
            this.panelDrink.Size = new System.Drawing.Size(1057, 733);
            this.panelDrink.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(100, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 473);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "飲料";
            // 
            // panelBLeft
            // 
            this.panelBLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelBLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBLeft.Name = "panelBLeft";
            this.panelBLeft.Size = new System.Drawing.Size(1, 764);
            this.panelBLeft.TabIndex = 2;
            // 
            // panelBInner
            // 
            this.panelBInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelBInner.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBInner.Location = new System.Drawing.Point(218, 1);
            this.panelBInner.Name = "panelBInner";
            this.panelBInner.Size = new System.Drawing.Size(1, 763);
            this.panelBInner.TabIndex = 3;
            // 
            // panelBTOP
            // 
            this.panelBTOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelBTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBTOP.Location = new System.Drawing.Point(1, 0);
            this.panelBTOP.Name = "panelBTOP";
            this.panelBTOP.Size = new System.Drawing.Size(1275, 1);
            this.panelBTOP.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(1113, 31);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(160, 30);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "搜尋商品";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Visible = false;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_NotOnFocus);
            // 
            // panelBBottom
            // 
            this.panelBBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelBBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBBottom.Location = new System.Drawing.Point(0, 764);
            this.panelBBottom.Name = "panelBBottom";
            this.panelBBottom.Size = new System.Drawing.Size(1276, 1);
            this.panelBBottom.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1276, 765);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panelDrink);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelIceCream);
            this.Controls.Add(this.panelsundae);
            this.Controls.Add(this.panelPopsicle);
            this.Controls.Add(this.panelBInner);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBTOP);
            this.Controls.Add(this.panelBLeft);
            this.Controls.Add(this.panelBBottom);
            this.MinimumSize = new System.Drawing.Size(1276, 765);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI冰舖";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelItemList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.paneltitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelIceCream.ResumeLayout(false);
            this.panelIceCream.PerformLayout();
            this.panelsundae.ResumeLayout(false);
            this.panelsundae.PerformLayout();
            this.panelPopsicle.ResumeLayout(false);
            this.panelPopsicle.PerformLayout();
            this.panelDrink.ResumeLayout(false);
            this.panelDrink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnItemList;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Panel panelItemList;
        private System.Windows.Forms.Button btnPopsicle;
        private System.Windows.Forms.Button btnSundae;
        private System.Windows.Forms.Button btnIceCream;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox picBoxExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIceCream;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelsundae;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPopsicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelDrink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBoxSearch;
        private System.Windows.Forms.PictureBox picBoxFullScreen;
        private System.Windows.Forms.PictureBox picBoxMinimize;
        private System.Windows.Forms.Panel panelBLeft;
        private System.Windows.Forms.Panel panelBInner;
        private System.Windows.Forms.Panel panelBTOP;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelBBottom;
    }
}

