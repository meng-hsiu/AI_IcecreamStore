using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace WindowsFormsApp1
{
    public partial class ProductDetail : Form
    {
        public ProductDetail()
        {
            InitializeComponent();
            GlobalVar.productDetail = this;
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {           

            //Load();
            LoadDetail();

        }
        
        void LoadDetail()
        {
            this.pictureBoxProduct.Image = null;
            List<Products> myproduct = GlobalVar.listallmyproducts.Where(s => s.id == GlobalVar.DetailItemId).ToList();
            this.pictureBoxProduct.Image = myproduct[0].Image;
            this.lblPrice.Text = "建議售價: " + myproduct[0].price.ToString() + "元";
            this.txtDesc.Text = myproduct[0].pdesc;
        }


        /*
        void Load()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from products where id = @NewID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewID", GlobalVar.DetailItemId);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string imagename = ((string)reader["pimage"]);
                string desc = (string)reader["pdesc"];
                int price = (int)reader["price"];
                string Fullpicpath = $"{GlobalVar.image_dir}\\{imagename}";
                System.IO.FileStream fs = System.IO.File.OpenRead(Fullpicpath);
                Image Pimage = Image.FromStream(fs);
                this.pictureBoxProduct.Image = Pimage;
                lblPrice.Text = "建議售價: " + price.ToString() + "元";
                txtDesc.Text = desc.ToString();
                fs.Close();
            }

            reader.Close();
            con.Close();
        }
        */


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.pictureBoxProduct.Image = null;
            this.Close();
        }
    }
}
