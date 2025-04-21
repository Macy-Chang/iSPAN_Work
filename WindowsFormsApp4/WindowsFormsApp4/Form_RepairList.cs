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
    public partial class Form_RepairList : Form
    {
        public Form_RepairList()
        {
            InitializeComponent();
        }

        private void Form_RepairList_Load(object sender, EventArgs e)
        {

        }

        private void btn上一步_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();  // 關閉所在的父窗體

            // 創建並顯示 Form1
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
