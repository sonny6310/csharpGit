namespace UserControlForm
{
    partial class Menu1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_writer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_select);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 57);
            this.panel1.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(448, 6);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(89, 45);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(353, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 45);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(258, 6);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(89, 45);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(163, 6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 45);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(68, 6);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(89, 45);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 382);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(163, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(382, 382);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(382, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_content);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_pw);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_subject);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_writer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 382);
            this.panel3.TabIndex = 0;
            // 
            // txt_content
            // 
            this.txt_content.Enabled = false;
            this.txt_content.Location = new System.Drawing.Point(6, 234);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(151, 131);
            this.txt_content.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "내용";
            // 
            // txt_pw
            // 
            this.txt_pw.Enabled = false;
            this.txt_pw.Location = new System.Drawing.Point(6, 187);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(151, 21);
            this.txt_pw.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "패스워드";
            // 
            // txt_subject
            // 
            this.txt_subject.Enabled = false;
            this.txt_subject.Location = new System.Drawing.Point(3, 139);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(151, 21);
            this.txt_subject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "제목";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(6, 92);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(151, 21);
            this.txt_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "이메일";
            // 
            // txt_writer
            // 
            this.txt_writer.Enabled = false;
            this.txt_writer.Location = new System.Drawing.Point(6, 43);
            this.txt_writer.Name = "txt_writer";
            this.txt_writer.Size = new System.Drawing.Size(151, 21);
            this.txt_writer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "작성자";
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu1";
            this.Size = new System.Drawing.Size(545, 439);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_writer;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
    }
}
