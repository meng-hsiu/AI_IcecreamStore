using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ItemControl : Form
    {

        string strAfterEditFileTypeName = "";
        string strAfterEditFileName = "";
        bool picChanged = false;


        public ItemControl()
        {
            InitializeComponent();
        }

        private void ItemControl_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                
                if (txtID.Text == "")
                {//Insert
                    string strSQL = "Insert Into products Values (@NewName, @NewPrice, @NewPdesc, @NewPimage, @NewType, @state);";
                    SqlCommand cmd = new SqlCommand(strSQL, con, transaction);
                    cmd.Parameters.AddWithValue("@NewName", txtPname.Text);

                    if (!Int32.TryParse(txtPrice.Text, out int price))
                    {
                        MessageBox.Show("無效的價格");
                    }
                    cmd.Parameters.AddWithValue("@NewPrice", price);

                    if (!Int32.TryParse(txtstate.Text, out int state))
                    {
                        MessageBox.Show("無效的狀態");
                    }
                    cmd.Parameters.AddWithValue("@state", state);

                    cmd.Parameters.AddWithValue("@NewPdesc", txtdesc.Text);   

                    if (txtType.Text != "冰淇淋" && txtType.Text != "冰棒" && txtType.Text != "聖代" && txtType.Text != "飲料")
                    {
                        MessageBox.Show("目前還沒辦法新增沒賣的類型");
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NewType", txtType.Text);
                    }

                    if (txtPname.Text == "" || txtPrice.Text == "" || txtdesc.Text == "" || txtType.Text == "" || picboxItem.Image == null)
                    {
                        MessageBox.Show("資料不齊全,請再次確認");
                        return;
                    }
                    else
                    {
                        if (picChanged == true)
                        {
                            string strfullpath = $"{GlobalVar.image_dir}\\{strAfterEditFileName}";
                            picboxItem.Tag = strfullpath;
                            picboxItem.Image.Save(strfullpath);
                            picChanged = false;
                            cmd.Parameters.AddWithValue("@NewPimage", strAfterEditFileName);
                        }
                        transaction.Commit();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"新增了名為{txtPname.Text}的商品");                        
                    }


                }                
                else
                {//UPDATE
                    string strSQL = "UPDATE products set pname=@NewName, price=@NewPrice, pdesc=@NewPdesc, pimage=@NewPimage, type = @NewType, state = @state where id =@SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con, transaction);
                    if (!Int32.TryParse(txtID.Text, out int intid))
                    {
                        MessageBox.Show("無效的ID");
                        return;
                    }
                    if (!Int32.TryParse(txtPrice.Text, out int price))
                    {
                        MessageBox.Show("無效的價格");
                        return;
                    }
                    if (!Int32.TryParse(txtstate.Text, out int state))
                    {
                        MessageBox.Show("無效的狀態");
                    }
                    cmd.Parameters.AddWithValue("@state", state);

                    cmd.Parameters.AddWithValue("@SearchID", intid);
                    cmd.Parameters.AddWithValue("@NewName", txtPname.Text);                    
                    cmd.Parameters.AddWithValue("@NewPrice", price);
                    cmd.Parameters.AddWithValue("@NewPdesc", txtdesc.Text);                    
                    if (picChanged == true)
                    {
                        string strfullpath = $"{GlobalVar.image_dir}\\{strAfterEditFileName}";
                        picboxItem.Tag = strfullpath;
                        picboxItem.Image.Save(strfullpath);
                        picChanged = false;
                        cmd.Parameters.AddWithValue("@NewPimage", strAfterEditFileName);
                    }
                    else
                    {
                        List<Products> selectproduct = GlobalVar.listallmyproducts.Where(s=>s.id == intid).ToList();
                        cmd.Parameters.AddWithValue("@NewPimage", selectproduct[0].pimage);
                    }
                    if (txtType.Text != "冰淇淋" && txtType.Text != "冰棒" && txtType.Text != "聖代" && txtType.Text != "飲料")
                    {
                        MessageBox.Show("目前還沒辦法新增沒賣的類型");
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NewType", txtType.Text);
                    }
                    
                    if (txtPname.Text == "" || txtPrice.Text == "" || txtdesc.Text == "" || txtType.Text == "" || picboxItem.Image == null)
                    {
                        MessageBox.Show("資料不齊全,請再次確認");
                    }
                    else
                    {
                        transaction.Commit();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"商品{txtPname.Text}修改成功!");
                    }
                }
                

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("發生錯誤" + ex.Message);
            }
            con.Close();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(PNG)|*.png;";  //  "過濾器的描述 | 過濾器的條件"

            DialogResult R = ofd.ShowDialog();

            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                picboxItem.Image = Image.FromStream(fs);
                picboxItem.Tag = ofd.FileName;
                strAfterEditFileTypeName = System.IO.Path.GetExtension(ofd.SafeFileName).ToLower();
                Random myRnd = new Random();
                strAfterEditFileName = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 1000).ToString() + strAfterEditFileTypeName;              
                fs.Close();
                picChanged = true;
            }



        }
    }
}
