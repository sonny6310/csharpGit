namespace Login
{
    partial class Menu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_search = new System.Windows.Forms.Panel();
            this.btn_search = new Login.Recruit.CircularButton();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.W_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_PLACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_END_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_allSearch = new System.Windows.Forms.Button();
            this.btn_comSearch = new System.Windows.Forms.Button();
            this.btn_subjectSearch = new System.Windows.Forms.Button();
            this.btn_countSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_paySearch = new System.Windows.Forms.Button();
            this.btn_w_placeSearch = new System.Windows.Forms.Button();
            this.btn_w_end_timeSearch = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.panel_search.Controls.Add(this.btn_search);
            this.panel_search.Controls.Add(this.tb_search);
            this.panel_search.Location = new System.Drawing.Point(124, 18);
            this.panel_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(748, 64);
            this.panel_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(28, 10);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(46, 46);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Font = new System.Drawing.Font("HY강M", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_search.ForeColor = System.Drawing.Color.White;
            this.tb_search.Location = new System.Drawing.Point(98, 22);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(621, 22);
            this.tb_search.TabIndex = 0;
            this.tb_search.Text = "검색 할 내용을 입력하세요";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.W_NUM,
            this.COM_NAME,
            this.SUBJECT,
            this.PAY,
            this.W_PLACE,
            this.W_END_TIME,
            this.COUNT});
            this.dataGridView1.Location = new System.Drawing.Point(35, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(938, 425);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // W_NUM
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.W_NUM.DefaultCellStyle = dataGridViewCellStyle3;
            this.W_NUM.FillWeight = 35F;
            this.W_NUM.HeaderText = "글번호";
            this.W_NUM.MinimumWidth = 6;
            this.W_NUM.Name = "W_NUM";
            this.W_NUM.ReadOnly = true;
            // 
            // COM_NAME
            // 
            this.COM_NAME.FillWeight = 70F;
            this.COM_NAME.HeaderText = "업체명";
            this.COM_NAME.MinimumWidth = 6;
            this.COM_NAME.Name = "COM_NAME";
            this.COM_NAME.ReadOnly = true;
            // 
            // SUBJECT
            // 
            this.SUBJECT.FillWeight = 150F;
            this.SUBJECT.HeaderText = "제목";
            this.SUBJECT.MinimumWidth = 6;
            this.SUBJECT.Name = "SUBJECT";
            this.SUBJECT.ReadOnly = true;
            // 
            // PAY
            // 
            this.PAY.FillWeight = 50F;
            this.PAY.HeaderText = "급여";
            this.PAY.MinimumWidth = 6;
            this.PAY.Name = "PAY";
            this.PAY.ReadOnly = true;
            // 
            // W_PLACE
            // 
            this.W_PLACE.FillWeight = 50F;
            this.W_PLACE.HeaderText = "근무지";
            this.W_PLACE.MinimumWidth = 6;
            this.W_PLACE.Name = "W_PLACE";
            this.W_PLACE.ReadOnly = true;
            // 
            // W_END_TIME
            // 
            this.W_END_TIME.FillWeight = 35F;
            this.W_END_TIME.HeaderText = "마감일";
            this.W_END_TIME.MinimumWidth = 6;
            this.W_END_TIME.Name = "W_END_TIME";
            this.W_END_TIME.ReadOnly = true;
            // 
            // COUNT
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.COUNT.DefaultCellStyle = dataGridViewCellStyle4;
            this.COUNT.FillWeight = 35F;
            this.COUNT.HeaderText = "조회수";
            this.COUNT.MinimumWidth = 6;
            this.COUNT.Name = "COUNT";
            this.COUNT.ReadOnly = true;
            // 
            // btn_allSearch
            // 
            this.btn_allSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.btn_allSearch.FlatAppearance.BorderSize = 0;
            this.btn_allSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allSearch.Font = new System.Drawing.Font("HY강M", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_allSearch.ForeColor = System.Drawing.Color.White;
            this.btn_allSearch.Location = new System.Drawing.Point(144, 94);
            this.btn_allSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_allSearch.Name = "btn_allSearch";
            this.btn_allSearch.Size = new System.Drawing.Size(94, 39);
            this.btn_allSearch.TabIndex = 2;
            this.btn_allSearch.Text = "전체글";
            this.btn_allSearch.UseVisualStyleBackColor = false;
            this.btn_allSearch.Click += new System.EventHandler(this.btn_allSearch_Click);
            // 
            // btn_comSearch
            // 
            this.btn_comSearch.BackColor = System.Drawing.Color.White;
            this.btn_comSearch.FlatAppearance.BorderSize = 0;
            this.btn_comSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comSearch.Font = new System.Drawing.Font("HY강M", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_comSearch.ForeColor = System.Drawing.Color.Gray;
            this.btn_comSearch.Location = new System.Drawing.Point(242, 94);
            this.btn_comSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_comSearch.Name = "btn_comSearch";
            this.btn_comSearch.Size = new System.Drawing.Size(94, 39);
            this.btn_comSearch.TabIndex = 2;
            this.btn_comSearch.Text = "기업명";
            this.btn_comSearch.UseVisualStyleBackColor = false;
            this.btn_comSearch.Click += new System.EventHandler(this.btn_comSearch_Click);
            // 
            // btn_subjectSearch
            // 
            this.btn_subjectSearch.BackColor = System.Drawing.Color.White;
            this.btn_subjectSearch.FlatAppearance.BorderSize = 0;
            this.btn_subjectSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subjectSearch.Font = new System.Drawing.Font("HY강M", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_subjectSearch.ForeColor = System.Drawing.Color.Gray;
            this.btn_subjectSearch.Location = new System.Drawing.Point(342, 94);
            this.btn_subjectSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_subjectSearch.Name = "btn_subjectSearch";
            this.btn_subjectSearch.Size = new System.Drawing.Size(94, 39);
            this.btn_subjectSearch.TabIndex = 2;
            this.btn_subjectSearch.Text = "제목";
            this.btn_subjectSearch.UseVisualStyleBackColor = false;
            this.btn_subjectSearch.Click += new System.EventHandler(this.btn_subjectSearch_Click);
            // 
            // btn_countSearch
            // 
            this.btn_countSearch.BackColor = System.Drawing.Color.White;
            this.btn_countSearch.FlatAppearance.BorderSize = 0;
            this.btn_countSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_countSearch.Font = new System.Drawing.Font("HY강M", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_countSearch.ForeColor = System.Drawing.Color.Gray;
            this.btn_countSearch.Location = new System.Drawing.Point(738, 94);
            this.btn_countSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_countSearch.Name = "btn_countSearch";
            this.btn_countSearch.Size = new System.Drawing.Size(94, 39);
            this.btn_countSearch.TabIndex = 2;
            this.btn_countSearch.Text = "조회수";
            this.btn_countSearch.UseVisualStyleBackColor = false;
            this.btn_countSearch.Click += new System.EventHandler(this.btn_countSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "글번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(104, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "기업명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(292, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "제목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.label4.Location = new System.Drawing.Point(565, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "급여";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.label5.Location = new System.Drawing.Point(683, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "근무지";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.label6.Location = new System.Drawing.Point(782, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "마감일";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.label7.Location = new System.Drawing.Point(867, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "조회수";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 36);
            this.panel1.TabIndex = 4;
            // 
            // btn_paySearch
            // 
            this.btn_paySearch.BackColor = System.Drawing.Color.White;
            this.btn_paySearch.FlatAppearance.BorderSize = 0;
            this.btn_paySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paySearch.Font = new System.Drawing.Font("HY강M", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_paySearch.ForeColor = System.Drawing.Color.Gray;
            this.btn_paySearch.Location = new System.Drawing.Point(441, 94);
            this.btn_paySearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_paySearch.Name = "btn_paySearch";
            this.btn_paySearch.Size = new System.Drawing.Size(94, 39);
            this.btn_paySearch.TabIndex = 2;
            this.btn_paySearch.Text = "급여";
            this.btn_paySearch.UseVisualStyleBackColor = false;
            this.btn_paySearch.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_w_placeSearch
            // 
            this.btn_w_placeSearch.BackColor = System.Drawing.Color.White;
            this.btn_w_placeSearch.FlatAppearance.BorderSize = 0;
            this.btn_w_placeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w_placeSearch.Font = new System.Drawing.Font("HY강M", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_w_placeSearch.ForeColor = System.Drawing.Color.Gray;
            this.btn_w_placeSearch.Location = new System.Drawing.Point(540, 94);
            this.btn_w_placeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_w_placeSearch.Name = "btn_w_placeSearch";
            this.btn_w_placeSearch.Size = new System.Drawing.Size(94, 39);
            this.btn_w_placeSearch.TabIndex = 2;
            this.btn_w_placeSearch.Text = "근무지";
            this.btn_w_placeSearch.UseVisualStyleBackColor = false;
            this.btn_w_placeSearch.Click += new System.EventHandler(this.btn_w_place_Click);
            // 
            // btn_w_end_timeSearch
            // 
            this.btn_w_end_timeSearch.BackColor = System.Drawing.Color.White;
            this.btn_w_end_timeSearch.FlatAppearance.BorderSize = 0;
            this.btn_w_end_timeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_w_end_timeSearch.Font = new System.Drawing.Font("HY강M", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_w_end_timeSearch.ForeColor = System.Drawing.Color.Gray;
            this.btn_w_end_timeSearch.Location = new System.Drawing.Point(639, 94);
            this.btn_w_end_timeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_w_end_timeSearch.Name = "btn_w_end_timeSearch";
            this.btn_w_end_timeSearch.Size = new System.Drawing.Size(94, 39);
            this.btn_w_end_timeSearch.TabIndex = 2;
            this.btn_w_end_timeSearch.Text = "마감일";
            this.btn_w_end_timeSearch.UseVisualStyleBackColor = false;
            this.btn_w_end_timeSearch.Click += new System.EventHandler(this.btn_w_end_time_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(928, 94);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(37, 39);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_countSearch);
            this.Controls.Add(this.btn_w_end_timeSearch);
            this.Controls.Add(this.btn_w_placeSearch);
            this.Controls.Add(this.btn_paySearch);
            this.Controls.Add(this.btn_subjectSearch);
            this.Controls.Add(this.btn_comSearch);
            this.Controls.Add(this.btn_allSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_search);
            this.Name = "Menu2";
            this.Size = new System.Drawing.Size(995, 634);
            this.Load += new System.EventHandler(this.Menu2_Load);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_allSearch;
        private System.Windows.Forms.Button btn_comSearch;
        private System.Windows.Forms.Button btn_subjectSearch;
        private System.Windows.Forms.Button btn_countSearch;
        private Recruit.CircularButton btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_paySearch;
        private System.Windows.Forms.Button btn_w_placeSearch;
        private System.Windows.Forms.Button btn_w_end_timeSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_PLACE;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_END_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNT;
        private System.Windows.Forms.Button btn_refresh;
    }
}
