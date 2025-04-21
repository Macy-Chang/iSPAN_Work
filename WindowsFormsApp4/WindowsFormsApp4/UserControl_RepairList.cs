using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp4
{
    public partial class UserControl_RepairList : UserControl
    {
        // 假設的數據
        private List<string> serviceItems = new List<string>
        {
            "機油200",
            "檢查傳動300",
            "中柱650"
        };


        public UserControl_RepairList()
        {
            InitializeComponent();
            
        }
                
        private void UserControl_RepairList_Load(object sender, EventArgs e)
        {
            // 設置假設資料的內容
            tbx顯示欄位1.Text = "張小東";
            tbx顯示欄位2.Text = "713-QQQ";
            txt項目及零件費用小計.Text = "1100";
            txt工資小計.Text = "2000";
            txt折扣.Text = "0";
            txt總金額.Text = "3100";
            txt實收金額.Text = "3100";
            txt未收金額.Text = "0";

            // 將服務項目加入到 ListBox
            foreach (var item in serviceItems)
            {
                lbox服務項目列表.Items.Add(item);
            }

        }


        private void btn上一步_Click(object sender, EventArgs e)
        {
            // 返回上一頁邏輯
            this.Visible = false;
            UserControl_Service serviceControl = this.Parent.Controls.OfType<UserControl_Service>().FirstOrDefault();
            if (serviceControl != null)
            {
                serviceControl.Visible = true;
                serviceControl.BringToFront();
            }

        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();  // 關閉所在的父窗體

            // 創建並顯示 Form1
            Form1 form1 = new Form1();
            form1.Show();
        }


        private void tbx顯示欄位1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void tbx顯示欄位2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn產生報價單_Click(object sender, EventArgs e)
        {
            {
                // 收集顯示的資訊
                string customerName = tbx顯示欄位1.Text;  // 姓名
                string customerPhone = tbx顯示欄位2.Text; // 電話
                string itemSummary = GetItemSummary();     // 服務項目明細
                decimal itemCost = decimal.Parse(txt項目及零件費用小計.Text); // 項目及零件費用小計
                decimal laborCost = decimal.Parse(txt工資小計.Text); // 工資小計
                decimal discount = decimal.Parse(txt折扣.Text);    // 折扣
                decimal totalAmount = decimal.Parse(txt總金額.Text); // 總金額

                // 生成報價單內容
                StringBuilder quotation = new StringBuilder();
                quotation.AppendLine("------------- 報價單 -------------");
                quotation.AppendLine($"客戶姓名: {customerName}");
                quotation.AppendLine($"客戶電話: {customerPhone}");
                quotation.AppendLine("\n服務項目及價格:");
                quotation.AppendLine(itemSummary); // 顯示服務項目

                // 顯示各項金額
                quotation.AppendLine("\n項目及零件費用小計: " + itemCost.ToString("C"));
                quotation.AppendLine("工資小計: " + laborCost.ToString("C"));
                quotation.AppendLine("折扣: " + discount.ToString("C"));
                quotation.AppendLine("總金額: " + totalAmount.ToString("C"));
                quotation.AppendLine("\n------------------------------------");

                // 顯示保存路徑和文件名對話框
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt",  // 文件類型篩選器
                    FileName = "報價單.txt"  // 預設文件名
                };

                // 顯示對話框，並檢查是否選擇了文件路徑
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 將報價單內容保存到選擇的路徑
                    string filePath = saveFileDialog.FileName;

                    // 使用 StreamWriter 將內容寫入到指定的 .txt 文件
                    try
                    {
                        File.WriteAllText(filePath, quotation.ToString(), Encoding.UTF8);
                        MessageBox.Show("報價單已成功生成並保存到：" + filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("保存報價單時出現錯誤: " + ex.Message);
                    }
                }
            }

        }

        private string GetItemSummary()
        {
            // 假設服務項目已經存儲在 ListBox 控件中
            StringBuilder summary = new StringBuilder();
            foreach (var item in lbox服務項目列表.Items)
            {
                summary.AppendLine(item.ToString());
            }
            return summary.ToString();
        }

        private void btn確認存檔_Click(object sender, EventArgs e)
        {
            MessageBox.Show("資料已存檔");

        }

        private void lbox服務項目列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
