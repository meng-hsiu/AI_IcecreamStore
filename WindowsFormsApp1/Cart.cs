using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            GlobalVar.mycart = this;
            panels.Add(panelOrderHistory);
            panels.Add(panelOrder);
            menu.Menupanels(this.panels);
            showOrder();
        }





        List<UserHistoryOrders> listHOs = new List<UserHistoryOrders>(); //HistoryOrders
        List<UserHistoryOrderDetails> listHODs = new List<UserHistoryOrderDetails>(); //HistoryOrderDetails

        void Loadhistory()
        {
            listHOs.Clear();
            listHODs.Clear();

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from orders where personid = @UserID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@UserID", GlobalVar.UserID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserHistoryOrders historyoders = new UserHistoryOrders();
                historyoders.orderID = (int)reader["orderid"];
                historyoders.orderBill = (int)reader["orderprice"];
                historyoders.ordertime = (DateTime)reader["ordertime"];
                listHOs.Add(historyoders);
            }
            reader.Close();

            for (int i = 0; i < listHOs.Count; i++)
            {
                string strSQL2 = "select od.orderID,od.productID,p.pname,od.unitprice,od.quantity from orderdetails as od JOIN products as p on od.productID = p.id  where orderid = @UserOrderID;";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@UserOrderID", listHOs[i].orderID);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    UserHistoryOrderDetails historyOrderDetails = new UserHistoryOrderDetails();
                    historyOrderDetails.orderID = (int)reader2["orderID"];
                    historyOrderDetails.productID = (int)reader2["productID"];
                    historyOrderDetails.quantity = (int)reader2["quantity"];
                    historyOrderDetails.price = (int)reader2["unitprice"];
                    historyOrderDetails.pname = (string)reader2["pname"];
                    listHODs.Add(historyOrderDetails);
                }
                reader2.Close();

            }
            con.Close();                       
            
        }




        public void showOrder()
        {
            listViewOrder.Clear();
            listViewOrder.LargeImageList = null;
            listViewOrder.SmallImageList = null;
            listViewOrder.View = View.Details;
            listViewOrder.Columns.Add("ID", 100);
            listViewOrder.Columns.Add("商品名稱", 200);
            listViewOrder.Columns.Add("價格", 100);
            listViewOrder.Columns.Add("數量", 100);
            listViewOrder.GridLines = true;
            listViewOrder.FullRowSelect = true;

            for (int i = 0; i < GlobalVar.arrayListOrderItem.Count; i++)
            {           
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);             
                List<Products> myproduct = GlobalVar.listallmyproducts.Where(s => s.id == (int)GlobalVar.arrayListOrderItem[i]).ToList();
                item.Tag = myproduct[0].id;
                item.Text = myproduct[0].id.ToString();
                item.SubItems.Add(myproduct[0].pname); //從第二個開始要用subitems 比較特別
                item.SubItems.Add(myproduct[0].price.ToString());
                item.SubItems.Add(GlobalVar.arrayListOrderItemCounts[i].ToString());                
                listViewOrder.Items.Add(item);

            }
        }






        private void btnOrder_Click(object sender, EventArgs e)
        {
            menu.BigMenu(panelOrder);
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            menu.BigMenu(panelOrderHistory);
            Loadhistory();
            panelOrderHistory.Controls.Clear();
           
            for (int i = 0; i < listHOs.Count; i++)
            {
                HistoryOrders myHistoryOrders = new HistoryOrders();
                myHistoryOrders.Tag = listHOs[i].orderID;
                myHistoryOrders.lblOrderID.Text = listHOs[i].orderID.ToString();
                myHistoryOrders.lblOrderDay.Text = listHOs[i].ordertime.ToString();
                myHistoryOrders.lblBill.Text = listHOs[i].orderBill.ToString() + "元";
                myHistoryOrders.Dock = DockStyle.Top;
                myHistoryOrders.btnOrderDetail.Tag = listHODs[i].orderID;
                myHistoryOrders.btnOrderDetail.Click -= btnOrderDetail_Click;
                myHistoryOrders.btnOrderDetail.Click += btnOrderDetail_Click;
                panelOrderHistory.Controls.Add(myHistoryOrders);
            }
            
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            
            OrderDetails orderDetails = new OrderDetails();

            //orderDetails.listViewOrderDetails.BackColor = Color.FromArgb(222, 194, 158);
            orderDetails.listViewOrderDetails.LargeImageList = null;
            orderDetails.listViewOrderDetails.SmallImageList = null;
            orderDetails.listViewOrderDetails.View = View.Details;
            orderDetails.listViewOrderDetails.Columns.Add("商品ID", 100);
            orderDetails.listViewOrderDetails.Columns.Add("商品名稱", 200);
            orderDetails.listViewOrderDetails.Columns.Add("價格", 100);
            orderDetails.listViewOrderDetails.Columns.Add("數量", 100);
            orderDetails.listViewOrderDetails.GridLines = true;
            orderDetails.listViewOrderDetails.FullRowSelect = true;

            List<UserHistoryOrderDetails> selectedOrderDetails = new List<UserHistoryOrderDetails>();
            selectedOrderDetails = listHODs.Where(s=>s.orderID == GlobalVar.OrderDetailId).ToList();

            for (int i = 0; i < selectedOrderDetails.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);                
                item.Tag = selectedOrderDetails[i].orderID;
                item.Text = selectedOrderDetails[i].productID.ToString();
                item.SubItems.Add(selectedOrderDetails[i].pname); //從第二個開始要用subitems 比較特別
                item.SubItems.Add(selectedOrderDetails[i].price.ToString());
                item.SubItems.Add(selectedOrderDetails[i].quantity.ToString());
                orderDetails.listViewOrderDetails.Items.Add(item);

            }

            orderDetails.ShowDialog();
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

        private void btnRemoveIt_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count > 0)
            {
                int selectIndex = listViewOrder.SelectedItems[0].Index;
                GlobalVar.arrayListOrderItem.RemoveAt(selectIndex);
                GlobalVar.arrayListOrderItemCounts.RemoveAt(selectIndex);
                showOrder();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            GlobalVar.arrayListOrderItem.Clear();
            GlobalVar.arrayListOrderItemCounts.Clear();
            showOrder();
        }
    }

    public partial class UserHistoryOrders
    {
        public int orderID = 0;
        public DateTime ordertime = DateTime.Now;
        public int orderBill = 0;
    }

    public partial class UserHistoryOrderDetails
    {
        public int orderID = 0;
        public int productID = 0;
        public int quantity = 0;
        public int price = 0;
        public string pname = "";
    }
}
