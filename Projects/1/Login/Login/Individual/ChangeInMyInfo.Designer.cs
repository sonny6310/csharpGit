namespace Login.Individual
{
    partial class ChangeInMyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInMyInfo));
            this.btn_update = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_addr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("HY강M", 15F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(195, 589);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(173, 72);
            this.btn_update.TabIndex = 114;
            this.btn_update.Text = "수정";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("HY강M", 15F);
            this.text_name.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.text_name.Location = new System.Drawing.Point(62, 221);
            this.text_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(446, 36);
            this.text_name.TabIndex = 106;
            this.text_name.Text = " User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(57, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "이름";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 106);
            this.panel1.TabIndex = 115;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(499, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(72, 106);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "x";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY강M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "내정보수정";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HY강M", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(58, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 117;
            this.label8.Text = "전화번호";
            // 
            // text_phone
            // 
            this.text_phone.Font = new System.Drawing.Font("HY강M", 15F);
            this.text_phone.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.text_phone.Location = new System.Drawing.Point(62, 321);
            this.text_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(446, 36);
            this.text_phone.TabIndex = 107;
            this.text_phone.Text = "\'-\' 빼고 입력해주세요";
            // 
            // text_email
            // 
            this.text_email.Font = new System.Drawing.Font("HY강M", 15F);
            this.text_email.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.text_email.Location = new System.Drawing.Point(62, 521);
            this.text_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(446, 36);
            this.text_email.TabIndex = 109;
            this.text_email.Text = " someone@email.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HY강M", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(57, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 123;
            this.label6.Text = "이메일";
            // 
            // text_addr
            // 
            this.text_addr.Font = new System.Drawing.Font("HY강M", 15F);
            this.text_addr.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.text_addr.Location = new System.Drawing.Point(62, 421);
            this.text_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_addr.Name = "text_addr";
            this.text_addr.Size = new System.Drawing.Size(446, 36);
            this.text_addr.TabIndex = 108;
            this.text_addr.Text = " 대구광역시 동구 아양로 42길";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HY강M", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(57, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 122;
            this.label5.Text = "주소";
            // 
            // ChangeInMyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 696);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_phone);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_addr);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangeInMyInfo";
            this.Text = "ChangeInMyInfo";
            this.Load += new System.EventHandler(this.ChangeInMyInfo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_addr;
        private System.Windows.Forms.Label label5;
    }
}