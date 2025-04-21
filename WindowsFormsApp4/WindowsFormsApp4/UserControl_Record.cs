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

namespace WindowsFormsApp4
{
    public partial class UserControl_Record : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = ""; //資料庫連線字串        
        List<int> searchIDs = new List<int>(); //搜尋結果
        int DGV歷史紀錄 = 0; //dgv歷史紀錄;

        // 假設的數據
        private List<string> serviceItems = new List<string>
        {
            "機油200",
            "檢查傳動300",
            "中柱650"
        };


        public UserControl_Record()
        {
            InitializeComponent();
        }

        private void UserControl_Record_Load(object sender, EventArgs e)
        {
            scsb.DataSource = ".";  //伺服器名稱
            scsb.InitialCatalog = "myshop"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows驗證

            strDBConnectionString = scsb.ConnectionString.ToString();

            // 將服務項目加入到 ListBox
            foreach (var item in serviceItems)
            {
                lbox歷史紀錄列表.Items.Add(item);
            }
        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }



        private void dgv歷史紀錄列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            // 先查詢顧客的基本資料
            string strSQL = "SELECT * FROM customer WHERE 車牌 = @SearchMotorcycleLicensePlate;";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@SearchMotorcycleLicensePlate", txtbox關鍵字查詢.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // 顯示顧客的基本資料
                txt顯示欄位1.Text = (string)reader["姓名"];
                txt顯示欄位2.Text = (string)reader["車牌"];
                txt顯示欄位3.Text = (string)reader["型號"];
                             
            }
            else //先判斷是否"沒"找到人
            {
                MessageBox.Show("查無此人");
            }
            reader.Close();
            con.Close();
        }

        void 顯示會員欄位詳細資訊(int myId)
        {
            /*if (myId > 0)
            {

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select top 500 id as 會員編號, 姓名, 電話, 地址, email as 電子郵件, 生日 from persons;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txtID.Text = reader["id"].ToString();
                    txt姓名.Text = (string)reader["姓名"];
                    txt電話.Text = (string)reader["電話"];
                    txtEmail.Text = (string)reader["email"];
                    txt地址.Text = (string)reader["地址"];
                    dtp生日.Value = (DateTime)reader["生日"];
                    chk婚姻狀態.Checked = (bool)reader["婚姻狀態"];
                    txt點數.Text = reader["點數"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }*/
        }

        private void dgv歷史紀錄列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if ((e.RowIndex >= 0) && (e.RowIndex < DGV歷史紀錄))
            //{
            //    string strID = dgv歷史紀錄列表.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    Console.WriteLine(strID);

            //    int intSelId = 0;
            //    Int32.TryParse(strID, out intSelId);
            //    顯示會員欄位詳細資訊(intSelId);
            //}
        }
    }
}
