namespace UserControlForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu41 = new UserControlForm.Menu4();
            this.menu31 = new UserControlForm.Menu3();
            this.menu21 = new UserControlForm.Menu2();
            this.menu11 = new UserControlForm.Menu1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 80);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(364, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "menu4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "menu3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "menu2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "menu1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menu11);
            this.panel2.Controls.Add(this.menu41);
            this.panel2.Controls.Add(this.menu31);
            this.panel2.Controls.Add(this.menu21);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 384);
            this.panel2.TabIndex = 1;
            // 
            // menu41
            // 
            this.menu41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu41.Location = new System.Drawing.Point(0, 0);
            this.menu41.Name = "menu41";
            this.menu41.Size = new System.Drawing.Size(555, 384);
            this.menu41.TabIndex = 3;
            // 
            // menu31
            // 
            this.menu31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu31.Location = new System.Drawing.Point(0, 0);
            this.menu31.Name = "menu31";
            this.menu31.Size = new System.Drawing.Size(555, 384);
            this.menu31.TabIndex = 2;
            // 
            // menu21
            // 
            this.menu21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu21.Location = new System.Drawing.Point(0, 0);
            this.menu21.Name = "menu21";
            this.menu21.Size = new System.Drawing.Size(555, 384);
            this.menu21.TabIndex = 1;
            // 
            // menu11
            // 
            this.menu11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu11.Location = new System.Drawing.Point(0, 0);
            this.menu11.Name = "menu11";
            this.menu11.Size = new System.Drawing.Size(555, 384);
            this.menu11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private Menu4 menu41;
        private Menu3 menu31;
        private Menu2 menu21;
        private Menu1 menu11;
    }
}

