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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Menu menu = new Menu();
        List<Panel> panels = new List<Panel>();//用來存所有選單 這樣可以關掉一些不需要的 節省效能


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 存有用到的選單
            panels.Add(panelHome);
            panels.Add(panelPopsicle);
            panels.Add(panelIceCream);
            panels.Add(panelsundae);
            panels.Add(panelDrink);
            menu.Menupanels(this.panels);
            #endregion
            GlobalVar.CartButton = this.btnCart;

        }

        #region 大按鈕
        private void btnHome_Click(object sender, EventArgs e)
        {
            menu.BigMenu(panelHome);
        }
        #region 商品清單
        private void btnItemList_Click(object sender, EventArgs e)
        {
            menu.ShowCollapseMenu(btnItemList, panelItemList);
        }        

        private void btnIceCream_Click(object sender, EventArgs e)
        {
            menu.ShowINCollapseMenu(panelIceCream);
        }

        private void btnSundae_Click(object sender, EventArgs e)
        {
            menu.ShowINCollapseMenu(panelsundae);
        }

        private void btnPopsicle_Click(object sender, EventArgs e)
        {
            menu.ShowINCollapseMenu(panelPopsicle);
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            menu.ShowINCollapseMenu(panelDrink);
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
            Login login = new Login();
            login.Show();
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
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
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
            picBoxFullScreen.BackColor = Color.FromArgb(108, 86, 59);
        }

        private void picBoxFullScreen_MouseLeave(object sender, EventArgs e)
        {
            picBoxFullScreen.BackColor = Color.Transparent;
        }

        private void picBoxMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxMinimize.BackColor = Color.FromArgb(108, 86, 59);
        }

        private void picBoxMinimize_MouseLeave(object sender, EventArgs e)
        {
            picBoxMinimize.BackColor= Color.Transparent;
        }


        #region 搜尋功能

        bool istxtSearch = false;
        Timer Searchtimer = new Timer();
        Timer Searchtimer3S = new Timer();
        bool istxtSearchLeave = false;
        Point txtSearchStartPoint = new Point();
        bool istxtSearchSizeChanged = false;
        bool istxtSearchEnter = false;

        private void picBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Visible == false)
            {
                txtSearch.Visible = true;
                txtSearch.BringToFront();
            }
            else
            {
                txtSearch.Visible = false;
            }
        }

        private void picBoxSearch_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxSearch.BackColor = Color.FromArgb(108, 86, 59);
            
        }

        private void picBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            picBoxSearch.BackColor = Color.Transparent;
        }
        
        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (istxtSearchSizeChanged == false)
            {
                txtSearchStartPoint = txtSearch.Location;
                txtSearch.Location = new Point(txtSearch.Location.X - 40, 31);
                istxtSearchSizeChanged = true;
                txtSearch.Text = "";
                txtSearch.Size = new Size(200, 30);
                txtSearch.ForeColor = Color.Black;
                istxtSearchLeave = false;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            istxtSearchEnter = true;
        }


        private void txtSearch_NotOnFocus(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            txtSearch.Text = "搜尋商品";
            txtSearch.Size = new Size(160, 30);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = txtSearchStartPoint;
            istxtSearchSizeChanged = false;
            
        }

        #endregion

        #endregion

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Text = "";
                this.ActiveControl = null;
            }
        }
    }
}
