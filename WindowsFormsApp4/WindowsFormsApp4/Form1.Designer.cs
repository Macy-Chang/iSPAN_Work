namespace WindowsFormsApp4
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn登出 = new System.Windows.Forms.Button();
            this.btn顯示QRcode = new System.Windows.Forms.Button();
            this.btn歷史紀錄 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.userControl_Record1 = new WindowsFormsApp4.UserControl_Record();
            this.userControl_QRcode1 = new WindowsFormsApp4.UserControl_QRcode();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(617, 435);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 96);
            this.label4.TabIndex = 69;
            this.label4.Text = "- FB\r\n- IG\r\n- 官方LINE\r\n- 收款帳戶";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(64, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 48);
            this.label3.TabIndex = 68;
            this.label3.Text = "- 新增及查詢基本資料\r\n- 新增保養、維修紀錄";
            // 
            // btn登出
            // 
            this.btn登出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(13, 20);
            this.btn登出.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(65, 38);
            this.btn登出.TabIndex = 67;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = true;
            // 
            // btn顯示QRcode
            // 
            this.btn顯示QRcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(183)))), ((int)(((byte)(99)))));
            this.btn顯示QRcode.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn顯示QRcode.Location = new System.Drawing.Point(583, 319);
            this.btn顯示QRcode.Margin = new System.Windows.Forms.Padding(5);
            this.btn顯示QRcode.Name = "btn顯示QRcode";
            this.btn顯示QRcode.Size = new System.Drawing.Size(190, 102);
            this.btn顯示QRcode.TabIndex = 61;
            this.btn顯示QRcode.Text = "顯示\r\nQRcode";
            this.btn顯示QRcode.UseVisualStyleBackColor = false;
            this.btn顯示QRcode.Click += new System.EventHandler(this.btn顯示QRcode_Click);
            // 
            // btn歷史紀錄
            // 
            this.btn歷史紀錄.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(183)))), ((int)(((byte)(99)))));
            this.btn歷史紀錄.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn歷史紀錄.Location = new System.Drawing.Point(336, 319);
            this.btn歷史紀錄.Margin = new System.Windows.Forms.Padding(5);
            this.btn歷史紀錄.Name = "btn歷史紀錄";
            this.btn歷史紀錄.Size = new System.Drawing.Size(190, 102);
            this.btn歷史紀錄.TabIndex = 59;
            this.btn歷史紀錄.Text = "歷史紀錄";
            this.btn歷史紀錄.UseVisualStyleBackColor = false;
            this.btn歷史紀錄.Click += new System.EventHandler(this.btn歷史紀錄_Click);
            // 
            // btn新增資料
            // 
            this.btn新增資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(183)))), ((int)(((byte)(99)))));
            this.btn新增資料.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料.Location = new System.Drawing.Point(68, 319);
            this.btn新增資料.Margin = new System.Windows.Forms.Padding(5);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(190, 102);
            this.btn新增資料.TabIndex = 58;
            this.btn新增資料.Text = "新增及查詢";
            this.btn新增資料.UseVisualStyleBackColor = false;
            this.btn新增資料.Click += new System.EventHandler(this.btn新增資料_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(312, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "[ 請點選需要的服務 ]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(657, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 50);
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Image = global::WindowsFormsApp4.Properties.Resources.moped;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(276, 50);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(362, 62);
            this.label19.TabIndex = 173;
            this.label19.Text = "小安機車行";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userControl_Record1
            // 
            this.userControl_Record1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControl_Record1.Location = new System.Drawing.Point(-9, 14);
            this.userControl_Record1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Record1.Name = "userControl_Record1";
            this.userControl_Record1.Size = new System.Drawing.Size(860, 651);
            this.userControl_Record1.TabIndex = 174;
            this.userControl_Record1.Visible = false;
            // 
            // userControl_QRcode1
            // 
            this.userControl_QRcode1.Location = new System.Drawing.Point(-9, -2);
            this.userControl_QRcode1.Name = "userControl_QRcode1";
            this.userControl_QRcode1.Size = new System.Drawing.Size(860, 651);
            this.userControl_QRcode1.TabIndex = 74;
            this.userControl_QRcode1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(844, 661);
            this.Controls.Add(this.userControl_Record1);
            this.Controls.Add(this.userControl_QRcode1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn登出);
            this.Controls.Add(this.btn顯示QRcode);
            this.Controls.Add(this.btn歷史紀錄);
            this.Controls.Add(this.btn新增資料);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label19);
            this.Name = "Form1";
            this.Text = "機車行系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn登出;
        private System.Windows.Forms.Button btn顯示QRcode;
        private System.Windows.Forms.Button btn歷史紀錄;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private UserControl_QRcode userControl_QRcode1;
        private System.Windows.Forms.Label label19;
        private UserControl_Record userControl_Record1;
    }
}

