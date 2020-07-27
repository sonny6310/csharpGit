namespace Login
{
    partial class Resume_License
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
            this.tb_License = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_License
            // 
            this.tb_License.Location = new System.Drawing.Point(36, 201);
            this.tb_License.Name = "tb_License";
            this.tb_License.Size = new System.Drawing.Size(208, 21);
            this.tb_License.TabIndex = 7;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Insert.Location = new System.Drawing.Point(187, 228);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(57, 23);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "입력";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Font = new System.Drawing.Font("HY강M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "목공예 기능사",
            "가구제작 기능사",
            "건축목공 기능사",
            "간축목공 산업기사",
            "건축목재시공 기능장",
            "에너지관리 기능사",
            "온수온돌 기능사",
            "가스 기능사",
            "배관 기능사",
            "건축설비 기사",
            "건축설비 산업기사",
            "용접 기능사",
            "금속재창호 기능사",
            "플라스틱창호 기능사",
            "철근 기능사",
            "표면처리 기능사",
            "건축전기설비 기술사",
            "전기공사 기사",
            "석공 기사",
            "토목 기사",
            "기타(자기소개에 적으세요)"});
            this.checkedListBox2.Location = new System.Drawing.Point(36, 54);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(208, 140);
            this.checkedListBox2.TabIndex = 5;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "자격증 선택";
            // 
            // Resume_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 277);
            this.Controls.Add(this.tb_License);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label1);
            this.Name = "Resume_License";
            this.Text = "Resume_LicenseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_License;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label1;
    }
}