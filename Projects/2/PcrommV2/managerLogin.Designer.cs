namespace PcrommV2
{
    partial class managerLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.pwTextbox = new System.Windows.Forms.TextBox();
            this.loginB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.loginP = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PcrommV2.Properties.Resources.logo_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 126);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PW";
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(180, 183);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(100, 21);
            this.idTextbox.TabIndex = 0;
            // 
            // pwTextbox
            // 
            this.pwTextbox.Location = new System.Drawing.Point(180, 242);
            this.pwTextbox.Name = "pwTextbox";
            this.pwTextbox.Size = new System.Drawing.Size(100, 21);
            this.pwTextbox.TabIndex = 1;
            this.pwTextbox.UseSystemPasswordChar = true;
            this.pwTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwTextbox_KeyDown);
            // 
            // loginB
            // 
            this.loginB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginB.Location = new System.Drawing.Point(212, 305);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(75, 23);
            this.loginB.TabIndex = 2;
            this.loginB.Text = "로그인";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // cancelB
            // 
            this.cancelB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelB.Location = new System.Drawing.Point(114, 305);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 3;
            this.cancelB.Text = "취소";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // loginP
            // 
            this.loginP.Controls.Add(this.pictureBox1);
            this.loginP.Controls.Add(this.cancelB);
            this.loginP.Controls.Add(this.label1);
            this.loginP.Controls.Add(this.loginB);
            this.loginP.Controls.Add(this.label2);
            this.loginP.Controls.Add(this.pwTextbox);
            this.loginP.Controls.Add(this.idTextbox);
            this.loginP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginP.Location = new System.Drawing.Point(0, 0);
            this.loginP.Name = "loginP";
            this.loginP.Size = new System.Drawing.Size(400, 400);
            this.loginP.TabIndex = 0;
            // 
            // managerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.loginP);
            this.Name = "managerLogin";
            this.Text = "managerLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginP.ResumeLayout(false);
            this.loginP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox pwTextbox;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Panel loginP;
    }
}