using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp4
{
    public partial class Create : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>();

        string str修改後的圖檔名稱 = "";
        bool is修改圖檔 = false;
        private bool 搜尋成功 = false;
        string 搜尋的車牌 = "";



        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            scsb.DataSource = ".";  //伺服器名稱
            scsb.InitialCatalog = "myshop"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows驗證

            strDBConnectionString = scsb.ConnectionString.ToString();


        }





        private void btn連線測試_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 100 * from customer;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int count = 0;

            while (reader.Read() == true)
            {
                int id = (int)reader["id"];
                string 姓名 = (string)reader["姓名"];
                string 電話 = (string)reader["電話"];
                bool 車種 = (bool)reader["車種"];
                string 型號 = (string)reader["型號"];
                string 車牌 = (string)reader["車牌"];


                strMsg += $"{id} {姓名} {電話} {車種} {型號} {車牌}\n";
                count += 1;
            }

            strMsg += "--------------------------------------\n";
            strMsg += $"資料筆數:{count}";

            reader.Close();
            con.Close();
            MessageBox.Show(strMsg);
        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            this.Close();  // 關閉所在的父窗體

            // 創建並顯示 Form1
            Form1 form1 = new Form1();
            form1.Show();
        }




        void 選取商品圖片()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(Jpeg, Jpg, Png)|*.jpeg;*.jpg;*.png";

            DialogResult R = ofd.ShowDialog();

            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pbox機車示意圖.Image = Image.FromStream(fs);
                fs.Close();
                pbox機車示意圖.Tag = ofd.FileName;
                string str圖檔副檔名 = System.IO.Path.GetExtension(ofd.SafeFileName).ToLower();
                Random myRnd = new Random();
                str修改後的圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                is修改圖檔 = true;
                Console.WriteLine(str修改後的圖檔名稱);
            }
        }

        int 建立新會員編號() /// 需要取值的時候，寫int return
        {
            string 會員編號年份 = DateTime.Now.ToString("yyyy"); //

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "SELECT MAX(會員編號) AS 會員編號 FROM customer WHERE 會員編號 like @SearchCustomerNumber;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCustomerNumber", $"{會員編號年份}%");
            SqlDataReader reader = cmd.ExecuteReader();


            int 新會員編號 = 0;
            if (reader.Read())
            {
                int 最後一筆會員編號 = (int)reader["會員編號"];
                最後一筆會員編號++;
                新會員編號 = 最後一筆會員編號;
            }
            else
            {
                // 若沒抓到資料，就重新給一筆新會員編號
                Int32.TryParse(會員編號年份, out 新會員編號);
                新會員編號 = 新會員編號 * 1000 + 1;
            }
            reader.Close();
            con.Close();

            return 新會員編號;
        }

        private void btn建立資料_Click(object sender, EventArgs e)
        {
            if ((dateTP本次維修時間.Value != DateTime.MinValue) && (txt姓名.Text != "") && (txt電話.Text != "") && (chk速克達.Checked || chk打檔車.Checked) && (txt機車型號.Text != "") && (txt機車車牌.Text != "") && (txt機車里程數.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into customer (姓名,電話,車種,型號,車牌,與客人的關係,備註,image,本次維修日期,里程數,會員編號) values (@NewName,@NewPhone,@NewMotorcycleType,@NewMotorcycleModel,@NewMotorcycleLicensePlate,@NewRelation,@NewRemark,@NewImage,@NewFixDate,@NewMileAge,@NewCustomerNumber);";
                SqlCommand cmd = new SqlCommand(strSQL, con);


                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewMotorcycleType", chk速克達.Checked || chk打檔車.Checked);
                cmd.Parameters.AddWithValue("@NewMotorcycleModel", txt機車型號.Text);
                cmd.Parameters.AddWithValue("@NewMotorcycleLicensePlate", txt機車車牌.Text);
                cmd.Parameters.AddWithValue("@NewRelation", txt與客人的關係.Text);
                cmd.Parameters.AddWithValue("@NewRemark", txt備註.Text);
                cmd.Parameters.AddWithValue("@NewImage", str修改後的圖檔名稱);
                cmd.Parameters.AddWithValue("@NewFixDate", dateTP本次維修時間.Value);
                cmd.Parameters.AddWithValue("@NewMileAge", txt機車里程數.Text);

                cmd.Parameters.AddWithValue("@NewCustomerNumber", 建立新會員編號()); // 建立新會員編號，要自己寫int

                if (is修改圖檔 == true)
                { //存檔
                    string str完整圖檔路徑 = GlobalVar.image_dir + @"\" + str修改後的圖檔名稱;
                    Console.WriteLine(str完整圖檔路徑);
                    pbox機車示意圖.Tag = str完整圖檔路徑;
                    pbox機車示意圖.Image.Save(str完整圖檔路徑);
                    is修改圖檔 = false;
                }


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料新增成功，{rows} 筆已建檔.");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全，請返回做填寫");
            }
        }


        /// 刪除資料是以"車牌"為準 ---可能有Bug要修改
        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            // 取得車牌號碼，假設 txt車牌是用來輸入車牌號碼的 TextBox
            string carPlate = txt機車車牌.Text;

            // 檢查車牌是否為空
            if (!string.IsNullOrEmpty(carPlate))
            {
                // 顯示確認刪除對話框
                DialogResult result = MessageBox.Show($"確定要刪除車牌 {carPlate} 的資料嗎?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // 如果用戶選擇 Yes (確定刪除)
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // 使用 SqlConnection 建立資料庫連接
                        using (SqlConnection con = new SqlConnection(strDBConnectionString))
                        {
                            con.Open();

                            // 編寫 SQL 語句，根據車牌刪除資料
                            string strSQL = "delete from customer where 車牌 = @CarPlate;";
                            using (SqlCommand cmd = new SqlCommand(strSQL, con))
                            {
                                // 添加車牌參數
                                cmd.Parameters.AddWithValue("@CarPlate", carPlate);

                                // 執行刪除命令
                                int rows = cmd.ExecuteNonQuery();

                                // 如果刪除成功
                                if (rows > 0)
                                {
                                    // 清空欄位並顯示刪除成功的訊息
                                    清空欄位();
                                    MessageBox.Show($"車牌 {carPlate} 的資料刪除成功, 影響 {rows} 筆資料.");
                                }
                                else
                                {
                                    // 如果找不到該車牌的資料
                                    MessageBox.Show("刪除失敗！\n請重新填寫，謝謝!!");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // 處理錯誤，顯示錯誤訊息
                        MessageBox.Show($"刪除資料時發生錯誤: {ex.Message}");
                    }
                }
                else
                {
                    // 如果用戶選擇 No (取消刪除)
                    MessageBox.Show("已取消刪除動作");
                }
            }
            else
            {
                // 如果車牌欄位為空
                MessageBox.Show("請輸入有效的資料，謝謝");
            }
        }





        private void dateTP本次維修時間_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt姓名_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt電話_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk速克達_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk打檔車_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void cbx機車型號_SelectedIndexChanged(object sender, EventArgs e)
        {

        }







        private void cbx機車車牌_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt與客人的關係_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt備註_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbox機車示意圖_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        private void txtbox關鍵字查詢_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn搜尋_Click(object sender, EventArgs e)
        {
            int count = 0; // 計算搜尋SQL的資料次數
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            // 先查詢顧客的基本資料
            string strSQL = "SELECT * FROM customer WHERE 車牌 = @SearchMotorcycleLicensePlate ORDER BY '本次維修日期' DESC;";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@SearchMotorcycleLicensePlate", txtbox關鍵字查詢.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // 顯示顧客的基本資料
                txt姓名.Text = (string)reader["姓名"];
                txt電話.Text = (string)reader["電話"];
                txt機車型號.Text = (string)reader["型號"];
                txt機車車牌.Text = (string)reader["車牌"];
                txt機車里程數.Text = ((int)reader["里程數"]).ToString();
                txt與客人的關係.Text = reader.IsDBNull(reader.GetOrdinal("與客人的關係")) ? "" : (string)reader["與客人的關係"];
                txt備註.Text = reader.IsDBNull(reader.GetOrdinal("備註")) ? "" : (string)reader["備註"];
                txt上次維修日期.Text = ((DateTime)reader["本次維修日期"]).ToString("yyyy-MM-dd");
                // 機車車種顯示
                搜尋的車牌 = (string)reader["車牌"];
                int is機車車種 = (int)reader["車種"];
                if (is機車車種 == 0)
                {
                    chk打檔車.Checked = true;
                    chk速克達.Checked = false;
                }
                else
                {
                    chk打檔車.Checked = false;
                    chk速克達.Checked = true;
                }

                // 顯示機車示意圖
                string 機車示意圖 = reader["image"].ToString();
                string 機車圖檔位置 = GlobalVar.image_dir + @"\" + 機車示意圖;
                System.IO.FileStream fs = System.IO.File.OpenRead(機車圖檔位置);
                pbox機車示意圖.Image = Image.FromStream(fs);

                count++;
            }
            else //先判斷是否"沒"找到人
            {
                MessageBox.Show("查無此人");
            }
            reader.Close();
            con.Close();
        }



        void 清空欄位()
        {
            txt上次維修日期.Clear();
            txt姓名.Clear();
            txt電話.Clear();
            chk速克達.Checked = false;
            chk打檔車.Checked = false;
            txt機車車牌.Clear();
            txt機車里程數.Clear();
            txt機車型號.Clear();
            txt與客人的關係.Clear();
            txt備註.Clear();
            dateTP本次維修時間.Value = DateTime.Now;

            // 清空圖片並設置預設圖片
            //pbox機車示意圖.Image = Image.FromFile("C:\\Users\\iSpan\\Desktop\\Macy\\個人專題\\Photo\\motorbike.png");


        }

        private void btn清空資料_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn下一步_Click_1(object sender, EventArgs e)
        {
            if ((txt機車車牌.Text != "") && (txt姓名.Text != "") && (txt電話.Text != ""))
            {
                userControl_Service1.Visible = true;
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }


        void 顯示資料筆數()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            // 先查詢顧客的基本資料
            string strSQL = "select * from customer;";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmd.ExecuteReader(); //////// 11.09 回去要複習一下

            if (reader.Read())
            {
                // 顯示顧客的基本資料
                txt姓名.Text = (string)reader["姓名"];
                txt電話.Text = (string)reader["電話"];
                txt機車型號.Text = (string)reader["型號"];
                txt機車車牌.Text = (string)reader["車牌"];
                txt機車里程數.Text = ((int)reader["里程數"]).ToString();
                txt與客人的關係.Text = reader.IsDBNull(reader.GetOrdinal("與客人的關係")) ? "" : (string)reader["與客人的關係"];
                txt備註.Text = reader.IsDBNull(reader.GetOrdinal("備註")) ? "" : (string)reader["備註"];

                // 機車車種顯示
                int is機車車種 = (int)reader["車種"];
                if (is機車車種 == 0)
                {
                    chk打檔車.Checked = true;
                    chk速克達.Checked = false;
                }
                else
                {
                    chk打檔車.Checked = false;
                    chk速克達.Checked = true;
                }

                // 顯示機車示意圖
                string 機車示意圖 = reader["image"].ToString();
                string 機車圖檔位置 = GlobalVar.image_dir + @"\" + 機車示意圖;
                System.IO.FileStream fs = System.IO.File.OpenRead(機車圖檔位置);
                pbox機車示意圖.Image = Image.FromStream(fs);

                // 查詢顧客的最新維修日期
                reader.Close(); // 先關閉前一次的 reader

                string repairDateSQL = @"SELECT MAX(本次維修日期) AS LastRepairDate FROM customer;";

                SqlCommand cmdRepairDate = new SqlCommand(repairDateSQL, con);


                var lastRepairDate = cmdRepairDate.ExecuteScalar();

                if (lastRepairDate != DBNull.Value)
                {
                    // 顯示顧客的最後一次維修日期
                    txt上次維修日期.Text = Convert.ToDateTime(lastRepairDate).ToString("yyyy-MM-dd");
                }
                else
                {
                    // 若沒有維修記錄，顯示提示
                    txt上次維修日期.Text = "沒有維修記錄";
                }
            }
            else
            {
                MessageBox.Show("查無此人");
            }

            reader.Close();
            con.Close();

        }

        private void btn最後一筆_Click(object sender, EventArgs e)
        {

            顯示資料筆數();
        }

        private void btn第一筆_Click(object sender, EventArgs e)
        {

        }

        private void btn下一筆_Click(object sender, EventArgs e)
        {

        }

        private void btn上一筆_Click(object sender, EventArgs e)
        {

        }

        private void txt機車里程數_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {

            if ((txt機車車牌.Text != "") && (txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update customer set 姓名 = @NewName, 電話 = @NewPhone, 車種 = @NewMotorcycleType, 型號 = @NewMotorcycleModel, 車牌 = @NewMotorcycleLicensePlate, 與客人的關係 = @NewRelation, 備註 = @NewRemark, image = @NewImage, 本次維修日期 = @NewFixDate, 里程數 = @NewMileAge where 車牌 = @SearchMotorcycleLicensePlate;";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewMotorcycleType", chk速克達.Checked || chk打檔車.Checked);
                cmd.Parameters.AddWithValue("@NewMotorcycleModel", txt機車型號.Text);
                cmd.Parameters.AddWithValue("@NewMotorcycleLicensePlate", txt機車車牌.Text);
                cmd.Parameters.AddWithValue("@SearchMotorcycleLicensePlate", 搜尋的車牌);
                cmd.Parameters.AddWithValue("@NewRelation", txt與客人的關係.Text);
                cmd.Parameters.AddWithValue("@NewRemark", txt備註.Text);
                cmd.Parameters.AddWithValue("@NewImage", str修改後的圖檔名稱);
                cmd.Parameters.AddWithValue("@NewFixDate", dateTP本次維修時間.Value);

                int 機車里程數 = 0;
                Int32.TryParse(txt機車里程數.Text, out 機車里程數);
                cmd.Parameters.AddWithValue("@NewMileAge", 機車里程數);




                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"共{rows}筆資料完成修改");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        private void txt上次維修日期_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
