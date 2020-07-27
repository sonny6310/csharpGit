namespace LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_pw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.rbtn_customer = new System.Windows.Forms.RadioButton();
            this.rbtn_comcustomer = new System.Windows.Forms.RadioButton();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.btn_idFind = new System.Windows.Forms.Button();
            this.btn_pwFind = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 85);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1146, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(54, 85);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY강M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "오늘부터 일일";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(319, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(520, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(508, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please Login First";
            // 
            // text_id
            // 
            this.text_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_id.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_id.Location = new System.Drawing.Point(313, 466);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(575, 35);
            this.text_id.TabIndex = 5;
            // 
            // text_pw
            // 
            this.text_pw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_pw.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_pw.Location = new System.Drawing.Point(313, 569);
            this.text_pw.Name = "text_pw";
            this.text_pw.Size = new System.Drawing.Size(575, 35);
            this.text_pw.TabIndex = 7;
            this.text_pw.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(319, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(313, 694);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(575, 46);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // rbtn_customer
            // 
            this.rbtn_customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_customer.AutoSize = true;
            this.rbtn_customer.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtn_customer.ForeColor = System.Drawing.Color.Black;
            this.rbtn_customer.Location = new System.Drawing.Point(447, 379);
            this.rbtn_customer.Name = "rbtn_customer";
            this.rbtn_customer.Size = new System.Drawing.Size(132, 28);
            this.rbtn_customer.TabIndex = 10;
            this.rbtn_customer.TabStop = true;
            this.rbtn_customer.Text = "개인 회원";
            this.rbtn_customer.UseVisualStyleBackColor = true;
            // 
            // rbtn_comcustomer
            // 
            this.rbtn_comcustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_comcustomer.AutoSize = true;
            this.rbtn_comcustomer.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtn_comcustomer.ForeColor = System.Drawing.Color.Black;
            this.rbtn_comcustomer.Location = new System.Drawing.Point(695, 379);
            this.rbtn_comcustomer.Name = "rbtn_comcustomer";
            this.rbtn_comcustomer.Size = new System.Drawing.Size(132, 28);
            this.rbtn_comcustomer.TabIndex = 11;
            this.rbtn_comcustomer.TabStop = true;
            this.rbtn_comcustomer.Text = "기업 회원";
            this.rbtn_comcustomer.UseVisualStyleBackColor = true;
            // 
            // btn_signUp
            // 
            this.btn_signUp.AutoSize = true;
            this.btn_signUp.FlatAppearance.BorderSize = 0;
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUp.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_signUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_signUp.Location = new System.Drawing.Point(313, 640);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(143, 40);
            this.btn_signUp.TabIndex = 14;
            this.btn_signUp.Text = "회원가입";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // btn_idFind
            // 
            this.btn_idFind.AutoSize = true;
            this.btn_idFind.FlatAppearance.BorderSize = 0;
            this.btn_idFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_idFind.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_idFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_idFind.Location = new System.Drawing.Point(512, 640);
            this.btn_idFind.Name = "btn_idFind";
            this.btn_idFind.Size = new System.Drawing.Size(183, 40);
            this.btn_idFind.TabIndex = 15;
            this.btn_idFind.Text = "아이디 찾기";
            this.btn_idFind.UseVisualStyleBackColor = true;
            this.btn_idFind.Click += new System.EventHandler(this.btn_idFind_Click);
            // 
            // btn_pwFind
            // 
            this.btn_pwFind.AutoSize = true;
            this.btn_pwFind.FlatAppearance.BorderSize = 0;
            this.btn_pwFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pwFind.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_pwFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_pwFind.Location = new System.Drawing.Point(716, 640);
            this.btn_pwFind.Name = "btn_pwFind";
            this.btn_pwFind.Size = new System.Drawing.Size(213, 40);
            this.btn_pwFind.TabIndex = 16;
            this.btn_pwFind.Text = "비밀번호 찾기";
            this.btn_pwFind.UseVisualStyleBackColor = true;
            this.btn_pwFind.Click += new System.EventHandler(this.btn_pwFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.btn_pwFind);
            this.Controls.Add(this.btn_idFind);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.rbtn_comcustomer);
            this.Controls.Add(this.rbtn_customer);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.text_pw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox text_id;
		private System.Windows.Forms.TextBox text_pw;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.RadioButton rbtn_customer;
		private System.Windows.Forms.RadioButton rbtn_comcustomer;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Button btn_idFind;
        private System.Windows.Forms.Button btn_pwFind;
    }
}

