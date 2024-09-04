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
    public partial class Login : Form
    {
        Animation myanimation = new Animation();
        bool isCheck = false;
        bool isAccountCheck =false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "AIicecreamDB";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            radioPerson.Checked = true;
            //GlobalVar.mylogin = this;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            check();
        }


        void check()
        {
            string strAccount =txtAccount.Text.Trim();
            string strPassword = txtPassword.Text.Trim();

            if ((strAccount != "") && (strPassword != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();

                string tableName = "";

                switch (GlobalVar.UserCharacter)
                {
                    case 1:
                        tableName = "staff";
                        break;
                    case 2:
                        tableName = "persons";
                        break;
                    default:
                        break;
                }


                string strSQL = $"select * from {tableName} where account=@SearchAccount and password=@SearchPassword;";
                Console.WriteLine(strSQL);
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchAccount", strAccount);
                cmd.Parameters.AddWithValue("@SearchPassword", strPassword);
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    //登入成功                    
                    GlobalVar.UserName = reader["name"].ToString();
                    GlobalVar.UserID = (int)reader["id"];
                    GlobalVar.Useraccount = (string)reader["account"];
                    GlobalVar.Userpassword = (string)reader["password"];
                    GlobalVar.Useremail = (string)reader["email"];
                    GlobalVar.Userbirthday = (DateTime)reader["birthday"];
                    GlobalVar.UserRole = (int)reader["role"]; //代碼很自由 但建議 1~10: admin, 11~20: 店長, 21~30:店員, 101~200:店員, 0:訪客 範圍區間內可以做權限細分 同樣都是店長但有可能權限不同
                    GlobalVar.UserState = (int)reader["state"];
                    if (GlobalVar.UserState != 1)
                    {
                        reader.Close();
                        con.Close();
                        MessageBox.Show("該帳號已被停權,請洽櫃台");
                        return;
                    }
                    else
                    {
                        GlobalVar.isLogin = true;
                        MessageBox.Show("登入成功");
                        Form1 myform = new Form1();
                        myform.Show();
                        reader.Close();
                        con.Close();
                        this.Visible = false;
                    }
                    
                }


                if (GlobalVar.isLogin == false)
                {
                    lblResponse.Text = "登入資料有誤, 請重新登入";
                }

                reader.Close();
                con.Close();



            }
            else
            {
                MessageBox.Show("登入欄位必填");
            }
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            myanimation.LoginPic(pBoxLogin, panelRegister, true);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            myanimation.LoginPic(pBoxLogin,panelLogin,false);
        }





        private void btnJoin_Click(object sender, EventArgs e)
        {
            string strJoinName = txtName.Text.Trim();
            string strJoinAccount = txtJoinAccount.Text.Trim();
            string strJoinPassword = txtJoinPassword.Text.Trim();
            string dateJoinDate = dateBirthDay.Value.ToString("d");
            string strJoinEmail = txtEmail.Text.Trim();
            if (strJoinName == "" || strJoinAccount == "" || strJoinPassword == "")
            {
                MessageBox.Show("姓名和帳號和密碼不能有空白");
            }
            else if (isCheck == true && isAccountCheck == true)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "Insert into persons values (@NewName,@NewAccount,@NewPassword,@NewEmail,@NewDate,@NewRole,@NewState);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", strJoinName);
                cmd.Parameters.AddWithValue("@NewAccount",strJoinAccount);
                cmd.Parameters.AddWithValue("@NewPassword",strJoinPassword);
                cmd.Parameters.AddWithValue("@NewEmail", strJoinEmail);
                cmd.Parameters.AddWithValue("@NewDate", dateJoinDate);
                cmd.Parameters.AddWithValue("@NewRole",101);
                cmd.Parameters.AddWithValue("@NewState", 1);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("註冊成功");
                    txtEmail.Text = "";
                    txtName.Text = "";
                    txtJoinAccount.Text = "";
                    txtJoinPassword.Text = "";
                    txtJoinPasswordCheck.Text = "";
                    dateBirthDay.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("註冊失敗,請確認資料再試一次");
                }
                
                con.Close();
            }
            else
            {
                MessageBox.Show("註冊失敗,請確認資料再試一次");
            }
        }



        private void radioEmp_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.UserCharacter = 1;
        }

        private void radioPerson_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.UserCharacter = 2;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {   
            Dispose();
            GlobalVar.mylogin = null;
        }



        private void txtJoinPasswordCheck_TextChanged(object sender, EventArgs e)
        {
            if (txtJoinPassword.Text == txtJoinPasswordCheck.Text)
            {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "O";
                isCheck = true;
            }
            else
            {
                lblCheck.ForeColor= Color.Red;
                lblCheck.Text = "X";
                isCheck = false;
            }
        }

        private void btnAccountCheck_Click(object sender, EventArgs e)
        {
            CheckAccount();
        }

        void CheckAccount()
        {
            string strJoinAccount = txtJoinAccount.Text.Trim();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select id from persons where account=@NewAccount;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewAccount", strJoinAccount);
            SqlDataReader reader = cmd.ExecuteReader();
            int id = 0;

            while (reader.Read())
            {
                try
                {
                    id = (int)reader["id"];
                }
                catch
                {
                    Console.WriteLine("失敗");
                }
            }

            if (id > 0)
            {
                lblAccountCheck.ForeColor = Color.Red;
                lblAccountCheck.Text = "已有人使用此帳號";
                isAccountCheck = false;
            }
            else
            {
                lblAccountCheck.ForeColor = Color.Green;
                lblAccountCheck.Text = "目前無人使用此帳號";
                isAccountCheck = true;
            }


            reader.Close();
            con.Close();
        }
        private void txtJoinAccount_Leave(object sender, EventArgs e)
        {
            CheckAccount();
        }

        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            GlobalVar.mylogin = null;
            Dispose();
            Environment.Exit(0); //實在是不知道出什麼BUG 關不掉 只好用這招了
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
