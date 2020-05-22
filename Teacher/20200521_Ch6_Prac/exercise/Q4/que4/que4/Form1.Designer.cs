namespace que4
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
            this.label_sentense = new System.Windows.Forms.Label();
            this.button_sentense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_sentense
            // 
            this.label_sentense.AutoSize = true;
            this.label_sentense.Location = new System.Drawing.Point(13, 13);
            this.label_sentense.Name = "label_sentense";
            this.label_sentense.Size = new System.Drawing.Size(11, 12);
            this.label_sentense.TabIndex = 0;
            this.label_sentense.Text = "-";
            // 
            // button_sentense
            // 
            this.button_sentense.Location = new System.Drawing.Point(13, 60);
            this.button_sentense.Name = "button_sentense";
            this.button_sentense.Size = new System.Drawing.Size(75, 23);
            this.button_sentense.TabIndex = 1;
            this.button_sentense.Text = "문장 출력";
            this.button_sentense.UseVisualStyleBackColor = true;
            this.button_sentense.Click += new System.EventHandler(this.button_sentense_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_sentense);
            this.Controls.Add(this.label_sentense);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sentense;
        private System.Windows.Forms.Button button_sentense;
    }
}

