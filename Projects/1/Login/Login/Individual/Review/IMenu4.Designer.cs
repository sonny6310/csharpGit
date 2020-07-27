namespace Login
{
    partial class IMenu4
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_rev_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_rev_comName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_rev_subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_rev_content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_rev_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_rev_rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_write_review = new System.Windows.Forms.Button();
            this.btn_show_rev_detail = new System.Windows.Forms.Button();
            this.btn_My_Review = new System.Windows.Forms.Button();
            this.btn_All_review = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_rev_num,
            this.col_rev_comName,
            this.col_rev_subject,
            this.col_rev_content,
            this.col_rev_date,
            this.col_rev_rate});
            this.listView1.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(35, 173);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(938, 432);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // col_rev_num
            // 
            this.col_rev_num.Text = "번호";
            this.col_rev_num.Width = 70;
            // 
            // col_rev_comName
            // 
            this.col_rev_comName.Text = "회사명";
            this.col_rev_comName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_rev_comName.Width = 150;
            // 
            // col_rev_subject
            // 
            this.col_rev_subject.Text = "제목";
            this.col_rev_subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_rev_subject.Width = 150;
            // 
            // col_rev_content
            // 
            this.col_rev_content.Text = "내용";
            this.col_rev_content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_rev_content.Width = 300;
            // 
            // col_rev_date
            // 
            this.col_rev_date.Text = "작성일자";
            this.col_rev_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_rev_date.Width = 150;
            // 
            // col_rev_rate
            // 
            this.col_rev_rate.Text = "평점";
            this.col_rev_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_rev_rate.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 20F);
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "후기";
            // 
            // btn_write_review
            // 
            this.btn_write_review.BackColor = System.Drawing.SystemColors.Control;
            this.btn_write_review.Font = new System.Drawing.Font("HY강M", 9F);
            this.btn_write_review.Location = new System.Drawing.Point(861, 130);
            this.btn_write_review.Name = "btn_write_review";
            this.btn_write_review.Size = new System.Drawing.Size(112, 36);
            this.btn_write_review.TabIndex = 10;
            this.btn_write_review.Text = "후기 작성";
            this.btn_write_review.UseVisualStyleBackColor = false;
            this.btn_write_review.Click += new System.EventHandler(this.btn_write_review_Click);
            // 
            // btn_show_rev_detail
            // 
            this.btn_show_rev_detail.BackColor = System.Drawing.SystemColors.Control;
            this.btn_show_rev_detail.Font = new System.Drawing.Font("HY강M", 9F);
            this.btn_show_rev_detail.Location = new System.Drawing.Point(730, 130);
            this.btn_show_rev_detail.Name = "btn_show_rev_detail";
            this.btn_show_rev_detail.Size = new System.Drawing.Size(112, 36);
            this.btn_show_rev_detail.TabIndex = 9;
            this.btn_show_rev_detail.Text = "자세히 보기";
            this.btn_show_rev_detail.UseVisualStyleBackColor = false;
            this.btn_show_rev_detail.Click += new System.EventHandler(this.btn_show_rev_detail_Click);
            // 
            // btn_My_Review
            // 
            this.btn_My_Review.BackColor = System.Drawing.SystemColors.Control;
            this.btn_My_Review.Font = new System.Drawing.Font("HY강M", 9F);
            this.btn_My_Review.Location = new System.Drawing.Point(153, 130);
            this.btn_My_Review.Name = "btn_My_Review";
            this.btn_My_Review.Size = new System.Drawing.Size(112, 36);
            this.btn_My_Review.TabIndex = 11;
            this.btn_My_Review.Text = "내가 쓴 글";
            this.btn_My_Review.UseVisualStyleBackColor = false;
            this.btn_My_Review.Click += new System.EventHandler(this.btn_My_Review_Click);
            // 
            // btn_All_review
            // 
            this.btn_All_review.BackColor = System.Drawing.SystemColors.Control;
            this.btn_All_review.Font = new System.Drawing.Font("HY강M", 9F);
            this.btn_All_review.Location = new System.Drawing.Point(35, 130);
            this.btn_All_review.Name = "btn_All_review";
            this.btn_All_review.Size = new System.Drawing.Size(112, 36);
            this.btn_All_review.TabIndex = 12;
            this.btn_All_review.Text = "전체보기";
            this.btn_All_review.UseVisualStyleBackColor = false;
            this.btn_All_review.Click += new System.EventHandler(this.btn_All_review_Click);
            // 
            // IMenu4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_All_review);
            this.Controls.Add(this.btn_My_Review);
            this.Controls.Add(this.btn_write_review);
            this.Controls.Add(this.btn_show_rev_detail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IMenu4";
            this.Size = new System.Drawing.Size(995, 634);
            this.Load += new System.EventHandler(this.IMenu4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_rev_num;
        private System.Windows.Forms.ColumnHeader col_rev_comName;
        private System.Windows.Forms.ColumnHeader col_rev_subject;
        private System.Windows.Forms.ColumnHeader col_rev_content;
        private System.Windows.Forms.ColumnHeader col_rev_date;
        private System.Windows.Forms.ColumnHeader col_rev_rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_write_review;
        private System.Windows.Forms.Button btn_show_rev_detail;
        private System.Windows.Forms.Button btn_My_Review;
        private System.Windows.Forms.Button btn_All_review;
    }
}
