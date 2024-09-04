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
    public partial class HistoryOrders : UserControl
    {
        public HistoryOrders()
        {
            InitializeComponent();
        }

        private void HistoryOrders_Load(object sender, EventArgs e)
        {
            System.Drawing.Size size = new Size(782, 39);
            this.Size = size;
            this.MaximumSize = size;
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            GlobalVar.OrderDetailId = (int)this.Tag;
        }
    }
}
