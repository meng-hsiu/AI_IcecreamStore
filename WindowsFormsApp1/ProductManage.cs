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
    public partial class ProductManage : Form
    {
        public ProductManage()
        {
            InitializeComponent();
        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
            cboxType.Items.Add("冰淇淋");
            cboxType.Items.Add("冰棒");
            cboxType.Items.Add("聖代");
            cboxType.Items.Add("飲料");
            cboxType.SelectedIndex = 0;
            string ss = cboxType.SelectedItem.ToString();
            Console.WriteLine(ss);
            showallitem();
        }



        void showallitem()
        {
            Form1 myform1 = new Form1();
            myform1.SQLloadALL();
            listAllitem.Clear();
            listAllitem.LargeImageList = null;
            listAllitem.SmallImageList = null;
            listAllitem.View = View.Details;
            listAllitem.Columns.Add("ID", 100);
            listAllitem.Columns.Add("商品名稱", 200);
            listAllitem.Columns.Add("價格", 100);
            listAllitem.Columns.Add("類型", 100);
            listAllitem.Columns.Add("狀態", 100);
            listAllitem.GridLines = true;
            listAllitem.FullRowSelect = true;

            for (int i = 0; i < GlobalVar.listallmyproducts.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = GlobalVar.listallmyproducts[i].id;
                item.Text = GlobalVar.listallmyproducts[i].id.ToString();
                item.SubItems.Add(GlobalVar.listallmyproducts[i].pname); //從第二個開始要用subitems 比較特別
                item.SubItems.Add(GlobalVar.listallmyproducts[i].price.ToString());
                item.SubItems.Add(GlobalVar.listallmyproducts[i].type.ToString());
                string state = GetState(GlobalVar.listallmyproducts[i].state);
                item.SubItems.Add(state);
                listAllitem.Items.Add(item);
            }
        }

        string GetState(int i)
        {
            switch (i)
            {
                case 0:
                    return "停售";
                case 1:
                    return "正常";
                default:
                    return "錯誤";

            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearchP = txtSearch.Text; //Product
            string strSearchT = cboxType.Text; //Type
            listAllitem.Clear();
            listAllitem.LargeImageList = null;
            listAllitem.SmallImageList = null;
            listAllitem.View = View.Details;
            listAllitem.Columns.Add("ID", 100);
            listAllitem.Columns.Add("商品名稱", 200);
            listAllitem.Columns.Add("價格", 100);
            listAllitem.Columns.Add("類型", 100);
            listAllitem.Columns.Add("狀態", 100);
            listAllitem.GridLines = true;
            listAllitem.FullRowSelect = true;

            List<Products> SearchType = GlobalVar.listallmyproducts.Where(s => s.type == strSearchT).ToList();
            List<Products> myproducts = SearchType.Where(s => s.pname.Contains(strSearchP)).ToList();
            for (int i = 0; i < myproducts.Count(); i++)
            {                
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = myproducts[i].id;
                item.Text = myproducts[i].id.ToString();
                item.SubItems.Add(myproducts[i].pname); //從第二個開始要用subitems 比較特別
                item.SubItems.Add(myproducts[i].price.ToString());
                item.SubItems.Add(myproducts[i].type.ToString());
                string state = GetState(GlobalVar.listallmyproducts[i].state);
                item.SubItems.Add(state);
                listAllitem.Items.Add(item);
            }
        }                

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            ItemControl mycontrol = new ItemControl();
            mycontrol.ShowDialog();
        }

        private void btnChangeItem_Click(object sender, EventArgs e)
        {
            ItemControl mycontrol = new ItemControl();
            var selectItem = listAllitem.SelectedItems;
            int selectID = (int)selectItem[0].Tag;
            List<Products> selectproduct = GlobalVar.listallmyproducts.Where(s => s.id == selectID).ToList();
            mycontrol.txtID.Text = selectproduct[0].id.ToString();
            mycontrol.txtPname.Text = selectproduct[0].pname;
            mycontrol.txtPrice.Text = selectproduct[0].price.ToString();
            mycontrol.txtType.Text = selectproduct[0].type;
            mycontrol.txtdesc.Text = selectproduct[0].pdesc;
            mycontrol.txtstate.Text = selectproduct[0].state.ToString();
            mycontrol.picboxItem.Image = selectproduct[0].Image;
            mycontrol.picboxItem.Tag = selectproduct[0].fullpath;
            mycontrol.ShowDialog();

        }


        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                var selectItem = listAllitem.SelectedItems;
                int selectID = (int)selectItem[0].Tag;
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "Delete from products where id = @SelectID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SelectID", selectID);
                int rows = cmd.ExecuteNonQuery();
                DialogResult dialogResult = MessageBox.Show("是否要同時刪除圖片?","確認",MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Products> myproducts = GlobalVar.listallmyproducts.Where(s=>s.id==selectID).ToList();
                    System.IO.File.Delete(myproducts[0].fullpath);
                    con.Close();
                    MessageBox.Show($"刪除了{rows}筆資料,並且刪除了圖片");
                }
                else
                {
                    con.Close();
                    MessageBox.Show($"刪除了{rows}筆資料");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤"+ex.Message);
            }
        }

        private void btnRefreah_Click(object sender, EventArgs e)
        {
            showallitem();
        }
    }
}
