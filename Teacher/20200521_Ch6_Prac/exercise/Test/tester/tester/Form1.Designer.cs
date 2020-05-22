namespace tester
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
            this.textBox_square = new System.Windows.Forms.TextBox();
            this.textBox_mul1 = new System.Windows.Forms.TextBox();
            this.textBox_mul2 = new System.Windows.Forms.TextBox();
            this.button_square = new System.Windows.Forms.Button();
            this.button_multi = new System.Windows.Forms.Button();
            this.label_sResult = new System.Windows.Forms.Label();
            this.label_mResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_square
            // 
            this.textBox_square.Location = new System.Drawing.Point(13, 26);
            this.textBox_square.Name = "textBox_square";
            this.textBox_square.Size = new System.Drawing.Size(100, 21);
            this.textBox_square.TabIndex = 0;
            // 
            // textBox_mul1
            // 
            this.textBox_mul1.Location = new System.Drawing.Point(13, 54);
            this.textBox_mul1.Name = "textBox_mul1";
            this.textBox_mul1.Size = new System.Drawing.Size(100, 21);
            this.textBox_mul1.TabIndex = 1;
            // 
            // textBox_mul2
            // 
            this.textBox_mul2.Location = new System.Drawing.Point(119, 54);
            this.textBox_mul2.Name = "textBox_mul2";
            this.textBox_mul2.Size = new System.Drawing.Size(100, 21);
            this.textBox_mul2.TabIndex = 2;
            // 
            // button_square
            // 
            this.button_square.Location = new System.Drawing.Point(241, 26);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(75, 23);
            this.button_square.TabIndex = 3;
            this.button_square.Text = "제곱";
            this.button_square.UseVisualStyleBackColor = true;
            this.button_square.Click += new System.EventHandler(this.button_square_Click);
            // 
            // button_multi
            // 
            this.button_multi.Location = new System.Drawing.Point(241, 56);
            this.button_multi.Name = "button_multi";
            this.button_multi.Size = new System.Drawing.Size(75, 23);
            this.button_multi.TabIndex = 4;
            this.button_multi.Text = "곱하기";
            this.button_multi.UseVisualStyleBackColor = true;
            this.button_multi.Click += new System.EventHandler(this.button_multi_Click);
            // 
            // label_sResult
            // 
            this.label_sResult.AutoSize = true;
            this.label_sResult.Location = new System.Drawing.Point(352, 26);
            this.label_sResult.Name = "label_sResult";
            this.label_sResult.Size = new System.Drawing.Size(11, 12);
            this.label_sResult.TabIndex = 5;
            this.label_sResult.Text = "-";
            // 
            // label_mResult
            // 
            this.label_mResult.AutoSize = true;
            this.label_mResult.Location = new System.Drawing.Point(354, 62);
            this.label_mResult.Name = "label_mResult";
            this.label_mResult.Size = new System.Drawing.Size(11, 12);
            this.label_mResult.TabIndex = 6;
            this.label_mResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.label_mResult);
            this.Controls.Add(this.label_sResult);
            this.Controls.Add(this.button_multi);
            this.Controls.Add(this.button_square);
            this.Controls.Add(this.textBox_mul2);
            this.Controls.Add(this.textBox_mul1);
            this.Controls.Add(this.textBox_square);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_square;
        private System.Windows.Forms.TextBox textBox_mul1;
        private System.Windows.Forms.TextBox textBox_mul2;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button button_multi;
        private System.Windows.Forms.Label label_sResult;
        private System.Windows.Forms.Label label_mResult;
    }
}

