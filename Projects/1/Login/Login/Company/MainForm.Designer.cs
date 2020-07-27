namespace Login
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_admin_menu = new System.Windows.Forms.Button();
            this.lb_date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.사용자정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비밀번호변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu4 = new System.Windows.Forms.Button();
            this.btn_menu3 = new System.Windows.Forms.Button();
            this.btn_menu2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_menu1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu11 = new Login.Menu1();
            this.menu21 = new Login.Menu2();
            this.menu31 = new Login.Menu3();
            this.menu41 = new Login.Menu4();
            this.afterLoginMainPage1 = new Login.AfterLoginMainPage();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.afterLoginMainPage1);
            this.panel4.Controls.Add(this.menu41);
            this.panel4.Controls.Add(this.menu31);
            this.panel4.Controls.Add(this.menu21);
            this.panel4.Controls.Add(this.menu11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(189, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 635);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btn_admin_menu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(189, 734);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 28);
            this.panel3.TabIndex = 6;
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
            this.btn_admin_menu.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(881, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.lb_username.TabIndex = 3;
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
            this.btn_menu4.Text = "채용관리";
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
            this.btn_menu3.Text = "인재정보";
            this.btn_menu3.UseVisualStyleBackColor = true;
            this.btn_menu3.Click += new System.EventHandler(this.btn_menu3_Click);
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
            this.btn_menu2.Text = "구인목록";
            this.btn_menu2.UseVisualStyleBackColor = true;
            this.btn_menu2.Click += new System.EventHandler(this.btn_menu2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.lb_date);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 99);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.btn_menu1.Text = "구인등록";
            this.btn_menu1.UseVisualStyleBackColor = true;
            this.btn_menu1.Click += new System.EventHandler(this.btn_menu1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menu11
            // 
            this.menu11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu11.Location = new System.Drawing.Point(0, 0);
            this.menu11.Name = "menu11";
            this.menu11.Size = new System.Drawing.Size(995, 635);
            this.menu11.TabIndex = 0;
            // 
            // menu21
            // 
            this.menu21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu21.Location = new System.Drawing.Point(0, 0);
            this.menu21.Name = "menu21";
            this.menu21.Size = new System.Drawing.Size(995, 635);
            this.menu21.TabIndex = 1;
            // 
            // menu31
            // 
            this.menu31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu31.Location = new System.Drawing.Point(0, 0);
            this.menu31.Name = "menu31";
            this.menu31.Size = new System.Drawing.Size(995, 635);
            this.menu31.TabIndex = 2;
            // 
            // menu41
            // 
            this.menu41.BackColor = System.Drawing.Color.White;
            this.menu41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu41.Location = new System.Drawing.Point(0, 0);
            this.menu41.Name = "menu41";
            this.menu41.Size = new System.Drawing.Size(995, 635);
            this.menu41.TabIndex = 3;
            // 
            // afterLoginMainPage1
            // 
            this.afterLoginMainPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afterLoginMainPage1.Location = new System.Drawing.Point(0, 0);
            this.afterLoginMainPage1.Name = "afterLoginMainPage1";
            this.afterLoginMainPage1.Size = new System.Drawing.Size(995, 635);
            this.afterLoginMainPage1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Button btn_menu4;
        private System.Windows.Forms.Button btn_menu3;
        private System.Windows.Forms.Button btn_menu2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_menu1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_admin_menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 사용자정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비밀번호변경ToolStripMenuItem;
        private AfterLoginMainPage afterLoginMainPage1;
        private Menu4 menu41;
        private Menu3 menu31;
        private Menu2 menu21;
        private Menu1 menu11;
    }
}