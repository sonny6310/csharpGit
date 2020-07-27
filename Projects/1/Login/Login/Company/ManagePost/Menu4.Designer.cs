namespace Login
{
    partial class Menu4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu4));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_w_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_a_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_show_detail = new System.Windows.Forms.Button();
            this.btn_delete_post = new System.Windows.Forms.Button();
            this.btn_edit_detail = new System.Windows.Forms.Button();
            this.show_applier = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 20F);
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "내가 작성한 채용 공고";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_w_num,
            this.col_w_ID,
            this.col_w_subject,
            this.col_w_content,
            this.col_w_date,
            this.col_w_count,
            this.col_a_count});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 173);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(938, 432);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // col_w_num
            // 
            this.col_w_num.Text = "글 번호";
            this.col_w_num.Width = 70;
            // 
            // col_w_ID
            // 
            this.col_w_ID.Text = "ID";
            this.col_w_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_ID.Width = 100;
            // 
            // col_w_subject
            // 
            this.col_w_subject.Text = "제목";
            this.col_w_subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_subject.Width = 150;
            // 
            // col_w_content
            // 
            this.col_w_content.Text = "내용";
            this.col_w_content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_content.Width = 250;
            // 
            // col_w_date
            // 
            this.col_w_date.Text = "작성일자";
            this.col_w_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_date.Width = 150;
            // 
            // col_w_count
            // 
            this.col_w_count.Text = "조회수";
            this.col_w_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_count.Width = 100;
            // 
            // col_a_count
            // 
            this.col_a_count.Text = "지원자 수";
            this.col_a_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_a_count.Width = 94;
            // 
            // btn_show_detail
            // 
            this.btn_show_detail.BackColor = System.Drawing.SystemColors.Control;
            this.btn_show_detail.Font = new System.Drawing.Font("HY강M", 9F);
            this.btn_show_detail.Location = new System.Drawing.Point(602, 131);
            this.btn_show_detail.Name = "btn_show_detail";
            this.btn_show_detail.Size = new System.Drawing.Size(112, 36);
            this.btn_show_detail.TabIndex = 6;
            this.btn_show_detail.Text = "자세히 보기";
            this.btn_show_detail.UseVisualStyleBackColor = false;
            this.btn_show_detail.Click += new System.EventHandler(this.btn_show_detail_Click);
            // 
            // btn_delete_post
            // 
            this.btn_delete_post.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete_post.Font = new System.Drawing.Font("HY강M", 9F);
            this.btn_delete_post.Location = new System.Drawing.Point(861, 131);
            this.btn_delete_post.Name = "btn_delete_post";
            this.btn_delete_post.Size = new System.Drawing.Size(112, 36);
            this.btn_delete_post.TabIndex = 7;
            this.btn_delete_post.Text = "공고 삭제";
            this.btn_delete_post.UseVisualStyleBackColor = false;
            this.btn_delete_post.Click += new System.EventHandler(this.btn_delete_post_Click);
            // 
            // btn_edit_detail
            // 
            this.btn_edit_detail.BackColor = System.Drawing.SystemColors.Control;
            this.btn_edit_detail.Font = new System.Drawing.Font("HY강M", 9F);
            this.btn_edit_detail.Location = new System.Drawing.Point(733, 131);
            this.btn_edit_detail.Name = "btn_edit_detail";
            this.btn_edit_detail.Size = new System.Drawing.Size(112, 36);
            this.btn_edit_detail.TabIndex = 8;
            this.btn_edit_detail.Text = "공고 수정";
            this.btn_edit_detail.UseVisualStyleBackColor = false;
            this.btn_edit_detail.Click += new System.EventHandler(this.btn_edit_detail_Click);
            // 
            // show_applier
            // 
            this.show_applier.BackColor = System.Drawing.SystemColors.Control;
            this.show_applier.Font = new System.Drawing.Font("HY강M", 9F);
            this.show_applier.Location = new System.Drawing.Point(733, 75);
            this.show_applier.Name = "show_applier";
            this.show_applier.Size = new System.Drawing.Size(240, 38);
            this.show_applier.TabIndex = 13;
            this.show_applier.Text = "해당 공고 지원자 보기";
            this.show_applier.UseVisualStyleBackColor = false;
            this.show_applier.Click += new System.EventHandler(this.show_applier_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(936, 22);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(37, 39);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Menu4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.show_applier);
            this.Controls.Add(this.btn_edit_detail);
            this.Controls.Add(this.btn_delete_post);
            this.Controls.Add(this.btn_show_detail);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Menu4";
            this.Size = new System.Drawing.Size(995, 635);
            this.Load += new System.EventHandler(this.Menu4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader col_w_num;
        private System.Windows.Forms.ColumnHeader col_w_ID;
        private System.Windows.Forms.ColumnHeader col_w_subject;
        private System.Windows.Forms.ColumnHeader col_w_content;
        private System.Windows.Forms.ColumnHeader col_w_date;
        private System.Windows.Forms.ColumnHeader col_w_count;
        private System.Windows.Forms.Button btn_show_detail;
        private System.Windows.Forms.Button btn_delete_post;
        private System.Windows.Forms.Button btn_edit_detail;
        private System.Windows.Forms.ColumnHeader col_a_count;
        private System.Windows.Forms.Button show_applier;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_refresh;
    }
}
