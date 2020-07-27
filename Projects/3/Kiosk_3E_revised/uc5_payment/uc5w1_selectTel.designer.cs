namespace KIOSK_v1.uc5_payment
{
    partial class uc5w1_selectTel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc5w1_selectTel));
            this.selTelWin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.LG = new System.Windows.Forms.Button();
            this.SKT = new System.Windows.Forms.Button();
            this.KT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.selTelWin.SuspendLayout();
            this.SuspendLayout();
            // 
            // selTelWin
            // 
            this.selTelWin.BackColor = System.Drawing.SystemColors.Window;
            this.selTelWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selTelWin.Controls.Add(this.label1);
            this.selTelWin.Controls.Add(this.cancel);
            this.selTelWin.Controls.Add(this.confirm);
            this.selTelWin.Controls.Add(this.LG);
            this.selTelWin.Controls.Add(this.SKT);
            this.selTelWin.Controls.Add(this.KT);
            this.selTelWin.Location = new System.Drawing.Point(46, 14);
            this.selTelWin.Name = "selTelWin";
            this.selTelWin.Size = new System.Drawing.Size(295, 243);
            this.selTelWin.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(74, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 87;
            this.label1.Text = "통신사 선택";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Brown;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(150, 180);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(131, 39);
            this.cancel.TabIndex = 86;
            this.cancel.Text = "적용 취소";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.DarkBlue;
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(18, 180);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(126, 39);
            this.confirm.TabIndex = 85;
            this.confirm.Text = "적용 완료";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // LG
            // 
            this.LG.BackColor = System.Drawing.Color.Transparent;
            this.LG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LG.BackgroundImage")));
            this.LG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LG.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LG.ForeColor = System.Drawing.Color.White;
            this.LG.Location = new System.Drawing.Point(199, 75);
            this.LG.Name = "LG";
            this.LG.Size = new System.Drawing.Size(82, 75);
            this.LG.TabIndex = 84;
            this.LG.Text = "L G\r\n(10%)";
            this.LG.UseVisualStyleBackColor = false;
            this.LG.Click += new System.EventHandler(this.LG_Click);
            // 
            // SKT
            // 
            this.SKT.BackColor = System.Drawing.Color.Transparent;
            this.SKT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SKT.BackgroundImage")));
            this.SKT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SKT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SKT.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SKT.ForeColor = System.Drawing.Color.White;
            this.SKT.Location = new System.Drawing.Point(107, 75);
            this.SKT.Name = "SKT";
            this.SKT.Size = new System.Drawing.Size(82, 75);
            this.SKT.TabIndex = 83;
            this.SKT.Text = "SKT\r\n(15%)";
            this.SKT.UseVisualStyleBackColor = false;
            this.SKT.Click += new System.EventHandler(this.SKT_Click);
            // 
            // KT
            // 
            this.KT.BackColor = System.Drawing.Color.Transparent;
            this.KT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KT.BackgroundImage")));
            this.KT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KT.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KT.ForeColor = System.Drawing.Color.White;
            this.KT.Location = new System.Drawing.Point(14, 75);
            this.KT.Name = "KT";
            this.KT.Size = new System.Drawing.Size(82, 75);
            this.KT.TabIndex = 82;
            this.KT.Text = "K T\r\n(20%)";
            this.KT.UseVisualStyleBackColor = false;
            this.KT.Click += new System.EventHandler(this.KT_Click);
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
            this.button1.TabIndex = 170;
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
            this.button2.TabIndex = 169;
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
            this.button3.TabIndex = 168;
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
            this.button4.TabIndex = 167;
            this.button4.Text = "통신사 할인";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // uc5w1_selectTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.selTelWin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Name = "uc5w1_selectTel";
            this.Size = new System.Drawing.Size(384, 320);
            this.selTelWin.ResumeLayout(false);
            this.selTelWin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel selTelWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button LG;
        private System.Windows.Forms.Button SKT;
        private System.Windows.Forms.Button KT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
