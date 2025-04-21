namespace WindowsFormsApp4
{
    partial class UserControl_Record
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Record));
            this.btn回首頁 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.txtbox關鍵字查詢 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbox歷史紀錄列表 = new System.Windows.Forms.ListBox();
            this.txt顯示欄位2 = new System.Windows.Forms.TextBox();
            this.txt顯示欄位1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt顯示欄位3 = new System.Windows.Forms.TextBox();
            this.lbl回應訊息 = new System.Windows.Forms.Label();
            this.dgv歷史紀錄列表 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv歷史紀錄列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btn回首頁.Location = new System.Drawing.Point(370, 589);
            this.btn回首頁.Name = "btn回首頁";
            this.btn回首頁.Size = new System.Drawing.Size(111, 42);
            this.btn回首頁.TabIndex = 130;
            this.btn回首頁.Text = "回首頁";
            this.btn回首頁.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn回首頁.UseVisualStyleBackColor = false;
            this.btn回首頁.Click += new System.EventHandler(this.btn回首頁_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(348, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 45);
            this.label1.TabIndex = 124;
            this.label1.Text = "歷史紀錄";
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
            this.btn搜尋.Location = new System.Drawing.Point(559, 82);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(47, 42);
            this.btn搜尋.TabIndex = 177;
            this.btn搜尋.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // txtbox關鍵字查詢
            // 
            this.txtbox關鍵字查詢.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox關鍵字查詢.Location = new System.Drawing.Point(318, 79);
            this.txtbox關鍵字查詢.Multiline = true;
            this.txtbox關鍵字查詢.Name = "txtbox關鍵字查詢";
            this.txtbox關鍵字查詢.Size = new System.Drawing.Size(227, 45);
            this.txtbox關鍵字查詢.TabIndex = 175;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(202, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 174;
            this.label2.Text = "車牌查詢";
            // 
            // lbox歷史紀錄列表
            // 
            this.lbox歷史紀錄列表.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox歷史紀錄列表.FormattingEnabled = true;
            this.lbox歷史紀錄列表.ItemHeight = 28;
            this.lbox歷史紀錄列表.Location = new System.Drawing.Point(38, 254);
            this.lbox歷史紀錄列表.Margin = new System.Windows.Forms.Padding(2);
            this.lbox歷史紀錄列表.Name = "lbox歷史紀錄列表";
            this.lbox歷史紀錄列表.Size = new System.Drawing.Size(781, 256);
            this.lbox歷史紀錄列表.TabIndex = 182;
            // 
            // txt顯示欄位2
            // 
            this.txt顯示欄位2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt顯示欄位2.Location = new System.Drawing.Point(380, 178);
            this.txt顯示欄位2.Multiline = true;
            this.txt顯示欄位2.Name = "txt顯示欄位2";
            this.txt顯示欄位2.Size = new System.Drawing.Size(163, 27);
            this.txt顯示欄位2.TabIndex = 181;
            // 
            // txt顯示欄位1
            // 
            this.txt顯示欄位1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt顯示欄位1.Location = new System.Drawing.Point(141, 178);
            this.txt顯示欄位1.Multiline = true;
            this.txt顯示欄位1.Name = "txt顯示欄位1";
            this.txt顯示欄位1.Size = new System.Drawing.Size(163, 27);
            this.txt顯示欄位1.TabIndex = 180;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(586, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 179;
            this.label5.Text = "型號";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(62, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 178;
            this.label13.Text = "顧客姓名";
            // 
            // txt顯示欄位3
            // 
            this.txt顯示欄位3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt顯示欄位3.Location = new System.Drawing.Point(627, 178);
            this.txt顯示欄位3.Multiline = true;
            this.txt顯示欄位3.Name = "txt顯示欄位3";
            this.txt顯示欄位3.Size = new System.Drawing.Size(163, 27);
            this.txt顯示欄位3.TabIndex = 184;
            // 
            // lbl回應訊息
            // 
            this.lbl回應訊息.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(193)))), ((int)(((byte)(119)))));
            this.lbl回應訊息.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl回應訊息.ForeColor = System.Drawing.Color.Black;
            this.lbl回應訊息.Location = new System.Drawing.Point(34, 146);
            this.lbl回應訊息.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl回應訊息.Name = "lbl回應訊息";
            this.lbl回應訊息.Size = new System.Drawing.Size(785, 22);
            this.lbl回應訊息.TabIndex = 185;
            // 
            // dgv歷史紀錄列表
            // 
            this.dgv歷史紀錄列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv歷史紀錄列表.Location = new System.Drawing.Point(38, 242);
            this.dgv歷史紀錄列表.Name = "dgv歷史紀錄列表";
            this.dgv歷史紀錄列表.RowTemplate.Height = 24;
            this.dgv歷史紀錄列表.Size = new System.Drawing.Size(781, 281);
            this.dgv歷史紀錄列表.TabIndex = 186;
            this.dgv歷史紀錄列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv歷史紀錄列表_CellClick);
            this.dgv歷史紀錄列表.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv歷史紀錄列表_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(333, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 187;
            this.label4.Text = "車牌";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 188;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv歷史紀錄列表);
            this.Controls.Add(this.lbl回應訊息);
            this.Controls.Add(this.txt顯示欄位3);
            this.Controls.Add(this.lbox歷史紀錄列表);
            this.Controls.Add(this.txt顯示欄位2);
            this.Controls.Add(this.txt顯示欄位1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.txtbox關鍵字查詢);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn回首頁);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl_Record";
            this.Size = new System.Drawing.Size(860, 651);
            this.Load += new System.EventHandler(this.UserControl_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv歷史紀錄列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn回首頁;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.TextBox txtbox關鍵字查詢;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbox歷史紀錄列表;
        private System.Windows.Forms.TextBox txt顯示欄位2;
        private System.Windows.Forms.TextBox txt顯示欄位1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt顯示欄位3;
        private System.Windows.Forms.Label lbl回應訊息;
        private System.Windows.Forms.DataGridView dgv歷史紀錄列表;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
