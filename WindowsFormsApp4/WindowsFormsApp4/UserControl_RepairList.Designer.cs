namespace WindowsFormsApp4
{
    partial class UserControl_RepairList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_RepairList));
            this.lbox服務項目列表 = new System.Windows.Forms.ListBox();
            this.tbx顯示欄位2 = new System.Windows.Forms.TextBox();
            this.tbx顯示欄位1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt實收金額 = new System.Windows.Forms.TextBox();
            this.txt總金額 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt折扣原因 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt未收金額 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt保養維修明細的備註 = new System.Windows.Forms.TextBox();
            this.txt折扣 = new System.Windows.Forms.TextBox();
            this.txt工資小計 = new System.Windows.Forms.TextBox();
            this.txt項目及零件費用小計 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn回首頁 = new System.Windows.Forms.Button();
            this.btn產生報價單 = new System.Windows.Forms.Button();
            this.btn上一步 = new System.Windows.Forms.Button();
            this.btn確認存檔 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox服務項目列表
            // 
            this.lbox服務項目列表.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox服務項目列表.FormattingEnabled = true;
            this.lbox服務項目列表.ItemHeight = 28;
            this.lbox服務項目列表.Location = new System.Drawing.Point(68, 99);
            this.lbox服務項目列表.Margin = new System.Windows.Forms.Padding(2);
            this.lbox服務項目列表.Name = "lbox服務項目列表";
            this.lbox服務項目列表.Size = new System.Drawing.Size(809, 340);
            this.lbox服務項目列表.TabIndex = 173;
            this.lbox服務項目列表.SelectedIndexChanged += new System.EventHandler(this.lbox服務項目列表_SelectedIndexChanged);
            // 
            // tbx顯示欄位2
            // 
            this.tbx顯示欄位2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx顯示欄位2.Location = new System.Drawing.Point(555, 67);
            this.tbx顯示欄位2.Multiline = true;
            this.tbx顯示欄位2.Name = "tbx顯示欄位2";
            this.tbx顯示欄位2.Size = new System.Drawing.Size(163, 27);
            this.tbx顯示欄位2.TabIndex = 172;
            this.tbx顯示欄位2.TextChanged += new System.EventHandler(this.tbx顯示欄位2_TextChanged);
            // 
            // tbx顯示欄位1
            // 
            this.tbx顯示欄位1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx顯示欄位1.Location = new System.Drawing.Point(284, 67);
            this.tbx顯示欄位1.Multiline = true;
            this.tbx顯示欄位1.Name = "tbx顯示欄位1";
            this.tbx顯示欄位1.Size = new System.Drawing.Size(163, 27);
            this.tbx顯示欄位1.TabIndex = 171;
            this.tbx顯示欄位1.TextChanged += new System.EventHandler(this.tbx顯示欄位1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(508, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 170;
            this.label5.Text = "車牌";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(205, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 169;
            this.label13.Text = "顧客姓名";
            // 
            // txt實收金額
            // 
            this.txt實收金額.Location = new System.Drawing.Point(603, 517);
            this.txt實收金額.Multiline = true;
            this.txt實收金額.Name = "txt實收金額";
            this.txt實收金額.Size = new System.Drawing.Size(246, 34);
            this.txt實收金額.TabIndex = 168;
            // 
            // txt總金額
            // 
            this.txt總金額.Location = new System.Drawing.Point(603, 474);
            this.txt總金額.Multiline = true;
            this.txt總金額.Name = "txt總金額";
            this.txt總金額.Size = new System.Drawing.Size(246, 34);
            this.txt總金額.TabIndex = 167;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(321, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 45);
            this.label2.TabIndex = 163;
            this.label2.Text = "保養(維修)明細表";
            // 
            // txt折扣原因
            // 
            this.txt折扣原因.Location = new System.Drawing.Point(251, 627);
            this.txt折扣原因.Multiline = true;
            this.txt折扣原因.Name = "txt折扣原因";
            this.txt折扣原因.Size = new System.Drawing.Size(196, 34);
            this.txt折扣原因.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(168, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 161;
            this.label3.Text = "折扣原因";
            // 
            // txt未收金額
            // 
            this.txt未收金額.Location = new System.Drawing.Point(603, 559);
            this.txt未收金額.Multiline = true;
            this.txt未收金額.Name = "txt未收金額";
            this.txt未收金額.Size = new System.Drawing.Size(246, 34);
            this.txt未收金額.TabIndex = 160;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(524, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 159;
            this.label14.Text = "未收金額";
            // 
            // txt保養維修明細的備註
            // 
            this.txt保養維修明細的備註.Location = new System.Drawing.Point(603, 605);
            this.txt保養維修明細的備註.Multiline = true;
            this.txt保養維修明細的備註.Name = "txt保養維修明細的備註";
            this.txt保養維修明細的備註.Size = new System.Drawing.Size(246, 86);
            this.txt保養維修明細的備註.TabIndex = 158;
            // 
            // txt折扣
            // 
            this.txt折扣.Location = new System.Drawing.Point(251, 581);
            this.txt折扣.Multiline = true;
            this.txt折扣.Name = "txt折扣";
            this.txt折扣.Size = new System.Drawing.Size(196, 34);
            this.txt折扣.TabIndex = 157;
            // 
            // txt工資小計
            // 
            this.txt工資小計.Location = new System.Drawing.Point(251, 524);
            this.txt工資小計.Multiline = true;
            this.txt工資小計.Name = "txt工資小計";
            this.txt工資小計.Size = new System.Drawing.Size(196, 34);
            this.txt工資小計.TabIndex = 156;
            // 
            // txt項目及零件費用小計
            // 
            this.txt項目及零件費用小計.Location = new System.Drawing.Point(251, 479);
            this.txt項目及零件費用小計.Multiline = true;
            this.txt項目及零件費用小計.Name = "txt項目及零件費用小計";
            this.txt項目及零件費用小計.Size = new System.Drawing.Size(196, 34);
            this.txt項目及零件費用小計.TabIndex = 155;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(469, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 21);
            this.label12.TabIndex = 154;
            this.label12.Text = "總金額(應收金額)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(171, 530);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 153;
            this.label11.Text = "工資 小計";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(177, 586);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 152;
            this.label10.Text = "折扣 (-)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(524, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 151;
            this.label8.Text = "實收金額";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(561, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 150;
            this.label7.Text = "備註";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(104, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 149;
            this.label1.Text = "項目/零件費用小計";
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
            this.btn回首頁.Location = new System.Drawing.Point(150, 715);
            this.btn回首頁.Name = "btn回首頁";
            this.btn回首頁.Size = new System.Drawing.Size(111, 42);
            this.btn回首頁.TabIndex = 200;
            this.btn回首頁.Text = "回首頁";
            this.btn回首頁.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn回首頁.UseVisualStyleBackColor = false;
            this.btn回首頁.Click += new System.EventHandler(this.btn回首頁_Click);
            // 
            // btn產生報價單
            // 
            this.btn產生報價單.AutoSize = true;
            this.btn產生報價單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(124)))));
            this.btn產生報價單.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn產生報價單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn產生報價單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn產生報價單.Image = ((System.Drawing.Image)(resources.GetObject("btn產生報價單.Image")));
            this.btn產生報價單.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn產生報價單.Location = new System.Drawing.Point(609, 715);
            this.btn產生報價單.Name = "btn產生報價單";
            this.btn產生報價單.Size = new System.Drawing.Size(160, 42);
            this.btn產生報價單.TabIndex = 166;
            this.btn產生報價單.Text = "產生報價單";
            this.btn產生報價單.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn產生報價單.UseVisualStyleBackColor = false;
            this.btn產生報價單.Click += new System.EventHandler(this.btn產生報價單_Click);
            // 
            // btn上一步
            // 
            this.btn上一步.AutoSize = true;
            this.btn上一步.BackColor = System.Drawing.Color.Gold;
            this.btn上一步.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn上一步.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn上一步.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn上一步.Image = ((System.Drawing.Image)(resources.GetObject("btn上一步.Image")));
            this.btn上一步.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn上一步.Location = new System.Drawing.Point(19, 715);
            this.btn上一步.Name = "btn上一步";
            this.btn上一步.Size = new System.Drawing.Size(111, 42);
            this.btn上一步.TabIndex = 165;
            this.btn上一步.Text = "上一步";
            this.btn上一步.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn上一步.UseVisualStyleBackColor = false;
            this.btn上一步.Click += new System.EventHandler(this.btn上一步_Click);
            // 
            // btn確認存檔
            // 
            this.btn確認存檔.AutoSize = true;
            this.btn確認存檔.BackColor = System.Drawing.Color.Orange;
            this.btn確認存檔.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn確認存檔.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn確認存檔.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確認存檔.Image = ((System.Drawing.Image)(resources.GetObject("btn確認存檔.Image")));
            this.btn確認存檔.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn確認存檔.Location = new System.Drawing.Point(780, 715);
            this.btn確認存檔.Name = "btn確認存檔";
            this.btn確認存檔.Size = new System.Drawing.Size(134, 42);
            this.btn確認存檔.TabIndex = 164;
            this.btn確認存檔.Text = "確認存檔";
            this.btn確認存檔.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn確認存檔.UseVisualStyleBackColor = false;
            this.btn確認存檔.Click += new System.EventHandler(this.btn確認存檔_Click);
            // 
            // UserControl_RepairList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn回首頁);
            this.Controls.Add(this.lbox服務項目列表);
            this.Controls.Add(this.tbx顯示欄位2);
            this.Controls.Add(this.tbx顯示欄位1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt實收金額);
            this.Controls.Add(this.txt總金額);
            this.Controls.Add(this.btn產生報價單);
            this.Controls.Add(this.btn上一步);
            this.Controls.Add(this.btn確認存檔);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt折扣原因);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt未收金額);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt保養維修明細的備註);
            this.Controls.Add(this.txt折扣);
            this.Controls.Add(this.txt工資小計);
            this.Controls.Add(this.txt項目及零件費用小計);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl_RepairList";
            this.Size = new System.Drawing.Size(938, 780);
            this.Load += new System.EventHandler(this.UserControl_RepairList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox服務項目列表;
        private System.Windows.Forms.TextBox tbx顯示欄位2;
        private System.Windows.Forms.TextBox tbx顯示欄位1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt實收金額;
        private System.Windows.Forms.TextBox txt總金額;
        private System.Windows.Forms.Button btn產生報價單;
        private System.Windows.Forms.Button btn上一步;
        private System.Windows.Forms.Button btn確認存檔;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt折扣原因;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt未收金額;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt保養維修明細的備註;
        private System.Windows.Forms.TextBox txt折扣;
        private System.Windows.Forms.TextBox txt工資小計;
        private System.Windows.Forms.TextBox txt項目及零件費用小計;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn回首頁;
    }
}
