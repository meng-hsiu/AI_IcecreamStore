using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
