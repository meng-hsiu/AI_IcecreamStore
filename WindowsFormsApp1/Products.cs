using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Products : UserControl
    {
        public int state = 0;
        public int id = 0;
        public string pname = "";
        public int price = 0;
        public string pdesc = "";
        public string pimage = "";
        public string type = "";
        public string fullpath = "";
        public Image Image { get; set; }




        public Products()
        {
            InitializeComponent();
            this.Size = new Size(250, 300); // 設置固定大小，例如 200x100
            this.MaximumSize = this.Size; // 設置最大大小為固定大小
            this.MinimumSize = this.Size; // 設置最小大小為固定大小       

        }


        private void Products_Load(object sender, EventArgs e)
        {
            txtNums.Text = "1";
        }


        private void btnJoinCart_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.btnJoinCart.Name);
            int id = Get_id(this.btnJoinCart);
            GlobalVar.arrayListOrderItem.Add(id);
            GlobalVar.arrayListOrderItemCounts.Add(ProductsOrderCounts);
            
        }

        int Get_id(Button button)
        {
            int id = 0;
            id = Convert.ToInt32(button.Name);
            return id;
        }



        private void btnDetail_Click(object sender, EventArgs e)
        {
            GlobalVar.DetailItemId = Get_id(this.btnDetail);
        }


        int ProductsOrderCounts = 1;        
        private void txtNums_TextChanged(object sender, EventArgs e)
        {
            ProductsOrderCounts = 1;
            if (Int32.TryParse(txtNums.Text, out int result))
            {
                ProductsOrderCounts = result;
            }
            else if(result==0)
            {
                MessageBox.Show("至少購買1個");
                txtNums.Text = "1";
            }
            else
            {
                MessageBox.Show("輸入格式錯誤");
                txtNums.Text = "1";
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int counts = 0;
            counts = Convert.ToInt32(txtNums.Text);
            counts += 1;
            txtNums.Text = counts.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int counts = 0;
            counts = Convert.ToInt32(txtNums.Text);
            if (counts > 1)
            {
                counts -= 1;
                txtNums.Text = counts.ToString();
            }
            else
            {
                MessageBox.Show("數量最低為一個");
            }
        }
    }
}
