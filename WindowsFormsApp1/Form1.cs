//還在修改 Linq版本


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Menu menu = new Menu();
        List<Panel> panels = new List<Panel>();//用來存所有選單 這樣可以關掉一些不需要的 節省效能
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<int> listPid= new List<int>();
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        
        

        public Form1()
        {
            InitializeComponent();            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //GlobalVar.panelItemManage = this.panelItemManage;
            #region 存有用到的選單
            panels.Add(panelHome);
            panels.Add(panelPopsicle);
            panels.Add(panelIceCream);
            panels.Add(panelsundae);
            panels.Add(panelDrink);
            panels.Add(panelallproducts);
            panels.Add(panelUserSetting);
            menu.Menupanels(this.panels);
            #endregion
            scsb.DataSource = @".";
            scsb.InitialCatalog = "AIicecreamDB";
            scsb.IntegratedSecurity = true;
            GlobalVar.Form1 = this;
            Console.WriteLine(DateTime.Now);
            GlobalVar.CartButton = this.btnCart;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            
            SQLloadALL();
            CreateRndProduct();
        }


        void CreateRndProduct()
        {
            Random myrnd = new Random();
            int rnd = myrnd.Next(GlobalVar.listallmyproducts.Count());
            lblhometitle.Text = GlobalVar.listallmyproducts[rnd].pname;
            picboxhome.Image = GlobalVar.listallmyproducts[rnd].Image;
            int price = GlobalVar.listallmyproducts[rnd].price;
            lblhomeprice.Text = $"建議售價:{price}元";
            txthomedesc.Text = GlobalVar.listallmyproducts[rnd].pdesc;                

        }







        public void SQLloadALL()
        {
            //釋放資源用            
            foreach (var product in GlobalVar.listallmyproducts)
            {
                product.Image.Dispose(); 
            }
            GlobalVar.listallmyproducts.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                Products myproducts = new Products();
                myproducts.id = (int)reader["id"];
                myproducts.pname = (string)reader["pname"];
                myproducts.pimage = (string)reader["pimage"];
                myproducts.pdesc = (string)reader["pdesc"];
                myproducts.price = (int)reader["price"];
                myproducts.type = (string)reader["type"];
                myproducts.state = (int)reader["state"];
                string Fullpicpath = $"{GlobalVar.image_dir}\\{myproducts.pimage}";
                System.IO.FileStream fs = System.IO.File.OpenRead(Fullpicpath);
                myproducts.fullpath = Fullpicpath;
                myproducts.Image = System.Drawing.Image.FromStream(fs);
                GlobalVar.listallmyproducts.Add(myproducts);
                count += 1;
                fs.Close();
            }

            reader.Close();
            con.Close();
            Console.WriteLine($"讀取了{count}筆資料");
        }


        #region 大按鈕

        private void btnHome_Click(object sender, EventArgs e)
        {
            menu.BigMenu(panelHome);
            CreateRndProduct();
        }
        #region 商品清單
        private void btnItemList_Click(object sender, EventArgs e)
        {
            menu.CreatCollapseMenuSize(panelItemList);
            menu.ShowCollapseMenu(btnItemList, panelItemList);
        }

        string SearchType = "";
        Panel Searchpanel = null;
        private void btnIceCream_Click(object sender, EventArgs e)
        {            
            menu.ShowINCollapseMenu(panelIceCream);
            CreateTypeProducts("冰淇淋", panelIcecreamList);
            txtSearch.BringToFront();
            picBoxSearch.BringToFront();
            SearchType = "冰淇淋";
            Searchpanel = panelIcecreamList;
        }
               

        private void btnSundae_Click(object sender, EventArgs e)
        {            
            menu.ShowINCollapseMenu(panelsundae);
            CreateTypeProducts("聖代", panelSundaeList);
            txtSearch.BringToFront();
            picBoxSearch.BringToFront();
            SearchType = "聖代";
            Searchpanel = panelSundaeList;
        }


        private void btnPopsicle_Click(object sender, EventArgs e)
        {            
            menu.ShowINCollapseMenu(panelPopsicle);
            CreateTypeProducts("冰棒", panelPopsicleList);
            txtSearch.BringToFront();
            picBoxSearch.BringToFront();
            SearchType = "冰棒";
            Searchpanel = panelPopsicleList;

        }


        private void btnDrink_Click(object sender, EventArgs e)
        {            
            menu.ShowINCollapseMenu(panelDrink);
            CreateTypeProducts("飲料", panelDrinkList);
            txtSearch.BringToFront();
            picBoxSearch.BringToFront();
            SearchType = "飲料";
            Searchpanel = panelDrinkList;
        }


        private void btnAllproducts_Click(object sender, EventArgs e)
        {            
            menu.ShowINCollapseMenu(panelallproducts);            
            CreateTypeProducts("所有", panelAllproductslist);
            txtSearch.BringToFront();
            picBoxSearch.BringToFront();
            SearchType = "所有";
            Searchpanel = panelAllproductslist;
        }

        #region 搜尋功能

        bool istxtSearch = false;
        Point txtSearchStartPoint = new Point();
        bool istxtSearchSizeChanged = false;

        string strSearchName = "搜尋商品";

        bool isMouseIN = false;

        private void picBoxSearch_Click(object sender, EventArgs e)
        {
            strSearchName = txtSearch.Text;
            CreateTypeProducts(SearchType, Searchpanel, strSearchName);
        }


        private void picBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            picBoxSearch.BackColor = Color.LightGray;
        }


        private void picBoxSearch_MouseUp(object sender, MouseEventArgs e)
        {
            picBoxSearch.BackColor = Color.DarkGray;
        }

        private void picBoxSearch_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseIN == false)
            {
                picBoxSearch.BackColor = Color.DarkGray;
                isMouseIN = true;
            }
        }

        private void picBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            picBoxSearch.BackColor = Color.Transparent;
            isMouseIN = false;
        }



        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (istxtSearchSizeChanged == false)
            {
                txtSearchStartPoint = txtSearch.Location;
                txtSearch.Location = new Point(txtSearch.Location.X, txtSearch.Location.Y);
                istxtSearchSizeChanged = true;
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }


        private void txtSearch_NotOnFocus(object sender, EventArgs e)
        {
            txtSearch.Text = "搜尋商品";
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = txtSearchStartPoint;
            istxtSearchSizeChanged = false;

        }


        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Text = "";
                this.ActiveControl = null;
            }
        }




        #endregion




        //GPT的方法
        void CreateTypeProducts(string str, Panel panel)
        {
            panel.Controls.Clear();
            panel.AutoScroll = true; 

            List<Products> lists = new List<Products>();

            if (GlobalVar.UserRole < 101)
            {
                if (str == "所有")
                {
                    lists = GlobalVar.listallmyproducts.ToList();
                }
                else
                {
                    lists = GlobalVar.listallmyproducts.Where(s => s.type == str).ToList();
                }
            }
            else
            {
                if (str == "所有")
                {
                    lists = GlobalVar.listallmyproducts.Where(s => s.state == 1).ToList();
                }
                else
                {
                    lists = GlobalVar.listallmyproducts.Where(s => s.type == str && s.state == 1).ToList();
                }
            }
            

            int columns = 4; // 每行顯示的控制項數量
            int rows = (int)Math.Ceiling(lists.Count / (double)columns);
            int columnWidth = 256;

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                //CellBorderStyle = TableLayoutPanelCellBorderStyle.Single, 拿來檢查框框大小的
                ColumnCount = columns,
                RowCount = rows,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };

            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, columnWidth));
            }

            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < lists.Count; i++)
            {
                var product = lists[i];
                product.Dock = DockStyle.Fill;
                product.lblPrice.Text = $"建議售價: {product.price} 元";
                product.lblPname.Text = product.pname;
                product.btnJoinCart.Name = product.id.ToString();
                product.btnDetail.Name = product.id.ToString();
                product.btnDetail.Click -= btnDetail_Click;
                product.btnJoinCart.Click -= btnJoinCart_Click;
                product.btnDetail.Click += btnDetail_Click;
                product.btnJoinCart.Click += btnJoinCart_Click;
                product.pictureBox1.Image = product.Image;

                tableLayoutPanel.Controls.Add(product, i % columns, i / columns);
            }

            panel.Controls.Add(tableLayoutPanel);
            tableLayoutPanel.Dock = DockStyle.Top;
        }



        int columns = 4; // 每行顯示的控制項數量
        void CreateTypeProducts(string str, Panel panel,string SearchName)
        {
            panel.Controls.Clear();
            panel.AutoScroll = true;

            List<Products> lists = new List<Products>();

            if (str == "所有")
            {
                if (SearchName != "搜尋商品")
                {
                    lists = GlobalVar.listallmyproducts.Where(s => s.pname.Contains(SearchName)).ToList();
                }
                else
                {
                    lists = GlobalVar.listallmyproducts;
                }
            }
            else
            {

                if (SearchName != "搜尋商品")
                {
                    lists = GlobalVar.listallmyproducts.Where(s => s.type == str && s.pname.Contains(SearchName)).ToList();
                }
                else
                {
                    lists = GlobalVar.listallmyproducts.Where(s => s.type == str).ToList();
                }
            }

            
            int rows = (int)Math.Ceiling(lists.Count / (double)columns);
            int columnWidth = 256;

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                //CellBorderStyle = TableLayoutPanelCellBorderStyle.Single, 拿來檢查框框大小的
                ColumnCount = columns,
                RowCount = rows,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };

            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, columnWidth));
            }

            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < lists.Count; i++)
            {
                var product = lists[i];
                product.Dock = DockStyle.Fill;
                product.lblPrice.Text = $"建議售價: {product.price} 元";
                product.lblPname.Text = product.pname;
                product.btnJoinCart.Name = product.id.ToString();
                product.btnDetail.Name = product.id.ToString();
                product.btnDetail.Click -= btnDetail_Click;
                product.btnJoinCart.Click -= btnJoinCart_Click;
                product.btnDetail.Click += btnDetail_Click;
                product.btnJoinCart.Click += btnJoinCart_Click;
                product.pictureBox1.Image = product.Image;

                tableLayoutPanel.Controls.Add(product, i % columns, i / columns);
            }

            panel.Controls.Add(tableLayoutPanel);
            tableLayoutPanel.Dock = DockStyle.Top;
        }




        private void btnDetail_Click(object sender, EventArgs e)
        {
            GlobalVar.productDetail.Location = new Point(this.Location.X, this.Location.Y);       
            GlobalVar.productDetail.ShowDialog();
        }



        Timer btnJoinCarttimer = new Timer();
        private void btnJoinCart_Click(object sender, EventArgs e)
        {
            GlobalVar.mycart.showOrder();
            btnCart.BackColor = Color.LightYellow;
            btnJoinCarttimer.Enabled = true;
            btnJoinCarttimer.Interval = 500;
            btnJoinCarttimer.Tick += btnJoinCart_ColorChange;
            btnJoinCarttimer.Start();
        }

        private void btnJoinCart_ColorChange(object sender, EventArgs e)
        {
            btnCart.BackColor = Color.FromArgb(202, 176, 127);
            btnJoinCarttimer.Tick -= btnJoinCart_ColorChange;
            btnJoinCarttimer.Stop();
            btnJoinCarttimer.Enabled = false;
            btnJoinCarttimer.Dispose();
        }

        #endregion

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.btnCart.Enabled = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            clearData();
            
        }

        void clearData()
        {
            GlobalVar.Form1 = null;
            foreach (var item in panels)
            {
                item.Dispose();
            }
            foreach (var product in GlobalVar.listallmyproducts)
            {
                product.Image.Dispose();
            }
            
            GlobalVar.CartButton = null;
            GlobalVar.listallmyproducts.Clear();
            GlobalVar.UserID = 0;
            GlobalVar.UserName = "";
            lblUserName.Text = "";
            GlobalVar.UserRole = 0;
            GlobalVar.Useraccount = "";
            GlobalVar.Userpassword = "";
            GlobalVar.Useremail = "";
            GlobalVar.Userbirthday = DateTime.Now;
            GlobalVar.UserCharacter = 2; //會員:2,員工:1
            GlobalVar.mylogin.radioPerson.Checked = true;
            GlobalVar.UserState = 0; //會員:2,員工:1
            GlobalVar.isLogin = false;
            GlobalVar.mycart.Close();
            GlobalVar.arrayListOrderItem.Clear();
            GlobalVar.arrayListOrderItemCounts.Clear();
            GlobalVar.mylogin.Visible = true;            
            this.Close();
        }

        #endregion        

        #region 視窗拖曳功能
        bool isDown = false;
        Point startPoint = new Point();
        private void paneltitle_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void paneltitle_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
            
        }

        private void paneltitle_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        #endregion

        #region 右上的按鈕


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.picBoxExit.BackColor = Color.IndianRed;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.picBoxExit.BackColor = Color.Transparent;
        }
        private void picBoxExit_Click(object sender, EventArgs e)
        {
            GlobalVar.mylogin.Visible = true;
            clearData();
            this.Close();            
        }

        private void picBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        bool Full = false;
        private void picBoxFullScreen_Click(object sender, EventArgs e)
        {
            if (Full == false)
            {
                WindowState = FormWindowState.Maximized;
                Full = true;
            }
            else
            {                
                WindowState = FormWindowState.Normal;
                Full = false;
            }
            
        }

        private void picBoxFullScreen_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxFullScreen.BackColor = Color.DarkGray;
        }

        private void picBoxFullScreen_MouseLeave(object sender, EventArgs e)
        {
            picBoxFullScreen.BackColor = Color.Transparent;
        }

        private void picBoxMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxMinimize.BackColor = Color.DarkGray;
        }

        private void picBoxMinimize_MouseLeave(object sender, EventArgs e)
        {
            picBoxMinimize.BackColor= Color.Transparent;
        }


        

        #endregion


        bool isEdit = false;
        private void Form1_Activated(object sender, EventArgs e)
        {
            /*
            if (btnCart.Enabled==true)
            {
                menu.BigMenu(panelHome);
                CreateRndProduct();
            }
            */

            LoadUser();
            if (isEdit)
            {
                menu.BigMenu(panelHome);
                CreateRndProduct();
                MessageBox.Show("資料庫有變動,建議重新開啟程式已確保資料載入正常");
                panelAllproductslist.Controls.Clear();
                panelDrinkList.Controls.Clear();
                panelIcecreamList.Controls.Clear();
                panelPopsicleList.Controls.Clear();
                panelSundaeList.Controls.Clear();
                panelHome.BringToFront();
                isEdit = false;
                SQLloadALL();
            }

            if (GlobalVar.UserRole <= 11) //BOSS
            {
                btnCart.Visible = false;
                panelItemManage.Size = new Size(171, 63 * 4);
                btnOrderManage.Visible = true;
                btnPersonManage.Visible = true;
                btnProductManage.Visible = true;
                btnStoreSystem.Visible = true;
                //newmenu.CreatCollapseMenuSize(panelItemManage);

            }
            else if (GlobalVar.UserRole <= 12) //Manager
            {
                btnCart.Visible = false;
                panelItemManage.Size = new Size(171, 63 * 3);
                btnOrderManage.Visible = true;
                btnPersonManage.Visible = true;
                btnProductManage.Visible = true;
                btnStoreSystem.Visible = false;                
                panelItemManage.Visible = false;
                //newmenu.CreatCollapseMenuSize(panelItemManage);
            }
            else if (GlobalVar.UserRole < 101) //員工部分
            {
                btnCart.Visible = false;
                panelItemManage.Size = new Size(171, 63 * 2);
                btnProductSystem.Visible = true;
                btnOrderManage.Visible = true;
                btnPersonManage.Visible = true;
                btnProductManage.Visible = false;
                btnStoreSystem.Visible = false;
                //newmenu.CreatCollapseMenuSize(panelItemManage);


            }
            else if (GlobalVar.UserRole >= 101) // 顧客部分
            {
                btnCart.Visible = true;
                if (panelItemManage.Visible == true)
                {
                    //newmenu.CreatCollapseMenuSize(panelItemManage);                    
                    panelItemManage.Visible = false;
                }
                btnProductSystem.Visible = false;
                panelItemManage.Visible = false;
            }

        }

        void LoadUser()
        {
            lblUserName.Text = "歡迎,"+GlobalVar.UserName;            
        }





        #region 非顧客功能
        Menu newmenu = new Menu(); //要new一個 阿不然會兩個摺疊選單共用timer 有BUG
        private void btnProductSystem_Click(object sender, EventArgs e)
        {
            newmenu.CreatCollapseMenuSize(panelItemManage);
            newmenu.ShowCollapseMenu(btnProductSystem, panelItemManage);
            
        }


        private void btnProductManage_Click(object sender, EventArgs e)
        {
            isEdit = true;
            ProductManage myproductManage = new ProductManage();
            myproductManage.ShowDialog();
        }

        private void btnOrderManage_Click(object sender, EventArgs e)
        {
            OrdersManage myorders = new OrdersManage();
            myorders.ShowDialog();
        }

        private void btnPersonManage_Click(object sender, EventArgs e)
        {
            PersonsManage mypersons = new PersonsManage();
            mypersons.ShowDialog();
        }








        #endregion

        bool isSizeChange = false;
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (isSizeChange)
            {

            }
            else
            {

            }
        }

        private void picboxUser_Click(object sender, EventArgs e)
        {
            menu.BigMenu(panelUserSetting);
            panelUserSetting.BringToFront();
            txtID.Text = GlobalVar.UserID.ToString();
            txtName.Text = GlobalVar.UserName;
            txtEmail.Text = GlobalVar.Useremail;
            dateBirthday.Value = GlobalVar.Userbirthday;
            txtAccount.Text = GlobalVar.Useraccount;
            txtPassword.Text = GlobalVar.Userpassword;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string tableName = "";
            switch (GlobalVar.UserCharacter)
            {
                case 1:
                    tableName = "staff";
                    break;
                case 2:
                    tableName = "persons";
                    break;
                default:
                    break;
            }
            string strSQL = $"UPDATE {tableName} Set name = @NewName, password = @NewPassword, email = @NewEmail, birthday = @NewBirthday Where id = @selectedID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@selectedID", GlobalVar.UserID);
            cmd.Parameters.AddWithValue("@NewName", txtName.Text);
            cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
            cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@NewBirthday", dateBirthday.Value.ToString("d"));            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("會員資料修改成功,請重新登入");

            clearData();

            ////這裡還在

        }

        private void picboxUser_MouseMove(object sender, MouseEventArgs e)
        {
            picboxUser.BackColor = Color.LightGray;            
        }

        private void picboxUser_MouseLeave(object sender, EventArgs e)
        {
            picboxUser.BackColor = Color.Transparent;
        }

        private void btnStoreSystem_Click(object sender, EventArgs e)
        {
            StoreSystem mystore = new StoreSystem();
            mystore.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
