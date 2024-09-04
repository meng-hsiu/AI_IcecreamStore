using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    internal class GlobalVar
    {
        public static ListBox OrderList = new ListBox();
        public static Button CartButton = new Button();
        public static Cart mycart = new Cart();
        public static Login mylogin = new Login();
        public static ProductDetail productDetail = new ProductDetail();
        public static Form1 Form1 = new Form1();
        public static Panel panelItemManage = new Panel();


        public static List<Products> listallmyproducts = new List<Products>();


        public static string strDBConnectionString = "";
        public static string image_dir = @"C:\Users\meng\Documents\Class\Project\Images";

        public static ArrayList arrayListOrderItem = new ArrayList();
        public static ArrayList arrayListOrderItemCounts = new ArrayList();



        public static int OrderDetailId = 0;
        public static int DetailItemId = 0;

        //使用者登入部分
        public static bool isLogin = false;
        public static string UserName = "";
        public static int UserID = 0;
        public static string Useraccount = "";
        public static string Userpassword = "";
        public static string Useremail = "";
        public static DateTime Userbirthday = DateTime.Now;
        public static int UserRole = 0;
        public static int UserCharacter = 0; //會員:2,員工:1
        public static int UserState = 0; //會員:2,員工:1

    }
}
