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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn顯示QRcode_Click(object sender, EventArgs e)
        {
            userControl_QRcode1.Visible = true;           
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create();
            myCreateForm.Show();

            this.Hide(); //隱藏Form1

        }

        private void btn歷史紀錄_Click(object sender, EventArgs e)
        {
            userControl_Record1.Visible = true;
        }
    }
}
