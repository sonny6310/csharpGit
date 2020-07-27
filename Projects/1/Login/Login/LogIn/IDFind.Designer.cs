namespace Login
{
    partial class IDFind
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_idFind = new System.Windows.Forms.Button();
            this.rbtn_customer = new System.Windows.Forms.RadioButton();
            this.rbtn_comcustomer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(134, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 찾기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY강M", 12F);
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 입력 :";
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_name.Location = new System.Drawing.Point(36, 134);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(312, 26);
            this.text_name.TabIndex = 2;
            this.text_name.Enter += new System.EventHandler(this.textbox_Enter);
            // 
            // text_tel
            // 
            this.text_tel.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_tel.Location = new System.Drawing.Point(36, 234);
            this.text_tel.MaxLength = 11;
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(312, 26);
            this.text_tel.TabIndex = 4;
            this.text_tel.Enter += new System.EventHandler(this.textbox_Enter);
            this.text_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_tel_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY강M", 12F);
            this.label3.Location = new System.Drawing.Point(33, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "전화번호 입력 :";
            // 
            // text_email
            // 
            this.text_email.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_email.Location = new System.Drawing.Point(36, 337);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(312, 26);
            this.text_email.TabIndex = 6;
            this.text_email.Enter += new System.EventHandler(this.textbox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HY강M", 12F);
            this.label4.Location = new System.Drawing.Point(33, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "이메일 입력 :";
            // 
            // btn_idFind
            // 
            this.btn_idFind.AutoSize = true;
            this.btn_idFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btn_idFind.FlatAppearance.BorderSize = 0;
            this.btn_idFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_idFind.Font = new System.Drawing.Font("HY강M", 12F);
            this.btn_idFind.ForeColor = System.Drawing.Color.White;
            this.btn_idFind.Location = new System.Drawing.Point(145, 376);
            this.btn_idFind.Name = "btn_idFind";
            this.btn_idFind.Size = new System.Drawing.Size(94, 41);
            this.btn_idFind.TabIndex = 7;
            this.btn_idFind.Text = "찾기";
            this.btn_idFind.UseVisualStyleBackColor = false;
            this.btn_idFind.Click += new System.EventHandler(this.btn_idFind_Click);
            // 
            // rbtn_customer
            // 
            this.rbtn_customer.AutoSize = true;
            this.rbtn_customer.Font = new System.Drawing.Font("HY강M", 10F);
            this.rbtn_customer.Location = new System.Drawing.Point(65, 64);
            this.rbtn_customer.Name = "rbtn_customer";
            this.rbtn_customer.Size = new System.Drawing.Size(86, 18);
            this.rbtn_customer.TabIndex = 8;
            this.rbtn_customer.TabStop = true;
            this.rbtn_customer.Text = "개인 회원";
            this.rbtn_customer.UseVisualStyleBackColor = true;
            // 
            // rbtn_comcustomer
            // 
            this.rbtn_comcustomer.AutoSize = true;
            this.rbtn_comcustomer.Font = new System.Drawing.Font("HY강M", 10F);
            this.rbtn_comcustomer.Location = new System.Drawing.Point(225, 64);
            this.rbtn_comcustomer.Name = "rbtn_comcustomer";
            this.rbtn_comcustomer.Size = new System.Drawing.Size(86, 18);
            this.rbtn_comcustomer.TabIndex = 9;
            this.rbtn_comcustomer.TabStop = true;
            this.rbtn_comcustomer.Text = "기업 회원";
            this.rbtn_comcustomer.UseVisualStyleBackColor = true;
            // 
            // IDFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 448);
            this.Controls.Add(this.rbtn_comcustomer);
            this.Controls.Add(this.rbtn_customer);
            this.Controls.Add(this.btn_idFind);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IDFind";
            this.Text = "아이디 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_idFind;
        private System.Windows.Forms.RadioButton rbtn_customer;
        private System.Windows.Forms.RadioButton rbtn_comcustomer;
    }
}