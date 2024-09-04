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
    public partial class PersonsManage : Form
    {
        int id = 0;
        string name = "";
        string account = "";
        string password = "";
        string email = "";
        DateTime birthday = DateTime.Now;
        int role = 0;
        int state = 0;

        List<PersonsManage> listpersons = new List<PersonsManage>();


        public PersonsManage()
        {
            InitializeComponent();
        }

        private void PersonsManage_Load(object sender, EventArgs e)
        {
            addPersons();
            cboxType.Items.Add("ID");
            cboxType.Items.Add("名字");
            cboxType.Items.Add("帳號");
            cboxType.Items.Add("Email");
            cboxType.SelectedIndex = 0;
        }




        void addPersons()
        {
            LoadPersons();
            listViewAllpersons.Clear();
            listViewAllpersons.LargeImageList = null;
            listViewAllpersons.SmallImageList = null;
            listViewAllpersons.View = View.Details;
            listViewAllpersons.Columns.Add("編號", 100);
            listViewAllpersons.Columns.Add("姓名", 100);
            listViewAllpersons.Columns.Add("帳號", 200);
            listViewAllpersons.Columns.Add("密碼", 200);
            listViewAllpersons.Columns.Add("信箱", 300);
            listViewAllpersons.Columns.Add("生日", 200);
            listViewAllpersons.Columns.Add("權限", 100);
            listViewAllpersons.Columns.Add("狀態", 100);
            listViewAllpersons.GridLines = true;
            listViewAllpersons.FullRowSelect = true;

            for (int i = 0; i < listpersons.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = listpersons[i].id;
                item.Text = listpersons[i].id.ToString();
                item.SubItems.Add(listpersons[i].name.ToString());
                item.SubItems.Add(listpersons[i].account.ToString()); //從第二個開始要用subitems 比較特別
                item.SubItems.Add(listpersons[i].password.ToString());
                item.SubItems.Add(listpersons[i].email.ToString());
                item.SubItems.Add(listpersons[i].birthday.ToString("d"));
                item.SubItems.Add(listpersons[i].role.ToString());
                item.SubItems.Add(GetState(listpersons[i].state));
                


                listViewAllpersons.Items.Add(item);
            }
        }


        void addPersons(string Type)
        {
            LoadPersons();
            listViewAllpersons.Clear();
            listViewAllpersons.LargeImageList = null;
            listViewAllpersons.SmallImageList = null;
            listViewAllpersons.View = View.Details;
            listViewAllpersons.Columns.Add("編號", 100);
            listViewAllpersons.Columns.Add("姓名", 100);
            listViewAllpersons.Columns.Add("帳號", 200);
            listViewAllpersons.Columns.Add("密碼", 200);
            listViewAllpersons.Columns.Add("信箱", 300);
            listViewAllpersons.Columns.Add("生日", 200);
            listViewAllpersons.Columns.Add("權限", 100);
            listViewAllpersons.Columns.Add("狀態", 100);
            listViewAllpersons.GridLines = true;
            listViewAllpersons.FullRowSelect = true;

            List<PersonsManage> selectedpersons = new List<PersonsManage>();
            List<PersonsManage> selecteddayrange = new List<PersonsManage>();
            selecteddayrange = listpersons.Where(s => s.birthday <= DTPmax.Value && s.birthday >= DTPmin.Value).ToList();
            
            if (cboxType.Text == "ID")
            {
                if (txtSearch.Text != "")
                {
                    int id = 0;
                    if (!Int32.TryParse(txtSearch.Text, out id))
                    {
                        MessageBox.Show("ID必須為數字");
                    }
                    selectedpersons = selecteddayrange.Where(s => s.id == id).ToList();
                }
                else
                {
                    selectedpersons = selecteddayrange;
                }
                
            }
            else if (cboxType.Text == "名字")
            {
                selectedpersons = selecteddayrange.Where(s => s.name.Contains(txtSearch.Text)).ToList();
            }
            else if (cboxType.Text == "帳號")
            {
                selectedpersons = selecteddayrange.Where(s => s.account.Contains(txtSearch.Text)).ToList();
            }
            else if (cboxType.Text == "Email")
            {
                selectedpersons = selecteddayrange.Where(s => s.email.Contains(txtSearch.Text)).ToList();
            }

            for (int i = 0; i < selectedpersons.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = selectedpersons[i].id;
                item.Text = selectedpersons[i].id.ToString();
                item.SubItems.Add(selectedpersons[i].name.ToString());
                item.SubItems.Add(selectedpersons[i].account.ToString()); //從第二個開始要用subitems 比較特別
                item.SubItems.Add(selectedpersons[i].password.ToString());
                item.SubItems.Add(selectedpersons[i].email.ToString());
                item.SubItems.Add(selectedpersons[i].birthday.ToString("d"));
                item.SubItems.Add(selectedpersons[i].role.ToString());
                item.SubItems.Add(GetState(selectedpersons[i].state));
                listViewAllpersons.Items.Add(item);
            }
        }






        string GetState(int i)
        {
            switch (i)
            {
                case 0:
                    return "停權";
                case 1:
                    return "正常";
                default:
                    return "錯誤";

            }
        }






        void LoadPersons()
        {
            listpersons.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from persons;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PersonsManage person = new PersonsManage();
                person.id = (int)reader["id"];
                person.name = (string)reader["name"];
                person.account = (string)reader["account"];
                person.password = (string)reader["password"];
                person.email = (string)reader["email"];
                person.birthday = (DateTime)reader["birthday"];
                person.role = (int)reader["role"];
                person.state = (int)reader["state"];
                listpersons.Add(person);                
            }

            reader.Close();
            con.Close();
        }

        private void listViewAllpersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAllpersons.SelectedItems.Count > 0)
            {
                ListViewItem selectID = listViewAllpersons.SelectedItems[0];
                List<PersonsManage> selectperson = new List<PersonsManage>();
                selectperson = listpersons.Where(person => person.id == (int)selectID.Tag).ToList();

                txtID.Text = selectperson[0].id.ToString();
                txtName.Text = selectperson[0].name.ToString();
                txtEmail.Text = selectperson[0].email.ToString();
                dateBirthday.Value = selectperson[0].birthday;

                txtAccount.Text = selectperson[0].account;
                txtPassword.Text = selectperson[0].password;

                txtRole.Text = selectperson[0].role.ToString();
                txtState.Text = selectperson[0].state.ToString();
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewAllpersons.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewAllpersons.SelectedItems[0];
                int selectedID = (int)selectedItem.Tag;

                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "UPDATE persons Set name = @NewName, password = @NewPassword, email = @NewEmail, birthday = @NewBirthday, role = @Newrole, state= @NewState Where id = @selectedID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@selectedID", selectedID);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dateBirthday.Value.ToString("d"));
                int Role = 0;
                if (!Int32.TryParse(txtRole.Text, out Role))
                {
                    MessageBox.Show("Role必須為數字");
                    con.Close();
                    return;
                }
                cmd.Parameters.AddWithValue("@Newrole", Role);
                int State = 0;
                if (!Int32.TryParse(txtState.Text, out State))
                {
                    MessageBox.Show("State必須為數字");
                    con.Close();
                    return;
                }
                cmd.Parameters.AddWithValue("@NewState", State);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("會員資料修改成功");
            } 
        }

        private void btnRefreah_Click(object sender, EventArgs e)
        {
            DTPmin.Value = new DateTime(1900, 01, 01);
            DTPmax.Value = DateTime.Now;
            listpersons.Clear();
            addPersons();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewAllpersons.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("確定要刪除嗎?", "刪除確認", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = listViewAllpersons.SelectedItems[0];
                    int selectedID = (int)selectedItem.Tag;
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        string strSQL = "delete from persons where id = @selectedID";
                        SqlCommand cmd = new SqlCommand(strSQL, con, transaction);
                        cmd.Parameters.AddWithValue("@selectedID", selectedID);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        con.Close();
                        MessageBox.Show("刪除成功");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        con.Close();
                        MessageBox.Show("刪除失敗" + ex.Message);
                    }
                }
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Type = "";
            addPersons(Type);
        }
    }
}
