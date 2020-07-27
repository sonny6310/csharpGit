namespace Login
{
    partial class Resume_LocationForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "지역 선택";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("HY강M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "서울 · 경기",
            "대구 · 경북",
            "부산 · 경남",
            "대전 · 충남",
            "강원",
            "인천",
            "광주 · 전남",
            "충북",
            "전북",
            "제주",
            "전국"});
            this.checkedListBox1.Location = new System.Drawing.Point(30, 52);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(155, 140);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Insert.Location = new System.Drawing.Point(128, 227);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(57, 23);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "입력";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(30, 199);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(155, 21);
            this.tb_location.TabIndex = 3;
            // 
            // Resume_LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 262);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Name = "Resume_LocationForm";
            this.Text = "Resume_LocationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox tb_location;
    }
}