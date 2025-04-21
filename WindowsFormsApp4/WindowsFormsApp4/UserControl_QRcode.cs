using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class UserControl_QRcode : UserControl
    {
        public UserControl_QRcode()
        {
            InitializeComponent();
        }

        private void UserControl_QRcode_Load(object sender, EventArgs e)
        {

        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/user/70999boy";

            // 使用 Process.Start() 打開預設瀏覽器並訪問指定的 URL
            System.Diagnostics.Process.Start(url);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/haofa_motorcycle_shop/";

            // 使用 Process.Start() 打開預設瀏覽器並訪問指定的 URL
            System.Diagnostics.Process.Start(url);
        }


    }
}
