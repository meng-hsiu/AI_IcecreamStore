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

namespace WindowsFormsApp1
{
    public partial class OrderCheck : Form
    {
        int bill = 0;

        public OrderCheck()
        {
            InitializeComponent();
        }

        private void OrderCheck_Load(object sender, EventArgs e)
        {
            bill = 0;
            listViewOrderCheck.Clear();
            listViewOrderCheck.LargeImageList = null;
            listViewOrderCheck.SmallImageList = null;
            listViewOrderCheck.View = View.Details;
            listViewOrderCheck.Columns.Add("ID", 80, HorizontalAlignment.Center);
            listViewOrderCheck.Columns.Add("商品名稱", 330, HorizontalAlignment.Center);
            listViewOrderCheck.Columns.Add("價格", 85, HorizontalAlignment.Center);
            listViewOrderCheck.Columns.Add("數量", 85, HorizontalAlignment.Center);
            listViewOrderCheck.Columns.Add("總和價格", 140, HorizontalAlignment.Center);            
            listViewOrderCheck.GridLines = true;
            //listViewOrderCheck.Enabled = false;      

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
                item.SubItems.Add((myproduct[0].price * (int)GlobalVar.arrayListOrderItemCounts[i]).ToString());
                listViewOrderCheck.Items.Add(item);
                bill += (myproduct[0].price * (int)GlobalVar.arrayListOrderItemCounts[i]);
            }

            lblBill.Text = bill.ToString();
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            //Output這方法是GPT教的 原本想到的是找Max 但如果同時多人用 這方法會出錯
            try
            {
                string strSQL = "Insert Into orders Output Inserted.orderid values (@personid,@orderprice,@ordertime);";
                SqlCommand cmd = new SqlCommand(strSQL, con, transaction);
                cmd.Parameters.AddWithValue("@personid", GlobalVar.UserID);
                cmd.Parameters.AddWithValue("@orderprice", bill);
                cmd.Parameters.AddWithValue("@ordertime", DateTime.Now);

                // 獲取新插入的OrderID
                int orderId = Convert.ToInt32(cmd.ExecuteScalar());

                int rows = 0;
                for (int i = 0; i < GlobalVar.arrayListOrderItem.Count; i++)
                {
                    string strSQLproducts = $"Insert Into orderdetails values (@orderID,@productsid,@quantity,@unitprice);";
                    SqlCommand cmdproducts = new SqlCommand(strSQLproducts, con, transaction);
                    cmdproducts.Parameters.AddWithValue("@orderID", orderId);
                    cmdproducts.Parameters.AddWithValue("@productsid", (int)GlobalVar.arrayListOrderItem[i]);
                    cmdproducts.Parameters.AddWithValue("@quantity", (int)GlobalVar.arrayListOrderItemCounts[i]);
                    List<Products> product = GlobalVar.listallmyproducts.Where(s => s.id == (int)GlobalVar.arrayListOrderItem[i]).ToList();
                    cmdproducts.Parameters.AddWithValue("@unitprice", product[0].price);
                    cmdproducts.ExecuteNonQuery();
                    rows++;
                }
                                
                transaction.Commit();
                con.Close();
                MessageBox.Show("訂單送出成功,訂單編號為: " + orderId );
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                con.Close();
                MessageBox.Show("訂單發生錯誤" + ex.Message);
            }
        }
    }
}
