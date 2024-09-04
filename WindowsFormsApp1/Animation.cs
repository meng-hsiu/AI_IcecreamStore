using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Animation
    {
        #region Login
        private Timer mytimer = new Timer();
        private PictureBox mypictureBox = new PictureBox();
        private Panel mypanel = new Panel();
        int FastMaxCounts = 19;//FastMaxCounts*pixel 要是190
        int SlowMaxCounts = 17;//SlowMaxCounts*pixel要是90 慢的部分
        
        public void LoginPic(PictureBox pictureBox,Panel panel, bool isbool)
        { //True就是向左
            mytimer.Interval = 15;
            mypictureBox = pictureBox;
            mytimer.Start();
            mypanel = panel;
            //True就是向左284
            if (isbool)
            {
                mytimer.Tick += PicMoveLeft_Fast;
            }
            else
            {
                mytimer.Tick += PicMoveRight_Fast;
            }


        }

        //為了移動的更自然 所以分成兩部分 快跟慢 快占2/3的路徑



        int Left_Fastcounts = 0;
        public void PicMoveLeft_Fast(object sender, EventArgs e)
        {
            
            if (Left_Fastcounts <= FastMaxCounts)
            {
                mypictureBox.Location = new Point(285 - 12 * Left_Fastcounts, 0);
                Left_Fastcounts++;
            }
            else
            {
                mytimer.Tick -= PicMoveLeft_Fast;
                mytimer.Tick += PicMoveLeft_slow;
                Left_Fastcounts = 0;
            }

        }



        int Right_Fastcounts = 0;
        public void PicMoveRight_Fast(object sender, EventArgs e)
        {//Panel的寬度是285 所以移動190
            
            if (Right_Fastcounts <= FastMaxCounts)
            {                
                mypictureBox.Location = new Point(0 + 12* Right_Fastcounts, 0);
                Right_Fastcounts++;
            }
            else
            {
                mytimer.Tick -= PicMoveRight_Fast;
                mytimer.Tick += PicMoveRight_slow;
                Right_Fastcounts = 0;
            }
            
            
        }


        int Left_slowcounts = 0;
        public void PicMoveLeft_slow(object sender, EventArgs e)
        {
            
            if (Left_slowcounts < SlowMaxCounts)
            {
                mypictureBox.Location = new Point(57 - 3 * Left_slowcounts, 0);
                Left_slowcounts++;
            }
            else
            {                
                mypictureBox.Location = new Point(0,0);                
                mypanel.Visible = true;
                Left_slowcounts = 0;
                mytimer.Tick -= PicMoveLeft_slow;
                mytimer.Stop();
                mytimer.Dispose();
            }
        }


        int Right_slowcounts = 0;
        public void PicMoveRight_slow(object sender, EventArgs e)
        {
            
            if (Right_slowcounts < SlowMaxCounts)
            {
                mypictureBox.Location = new Point(228 + 3 * Right_slowcounts, 0);
                Right_slowcounts++;
            }
            else
            {                
                mypictureBox.Location = new Point(285, 0);                
                mypanel.Visible = true;
                Right_slowcounts= 0;
                mytimer.Tick -= PicMoveRight_slow;
                mytimer.Stop();
                mytimer.Dispose();
            }
        }
        #endregion



        #region Menu的部分
        int currentIndex = 0;
        int currentSlowIndex = 0;
        int MenuMaxCounts = 12;
        int MenuSlowMaxCount = 12;
        public int panelWidth = 0;
        public int panelHeight = 0;
        int panelFastChangeSize = 0;
        int panelSlowChangeSize = 0;
        Panel selectpanel = null;
        Timer Menutimer;
        public Button Menubutton;
        private Panel Menupanel = new Panel();

        public void CreateSize(Panel panel)
        {
            if (panelHeight == 0)
            {
                panelHeight = panel.Height;
            }
            panelWidth = panel.Width;
            selectpanel = panel;
            panelFastChangeSize = ((panelHeight / 7) * 6) / MenuMaxCounts;
            panelSlowChangeSize = (panelHeight / 7) / MenuSlowMaxCount;
        }


        public void MenuAnimation(Button button, Panel panel, bool action)
        {//true是打開 false是關閉
            /*
            if (panelHeight == 0)
            {
                panelHeight = panel.Height;
            }
            panelWidth = panel.Width;
            selectpanel = panel;
            panelFastChangeSize = ((panelHeight / 7)*6)/ MenuMaxCounts;
            panelSlowChangeSize = (panelHeight / 7) / MenuSlowMaxCount;
            */
            Menutimer = new Timer();
            Menutimer.Interval = 10;
            Menutimer.Enabled = true;
            Menutimer.Start();
            currentIndex = 0;
            Menupanel = panel;
            Menubutton = button;

            if (action == true)
            {
                currentIndex = 0;
                currentSlowIndex = 0;
                Menutimer.Tick += Open;
                Menupanel.Height = 0;
                Menupanel.Visible = true;
            }
            else
            {
                currentIndex = 0;
                currentSlowIndex = 0;
                Menutimer.Tick += Close;
            }

        }


        //打開的動畫
        public void Open(object sender, EventArgs e)
        {
            if (currentIndex < MenuMaxCounts)
            {
                Menubutton.Enabled = false;
                currentIndex += 1;
                Menupanel.Height += panelFastChangeSize;
            }
            else
            {
                Menutimer.Tick -= Open;
                Menutimer.Tick += Open_slow;
                
            }
        }


        public void Open_slow(object sender, EventArgs e)
        {
            if (currentSlowIndex < MenuSlowMaxCount)
            {
                Menubutton.Enabled = false;
                currentSlowIndex += 1;
                Menupanel.Height += panelSlowChangeSize;
            }
            else
            {
                selectpanel.Size=new Size(panelWidth,panelHeight);
                Menutimer.Tick -= Open_slow;
                Menutimer.Stop();
                Menutimer.Enabled = false;
                Menutimer.Dispose();
                Menubutton.Enabled = true;
            }
        }



        //關閉的動畫
        public void Close(object sender, EventArgs e)
        {
            if (currentIndex < MenuMaxCounts)
            {
                Menubutton.Enabled = false;
                currentIndex += 1;
                Menupanel.Height -= panelFastChangeSize;
            }
            else
            {
                Menutimer.Tick -= Close;
                Menutimer.Tick += Close_slow;
            }
        }





        public void Close_slow(object sender, EventArgs e)
        {
            if (currentSlowIndex < MenuSlowMaxCount)
            {
                Menubutton.Enabled = false;
                currentSlowIndex += 1;
                Menupanel.Height -= panelSlowChangeSize;
            }
            else
            {
                Menubutton.Enabled = true;
                Menutimer.Tick -= Close_slow;
                Menutimer.Stop();
                Menutimer.Enabled = false;
                Menupanel.Visible = false; //節省效能 把它關了 其實沒這行也沒差
                Menutimer.Dispose();
                
            }
        }
        #endregion


    }



}