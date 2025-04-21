namespace WindowsFormsApp4
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.txt機車車牌 = new System.Windows.Forms.TextBox();
            this.txt機車型號 = new System.Windows.Forms.TextBox();
            this.btn修改資料 = new System.Windows.Forms.Button();
            this.txt機車里程數 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt上次維修日期 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn連線測試 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn清空資料 = new System.Windows.Forms.Button();
            this.btn建立資料 = new System.Windows.Forms.Button();
            this.btn下一步 = new System.Windows.Forms.Button();
            this.btn回首頁 = new System.Windows.Forms.Button();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pbox機車示意圖 = new System.Windows.Forms.PictureBox();
            this.chk打檔車 = new System.Windows.Forms.CheckBox();
            this.chk速克達 = new System.Windows.Forms.CheckBox();
            this.dateTP本次維修時間 = new System.Windows.Forms.DateTimePicker();
            this.txt備註 = new System.Windows.Forms.TextBox();
            this.txt與客人的關係 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox關鍵字查詢 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl_RepairList1 = new WindowsFormsApp4.UserControl_RepairList();
            this.userControl_Service1 = new WindowsFormsApp4.UserControl_Service();
            ((System.ComponentModel.ISupportInitialize)(this.pbox機車示意圖)).BeginInit();
            this.SuspendLayout();
            // 
            // txt機車車牌
            // 
            this.txt機車車牌.Location = new System.Drawing.Point(183, 503);
            this.txt機車車牌.Multiline = true;
            this.txt機車車牌.Name = "txt機車車牌";
            this.txt機車車牌.Size = new System.Drawing.Size(196, 33);
            this.txt機車車牌.TabIndex = 188;
            // 
            // txt機車型號
            // 
            this.txt機車型號.Location = new System.Drawing.Point(183, 466);
            this.txt機車型號.Multiline = true;
            this.txt機車型號.Name = "txt機車型號";
            this.txt機車型號.Size = new System.Drawing.Size(196, 33);
            this.txt機車型號.TabIndex = 187;
            // 
            // btn修改資料
            // 
            this.btn修改資料.AutoSize = true;
            this.btn修改資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(124)))));
            this.btn修改資料.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn修改資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn修改資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改資料.Image = ((System.Drawing.Image)(resources.GetObject("btn修改資料.Image")));
            this.btn修改資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn修改資料.Location = new System.Drawing.Point(716, 498);
            this.btn修改資料.Name = "btn修改資料";
            this.btn修改資料.Size = new System.Drawing.Size(128, 42);
            this.btn修改資料.TabIndex = 186;
            this.btn修改資料.Text = "修改資料";
            this.btn修改資料.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn修改資料.UseVisualStyleBackColor = false;
            this.btn修改資料.Click += new System.EventHandler(this.btn修改資料_Click);
            // 
            // txt機車里程數
            // 
            this.txt機車里程數.Location = new System.Drawing.Point(183, 540);
            this.txt機車里程數.Multiline = true;
            this.txt機車里程數.Name = "txt機車里程數";
            this.txt機車里程數.Size = new System.Drawing.Size(196, 33);
            this.txt機車里程數.TabIndex = 185;
            this.txt機車里程數.TextChanged += new System.EventHandler(this.txt機車里程數_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(108, 545);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 184;
            this.label17.Text = "里程數";
            // 
            // txt上次維修日期
            // 
            this.txt上次維修日期.Location = new System.Drawing.Point(180, 216);
            this.txt上次維修日期.Multiline = true;
            this.txt上次維修日期.Name = "txt上次維修日期";
            this.txt上次維修日期.Size = new System.Drawing.Size(196, 33);
            this.txt上次維修日期.TabIndex = 183;
            this.txt上次維修日期.TextChanged += new System.EventHandler(this.txt上次維修日期_TextChanged);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.DarkKhaki;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(54, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 78);
            this.label15.TabIndex = 182;
            this.label15.Text = "日\r\n期";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(102, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 181;
            this.label13.Text = "上次維修";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(740, 691);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 19);
            this.label4.TabIndex = 180;
            this.label4.Text = "(前往新增維修/保養紀錄)";
            // 
            // btn連線測試
            // 
            this.btn連線測試.Location = new System.Drawing.Point(836, 18);
            this.btn連線測試.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn連線測試.Name = "btn連線測試";
            this.btn連線測試.Size = new System.Drawing.Size(86, 38);
            this.btn連線測試.TabIndex = 179;
            this.btn連線測試.Text = "連線測試";
            this.btn連線測試.UseVisualStyleBackColor = true;
            this.btn連線測試.Visible = false;
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.AutoSize = true;
            this.btn刪除資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(124)))));
            this.btn刪除資料.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn刪除資料.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn刪除資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除資料.ForeColor = System.Drawing.Color.Red;
            this.btn刪除資料.Image = global::WindowsFormsApp4.Properties.Resources.user;
            this.btn刪除資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn刪除資料.Location = new System.Drawing.Point(716, 556);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(128, 42);
            this.btn刪除資料.TabIndex = 178;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn刪除資料.UseVisualStyleBackColor = false;
            this.btn刪除資料.Click += new System.EventHandler(this.btn刪除資料_Click);
            // 
            // btn清空資料
            // 
            this.btn清空資料.AutoSize = true;
            this.btn清空資料.BackColor = System.Drawing.Color.Orange;
            this.btn清空資料.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn清空資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn清空資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空資料.Image = global::WindowsFormsApp4.Properties.Resources.recycle;
            this.btn清空資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn清空資料.Location = new System.Drawing.Point(573, 556);
            this.btn清空資料.Name = "btn清空資料";
            this.btn清空資料.Size = new System.Drawing.Size(128, 42);
            this.btn清空資料.TabIndex = 177;
            this.btn清空資料.Text = "清空資料";
            this.btn清空資料.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn清空資料.UseVisualStyleBackColor = false;
            this.btn清空資料.Click += new System.EventHandler(this.btn清空資料_Click);
            // 
            // btn建立資料
            // 
            this.btn建立資料.AutoSize = true;
            this.btn建立資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(124)))));
            this.btn建立資料.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn建立資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn建立資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn建立資料.Image = global::WindowsFormsApp4.Properties.Resources.add_document;
            this.btn建立資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn建立資料.Location = new System.Drawing.Point(573, 498);
            this.btn建立資料.Name = "btn建立資料";
            this.btn建立資料.Size = new System.Drawing.Size(128, 42);
            this.btn建立資料.TabIndex = 176;
            this.btn建立資料.Text = "建立資料";
            this.btn建立資料.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn建立資料.UseVisualStyleBackColor = false;
            this.btn建立資料.Click += new System.EventHandler(this.btn建立資料_Click);
            // 
            // btn下一步
            // 
            this.btn下一步.AutoSize = true;
            this.btn下一步.BackColor = System.Drawing.Color.Gold;
            this.btn下一步.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn下一步.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn下一步.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn下一步.Image = global::WindowsFormsApp4.Properties.Resources.checkbox;
            this.btn下一步.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn下一步.Location = new System.Drawing.Point(804, 713);
            this.btn下一步.Name = "btn下一步";
            this.btn下一步.Size = new System.Drawing.Size(111, 42);
            this.btn下一步.TabIndex = 175;
            this.btn下一步.Text = "下一步";
            this.btn下一步.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn下一步.UseVisualStyleBackColor = false;
            this.btn下一步.Click += new System.EventHandler(this.btn下一步_Click_1);
            // 
            // btn回首頁
            // 
            this.btn回首頁.AutoSize = true;
            this.btn回首頁.BackColor = System.Drawing.Color.Gold;
            this.btn回首頁.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn回首頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn回首頁.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回首頁.Image = ((System.Drawing.Image)(resources.GetObject("btn回首頁.Image")));
            this.btn回首頁.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn回首頁.Location = new System.Drawing.Point(19, 713);
            this.btn回首頁.Name = "btn回首頁";
            this.btn回首頁.Size = new System.Drawing.Size(111, 42);
            this.btn回首頁.TabIndex = 174;
            this.btn回首頁.Text = "回首頁";
            this.btn回首頁.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn回首頁.UseVisualStyleBackColor = false;
            this.btn回首頁.Click += new System.EventHandler(this.btn回首頁_Click);
            // 
            // btn搜尋
            // 
            this.btn搜尋.AutoSize = true;
            this.btn搜尋.BackColor = System.Drawing.Color.Transparent;
            this.btn搜尋.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn搜尋.FlatAppearance.BorderSize = 0;
            this.btn搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Image = ((System.Drawing.Image)(resources.GetObject("btn搜尋.Image")));
            this.btn搜尋.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn搜尋.Location = new System.Drawing.Point(654, 82);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(47, 42);
            this.btn搜尋.TabIndex = 173;
            this.btn搜尋.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Image = global::WindowsFormsApp4.Properties.Resources.moped;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(11, 10);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(362, 62);
            this.label19.TabIndex = 172;
            this.label19.Text = "小安機車行";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DarkKhaki;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(56, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 78);
            this.label14.TabIndex = 171;
            this.label14.Text = "顧\r\n客";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.DarkKhaki;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(56, 430);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 143);
            this.label18.TabIndex = 170;
            this.label18.Text = "機\r\n車";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(193)))), ((int)(((byte)(119)))));
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(517, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(382, 35);
            this.label16.TabIndex = 169;
            this.label16.Text = "機車示意圖";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbox機車示意圖
            // 
            this.pbox機車示意圖.Image = global::WindowsFormsApp4.Properties.Resources.motorbike;
            this.pbox機車示意圖.Location = new System.Drawing.Point(517, 227);
            this.pbox機車示意圖.Name = "pbox機車示意圖";
            this.pbox機車示意圖.Size = new System.Drawing.Size(382, 250);
            this.pbox機車示意圖.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox機車示意圖.TabIndex = 168;
            this.pbox機車示意圖.TabStop = false;
            this.pbox機車示意圖.Click += new System.EventHandler(this.pbox機車示意圖_Click);
            // 
            // chk打檔車
            // 
            this.chk打檔車.AutoSize = true;
            this.chk打檔車.Location = new System.Drawing.Point(279, 428);
            this.chk打檔車.Name = "chk打檔車";
            this.chk打檔車.Size = new System.Drawing.Size(76, 24);
            this.chk打檔車.TabIndex = 167;
            this.chk打檔車.Text = "打檔車";
            this.chk打檔車.UseVisualStyleBackColor = true;
            this.chk打檔車.CheckedChanged += new System.EventHandler(this.chk打檔車_CheckedChanged);
            // 
            // chk速克達
            // 
            this.chk速克達.AutoSize = true;
            this.chk速克達.Location = new System.Drawing.Point(197, 428);
            this.chk速克達.Name = "chk速克達";
            this.chk速克達.Size = new System.Drawing.Size(76, 24);
            this.chk速克達.TabIndex = 166;
            this.chk速克達.Text = "速克達";
            this.chk速克達.UseVisualStyleBackColor = true;
            this.chk速克達.CheckedChanged += new System.EventHandler(this.chk速克達_CheckedChanged);
            // 
            // dateTP本次維修時間
            // 
            this.dateTP本次維修時間.Location = new System.Drawing.Point(183, 262);
            this.dateTP本次維修時間.Name = "dateTP本次維修時間";
            this.dateTP本次維修時間.Size = new System.Drawing.Size(196, 29);
            this.dateTP本次維修時間.TabIndex = 165;
            this.dateTP本次維修時間.ValueChanged += new System.EventHandler(this.dateTP本次維修時間_ValueChanged);
            // 
            // txt備註
            // 
            this.txt備註.Location = new System.Drawing.Point(181, 637);
            this.txt備註.Multiline = true;
            this.txt備註.Name = "txt備註";
            this.txt備註.Size = new System.Drawing.Size(196, 59);
            this.txt備註.TabIndex = 164;
            this.txt備註.TextChanged += new System.EventHandler(this.txt備註_TextChanged);
            // 
            // txt與客人的關係
            // 
            this.txt與客人的關係.Location = new System.Drawing.Point(181, 597);
            this.txt與客人的關係.Multiline = true;
            this.txt與客人的關係.Name = "txt與客人的關係";
            this.txt與客人的關係.Size = new System.Drawing.Size(196, 33);
            this.txt與客人的關係.TabIndex = 163;
            this.txt與客人的關係.TextChanged += new System.EventHandler(this.txt與客人的關係_TextChanged);
            // 
            // txt電話
            // 
            this.txt電話.Location = new System.Drawing.Point(183, 361);
            this.txt電話.Multiline = true;
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(196, 33);
            this.txt電話.TabIndex = 162;
            this.txt電話.TextChanged += new System.EventHandler(this.txt電話_TextChanged);
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(183, 321);
            this.txt姓名.Multiline = true;
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(196, 33);
            this.txt姓名.TabIndex = 161;
            this.txt姓名.TextChanged += new System.EventHandler(this.txt姓名_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 506);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 160;
            this.label12.Text = "車牌";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 159;
            this.label11.Text = "車種";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 158;
            this.label10.Text = "型號";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 157;
            this.label9.Text = "電話";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 604);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 156;
            this.label8.Text = "與人客的關係";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 653);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 155;
            this.label7.Text = "備註";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 154;
            this.label6.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 153;
            this.label5.Text = "本次維修";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(193)))), ((int)(((byte)(119)))));
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(40, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 35);
            this.label3.TabIndex = 152;
            this.label3.Text = "基本資料";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox關鍵字查詢
            // 
            this.txtbox關鍵字查詢.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox關鍵字查詢.Location = new System.Drawing.Point(413, 79);
            this.txtbox關鍵字查詢.Multiline = true;
            this.txtbox關鍵字查詢.Name = "txtbox關鍵字查詢";
            this.txtbox關鍵字查詢.Size = new System.Drawing.Size(227, 45);
            this.txtbox關鍵字查詢.TabIndex = 151;
            this.txtbox關鍵字查詢.TextChanged += new System.EventHandler(this.txtbox關鍵字查詢_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(297, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 150;
            this.label1.Text = "車牌查詢";
            // 
            // userControl_RepairList1
            // 
            this.userControl_RepairList1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControl_RepairList1.Location = new System.Drawing.Point(-2, -6);
            this.userControl_RepairList1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_RepairList1.Name = "userControl_RepairList1";
            this.userControl_RepairList1.Size = new System.Drawing.Size(938, 780);
            this.userControl_RepairList1.TabIndex = 190;
            this.userControl_RepairList1.Visible = false;
            // 
            // userControl_Service1
            // 
            this.userControl_Service1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControl_Service1.Location = new System.Drawing.Point(-2, -6);
            this.userControl_Service1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Service1.Name = "userControl_Service1";
            this.userControl_Service1.Size = new System.Drawing.Size(938, 780);
            this.userControl_Service1.TabIndex = 189;
            this.userControl_Service1.Visible = false;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(932, 764);
            this.Controls.Add(this.userControl_RepairList1);
            this.Controls.Add(this.userControl_Service1);
            this.Controls.Add(this.txt機車車牌);
            this.Controls.Add(this.txt機車型號);
            this.Controls.Add(this.btn修改資料);
            this.Controls.Add(this.txt機車里程數);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt上次維修日期);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn連線測試);
            this.Controls.Add(this.btn刪除資料);
            this.Controls.Add(this.btn清空資料);
            this.Controls.Add(this.btn建立資料);
            this.Controls.Add(this.btn下一步);
            this.Controls.Add(this.btn回首頁);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pbox機車示意圖);
            this.Controls.Add(this.chk打檔車);
            this.Controls.Add(this.chk速克達);
            this.Controls.Add(this.dateTP本次維修時間);
            this.Controls.Add(this.txt備註);
            this.Controls.Add(this.txt與客人的關係);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox關鍵字查詢);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Create";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox機車示意圖)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt機車車牌;
        private System.Windows.Forms.TextBox txt機車型號;
        private System.Windows.Forms.Button btn修改資料;
        private System.Windows.Forms.TextBox txt機車里程數;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt上次維修日期;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn連線測試;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn清空資料;
        private System.Windows.Forms.Button btn建立資料;
        private System.Windows.Forms.Button btn下一步;
        private System.Windows.Forms.Button btn回首頁;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbox機車示意圖;
        private System.Windows.Forms.CheckBox chk打檔車;
        private System.Windows.Forms.CheckBox chk速克達;
        private System.Windows.Forms.DateTimePicker dateTP本次維修時間;
        private System.Windows.Forms.TextBox txt備註;
        private System.Windows.Forms.TextBox txt與客人的關係;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox關鍵字查詢;
        private System.Windows.Forms.Label label1;
        private UserControl_Service userControl_Service1;
        private UserControl_RepairList userControl_RepairList1;
    }
}