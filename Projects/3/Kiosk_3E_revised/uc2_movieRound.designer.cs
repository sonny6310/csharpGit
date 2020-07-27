namespace KIOSK_v1
{
    partial class uc2_movieRound
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
            this.selectRound = new System.Windows.Forms.Label();
            this.cbRound = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.leftSeat = new System.Windows.Forms.Label();
            this.seatNow = new System.Windows.Forms.Label();
            this.goSelectSeat = new System.Windows.Forms.Button();
            this.movie1 = new System.Windows.Forms.PictureBox();
            this.rating1 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.runtime1 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectRound
            // 
            this.selectRound.AutoSize = true;
            this.selectRound.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectRound.Location = new System.Drawing.Point(53, 35);
            this.selectRound.Name = "selectRound";
            this.selectRound.Size = new System.Drawing.Size(266, 25);
            this.selectRound.TabIndex = 15;
            this.selectRound.Text = "일자 및 시간을 선택해주세요.";
            // 
            // cbRound
            // 
            this.cbRound.FormattingEnabled = true;
            this.cbRound.Location = new System.Drawing.Point(59, 541);
            this.cbRound.Name = "cbRound";
            this.cbRound.Size = new System.Drawing.Size(178, 20);
            this.cbRound.TabIndex = 22;
            this.cbRound.Text = "상영시간";
            this.cbRound.SelectedIndexChanged += new System.EventHandler(this.cbRound_SelectedIndexChanged);
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(59, 512);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(178, 20);
            this.cbDate.TabIndex = 21;
            this.cbDate.Text = "상영일자";
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // leftSeat
            // 
            this.leftSeat.AutoSize = true;
            this.leftSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftSeat.Location = new System.Drawing.Point(57, 567);
            this.leftSeat.Name = "leftSeat";
            this.leftSeat.Size = new System.Drawing.Size(101, 20);
            this.leftSeat.TabIndex = 20;
            this.leftSeat.Text = "잔여좌석 수 :";
            // 
            // seatNow
            // 
            this.seatNow.BackColor = System.Drawing.Color.White;
            this.seatNow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seatNow.Location = new System.Drawing.Point(145, 566);
            this.seatNow.Name = "seatNow";
            this.seatNow.Size = new System.Drawing.Size(92, 23);
            this.seatNow.TabIndex = 23;
            this.seatNow.Text = " ";
            this.seatNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goSelectSeat
            // 
            this.goSelectSeat.Location = new System.Drawing.Point(243, 512);
            this.goSelectSeat.Name = "goSelectSeat";
            this.goSelectSeat.Size = new System.Drawing.Size(78, 76);
            this.goSelectSeat.TabIndex = 24;
            this.goSelectSeat.Text = "인원 선택";
            this.goSelectSeat.UseVisualStyleBackColor = true;
            this.goSelectSeat.Click += new System.EventHandler(this.goSelectSeat_Click);
            // 
            // movie1
            // 
            this.movie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movie1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movie1.Location = new System.Drawing.Point(58, 77);
            this.movie1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movie1.Name = "movie1";
            this.movie1.Size = new System.Drawing.Size(262, 367);
            this.movie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie1.TabIndex = 25;
            this.movie1.TabStop = false;
            // 
            // rating1
            // 
            this.rating1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rating1.Location = new System.Drawing.Point(215, 449);
            this.rating1.Name = "rating1";
            this.rating1.Size = new System.Drawing.Size(25, 25);
            this.rating1.TabIndex = 38;
            this.rating1.TabStop = false;
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.line1.Location = new System.Drawing.Point(239, 451);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(21, 21);
            this.line1.TabIndex = 37;
            this.line1.Text = "|";
            // 
            // min1
            // 
            this.min1.AutoSize = true;
            this.min1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.min1.Location = new System.Drawing.Point(296, 451);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(31, 21);
            this.min1.TabIndex = 36;
            this.min1.Text = "분";
            // 
            // runtime1
            // 
            this.runtime1.AutoSize = true;
            this.runtime1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.runtime1.Location = new System.Drawing.Point(257, 452);
            this.runtime1.Name = "runtime1";
            this.runtime1.Size = new System.Drawing.Size(43, 21);
            this.runtime1.TabIndex = 35;
            this.runtime1.Text = "000";
            // 
            // title1
            // 
            this.title1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title1.Location = new System.Drawing.Point(57, 451);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(145, 51);
            this.title1.TabIndex = 34;
            this.title1.Text = "제목";
            // 
            // uc2_movieRound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rating1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.runtime1);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.movie1);
            this.Controls.Add(this.goSelectSeat);
            this.Controls.Add(this.seatNow);
            this.Controls.Add(this.cbRound);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.leftSeat);
            this.Controls.Add(this.selectRound);
            this.Name = "uc2_movieRound";
            this.Size = new System.Drawing.Size(384, 621);
            ((System.ComponentModel.ISupportInitialize)(this.movie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectRound;
        private System.Windows.Forms.ComboBox cbRound;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label leftSeat;
        private System.Windows.Forms.Label seatNow;
        private System.Windows.Forms.Button goSelectSeat;
        private System.Windows.Forms.PictureBox movie1;
        private System.Windows.Forms.PictureBox rating1;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label runtime1;
        private System.Windows.Forms.Label title1;
    }
}
