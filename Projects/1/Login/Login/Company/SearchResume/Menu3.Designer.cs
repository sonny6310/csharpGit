namespace Login
{
    partial class Menu3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TWView = new System.Windows.Forms.Button();
            this.btn_SashView = new System.Windows.Forms.Button();
            this.btn_TileView = new System.Windows.Forms.Button();
            this.btn_GasView = new System.Windows.Forms.Button();
            this.btn_MoldView = new System.Windows.Forms.Button();
            this.btn_PipeView = new System.Windows.Forms.Button();
            this.btn_ElecView = new System.Windows.Forms.Button();
            this.btn_CptView = new System.Windows.Forms.Button();
            this.btn_AllView = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RESUMEInfo = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RESUMEInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(45, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 10);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(43, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "인재정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY강M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(48, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "좋은 인재를 찾아보세요";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_TWView);
            this.panel2.Controls.Add(this.btn_SashView);
            this.panel2.Controls.Add(this.btn_TileView);
            this.panel2.Controls.Add(this.btn_GasView);
            this.panel2.Controls.Add(this.btn_MoldView);
            this.panel2.Controls.Add(this.btn_PipeView);
            this.panel2.Controls.Add(this.btn_ElecView);
            this.panel2.Controls.Add(this.btn_CptView);
            this.panel2.Controls.Add(this.btn_AllView);
            this.panel2.Location = new System.Drawing.Point(45, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 58);
            this.panel2.TabIndex = 4;
            // 
            // btn_TWView
            // 
            this.btn_TWView.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TWView.Location = new System.Drawing.Point(723, 9);
            this.btn_TWView.Name = "btn_TWView";
            this.btn_TWView.Size = new System.Drawing.Size(65, 40);
            this.btn_TWView.TabIndex = 8;
            this.btn_TWView.Text = "일용직";
            this.btn_TWView.UseVisualStyleBackColor = true;
            this.btn_TWView.Click += new System.EventHandler(this.btn_TWView_Click);
            // 
            // btn_SashView
            // 
            this.btn_SashView.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SashView.Location = new System.Drawing.Point(631, 9);
            this.btn_SashView.Name = "btn_SashView";
            this.btn_SashView.Size = new System.Drawing.Size(65, 40);
            this.btn_SashView.TabIndex = 7;
            this.btn_SashView.Text = "새시";
            this.btn_SashView.UseVisualStyleBackColor = true;
            this.btn_SashView.Click += new System.EventHandler(this.btn_SashView_Click);
            // 
            // btn_TileView
            // 
            this.btn_TileView.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TileView.Location = new System.Drawing.Point(536, 9);
            this.btn_TileView.Name = "btn_TileView";
            this.btn_TileView.Size = new System.Drawing.Size(65, 40);
            this.btn_TileView.TabIndex = 6;
            this.btn_TileView.Text = "타일";
            this.btn_TileView.UseVisualStyleBackColor = true;
            this.btn_TileView.Click += new System.EventHandler(this.btn_TileView_Click);
            // 
            // btn_GasView
            // 
            this.btn_GasView.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GasView.Location = new System.Drawing.Point(443, 9);
            this.btn_GasView.Name = "btn_GasView";
            this.btn_GasView.Size = new System.Drawing.Size(65, 40);
            this.btn_GasView.TabIndex = 5;
            this.btn_GasView.Text = "가스";
            this.btn_GasView.UseVisualStyleBackColor = true;
            this.btn_GasView.Click += new System.EventHandler(this.btn_GasView_Click);
            // 
            // btn_MoldView
            // 
            this.btn_MoldView.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_MoldView.Location = new System.Drawing.Point(353, 9);
            this.btn_MoldView.Name = "btn_MoldView";
            this.btn_MoldView.Size = new System.Drawing.Size(65, 40);
            this.btn_MoldView.TabIndex = 4;
            this.btn_MoldView.Text = "몰딩";
            this.btn_MoldView.UseVisualStyleBackColor = true;
            this.btn_MoldView.Click += new System.EventHandler(this.btn_MoldView_Click);
            // 
            // btn_PipeView
            // 
            this.btn_PipeView.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_PipeView.Location = new System.Drawing.Point(264, 9);
            this.btn_PipeView.Name = "btn_PipeView";
            this.btn_PipeView.Size = new System.Drawing.Size(65, 40);
            this.btn_PipeView.TabIndex = 3;
            this.btn_PipeView.Text = "배관";
            this.btn_PipeView.UseVisualStyleBackColor = true;
            this.btn_PipeView.Click += new System.EventHandler(this.btn_PipeView_Click);
            // 
            // btn_ElecView
            // 
            this.btn_ElecView.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ElecView.Location = new System.Drawing.Point(182, 9);
            this.btn_ElecView.Name = "btn_ElecView";
            this.btn_ElecView.Size = new System.Drawing.Size(65, 40);
            this.btn_ElecView.TabIndex = 2;
            this.btn_ElecView.Text = "전기";
            this.btn_ElecView.UseVisualStyleBackColor = true;
            this.btn_ElecView.Click += new System.EventHandler(this.btn_ElecView_Click);
            // 
            // btn_CptView
            // 
            this.btn_CptView.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CptView.Location = new System.Drawing.Point(95, 9);
            this.btn_CptView.Name = "btn_CptView";
            this.btn_CptView.Size = new System.Drawing.Size(65, 40);
            this.btn_CptView.TabIndex = 1;
            this.btn_CptView.Text = "목공";
            this.btn_CptView.UseVisualStyleBackColor = true;
            this.btn_CptView.Click += new System.EventHandler(this.btn_CptView_Click);
            // 
            // btn_AllView
            // 
            this.btn_AllView.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_AllView.Location = new System.Drawing.Point(10, 9);
            this.btn_AllView.Name = "btn_AllView";
            this.btn_AllView.Size = new System.Drawing.Size(65, 40);
            this.btn_AllView.TabIndex = 0;
            this.btn_AllView.Text = "전체보기";
            this.btn_AllView.UseVisualStyleBackColor = true;
            this.btn_AllView.Click += new System.EventHandler(this.btn_AllView_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(45, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 12);
            this.panel3.TabIndex = 5;
            // 
            // RESUMEInfo
            // 
            this.RESUMEInfo.BackgroundColor = System.Drawing.Color.White;
            this.RESUMEInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RESUMEInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RESUMEInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RESUMEInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RESUMEInfo.ColumnHeadersVisible = false;
            this.RESUMEInfo.Location = new System.Drawing.Point(45, 320);
            this.RESUMEInfo.Name = "RESUMEInfo";
            this.RESUMEInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RESUMEInfo.RowHeadersVisible = false;
            this.RESUMEInfo.RowHeadersWidth = 51;
            this.RESUMEInfo.RowTemplate.Height = 23;
            this.RESUMEInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RESUMEInfo.Size = new System.Drawing.Size(900, 258);
            this.RESUMEInfo.TabIndex = 6;
            this.RESUMEInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RESUMEInfo_CellClick);
            this.RESUMEInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RESUMEInfo_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(814, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(45, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 10);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(45, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 28);
            this.panel5.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(835, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "지역";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(682, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "경력";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(356, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "제목";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(79, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "번호";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(837, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RESUMEInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Menu3";
            this.Size = new System.Drawing.Size(995, 635);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RESUMEInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TWView;
        private System.Windows.Forms.Button btn_SashView;
        private System.Windows.Forms.Button btn_TileView;
        private System.Windows.Forms.Button btn_GasView;
        private System.Windows.Forms.Button btn_MoldView;
        private System.Windows.Forms.Button btn_PipeView;
        private System.Windows.Forms.Button btn_ElecView;
        private System.Windows.Forms.Button btn_CptView;
        private System.Windows.Forms.Button btn_AllView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView RESUMEInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
