using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace WindowsFormsApp1
{
    public partial class OrdersManage : Form
    {


        public int orderid = 0;
        public int personid = 0;
        public string personname = "";
        public int orderprice = 0;
        DateTime dateTime = DateTime.Now;
        List<OrdersManage> listOrders = new List<OrdersManage>();

        //OD就OrderDetail
        public int ODorderDetailID = 0;
        public int ODorderid = 0;
        public int ODproductid = 0;
        public string ODproductname = "";
        public int ODquantity = 0;
        public int ODunitprice = 0;
        List<OrdersManage> listOrderDetail = new List<OrdersManage>();

        public OrdersManage()
        {
            InitializeComponent();
        }

        private void OrdersManage_Load(object sender, EventArgs e)
        {
            cboxType.Items.Add("訂單編號");
            cboxType.Items.Add("訂單會員編號");
            cboxType.Items.Add("訂單會員名字");
            cboxType.SelectedIndex = 0;

            addOrders("all");
            LoadOrderDetail();
        }


        void addOrders(string str)
        {
            LoadOrders();

            if (str == "all")
            {
                listAllOrders.Clear();
                listAllOrders.LargeImageList = null;
                listAllOrders.SmallImageList = null;
                listAllOrders.View = View.Details;
                listAllOrders.Columns.Add("訂單編號", 100);
                listAllOrders.Columns.Add("訂單會員編號", 200);
                listAllOrders.Columns.Add("訂單會員名字", 200);
                listAllOrders.Columns.Add("訂單價格", 100);
                listAllOrders.Columns.Add("訂單時間", 300);
                listAllOrders.GridLines = true;
                listAllOrders.FullRowSelect = true;

                for (int i = 0; i < listOrders.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Tag = listOrders[i].orderid;
                    item.Text = listOrders[i].orderid.ToString();
                    item.SubItems.Add(listOrders[i].personid.ToString());
                    item.SubItems.Add(listOrders[i].personname.ToString()); //從第二個開始要用subitems 比較特別
                    item.SubItems.Add(listOrders[i].orderprice.ToString());
                    item.SubItems.Add(listOrders[i].dateTime.ToString());
                    listAllOrders.Items.Add(item);
                }
            }
            else
            {

                listAllOrders.Clear();
                listAllOrders.LargeImageList = null;
                listAllOrders.SmallImageList = null;
                listAllOrders.View = View.Details;
                listAllOrders.Columns.Add("訂單編號", 100);
                listAllOrders.Columns.Add("訂單會員編號", 200);
                listAllOrders.Columns.Add("訂單會員名字", 200);
                listAllOrders.Columns.Add("訂單價格", 100);
                listAllOrders.Columns.Add("訂單時間", 300);
                listAllOrders.GridLines = true;
                listAllOrders.FullRowSelect = true;

                if (cboxType.Text == "訂單會員名字")
                {
                    string strSearchName = txtSearch.Text;
                    List<OrdersManage> searchorders = new List<OrdersManage>();
                    searchorders = listOrders.Where(s => s.personname == strSearchName).ToList();
                    for (int i = 0; i < listOrders.Where(s => s.personname == strSearchName).Count(); i++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                        item.Tag = searchorders[i].orderid;
                        item.Text = searchorders[i].orderid.ToString();
                        item.SubItems.Add(searchorders[i].personid.ToString());
                        item.SubItems.Add(searchorders[i].personname.ToString()); //從第二個開始要用subitems 比較特別
                        item.SubItems.Add(searchorders[i].orderprice.ToString());
                        item.SubItems.Add(searchorders[i].dateTime.ToString());
                        listAllOrders.Items.Add(item);
                    }
                }
                else if (cboxType.Text == "訂單編號")
                {
                    if (!Int32.TryParse(txtSearch.Text, out int search))
                    {
                        MessageBox.Show("搜尋欄必須為數字");
                        return;
                    }

                    List<OrdersManage> searchorders = new List<OrdersManage>();
                    searchorders = listOrders.Where(s => s.orderid == search).ToList();
                    for (int i = 0; i < listOrders.Where(s => s.orderid == search).Count(); i++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                        item.Tag = searchorders[i].orderid;
                        item.Text = searchorders[i].orderid.ToString();
                        item.SubItems.Add(searchorders[i].personid.ToString());
                        item.SubItems.Add(searchorders[i].personname.ToString()); //從第二個開始要用subitems 比較特別
                        item.SubItems.Add(searchorders[i].orderprice.ToString());
                        item.SubItems.Add(searchorders[i].dateTime.ToString());
                        listAllOrders.Items.Add(item);
                    }
                }
                else
                {
                    if (!Int32.TryParse(txtSearch.Text, out int search))
                    {
                        MessageBox.Show("搜尋欄必須為數字");
                        return ;
                    }

                    List<OrdersManage> searchorders = new List<OrdersManage>();
                    searchorders = listOrders.Where(s => s.personid == search).ToList();
                    for (int i = 0; i < listOrders.Where(s => s.personid == search).Count(); i++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                        item.Tag = searchorders[i].orderid;
                        item.Text = searchorders[i].orderid.ToString();
                        item.SubItems.Add(searchorders[i].personid.ToString());
                        item.SubItems.Add(searchorders[i].personname.ToString()); //從第二個開始要用subitems 比較特別
                        item.SubItems.Add(searchorders[i].orderprice.ToString());
                        item.SubItems.Add(searchorders[i].dateTime.ToString());
                        listAllOrders.Items.Add(item);
                    }
                }

            }





        }



        void LoadOrders()
        {
            listOrders.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select o.*,p.name as personname from orders as o JOIN persons as p ON o.personid = p.id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OrdersManage order = new OrdersManage();
                order.orderid = (int)reader["orderid"];
                order.personid = (int)reader["personid"];
                order.personname = (string)reader["personname"];
                order.orderprice = (int)reader["orderprice"];
                order.dateTime = (DateTime)reader["ordertime"];
                listOrders.Add(order);
            }

            reader.Close();
            con.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewOrderDetail.Clear();
            string SearchType = cboxType.Text;
            addOrders(SearchType);
        }




        void LoadOrderDetail()
        {
            listOrderDetail.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select o.*,p.pname as pname from orderdetails as o JOIN products as p ON o.productID = p.id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OrdersManage orderdetail = new OrdersManage();
                orderdetail.ODorderDetailID = (int)reader["orderDetailID"];
                orderdetail.ODorderid = (int)reader["orderID"];
                orderdetail.ODproductid = (int)reader["productID"];
                orderdetail.ODquantity = (int)reader["quantity"];
                orderdetail.ODunitprice = (int)reader["unitprice"];
                orderdetail.ODproductname = (string)reader["pname"];
                listOrderDetail.Add(orderdetail);
            }
            reader.Close();
            con.Close();
        }




        List<OrdersManage> listselectOrderDetail = new List<OrdersManage>();
        private void listAllOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listAllOrders.SelectedItems.Count > 0)
            {
                var selectitem = listAllOrders.SelectedItems;
                int selectID = (int)selectitem[0].Tag;
                listselectOrderDetail = listOrderDetail.Where(s => s.ODorderid == selectID).ToList();

                listViewOrderDetail.Clear();
                listViewOrderDetail.Items.Clear();
                listViewOrderDetail.LargeImageList = null;
                listViewOrderDetail.SmallImageList = null;
                listViewOrderDetail.View = View.Details;
                listViewOrderDetail.Columns.Add("訂單詳細編號", 150);
                listViewOrderDetail.Columns.Add("訂單編號", 100);
                listViewOrderDetail.Columns.Add("訂單商品編號", 150);
                listViewOrderDetail.Columns.Add("訂單商品名字", 200);
                listViewOrderDetail.Columns.Add("訂單商品價格", 200);
                listViewOrderDetail.Columns.Add("訂單商品數量", 150);
                listViewOrderDetail.GridLines = true;
                listViewOrderDetail.FullRowSelect = true;

                for (int i = 0; i < listselectOrderDetail.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Tag = listselectOrderDetail[i].ODorderDetailID; //拿來存訂單詳細編號
                    item.Text = listselectOrderDetail[i].ODorderDetailID.ToString();
                    item.SubItems.Add(listselectOrderDetail[i].ODorderid.ToString());
                    item.SubItems.Add(listselectOrderDetail[i].ODproductid.ToString()); //從第二個開始要用subitems 比較特別
                    item.SubItems.Add(listselectOrderDetail[i].ODproductname.ToString());
                    item.SubItems.Add(listselectOrderDetail[i].ODunitprice.ToString());
                    item.SubItems.Add(listselectOrderDetail[i].ODquantity.ToString());
                    listViewOrderDetail.Items.Add(item);
                }

            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

            var selectitem = listAllOrders.SelectedItems;
            int selectID = (int)selectitem[0].Tag;

            DialogResult dialogResult = MessageBox.Show($"確定要刪除編號{selectID}的訂單嗎?","刪除確認",MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {



                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    listViewOrderDetail.Clear();
                    listViewOrderDetail.Items.Clear();


                    string strSQL = "Delete from orderdetails where orderID = @deleteorderID";
                    SqlCommand cmd = new SqlCommand(strSQL, con, transaction);
                    cmd.Parameters.AddWithValue("@deleteorderID", selectID);
                    int rows = cmd.ExecuteNonQuery();
                    Console.WriteLine("rows"+rows);

                    string strSQL2 = "Delete from orders where orderID = @deleteID";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con, transaction);
                    cmd2.Parameters.AddWithValue("@deleteID", selectID);
                    int rows2 = cmd2.ExecuteNonQuery();
                    Console.WriteLine("rows2" + rows2);




                    transaction.Commit();
                    con.Close();
                    MessageBox.Show("訂單刪除成功!");


                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    con.Close();
                    MessageBox.Show("刪除失敗" + ex.Message);
                }



            }


        }

        private void btnRefreah_Click(object sender, EventArgs e)
        {
            addOrders("all");
            LoadOrderDetail();
        }
    }
}
