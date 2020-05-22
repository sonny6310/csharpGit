namespace Qz1
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
            this.label_st1 = new System.Windows.Forms.Label();
            this.label_st2 = new System.Windows.Forms.Label();
            this.label_st3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_st1
            // 
            this.label_st1.AutoSize = true;
            this.label_st1.Location = new System.Drawing.Point(12, 194);
            this.label_st1.Name = "label_st1";
            this.label_st1.Size = new System.Drawing.Size(35, 12);
            this.label_st1.TabIndex = 0;
            this.label_st1.Text = "학생1";
            // 
            // label_st2
            // 
            this.label_st2.AutoSize = true;
            this.label_st2.Location = new System.Drawing.Point(12, 218);
            this.label_st2.Name = "label_st2";
            this.label_st2.Size = new System.Drawing.Size(35, 12);
            this.label_st2.TabIndex = 1;
            this.label_st2.Text = "학생2";
            // 
            // label_st3
            // 
            this.label_st3.AutoSize = true;
            this.label_st3.Location = new System.Drawing.Point(12, 241);
            this.label_st3.Name = "label_st3";
            this.label_st3.Size = new System.Drawing.Size(35, 12);
            this.label_st3.TabIndex = 2;
            this.label_st3.Text = "학생3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "↓ 수동";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "↑ 자동";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_st3);
            this.Controls.Add(this.label_st2);
            this.Controls.Add(this.label_st1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_st1;
        private System.Windows.Forms.Label label_st2;
        private System.Windows.Forms.Label label_st3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

