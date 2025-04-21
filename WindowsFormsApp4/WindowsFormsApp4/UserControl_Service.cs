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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace WindowsFormsApp4
{
    public partial class UserControl_Service : UserControl
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";


        public UserControl_Service()
        {
            InitializeComponent();
        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();  // 關閉所在的父窗體

            // 創建並顯示 Form1
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void btn上一步_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void btn結帳去_Click(object sender, EventArgs e)
        {

            // 假設您有多個 CheckBox，例如 checkBox1, checkBox2, checkBox3...
            if (cbx機油.Checked || cbx齒輪油.Checked || cbx汽油精.Checked || cbx空濾.Checked || cbx火星塞.Checked || cbx剎車油.Checked || cbx檢查傳動系統.Checked || cbx皮帶.Checked || cbx輪胎之外胎.Checked || cbx剎車皮.Checked || cbx清洗油路.Checked || cbx三角台.Checked || cbx車台.Checked)
            {
                // 假設你有一個父容器來顯示 UserControl
                // 假設父容器是這個 UserControl
                UserControl_RepairList repairListControl = new UserControl_RepairList();

                // 如果需要將 UserControl_RepairList 添加到當前容器中顯示：
                this.Controls.Add(repairListControl);
                repairListControl.BringToFront();  // 使其顯示在前面
            }
            else
            {
                // 如果都沒有勾選，顯示提示訊息
                MessageBox.Show("請勾選服務項目，謝謝");
            }



        }

        private void UserControl_Service_Load(object sender, EventArgs e)
        {
            scsb.DataSource = ".";  //伺服器名稱
            scsb.InitialCatalog = "myshop"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows驗證

            strDBConnectionString = scsb.ConnectionString.ToString();

            // 載入服務項目
            LoadServiceItems();

        }

        // 載入服務項目到 listBox
        private void LoadServiceItems()
        {
            listBox顯示服務項目.Items.Clear();  // 清空現有的項目

            using (SqlConnection connection = new SqlConnection(strDBConnectionString))
            {
                connection.Open();
                string query = @"SELECT 服務項目,price FROM FixList_price;";  // 查詢服務名稱和價格
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // 遍歷資料庫中的資料並將服務名稱與價格顯示在 listBox 中
                while (reader.Read())
                {
                    string serviceName = reader["服務項目"].ToString();
                    decimal price = Convert.ToDecimal(reader["price"]);
                    // 在 listBox 顯示 服務名稱 和 價格
                    listBox顯示服務項目.Items.Add($"{serviceName} - {price:C}");  // 格式化價格為貨幣顯示
                }
            }
        }



    }
}
