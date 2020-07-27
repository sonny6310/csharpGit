namespace Login
{
    partial class Menu1
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.textPay = new System.Windows.Forms.TextBox();
            this.textPlace = new System.Windows.Forms.TextBox();
            this.deadLineTime = new System.Windows.Forms.DateTimePicker();
            this.textContent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(443, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "구인 등록";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(151, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "제목";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(151, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "급여";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(151, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "근무지";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(151, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "접수마감";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(151, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "구인내용";
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(247, 102);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(127, 21);
            this.textSubject.TabIndex = 6;
            // 
            // textPay
            // 
            this.textPay.Location = new System.Drawing.Point(247, 142);
            this.textPay.Name = "textPay";
            this.textPay.Size = new System.Drawing.Size(127, 21);
            this.textPay.TabIndex = 7;
            // 
            // textPlace
            // 
            this.textPlace.Location = new System.Drawing.Point(247, 184);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(127, 21);
            this.textPlace.TabIndex = 8;
            // 
            // deadLineTime
            // 
            this.deadLineTime.CalendarFont = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deadLineTime.Location = new System.Drawing.Point(247, 261);
            this.deadLineTime.Name = "deadLineTime";
            this.deadLineTime.Size = new System.Drawing.Size(127, 21);
            this.deadLineTime.TabIndex = 10;
            this.deadLineTime.CloseUp += new System.EventHandler(this.deadLineTime_CloseUp);
            // 
            // textContent
            // 
            this.textContent.Font = new System.Drawing.Font("HY강M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textContent.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textContent.Location = new System.Drawing.Point(154, 323);
            this.textContent.Multiline = true;
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(700, 250);
            this.textContent.TabIndex = 11;
            this.textContent.Text = "구인내용에는 우대사항과 작업내용을 등을 기입하여 주시기 바랍니다";
            this.textContent.Click += new System.EventHandler(this.textContent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(376, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "(만원)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(648, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // applyBtn
            // 
            this.applyBtn.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.applyBtn.Location = new System.Drawing.Point(419, 581);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(171, 32);
            this.applyBtn.TabIndex = 16;
            this.applyBtn.Text = "등록하기";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            this.applyBtn.Leave += new System.EventHandler(this.applyBtn_Leave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(151, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "근무일시";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimeStart.Location = new System.Drawing.Point(247, 224);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(126, 21);
            this.dateTimeStart.TabIndex = 18;
            this.dateTimeStart.CloseUp += new System.EventHandler(this.dateTimeStart_CloseUp);
            // 
            // dateTimeFinish
            // 
            this.dateTimeFinish.CalendarFont = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimeFinish.Location = new System.Drawing.Point(400, 224);
            this.dateTimeFinish.Name = "dateTimeFinish";
            this.dateTimeFinish.Size = new System.Drawing.Size(126, 21);
            this.dateTimeFinish.TabIndex = 19;
            this.dateTimeFinish.CloseUp += new System.EventHandler(this.dateTimeFinish_CloseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HY강M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(376, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "~";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(397, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "직종";
            // 
            // textField
            // 
            this.textField.Location = new System.Drawing.Point(443, 102);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(126, 21);
            this.textField.TabIndex = 23;
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimeFinish);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.deadLineTime);
            this.Controls.Add(this.textPlace);
            this.Controls.Add(this.textPay);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu1";
            this.Size = new System.Drawing.Size(995, 635);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.TextBox textSubject;
            private System.Windows.Forms.TextBox textPay;
            private System.Windows.Forms.TextBox textPlace;
            private System.Windows.Forms.DateTimePicker deadLineTime;
            private System.Windows.Forms.TextBox textContent;
            private System.Windows.Forms.Label label8;
            private System.Windows.Forms.PictureBox pictureBox2;
            private System.Windows.Forms.Button applyBtn;
            private System.Windows.Forms.Label label7;
            private System.Windows.Forms.DateTimePicker dateTimeStart;
            private System.Windows.Forms.DateTimePicker dateTimeFinish;
            private System.Windows.Forms.Label label10;
            private System.Windows.Forms.Label label9;
            private System.Windows.Forms.TextBox textField;
      }
}
