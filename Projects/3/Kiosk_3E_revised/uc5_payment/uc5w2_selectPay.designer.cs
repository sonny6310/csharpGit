namespace KIOSK_v1.uc5_payment
{
    partial class uc5w2_selectPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc5w2_selectPay));
            this.kakaoPay = new System.Windows.Forms.Button();
            this.creditCard = new System.Windows.Forms.Button();
            this.changeDiscount = new System.Windows.Forms.Button();
            this.selTelWin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.selTelWin.SuspendLayout();
            this.SuspendLayout();
            // 
            // kakaoPay
            // 
            this.kakaoPay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.kakaoPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kakaoPay.BackgroundImage")));
            this.kakaoPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kakaoPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kakaoPay.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kakaoPay.ForeColor = System.Drawing.Color.White;
            this.kakaoPay.Location = new System.Drawing.Point(149, 61);
            this.kakaoPay.Name = "kakaoPay";
            this.kakaoPay.Size = new System.Drawing.Size(130, 99);
            this.kakaoPay.TabIndex = 8;
            this.kakaoPay.Text = "카카오 PAY";
            this.kakaoPay.UseVisualStyleBackColor = false;
            this.kakaoPay.Click += new System.EventHandler(this.kakaoPay_Click);
            // 
            // creditCard
            // 
            this.creditCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.creditCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("creditCard.BackgroundImage")));
            this.creditCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditCard.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.creditCard.ForeColor = System.Drawing.Color.White;
            this.creditCard.Location = new System.Drawing.Point(13, 61);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(130, 99);
            this.creditCard.TabIndex = 7;
            this.creditCard.Text = "신용 카드";
            this.creditCard.UseVisualStyleBackColor = false;
            this.creditCard.Click += new System.EventHandler(this.creditCard_Click);
            // 
            // changeDiscount
            // 
            this.changeDiscount.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.changeDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeDiscount.BackgroundImage")));
            this.changeDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDiscount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changeDiscount.ForeColor = System.Drawing.SystemColors.Control;
            this.changeDiscount.Location = new System.Drawing.Point(75, 173);
            this.changeDiscount.Name = "changeDiscount";
            this.changeDiscount.Size = new System.Drawing.Size(135, 50);
            this.changeDiscount.TabIndex = 13;
            this.changeDiscount.Text = "할인 변경";
            this.changeDiscount.UseVisualStyleBackColor = false;
            this.changeDiscount.Click += new System.EventHandler(this.changeDiscount_Click);
            // 
            // selTelWin
            // 
            this.selTelWin.BackColor = System.Drawing.SystemColors.Window;
            this.selTelWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selTelWin.Controls.Add(this.label1);
            this.selTelWin.Controls.Add(this.creditCard);
            this.selTelWin.Controls.Add(this.kakaoPay);
            this.selTelWin.Controls.Add(this.changeDiscount);
            this.selTelWin.Location = new System.Drawing.Point(46, 14);
            this.selTelWin.Name = "selTelWin";
            this.selTelWin.Size = new System.Drawing.Size(295, 243);
            this.selTelWin.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 88;
            this.label1.Text = "결제수단 선택";
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(83, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 52);
            this.button1.TabIndex = 176;
            this.button1.Text = "결제수단 선택";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(260, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 97);
            this.button2.TabIndex = 175;
            this.button2.Text = "메가박스\r\n멤버십 할인";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(143, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 97);
            this.button3.TabIndex = 174;
            this.button3.Text = "메가박스 VIP 쿠폰";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(26, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 97);
            this.button4.TabIndex = 173;
            this.button4.Text = "통신사 할인";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // uc5w2_selectPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selTelWin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Name = "uc5w2_selectPay";
            this.Size = new System.Drawing.Size(384, 320);
            this.selTelWin.ResumeLayout(false);
            this.selTelWin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kakaoPay;
        private System.Windows.Forms.Button creditCard;
        private System.Windows.Forms.Button changeDiscount;
        private System.Windows.Forms.Panel selTelWin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}
