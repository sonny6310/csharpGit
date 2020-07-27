namespace KIOSK_v1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.buyTicket = new System.Windows.Forms.Label();
            this.bookedPrint = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.Label();
            this.nowTime = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.homeCover = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.goHome = new System.Windows.Forms.PictureBox();
            this.turnBack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeCover)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(384, 681);
            this.mainPanel.TabIndex = 0;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.SystemColors.Control;
            this.homePanel.Controls.Add(this.buyTicket);
            this.homePanel.Controls.Add(this.bookedPrint);
            this.homePanel.Controls.Add(this.today);
            this.homePanel.Controls.Add(this.nowTime);
            this.homePanel.Controls.Add(this.branch);
            this.homePanel.Controls.Add(this.homeCover);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Margin = new System.Windows.Forms.Padding(0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(384, 681);
            this.homePanel.TabIndex = 2;
            // 
            // buyTicket
            // 
            this.buyTicket.BackColor = System.Drawing.Color.LightPink;
            this.buyTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyTicket.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buyTicket.ForeColor = System.Drawing.Color.White;
            this.buyTicket.Image = ((System.Drawing.Image)(resources.GetObject("buyTicket.Image")));
            this.buyTicket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buyTicket.Location = new System.Drawing.Point(198, 431);
            this.buyTicket.Name = "buyTicket";
            this.buyTicket.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buyTicket.Size = new System.Drawing.Size(90, 100);
            this.buyTicket.TabIndex = 15;
            this.buyTicket.Text = "티켓 구매";
            this.buyTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buyTicket.Click += new System.EventHandler(this.buyTicket_Click);
            this.buyTicket.MouseLeave += new System.EventHandler(this.buyTicket_Leave);
            this.buyTicket.MouseHover += new System.EventHandler(this.buyTicket_Hover);
            // 
            // bookedPrint
            // 
            this.bookedPrint.BackColor = System.Drawing.Color.LightPink;
            this.bookedPrint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bookedPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookedPrint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookedPrint.ForeColor = System.Drawing.Color.White;
            this.bookedPrint.Image = ((System.Drawing.Image)(resources.GetObject("bookedPrint.Image")));
            this.bookedPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bookedPrint.Location = new System.Drawing.Point(86, 431);
            this.bookedPrint.Name = "bookedPrint";
            this.bookedPrint.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.bookedPrint.Size = new System.Drawing.Size(90, 100);
            this.bookedPrint.TabIndex = 14;
            this.bookedPrint.Text = "예매 티켓 출력";
            this.bookedPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookedPrint.Click += new System.EventHandler(this.bookedPrint_Click);
            this.bookedPrint.MouseLeave += new System.EventHandler(this.bookedPrint_Leave);
            this.bookedPrint.MouseHover += new System.EventHandler(this.bookedPrint_Hover);
            // 
            // today
            // 
            this.today.BackColor = System.Drawing.Color.Transparent;
            this.today.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.today.ForeColor = System.Drawing.SystemColors.Window;
            this.today.Location = new System.Drawing.Point(84, 358);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(138, 11);
            this.today.TabIndex = 18;
            this.today.Text = "2020년 6월 24일 수요일";
            this.today.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nowTime
            // 
            this.nowTime.BackColor = System.Drawing.Color.Transparent;
            this.nowTime.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowTime.ForeColor = System.Drawing.SystemColors.Window;
            this.nowTime.Location = new System.Drawing.Point(86, 385);
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(202, 24);
            this.nowTime.TabIndex = 17;
            this.nowTime.Text = "오후 5:56:04";
            this.nowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.BackColor = System.Drawing.Color.Transparent;
            this.branch.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.branch.ForeColor = System.Drawing.SystemColors.Window;
            this.branch.Location = new System.Drawing.Point(250, 358);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(38, 11);
            this.branch.TabIndex = 16;
            this.branch.Text = "안산점";
            // 
            // homeCover
            // 
            this.homeCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeCover.ErrorImage = null;
            this.homeCover.Image = ((System.Drawing.Image)(resources.GetObject("homeCover.Image")));
            this.homeCover.Location = new System.Drawing.Point(0, 0);
            this.homeCover.Margin = new System.Windows.Forms.Padding(0);
            this.homeCover.Name = "homeCover";
            this.homeCover.Size = new System.Drawing.Size(384, 681);
            this.homeCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeCover.TabIndex = 19;
            this.homeCover.TabStop = false;
            this.homeCover.DoubleClick += new System.EventHandler(this.Home_DoubleClick);
            this.homeCover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_Down);
            this.homeCover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_Move);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.BackgroundImage = global::KIOSK_v1.Properties.Resources.homeMenu_BG;
            this.bottomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottomPanel.Controls.Add(this.goHome);
            this.bottomPanel.Controls.Add(this.turnBack);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 621);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(384, 60);
            this.bottomPanel.TabIndex = 1;
            this.bottomPanel.DoubleClick += new System.EventHandler(this.Main_DoubleClick);
            this.bottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Down);
            this.bottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_Move);
            // 
            // goHome
            // 
            this.goHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goHome.BackgroundImage")));
            this.goHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.goHome.Location = new System.Drawing.Point(324, 0);
            this.goHome.Name = "goHome";
            this.goHome.Size = new System.Drawing.Size(60, 60);
            this.goHome.TabIndex = 1;
            this.goHome.TabStop = false;
            this.goHome.Click += new System.EventHandler(this.goHome_Click);
            // 
            // turnBack
            // 
            this.turnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("turnBack.BackgroundImage")));
            this.turnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.turnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.turnBack.Location = new System.Drawing.Point(0, 0);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(60, 60);
            this.turnBack.TabIndex = 0;
            this.turnBack.TabStop = false;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(384, 681);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeCover)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.PictureBox goHome;
        private System.Windows.Forms.PictureBox turnBack;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label buyTicket;
        private System.Windows.Forms.Label bookedPrint;
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Label nowTime;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.PictureBox homeCover;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

