namespace manager
{
    partial class CtUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbcash = new System.Windows.Forms.Label();
            this.btDelivery = new System.Windows.Forms.Button();
            this.lbMemo = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPcNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.lbcash);
            this.panel2.Controls.Add(this.btDelivery);
            this.panel2.Controls.Add(this.lbMemo);
            this.panel2.Controls.Add(this.lbPayment);
            this.panel2.Controls.Add(this.lbMoney);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(455, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 148);
            this.panel2.TabIndex = 4;
            // 
            // lbcash
            // 
            this.lbcash.BackColor = System.Drawing.Color.Snow;
            this.lbcash.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbcash.Location = new System.Drawing.Point(261, 23);
            this.lbcash.Name = "lbcash";
            this.lbcash.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbcash.Size = new System.Drawing.Size(84, 23);
            this.lbcash.TabIndex = 7;
            this.lbcash.Text = "원";
            this.lbcash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btDelivery
            // 
            this.btDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.btDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelivery.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btDelivery.FlatAppearance.BorderSize = 0;
            this.btDelivery.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btDelivery.ForeColor = System.Drawing.Color.Snow;
            this.btDelivery.Image = global::manager.Properties.Resources.FoodIcon11;
            this.btDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelivery.Location = new System.Drawing.Point(243, 75);
            this.btDelivery.Name = "btDelivery";
            this.btDelivery.Padding = new System.Windows.Forms.Padding(5);
            this.btDelivery.Size = new System.Drawing.Size(102, 56);
            this.btDelivery.TabIndex = 6;
            this.btDelivery.Text = "전달";
            this.btDelivery.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btDelivery.UseVisualStyleBackColor = false;
            this.btDelivery.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMemo
            // 
            this.lbMemo.BackColor = System.Drawing.Color.Snow;
            this.lbMemo.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMemo.Location = new System.Drawing.Point(12, 72);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Padding = new System.Windows.Forms.Padding(5);
            this.lbMemo.Size = new System.Drawing.Size(210, 59);
            this.lbMemo.TabIndex = 5;
            this.lbMemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPayment
            // 
            this.lbPayment.BackColor = System.Drawing.Color.Snow;
            this.lbPayment.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPayment.Location = new System.Drawing.Point(156, 23);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbPayment.Size = new System.Drawing.Size(86, 23);
            this.lbPayment.TabIndex = 4;
            this.lbPayment.Text = "카드or현금";
            this.lbPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMoney
            // 
            this.lbMoney.BackColor = System.Drawing.Color.Snow;
            this.lbMoney.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMoney.Location = new System.Drawing.Point(12, 23);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbMoney.Size = new System.Drawing.Size(102, 23);
            this.lbMoney.TabIndex = 3;
            this.lbMoney.Text = "원";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(54, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "메모";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(189, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "결제 방법";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "총 금액";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lbPcNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 38);
            this.panel1.TabIndex = 3;
            // 
            // lbPcNum
            // 
            this.lbPcNum.BackColor = System.Drawing.Color.Snow;
            this.lbPcNum.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPcNum.ForeColor = System.Drawing.Color.Black;
            this.lbPcNum.Location = new System.Drawing.Point(73, 9);
            this.lbPcNum.Name = "lbPcNum";
            this.lbPcNum.Size = new System.Drawing.Size(73, 21);
            this.lbPcNum.TabIndex = 0;
            this.lbPcNum.Text = "1";
            this.lbPcNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PCNum";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Snow;
            this.lbTime.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTime.Location = new System.Drawing.Point(152, 9);
            this.lbTime.Name = "lbTime";
            this.lbTime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbTime.Size = new System.Drawing.Size(235, 21);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "hh:mm:ss";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 148);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(455, 120);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "메뉴";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "수량";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 28);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Count";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CtUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CtUser";
            this.Size = new System.Drawing.Size(811, 186);
            this.Load += new System.EventHandler(this.CtUser_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDelivery;
        private System.Windows.Forms.Label lbMemo;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPcNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcash;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
