using System;

namespace KIOSK_v1
{
    partial class uc1_bookedPrint
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
            this.bP_Panel = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.printThis = new System.Windows.Forms.Button();
            this.selectedTicket = new System.Windows.Forms.Panel();
            this.seat = new System.Windows.Forms.Label();
            this.hall = new System.Windows.Forms.Label();
            this.roundTime = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Label();
            this.bookedTicket = new System.Windows.Forms.Panel();
            this.del = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bP_Panel.SuspendLayout();
            this.selectedTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // bP_Panel
            // 
            this.bP_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bP_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bP_Panel.Controls.Add(this.result);
            this.bP_Panel.Controls.Add(this.printThis);
            this.bP_Panel.Controls.Add(this.selectedTicket);
            this.bP_Panel.Controls.Add(this.input);
            this.bP_Panel.Controls.Add(this.bookedTicket);
            this.bP_Panel.Controls.Add(this.del);
            this.bP_Panel.Controls.Add(this.enter);
            this.bP_Panel.Controls.Add(this.button0);
            this.bP_Panel.Controls.Add(this.button9);
            this.bP_Panel.Controls.Add(this.button8);
            this.bP_Panel.Controls.Add(this.button7);
            this.bP_Panel.Controls.Add(this.button6);
            this.bP_Panel.Controls.Add(this.button5);
            this.bP_Panel.Controls.Add(this.button4);
            this.bP_Panel.Controls.Add(this.button3);
            this.bP_Panel.Controls.Add(this.button2);
            this.bP_Panel.Controls.Add(this.button1);
            this.bP_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bP_Panel.Location = new System.Drawing.Point(0, 0);
            this.bP_Panel.Name = "bP_Panel";
            this.bP_Panel.Size = new System.Drawing.Size(384, 621);
            this.bP_Panel.TabIndex = 16;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result.Location = new System.Drawing.Point(4, 18);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(82, 16);
            this.result.TabIndex = 5;
            this.result.Text = "조회 결과";
            // 
            // printThis
            // 
            this.printThis.BackColor = System.Drawing.Color.MediumPurple;
            this.printThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.printThis.CausesValidation = false;
            this.printThis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printThis.FlatAppearance.BorderSize = 0;
            this.printThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printThis.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.printThis.Location = new System.Drawing.Point(229, 485);
            this.printThis.Name = "printThis";
            this.printThis.Size = new System.Drawing.Size(148, 50);
            this.printThis.TabIndex = 34;
            this.printThis.Text = "출력";
            this.printThis.UseVisualStyleBackColor = false;
            this.printThis.Click += new System.EventHandler(this.printThis_Click);
            // 
            // selectedTicket
            // 
            this.selectedTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedTicket.Controls.Add(this.seat);
            this.selectedTicket.Controls.Add(this.hall);
            this.selectedTicket.Controls.Add(this.roundTime);
            this.selectedTicket.Controls.Add(this.movieTitle);
            this.selectedTicket.Location = new System.Drawing.Point(229, 239);
            this.selectedTicket.Name = "selectedTicket";
            this.selectedTicket.Size = new System.Drawing.Size(148, 230);
            this.selectedTicket.TabIndex = 33;
            // 
            // seat
            // 
            this.seat.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.seat.Location = new System.Drawing.Point(52, 120);
            this.seat.Name = "seat";
            this.seat.Size = new System.Drawing.Size(82, 93);
            this.seat.TabIndex = 38;
            this.seat.Text = "A0, B0";
            this.seat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // hall
            // 
            this.hall.Location = new System.Drawing.Point(19, 184);
            this.hall.Name = "hall";
            this.hall.Size = new System.Drawing.Size(27, 29);
            this.hall.TabIndex = 37;
            this.hall.Text = "0관";
            this.hall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // roundTime
            // 
            this.roundTime.Location = new System.Drawing.Point(19, 91);
            this.roundTime.Name = "roundTime";
            this.roundTime.Size = new System.Drawing.Size(115, 29);
            this.roundTime.TabIndex = 36;
            this.roundTime.Text = "날짜 및 시간";
            // 
            // movieTitle
            // 
            this.movieTitle.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieTitle.Location = new System.Drawing.Point(17, 19);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(115, 54);
            this.movieTitle.TabIndex = 35;
            this.movieTitle.Text = "영화제목";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.Control;
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.input.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input.Location = new System.Drawing.Point(7, 239);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(212, 34);
            this.input.TabIndex = 32;
            this.input.Text = "예매번호를 입력하세요.";
            this.input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookedTicket
            // 
            this.bookedTicket.AutoScroll = true;
            this.bookedTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookedTicket.Location = new System.Drawing.Point(7, 48);
            this.bookedTicket.Name = "bookedTicket";
            this.bookedTicket.Size = new System.Drawing.Size(370, 185);
            this.bookedTicket.TabIndex = 31;
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.MediumPurple;
            this.del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del.CausesValidation = false;
            this.del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.del.Location = new System.Drawing.Point(7, 485);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(60, 50);
            this.del.TabIndex = 30;
            this.del.Text = "수정";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.MediumPurple;
            this.enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enter.CausesValidation = false;
            this.enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter.FlatAppearance.BorderSize = 0;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enter.Location = new System.Drawing.Point(159, 485);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(60, 50);
            this.enter.TabIndex = 29;
            this.enter.Text = "조회";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.MediumPurple;
            this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button0.CausesValidation = false;
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.Location = new System.Drawing.Point(83, 485);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 50);
            this.button0.TabIndex = 28;
            this.button0.Tag = "0";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MediumPurple;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.CausesValidation = false;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(159, 419);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 50);
            this.button9.TabIndex = 26;
            this.button9.Tag = "9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumPurple;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.CausesValidation = false;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(83, 419);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 50);
            this.button8.TabIndex = 25;
            this.button8.Tag = "8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumPurple;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.CausesValidation = false;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(7, 419);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 50);
            this.button7.TabIndex = 24;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumPurple;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.CausesValidation = false;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(159, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 50);
            this.button6.TabIndex = 23;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumPurple;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.CausesValidation = false;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(83, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 50);
            this.button5.TabIndex = 22;
            this.button5.Tag = "5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.CausesValidation = false;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(7, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 50);
            this.button4.TabIndex = 21;
            this.button4.Tag = "4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.CausesValidation = false;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(159, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 50);
            this.button3.TabIndex = 20;
            this.button3.Tag = "3";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.CausesValidation = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(83, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 50);
            this.button2.TabIndex = 19;
            this.button2.Tag = "2";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(7, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 18;
            this.button1.Tag = "1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // uc1_bookedPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bP_Panel);
            this.Name = "uc1_bookedPrint";
            this.Size = new System.Drawing.Size(384, 621);
            this.bP_Panel.ResumeLayout(false);
            this.bP_Panel.PerformLayout();
            this.selectedTicket.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel bP_Panel;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Panel bookedTicket;
        private System.Windows.Forms.Panel selectedTicket;
        private System.Windows.Forms.Button printThis;
        public System.Windows.Forms.Label roundTime;
        public System.Windows.Forms.Label movieTitle;
        public System.Windows.Forms.Label seat;
        public System.Windows.Forms.Label hall;
    }
}
