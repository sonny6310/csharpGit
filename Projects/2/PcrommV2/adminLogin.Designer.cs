namespace PcrommV2
{
    partial class adminLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pcnamTextbox = new System.Windows.Forms.TextBox();
            this.serverAddTextbox = new System.Windows.Forms.TextBox();
            this.serverNameTextbox = new System.Windows.Forms.TextBox();
            this.serverIDTextbox = new System.Windows.Forms.TextBox();
            this.serverPwTextbox = new System.Windows.Forms.TextBox();
            this.enterB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pc이름(번호)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "서버주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "서버이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "서버아이디";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "서버패스워드";
            // 
            // pcnamTextbox
            // 
            this.pcnamTextbox.Location = new System.Drawing.Point(167, 51);
            this.pcnamTextbox.Name = "pcnamTextbox";
            this.pcnamTextbox.Size = new System.Drawing.Size(169, 21);
            this.pcnamTextbox.TabIndex = 5;
            this.pcnamTextbox.Text = "1번PC";
            // 
            // serverAddTextbox
            // 
            this.serverAddTextbox.Location = new System.Drawing.Point(167, 96);
            this.serverAddTextbox.Name = "serverAddTextbox";
            this.serverAddTextbox.Size = new System.Drawing.Size(169, 21);
            this.serverAddTextbox.TabIndex = 6;
            this.serverAddTextbox.Text = "munggu.iptime.org,25000";
            // 
            // serverNameTextbox
            // 
            this.serverNameTextbox.Location = new System.Drawing.Point(167, 145);
            this.serverNameTextbox.Name = "serverNameTextbox";
            this.serverNameTextbox.Size = new System.Drawing.Size(169, 21);
            this.serverNameTextbox.TabIndex = 7;
            this.serverNameTextbox.Text = "yj_20200611";
            // 
            // serverIDTextbox
            // 
            this.serverIDTextbox.Location = new System.Drawing.Point(167, 195);
            this.serverIDTextbox.Name = "serverIDTextbox";
            this.serverIDTextbox.Size = new System.Drawing.Size(169, 21);
            this.serverIDTextbox.TabIndex = 8;
            this.serverIDTextbox.Text = "sa";
            // 
            // serverPwTextbox
            // 
            this.serverPwTextbox.Location = new System.Drawing.Point(167, 246);
            this.serverPwTextbox.Name = "serverPwTextbox";
            this.serverPwTextbox.Size = new System.Drawing.Size(169, 21);
            this.serverPwTextbox.TabIndex = 9;
            this.serverPwTextbox.Text = "8765432!";
            // 
            // enterB
            // 
            this.enterB.Location = new System.Drawing.Point(215, 299);
            this.enterB.Name = "enterB";
            this.enterB.Size = new System.Drawing.Size(75, 23);
            this.enterB.TabIndex = 11;
            this.enterB.Text = "확인";
            this.enterB.UseVisualStyleBackColor = true;
            this.enterB.Click += new System.EventHandler(this.enterB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(104, 299);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 10;
            this.cancelB.Text = "취소";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.enterB);
            this.Controls.Add(this.serverPwTextbox);
            this.Controls.Add(this.serverIDTextbox);
            this.Controls.Add(this.serverNameTextbox);
            this.Controls.Add(this.serverAddTextbox);
            this.Controls.Add(this.pcnamTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pcnamTextbox;
        private System.Windows.Forms.TextBox serverAddTextbox;
        private System.Windows.Forms.TextBox serverNameTextbox;
        private System.Windows.Forms.TextBox serverIDTextbox;
        private System.Windows.Forms.TextBox serverPwTextbox;
        private System.Windows.Forms.Button enterB;
        private System.Windows.Forms.Button cancelB;
    }
}
