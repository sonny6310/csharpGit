namespace Login
{
    partial class ComManage
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tb_star_pt = new System.Windows.Forms.TextBox();
            this.tb_ap_count = new System.Windows.Forms.TextBox();
            this.tb_sales = new System.Windows.Forms.TextBox();
            this.tb_com_tel = new System.Windows.Forms.TextBox();
            this.tb_field = new System.Windows.Forms.TextBox();
            this.tb_com_addr = new System.Windows.Forms.TextBox();
            this.tb_com_name = new System.Windows.Forms.TextBox();
            this.tb_com_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.COM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COM_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(398, 26);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(211, 25);
            this.tb_search.TabIndex = 27;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(901, 16);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 44);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(825, 16);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(69, 44);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "수정";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(674, 16);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(69, 44);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "초기화";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(616, 21);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(53, 34);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(750, 16);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(69, 44);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "등록";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tb_star_pt
            // 
            this.tb_star_pt.Location = new System.Drawing.Point(542, 621);
            this.tb_star_pt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_star_pt.Multiline = true;
            this.tb_star_pt.Name = "tb_star_pt";
            this.tb_star_pt.Size = new System.Drawing.Size(93, 42);
            this.tb_star_pt.TabIndex = 7;
            // 
            // tb_ap_count
            // 
            this.tb_ap_count.Location = new System.Drawing.Point(542, 552);
            this.tb_ap_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ap_count.Multiline = true;
            this.tb_ap_count.Name = "tb_ap_count";
            this.tb_ap_count.Size = new System.Drawing.Size(226, 42);
            this.tb_ap_count.TabIndex = 6;
            // 
            // tb_sales
            // 
            this.tb_sales.Location = new System.Drawing.Point(542, 479);
            this.tb_sales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_sales.Multiline = true;
            this.tb_sales.Name = "tb_sales";
            this.tb_sales.Size = new System.Drawing.Size(379, 42);
            this.tb_sales.TabIndex = 5;
            // 
            // tb_com_tel
            // 
            this.tb_com_tel.Location = new System.Drawing.Point(542, 399);
            this.tb_com_tel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_com_tel.Multiline = true;
            this.tb_com_tel.Name = "tb_com_tel";
            this.tb_com_tel.Size = new System.Drawing.Size(379, 42);
            this.tb_com_tel.TabIndex = 4;
            // 
            // tb_field
            // 
            this.tb_field.Location = new System.Drawing.Point(542, 315);
            this.tb_field.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_field.Multiline = true;
            this.tb_field.Name = "tb_field";
            this.tb_field.Size = new System.Drawing.Size(379, 42);
            this.tb_field.TabIndex = 3;
            // 
            // tb_com_addr
            // 
            this.tb_com_addr.Location = new System.Drawing.Point(542, 234);
            this.tb_com_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_com_addr.Multiline = true;
            this.tb_com_addr.Name = "tb_com_addr";
            this.tb_com_addr.Size = new System.Drawing.Size(428, 42);
            this.tb_com_addr.TabIndex = 2;
            // 
            // tb_com_name
            // 
            this.tb_com_name.Location = new System.Drawing.Point(542, 165);
            this.tb_com_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_com_name.Multiline = true;
            this.tb_com_name.Name = "tb_com_name";
            this.tb_com_name.Size = new System.Drawing.Size(428, 42);
            this.tb_com_name.TabIndex = 1;
            // 
            // tb_com_num
            // 
            this.tb_com_num.Location = new System.Drawing.Point(542, 90);
            this.tb_com_num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_com_num.Multiline = true;
            this.tb_com_num.Name = "tb_com_num";
            this.tb_com_num.Size = new System.Drawing.Size(226, 35);
            this.tb_com_num.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(393, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "7.지원자수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(393, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "6.매출";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(393, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "5.전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(393, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "4.직종";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(393, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "3.주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(393, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "2.회사명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(393, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "1.사업자번호";
            // 
            // COM_NAME
            // 
            this.COM_NAME.HeaderText = "회사명";
            this.COM_NAME.MinimumWidth = 6;
            this.COM_NAME.Name = "COM_NAME";
            this.COM_NAME.ReadOnly = true;
            // 
            // COM_NUM
            // 
            this.COM_NUM.FillWeight = 60F;
            this.COM_NUM.HeaderText = "사업자번호";
            this.COM_NUM.MinimumWidth = 6;
            this.COM_NUM.Name = "COM_NUM";
            this.COM_NUM.ReadOnly = true;
            // 
            // num
            // 
            this.num.FillWeight = 30F;
            this.num.HeaderText = "NUM";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(393, 621);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "8.평점";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.COM_NUM,
            this.COM_NAME});
            this.dataGridView1.Location = new System.Drawing.Point(13, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(358, 658);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(13, 10);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(358, 32);
            this.btn_refresh.TabIndex = 28;
            this.btn_refresh.Text = "전체글새로고침";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // ComManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 722);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_star_pt);
            this.Controls.Add(this.tb_ap_count);
            this.Controls.Add(this.tb_sales);
            this.Controls.Add(this.tb_com_tel);
            this.Controls.Add(this.tb_field);
            this.Controls.Add(this.tb_com_addr);
            this.Controls.Add(this.tb_com_name);
            this.Controls.Add(this.tb_com_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComManage";
            this.Text = "ComManage";
            this.Load += new System.EventHandler(this.ComManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox tb_star_pt;
        private System.Windows.Forms.TextBox tb_ap_count;
        private System.Windows.Forms.TextBox tb_sales;
        private System.Windows.Forms.TextBox tb_com_tel;
        private System.Windows.Forms.TextBox tb_field;
        private System.Windows.Forms.TextBox tb_com_addr;
        private System.Windows.Forms.TextBox tb_com_name;
        private System.Windows.Forms.TextBox tb_com_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_refresh;
    }
}