namespace treasure
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
            this.components = new System.ComponentModel.Container();
            this.label_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_limitTime = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(153, 9);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(29, 12);
            this.label_result.TabIndex = 0;
            this.label_result.Text = "결과";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "제한 시간";
            // 
            // textBox_limitTime
            // 
            this.textBox_limitTime.Location = new System.Drawing.Point(233, 229);
            this.textBox_limitTime.Name = "textBox_limitTime";
            this.textBox_limitTime.Size = new System.Drawing.Size(100, 21);
            this.textBox_limitTime.TabIndex = 2;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(13, 227);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "게임 시작";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(278, 9);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(29, 12);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 262);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_limitTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_limitTime;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_time;
    }
}

