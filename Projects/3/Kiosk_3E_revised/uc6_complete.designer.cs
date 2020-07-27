namespace KIOSK_v1
{
    partial class uc6_complete
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
            this.doneGoHome = new System.Windows.Forms.Button();
            this.doneImage = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.doneTitle = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.ticketPaper = new System.Windows.Forms.Panel();
            this.seat = new System.Windows.Forms.Label();
            this.hall = new System.Windows.Forms.Label();
            this.roundTime = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.Label();
            this.QRCodeImage = new System.Windows.Forms.PictureBox();
            this.waitForTicket = new System.Windows.Forms.Label();
            this.doneDeal = new System.Windows.Forms.Label();
            this.chkPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doneImage)).BeginInit();
            this.panelTop.SuspendLayout();
            this.ticketPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // doneGoHome
            // 
            this.doneGoHome.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doneGoHome.Location = new System.Drawing.Point(127, 548);
            this.doneGoHome.Name = "doneGoHome";
            this.doneGoHome.Size = new System.Drawing.Size(132, 61);
            this.doneGoHome.TabIndex = 21;
            this.doneGoHome.Text = "처음으로";
            this.doneGoHome.UseVisualStyleBackColor = true;
            this.doneGoHome.Click += new System.EventHandler(this.doneGoHome_Click);
            // 
            // doneImage
            // 
            this.doneImage.BackColor = System.Drawing.Color.Transparent;
            this.doneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.doneImage.Image = global::KIOSK_v1.Properties.Resources.complete;
            this.doneImage.Location = new System.Drawing.Point(127, 9);
            this.doneImage.Name = "doneImage";
            this.doneImage.Size = new System.Drawing.Size(32, 35);
            this.doneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doneImage.TabIndex = 20;
            this.doneImage.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelTop.BackgroundImage = global::KIOSK_v1.Properties.Resources.homeMenu_BG;
            this.panelTop.Controls.Add(this.doneTitle);
            this.panelTop.Controls.Add(this.doneImage);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Black;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(384, 53);
            this.panelTop.TabIndex = 18;
            // 
            // doneTitle
            // 
            this.doneTitle.AutoSize = true;
            this.doneTitle.BackColor = System.Drawing.Color.Transparent;
            this.doneTitle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doneTitle.ForeColor = System.Drawing.Color.White;
            this.doneTitle.Location = new System.Drawing.Point(3, 9);
            this.doneTitle.Name = "doneTitle";
            this.doneTitle.Size = new System.Drawing.Size(119, 32);
            this.doneTitle.TabIndex = 0;
            this.doneTitle.Text = "예매 완료";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(38, 315);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(139, 32);
            this.warning.TabIndex = 23;
            this.warning.Text = "티켓 분실 시 \r\n환불 불가합니다.";
            // 
            // ticketPaper
            // 
            this.ticketPaper.BackColor = System.Drawing.Color.White;
            this.ticketPaper.Controls.Add(this.chkPoint);
            this.ticketPaper.Controls.Add(this.seat);
            this.ticketPaper.Controls.Add(this.hall);
            this.ticketPaper.Controls.Add(this.roundTime);
            this.ticketPaper.Controls.Add(this.movieTitle);
            this.ticketPaper.Controls.Add(this.QRCodeImage);
            this.ticketPaper.Location = new System.Drawing.Point(189, 157);
            this.ticketPaper.Name = "ticketPaper";
            this.ticketPaper.Size = new System.Drawing.Size(156, 347);
            this.ticketPaper.TabIndex = 24;
            // 
            // seat
            // 
            this.seat.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.seat.Location = new System.Drawing.Point(54, 249);
            this.seat.Name = "seat";
            this.seat.Size = new System.Drawing.Size(82, 44);
            this.seat.TabIndex = 4;
            this.seat.Text = "A0, B0";
            this.seat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // hall
            // 
            this.hall.Location = new System.Drawing.Point(21, 264);
            this.hall.Name = "hall";
            this.hall.Size = new System.Drawing.Size(27, 29);
            this.hall.TabIndex = 3;
            this.hall.Text = "0관";
            this.hall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // roundTime
            // 
            this.roundTime.Location = new System.Drawing.Point(21, 204);
            this.roundTime.Name = "roundTime";
            this.roundTime.Size = new System.Drawing.Size(115, 29);
            this.roundTime.TabIndex = 2;
            this.roundTime.Text = "날짜 및 시간";
            // 
            // movieTitle
            // 
            this.movieTitle.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieTitle.Location = new System.Drawing.Point(21, 136);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(115, 54);
            this.movieTitle.TabIndex = 1;
            this.movieTitle.Text = "영화제목";
            // 
            // QRCodeImage
            // 
            this.QRCodeImage.BackColor = System.Drawing.Color.White;
            this.QRCodeImage.Location = new System.Drawing.Point(23, 16);
            this.QRCodeImage.Name = "QRCodeImage";
            this.QRCodeImage.Size = new System.Drawing.Size(113, 105);
            this.QRCodeImage.TabIndex = 0;
            this.QRCodeImage.TabStop = false;
            // 
            // waitForTicket
            // 
            this.waitForTicket.AutoSize = true;
            this.waitForTicket.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.waitForTicket.Location = new System.Drawing.Point(37, 157);
            this.waitForTicket.Name = "waitForTicket";
            this.waitForTicket.Size = new System.Drawing.Size(146, 112);
            this.waitForTicket.TabIndex = 25;
            this.waitForTicket.Text = "감사합니다.\r\n\r\n티켓이 출력됩니다.\r\n\r\n잠시만 기다리시면\r\n티켓이 나옵니다.\r\n\r\n";
            // 
            // doneDeal
            // 
            this.doneDeal.AutoSize = true;
            this.doneDeal.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doneDeal.Location = new System.Drawing.Point(38, 100);
            this.doneDeal.Name = "doneDeal";
            this.doneDeal.Size = new System.Drawing.Size(278, 24);
            this.doneDeal.TabIndex = 26;
            this.doneDeal.Text = "구매가 완료되었습니다.\r\n";
            // 
            // chkPoint
            // 
            this.chkPoint.AutoSize = true;
            this.chkPoint.Location = new System.Drawing.Point(23, 311);
            this.chkPoint.Name = "chkPoint";
            this.chkPoint.Size = new System.Drawing.Size(53, 12);
            this.chkPoint.TabIndex = 5;
            this.chkPoint.Text = "특이사항";
            // 
            // uc6_complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doneDeal);
            this.Controls.Add(this.ticketPaper);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.doneGoHome);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.waitForTicket);
            this.Name = "uc6_complete";
            this.Size = new System.Drawing.Size(384, 681);
            ((System.ComponentModel.ISupportInitialize)(this.doneImage)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ticketPaper.ResumeLayout(false);
            this.ticketPaper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox doneImage;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label doneTitle;
        private System.Windows.Forms.Button doneGoHome;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Panel ticketPaper;
        public System.Windows.Forms.PictureBox QRCodeImage;
        public System.Windows.Forms.Label movieTitle;
        public System.Windows.Forms.Label waitForTicket;
        public System.Windows.Forms.Label roundTime;
        public System.Windows.Forms.Label hall;
        public System.Windows.Forms.Label seat;
        public System.Windows.Forms.Label doneDeal;
        public System.Windows.Forms.Label chkPoint;
    }
}
