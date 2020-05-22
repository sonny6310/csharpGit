namespace que3
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_s = new System.Windows.Forms.Button();
            this.button_r = new System.Windows.Forms.Button();
            this.button_p = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_me = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_computer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_s
            // 
            this.button_s.Location = new System.Drawing.Point(13, 13);
            this.button_s.Name = "button_s";
            this.button_s.Size = new System.Drawing.Size(75, 23);
            this.button_s.TabIndex = 0;
            this.button_s.Text = "가위";
            this.button_s.UseVisualStyleBackColor = true;
            this.button_s.Click += new System.EventHandler(this.button_s_Click);
            // 
            // button_r
            // 
            this.button_r.Location = new System.Drawing.Point(95, 13);
            this.button_r.Name = "button_r";
            this.button_r.Size = new System.Drawing.Size(75, 23);
            this.button_r.TabIndex = 1;
            this.button_r.Text = "바위";
            this.button_r.UseVisualStyleBackColor = true;
            this.button_r.Click += new System.EventHandler(this.button_r_Click);
            // 
            // button_p
            // 
            this.button_p.Location = new System.Drawing.Point(177, 13);
            this.button_p.Name = "button_p";
            this.button_p.Size = new System.Drawing.Size(75, 23);
            this.button_p.TabIndex = 2;
            this.button_p.Text = "보";
            this.button_p.UseVisualStyleBackColor = true;
            this.button_p.Click += new System.EventHandler(this.button_p_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "나:";
            // 
            // label_me
            // 
            this.label_me.AutoSize = true;
            this.label_me.Location = new System.Drawing.Point(68, 55);
            this.label_me.Name = "label_me";
            this.label_me.Size = new System.Drawing.Size(11, 12);
            this.label_me.TabIndex = 4;
            this.label_me.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "컴퓨터:";
            // 
            // label_computer
            // 
            this.label_computer.AutoSize = true;
            this.label_computer.Location = new System.Drawing.Point(70, 81);
            this.label_computer.Name = "label_computer";
            this.label_computer.Size = new System.Drawing.Size(11, 12);
            this.label_computer.TabIndex = 6;
            this.label_computer.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "결과:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(70, 110);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(11, 12);
            this.label_result.TabIndex = 8;
            this.label_result.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 174);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_computer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_me);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_p);
            this.Controls.Add(this.button_r);
            this.Controls.Add(this.button_s);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_s;
        private System.Windows.Forms.Button button_r;
        private System.Windows.Forms.Button button_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_me;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_computer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_result;
    }
}

