namespace Login
{
    partial class IMemberMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMemberMainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_admin_menu = new System.Windows.Forms.Button();
            this.lb_date = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_menu4 = new System.Windows.Forms.Button();
            this.btn_menu3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_menu2 = new System.Windows.Forms.Button();
            this.btn_menu1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.사용자정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비밀번호변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.Button();
            this.iMenu11 = new Login.IMenu1();
            this.iMenu21 = new Login.IMenu2();
            this.iMenu31 = new Login.IMenu3();
            this.iMenu41 = new Login.IMenu4();
            this.afterLoginMainPage1 = new Login.AfterLoginMainPage();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.afterLoginMainPage1);
            this.panel4.Controls.Add(this.iMenu41);
            this.panel4.Controls.Add(this.iMenu31);
            this.panel4.Controls.Add(this.iMenu21);
            this.panel4.Controls.Add(this.iMenu11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(189, 99);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 635);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btn_admin_menu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(189, 734);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 28);
            this.panel3.TabIndex = 10;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_admin_menu
            // 
            this.btn_admin_menu.FlatAppearance.BorderSize = 0;
            this.btn_admin_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_menu.ForeColor = System.Drawing.Color.White;
            this.btn_admin_menu.Location = new System.Drawing.Point(888, 3);
            this.btn_admin_menu.Name = "btn_admin_menu";
            this.btn_admin_menu.Size = new System.Drawing.Size(104, 25);
            this.btn_admin_menu.TabIndex = 12;
            this.btn_admin_menu.Text = "기업정보추가";
            this.btn_admin_menu.UseVisualStyleBackColor = true;
            this.btn_admin_menu.Visible = false;
            this.btn_admin_menu.Click += new System.EventHandler(this.btn_admin_menu_Click);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("HY강M", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_date.ForeColor = System.Drawing.Color.White;
            this.lb_date.Location = new System.Drawing.Point(12, 68);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(37, 15);
            this.lb_date.TabIndex = 0;
            this.lb_date.Text = "날짜";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.btn_menu4);
            this.panel2.Controls.Add(this.btn_menu3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_menu2);
            this.panel2.Controls.Add(this.btn_menu1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 663);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_menu4
            // 
            this.btn_menu4.FlatAppearance.BorderSize = 0;
            this.btn_menu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu4.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu4.ForeColor = System.Drawing.Color.White;
            this.btn_menu4.Location = new System.Drawing.Point(3, 517);
            this.btn_menu4.Name = "btn_menu4";
            this.btn_menu4.Size = new System.Drawing.Size(186, 89);
            this.btn_menu4.TabIndex = 2;
            this.btn_menu4.Text = "후기";
            this.btn_menu4.UseVisualStyleBackColor = true;
            this.btn_menu4.Click += new System.EventHandler(this.btn_menu4_Click);
            // 
            // btn_menu3
            // 
            this.btn_menu3.FlatAppearance.BorderSize = 0;
            this.btn_menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu3.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu3.ForeColor = System.Drawing.Color.White;
            this.btn_menu3.Location = new System.Drawing.Point(3, 405);
            this.btn_menu3.Name = "btn_menu3";
            this.btn_menu3.Size = new System.Drawing.Size(186, 89);
            this.btn_menu3.TabIndex = 2;
            this.btn_menu3.Text = "이력서등록";
            this.btn_menu3.UseVisualStyleBackColor = true;
            this.btn_menu3.Click += new System.EventHandler(this.btn_menu3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_menu2
            // 
            this.btn_menu2.FlatAppearance.BorderSize = 0;
            this.btn_menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu2.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu2.ForeColor = System.Drawing.Color.White;
            this.btn_menu2.Location = new System.Drawing.Point(3, 291);
            this.btn_menu2.Name = "btn_menu2";
            this.btn_menu2.Size = new System.Drawing.Size(186, 89);
            this.btn_menu2.TabIndex = 2;
            this.btn_menu2.Text = "기업정보";
            this.btn_menu2.UseVisualStyleBackColor = true;
            this.btn_menu2.Click += new System.EventHandler(this.btn_menu2_Click);
            // 
            // btn_menu1
            // 
            this.btn_menu1.FlatAppearance.BorderSize = 0;
            this.btn_menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu1.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu1.ForeColor = System.Drawing.Color.White;
            this.btn_menu1.Location = new System.Drawing.Point(3, 181);
            this.btn_menu1.Name = "btn_menu1";
            this.btn_menu1.Size = new System.Drawing.Size(186, 89);
            this.btn_menu1.TabIndex = 2;
            this.btn_menu1.Text = "채용관";
            this.btn_menu1.UseVisualStyleBackColor = true;
            this.btn_menu1.Click += new System.EventHandler(this.btn_menu1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Controls.Add(this.lb_date);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 99);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(881, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.ContextMenuStrip = this.contextMenuStrip1;
            this.lb_username.Font = new System.Drawing.Font("HY강M", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_username.ForeColor = System.Drawing.Color.White;
            this.lb_username.Location = new System.Drawing.Point(965, 39);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(76, 22);
            this.lb_username.TabIndex = 5;
            this.lb_username.Text = "사용자";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자정보수정ToolStripMenuItem,
            this.비밀번호변경ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 48);
            // 
            // 사용자정보수정ToolStripMenuItem
            // 
            this.사용자정보수정ToolStripMenuItem.Name = "사용자정보수정ToolStripMenuItem";
            this.사용자정보수정ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.사용자정보수정ToolStripMenuItem.Text = "내정보 수정";
            this.사용자정보수정ToolStripMenuItem.Click += new System.EventHandler(this.사용자정보수정ToolStripMenuItem_Click);
            // 
            // 비밀번호변경ToolStripMenuItem
            // 
            this.비밀번호변경ToolStripMenuItem.Name = "비밀번호변경ToolStripMenuItem";
            this.비밀번호변경ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.비밀번호변경ToolStripMenuItem.Text = "비밀번호 변경";
            this.비밀번호변경ToolStripMenuItem.Click += new System.EventHandler(this.비밀번호변경ToolStripMenuItem_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(1095, 25);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(66, 49);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // iMenu11
            // 
            this.iMenu11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMenu11.Location = new System.Drawing.Point(0, 0);
            this.iMenu11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iMenu11.Name = "iMenu11";
            this.iMenu11.Size = new System.Drawing.Size(995, 635);
            this.iMenu11.TabIndex = 0;
            // 
            // iMenu21
            // 
            this.iMenu21.BackColor = System.Drawing.Color.White;
            this.iMenu21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMenu21.Location = new System.Drawing.Point(0, 0);
            this.iMenu21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iMenu21.Name = "iMenu21";
            this.iMenu21.Size = new System.Drawing.Size(995, 635);
            this.iMenu21.TabIndex = 1;
            // 
            // iMenu31
            // 
            this.iMenu31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMenu31.Location = new System.Drawing.Point(0, 0);
            this.iMenu31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iMenu31.Name = "iMenu31";
            this.iMenu31.Size = new System.Drawing.Size(995, 635);
            this.iMenu31.TabIndex = 2;
            // 
            // iMenu41
            // 
            this.iMenu41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMenu41.Location = new System.Drawing.Point(0, 0);
            this.iMenu41.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iMenu41.Name = "iMenu41";
            this.iMenu41.Size = new System.Drawing.Size(995, 635);
            this.iMenu41.TabIndex = 3;
            // 
            // afterLoginMainPage1
            // 
            this.afterLoginMainPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afterLoginMainPage1.Location = new System.Drawing.Point(0, 0);
            this.afterLoginMainPage1.Name = "afterLoginMainPage1";
            this.afterLoginMainPage1.Size = new System.Drawing.Size(995, 635);
            this.afterLoginMainPage1.TabIndex = 4;
            // 
            // IMemberMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IMemberMainForm";
            this.Text = "IndividualMemberMainForm";
            this.Load += new System.EventHandler(this.IMemberMainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_menu4;
        private System.Windows.Forms.Button btn_menu3;
        private System.Windows.Forms.Button btn_menu2;
        private System.Windows.Forms.Button btn_menu1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 사용자정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비밀번호변경ToolStripMenuItem;
        private System.Windows.Forms.Button btn_admin_menu;
        private AfterLoginMainPage afterLoginMainPage1;
        private IMenu4 iMenu41;
        private IMenu3 iMenu31;
        private IMenu2 iMenu21;
        private IMenu1 iMenu11;
    }
}