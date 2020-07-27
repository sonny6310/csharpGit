namespace PcrommV2
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
            this.topP = new System.Windows.Forms.Panel();
            this.programInfo = new System.Windows.Forms.Label();
            this.closeB = new System.Windows.Forms.Button();
            this.mainP = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.topP.SuspendLayout();
            this.SuspendLayout();
            // 
            // topP
            // 
            this.topP.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.topP.Controls.Add(this.button1);
            this.topP.Controls.Add(this.programInfo);
            this.topP.Controls.Add(this.closeB);
            this.topP.Dock = System.Windows.Forms.DockStyle.Top;
            this.topP.Location = new System.Drawing.Point(0, 0);
            this.topP.Name = "topP";
            this.topP.Size = new System.Drawing.Size(1440, 30);
            this.topP.TabIndex = 0;
            this.topP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topP_MouseDown);
            this.topP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topP_MouseMove);
            // 
            // programInfo
            // 
            this.programInfo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.programInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.programInfo.ForeColor = System.Drawing.Color.White;
            this.programInfo.Location = new System.Drawing.Point(0, 0);
            this.programInfo.Name = "programInfo";
            this.programInfo.Size = new System.Drawing.Size(294, 30);
            this.programInfo.TabIndex = 1;
            this.programInfo.Text = "pc방 음식주문 프로그램 베타";
            this.programInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeB
            // 
            this.closeB.BackColor = System.Drawing.Color.Transparent;
            this.closeB.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeB.FlatAppearance.BorderSize = 0;
            this.closeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeB.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeB.ForeColor = System.Drawing.Color.White;
            this.closeB.Location = new System.Drawing.Point(1410, 0);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(30, 30);
            this.closeB.TabIndex = 0;
            this.closeB.Text = "X";
            this.closeB.UseVisualStyleBackColor = false;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // mainP
            // 
            this.mainP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainP.Location = new System.Drawing.Point(0, 30);
            this.mainP.Margin = new System.Windows.Forms.Padding(0);
            this.mainP.Name = "mainP";
            this.mainP.Size = new System.Drawing.Size(1440, 870);
            this.mainP.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1380, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.mainP);
            this.Controls.Add(this.topP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topP;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.Panel mainP;
        private System.Windows.Forms.Label programInfo;
        private System.Windows.Forms.Button button1;
    }
}

