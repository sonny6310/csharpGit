namespace Login.Individual.Review
{
    partial class Select_Review_for_Writing
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_comname = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_com_field = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 20F);
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "내가 지원한 공고";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.SystemColors.Control;
            this.btn_select.Font = new System.Drawing.Font("HY강M", 9F);
            this.btn_select.Location = new System.Drawing.Point(42, 179);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(112, 36);
            this.btn_select.TabIndex = 10;
            this.btn_select.Text = "이 공고 선택";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Font = new System.Drawing.Font("HY강M", 9F);
            this.btn_cancel.Location = new System.Drawing.Point(202, 179);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 36);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "취소하기";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY강M", 13F);
            this.label2.Location = new System.Drawing.Point(36, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "선택한 공고";
            // 
            // label_comname
            // 
            this.label_comname.AutoSize = true;
            this.label_comname.Font = new System.Drawing.Font("HY강M", 9F);
            this.label_comname.Location = new System.Drawing.Point(178, 117);
            this.label_comname.Name = "label_comname";
            this.label_comname.Size = new System.Drawing.Size(9, 12);
            this.label_comname.TabIndex = 13;
            this.label_comname.Text = "-";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(102, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 20);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY강M", 10F);
            this.label3.Location = new System.Drawing.Point(39, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "기업명 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HY강M", 10F);
            this.label4.Location = new System.Drawing.Point(39, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "직종 : ";
            // 
            // label_com_field
            // 
            this.label_com_field.AutoSize = true;
            this.label_com_field.Font = new System.Drawing.Font("HY강M", 9F);
            this.label_com_field.Location = new System.Drawing.Point(178, 146);
            this.label_com_field.Name = "label_com_field";
            this.label_com_field.Size = new System.Drawing.Size(9, 12);
            this.label_com_field.TabIndex = 17;
            this.label_com_field.Text = "-";
            // 
            // Select_Review_for_Writing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(386, 241);
            this.Controls.Add(this.label_com_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label_comname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Select_Review_for_Writing";
            this.Text = "후기 남길 글 선택";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_comname;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_com_field;
    }
}