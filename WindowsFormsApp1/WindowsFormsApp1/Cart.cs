using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cart : Form
    {
        Menu menu = new Menu();
        List<Panel> panels = new List<Panel>();

        public Cart()
        {
            InitializeComponent();


        }


        private void Cart_Load(object sender, EventArgs e)
        {
            panels.Add(panelOrderHistory);
            panels.Add(panelOrder);
            menu.Menupanels(this.panels);
            GlobalVar.OrderList = this.lboxOrder;
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            menu.BigMenu(panelOrder);
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            menu.BigMenu(panelOrderHistory);
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            OrderCheck orderCheck = new OrderCheck();
            orderCheck.ShowDialog();
        }

        private void Cart_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.CartButton.Enabled = true;
        }
    }
}
