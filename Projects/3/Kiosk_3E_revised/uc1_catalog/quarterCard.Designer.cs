namespace KIOSK_v1.uc1_catalog
{
    partial class quarterCard
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
            this.cardRating = new System.Windows.Forms.PictureBox();
            this.cardLine = new System.Windows.Forms.Label();
            this.cardMin = new System.Windows.Forms.Label();
            this.cardRuntime = new System.Windows.Forms.Label();
            this.cardTitle = new System.Windows.Forms.Label();
            this.cardPoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardRating)).BeginInit();
            this.SuspendLayout();
            // 
            // cardRating
            // 
            this.cardRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardRating.Location = new System.Drawing.Point(96, 228);
            this.cardRating.Name = "cardRating";
            this.cardRating.Size = new System.Drawing.Size(15, 15);
            this.cardRating.TabIndex = 63;
            this.cardRating.TabStop = false;
            // 
            // cardLine
            // 
            this.cardLine.AutoSize = true;
            this.cardLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cardLine.Location = new System.Drawing.Point(115, 230);
            this.cardLine.Name = "cardLine";
            this.cardLine.Size = new System.Drawing.Size(12, 12);
            this.cardLine.TabIndex = 62;
            this.cardLine.Text = "|";
            // 
            // cardMin
            // 
            this.cardMin.AutoSize = true;
            this.cardMin.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cardMin.Location = new System.Drawing.Point(150, 230);
            this.cardMin.Name = "cardMin";
            this.cardMin.Size = new System.Drawing.Size(17, 12);
            this.cardMin.TabIndex = 61;
            this.cardMin.Text = "분";
            // 
            // cardRuntime
            // 
            this.cardRuntime.AutoSize = true;
            this.cardRuntime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cardRuntime.Location = new System.Drawing.Point(126, 230);
            this.cardRuntime.Name = "cardRuntime";
            this.cardRuntime.Size = new System.Drawing.Size(23, 12);
            this.cardRuntime.TabIndex = 60;
            this.cardRuntime.Text = "000";
            // 
            // cardTitle
            // 
            this.cardTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cardTitle.Location = new System.Drawing.Point(18, 230);
            this.cardTitle.Name = "cardTitle";
            this.cardTitle.Size = new System.Drawing.Size(74, 25);
            this.cardTitle.TabIndex = 59;
            this.cardTitle.Text = "제목";
            // 
            // cardPoster
            // 
            this.cardPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardPoster.FlatAppearance.BorderSize = 0;
            this.cardPoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cardPoster.Location = new System.Drawing.Point(20, 8);
            this.cardPoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardPoster.Name = "cardPoster";
            this.cardPoster.Size = new System.Drawing.Size(147, 215);
            this.cardPoster.TabIndex = 58;
            this.cardPoster.UseVisualStyleBackColor = true;
            this.cardPoster.Click += new System.EventHandler(this.cardPoster_Click);
            // 
            // quarterCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardRating);
            this.Controls.Add(this.cardLine);
            this.Controls.Add(this.cardMin);
            this.Controls.Add(this.cardRuntime);
            this.Controls.Add(this.cardTitle);
            this.Controls.Add(this.cardPoster);
            this.Name = "quarterCard";
            this.Size = new System.Drawing.Size(168, 263);
            ((System.ComponentModel.ISupportInitialize)(this.cardRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardRating;
        private System.Windows.Forms.Label cardLine;
        private System.Windows.Forms.Label cardMin;
        private System.Windows.Forms.Label cardRuntime;
        private System.Windows.Forms.Label cardTitle;
        private System.Windows.Forms.Button cardPoster;
    }
}
