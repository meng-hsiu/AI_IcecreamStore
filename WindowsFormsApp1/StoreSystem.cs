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
    public partial class StoreSystem : Form
    {
        int ODorderid = 0;
        int id = 0;
        int totalsell = 0;
        string type = "";

        public StoreSystem()
        {
            InitializeComponent();
        }

        private void StoreSystem_Load(object sender, EventArgs e)
        {
            loadsale();
            showSell();
        }

        int total = 0;
        List<StoreSystem> listSell = new List<StoreSystem>();
        List<Order> listOrder = new List<Order>();
        void loadsale()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select orderid,orderprice,ordertime from orders;";            
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order myorder = new Order();
                myorder.orderid = (int)reader["orderid"];
                myorder.orderprice = (int)reader["orderprice"];
                myorder.ordertime = (DateTime)reader["ordertime"];
                listOrder.Add(myorder);
            }
            reader.Close();
            

            string strSQL2 = "select od.orderID, od.productid, sum(quantity) as totalsell, p.type as type from orderdetails as od Left JOIN products as p ON od.productID = p.id Group By od.productID,p.type,od.orderID;";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                StoreSystem mysell = new StoreSystem();
                mysell.ODorderid = (int)reader2["orderID"];
                mysell.id = (int)reader2["productid"];
                mysell.totalsell = (int)reader2["totalsell"];
                mysell.type = (string)reader2["type"];
                listSell.Add(mysell);
            }
            reader2.Close();
            con.Close();
        }

        void showSell()
        {
            List<int> listIcecream = new List<int>();
            List<int> listPopsicle = new List<int>();
            List<int> listSundae = new List<int>();
            List<int> listDrink = new List<int>();

            // 設定序列
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add($"商品販售比例");
            chart1.Series.Add("Series1");
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; // 你可以選擇不同類型的圖表，比如Column, Pie, Bar等

            List<Order> listDateOrder = new List<Order>(); //用來存在某個範圍時間內的訂單
            listDateOrder = listOrder.Where(s=>s.ordertime > dateStart.Value && s.ordertime < dateEnd.Value).ToList();

            total = listDateOrder.Sum(s => s.orderprice);
            List<int> listOrderIDs = new List<int>();
            listOrderIDs = listDateOrder.Select(s => s.orderid).ToList(); //將訂單list的訂單編號取出
            // 添加資料點

            
            List<StoreSystem> listSelectSell = new List<StoreSystem>(); //用來存有符合訂單編號的訂單詳細內容
            listSelectSell = listSell.Where(s => listOrderIDs.Contains(s.ODorderid)).ToList();            
            listIcecream = listSelectSell.Where(s => s.type == "冰淇淋").Select(s => s.totalsell).ToList();
            listPopsicle = listSelectSell.Where(s => s.type == "冰棒").Select(s => s.totalsell).ToList();
            listSundae = listSelectSell.Where(s => s.type == "聖代").Select(s => s.totalsell).ToList();
            listDrink = listSelectSell.Where(s => s.type == "飲料").Select(s => s.totalsell).ToList();


            int SumIcecream = listIcecream.Sum();
            int SumPopsicle = listPopsicle.Sum();
            int SumSundae = listSundae.Sum();
            int SumDrink = listDrink.Sum();

            if (SumIcecream > 0)
            {
                chart1.Series["Series1"].Points.AddXY("冰淇淋", SumIcecream);                
            }
            if (SumPopsicle > 0)
            {
                chart1.Series["Series1"].Points.AddXY("冰棒", SumPopsicle);
            }
            if (SumSundae > 0)
            {
                chart1.Series["Series1"].Points.AddXY("聖代", SumSundae);
            }
            if (SumDrink > 0)
            {
                chart1.Series["Series1"].Points.AddXY("飲料", SumDrink);
            }

            lblIcecream.Text = $"冰淇淋共賣出了{SumIcecream}個";
            lblpop.Text = $"冰棒共賣出了{SumPopsicle}個";            
            lblsun.Text = $"聖代共賣出了{SumSundae}個";
            lbldrink.Text = $"飲料共賣出了{SumDrink}個";


            lbltotalsell.Text = $"{total}元";
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            showSell();
        }
    }
    public class Order
    {
        public int orderid = 0;
        public DateTime ordertime = DateTime.Now;
        public int orderprice = 0;
    }
}
