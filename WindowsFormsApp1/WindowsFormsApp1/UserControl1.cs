using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            this.Size = new Size(484, 93); // 設置固定大小，例如 200x100
            this.MaximumSize = this.Size; // 設置最大大小為固定大小
            this.MinimumSize = this.Size; // 設置最小大小為固定大小
            this.Dock = DockStyle.Top;
        }

    }
}
