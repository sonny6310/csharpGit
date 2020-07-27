namespace manager
{
    partial class update
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_name2 = new System.Windows.Forms.TextBox();
            this.update_price2 = new System.Windows.Forms.TextBox();
            this.update_name = new System.Windows.Forms.TextBox();
            this.update_price = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.search_Menu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_menu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topP_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topP_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(551, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "제품수정/삭제";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delete_button);
            this.panel2.Controls.Add(this.update_name2);
            this.panel2.Controls.Add(this.update_price2);
            this.panel2.Controls.Add(this.update_name);
            this.panel2.Controls.Add(this.update_price);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.search_Menu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.combobox_menu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.update_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(-393, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 303);
            this.panel2.TabIndex = 1;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(920, 207);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(127, 47);
            this.delete_button.TabIndex = 15;
            this.delete_button.Text = "선택한 제품 삭제";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_name2
            // 
            this.update_name2.ForeColor = System.Drawing.Color.Gray;
            this.update_name2.Location = new System.Drawing.Point(925, 140);
            this.update_name2.Name = "update_name2";
            this.update_name2.Size = new System.Drawing.Size(119, 21);
            this.update_name2.TabIndex = 4;
            this.update_name2.Text = "이름 변경";
            this.update_name2.Click += new System.EventHandler(this.update_name2_Click);
            // 
            // update_price2
            // 
            this.update_price2.ForeColor = System.Drawing.Color.Gray;
            this.update_price2.Location = new System.Drawing.Point(925, 170);
            this.update_price2.Name = "update_price2";
            this.update_price2.Size = new System.Drawing.Size(119, 21);
            this.update_price2.TabIndex = 5;
            this.update_price2.Text = "가격 변경";
            this.update_price2.Click += new System.EventHandler(this.update_price2_Click);
            this.update_price2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // update_name
            // 
            this.update_name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.update_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_name.Location = new System.Drawing.Point(811, 140);
            this.update_name.Name = "update_name";
            this.update_name.ReadOnly = true;
            this.update_name.Size = new System.Drawing.Size(106, 21);
            this.update_name.TabIndex = 14;
            this.update_name.Text = "변경할 제품이름";
            // 
            // update_price
            // 
            this.update_price.BackColor = System.Drawing.SystemColors.ControlDark;
            this.update_price.ForeColor = System.Drawing.Color.White;
            this.update_price.Location = new System.Drawing.Point(811, 170);
            this.update_price.Name = "update_price";
            this.update_price.ReadOnly = true;
            this.update_price.Size = new System.Drawing.Size(106, 21);
            this.update_price.TabIndex = 13;
            this.update_price.Text = "변경할 제품가격";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(963, 20);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(80, 107);
            this.search.TabIndex = 3;
            this.search.Text = "검색";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_Menu
            // 
            this.search_Menu.Location = new System.Drawing.Point(810, 103);
            this.search_Menu.Name = "search_Menu";
            this.search_Menu.Size = new System.Drawing.Size(138, 21);
            this.search_Menu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(839, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "이름으로 검색";
            // 
            // combobox_menu
            // 
            this.combobox_menu.FormattingEnabled = true;
            this.combobox_menu.Items.AddRange(new object[] {
            "전체보기",
            "면류",
            "디저트",
            "밥류",
            "음료류",
            "카페"});
            this.combobox_menu.Location = new System.Drawing.Point(810, 48);
            this.combobox_menu.Name = "combobox_menu";
            this.combobox_menu.Size = new System.Drawing.Size(138, 20);
            this.combobox_menu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "분류 선택";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(808, 267);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(239, 26);
            this.close_button.TabIndex = 7;
            this.close_button.Text = "취소";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(808, 209);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(103, 45);
            this.update_button.TabIndex = 6;
            this.update_button.Text = "수정";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 303);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(409, 274);
            this.panel5.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(409, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 29);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(322, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(102, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "메뉴 이름";
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 333);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_menu;
        private System.Windows.Forms.TextBox search_Menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox update_name;
        private System.Windows.Forms.TextBox update_price;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox update_name2;
        private System.Windows.Forms.TextBox update_price2;
        private System.Windows.Forms.Button delete_button;
    }
}