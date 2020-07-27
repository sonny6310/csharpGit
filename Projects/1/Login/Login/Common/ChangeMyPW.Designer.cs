namespace Login
{
    partial class ChangeMyPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMyPW));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.text_check = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_changePW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_currentPW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 85);
            this.panel1.TabIndex = 102;
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
            this.btn_exit.Location = new System.Drawing.Point(637, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(63, 85);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "x";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY강M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "비밀번호변경";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("HY강M", 15F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(274, 294);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(151, 58);
            this.btn_update.TabIndex = 101;
            this.btn_update.Text = "변경";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // text_check
            // 
            this.text_check.Font = new System.Drawing.Font("HY강M", 15F);
            this.text_check.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.text_check.Location = new System.Drawing.Point(244, 237);
            this.text_check.Name = "text_check";
            this.text_check.PasswordChar = '●';
            this.text_check.Size = new System.Drawing.Size(391, 30);
            this.text_check.TabIndex = 100;
            this.text_check.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY강M", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(66, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "비밀번호확인";
            // 
            // text_changePW
            // 
            this.text_changePW.Font = new System.Drawing.Font("HY강M", 15F);
            this.text_changePW.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.text_changePW.Location = new System.Drawing.Point(244, 189);
            this.text_changePW.Name = "text_changePW";
            this.text_changePW.PasswordChar = '●';
            this.text_changePW.Size = new System.Drawing.Size(391, 30);
            this.text_changePW.TabIndex = 99;
            this.text_changePW.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(66, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "바꿀비밀번호";
            // 
            // text_currentPW
            // 
            this.text_currentPW.Font = new System.Drawing.Font("HY강M", 15F);
            this.text_currentPW.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.text_currentPW.Location = new System.Drawing.Point(244, 141);
            this.text_currentPW.Name = "text_currentPW";
            this.text_currentPW.PasswordChar = '●';
            this.text_currentPW.Size = new System.Drawing.Size(391, 30);
            this.text_currentPW.TabIndex = 98;
            this.text_currentPW.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HY강M", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(66, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 105;
            this.label4.Text = "현재비밀번호";
            // 
            // ChangeMyPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.text_check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_changePW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_currentPW);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangeMyPW";
            this.Text = "ChangeMyPW";
            this.Load += new System.EventHandler(this.ChangeMyPW_Load);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox text_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_changePW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_currentPW;
        private System.Windows.Forms.Label label4;
    }
}