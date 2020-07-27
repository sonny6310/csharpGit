namespace PcrommV2
{
    partial class OrderItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelFdName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelFdName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(274, 40);
            this.panel1.TabIndex = 1;
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.Snow;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPrice.Location = new System.Drawing.Point(107, 2);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 36);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "가격";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Snow;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.Location = new System.Drawing.Point(238, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(212, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCount
            // 
            this.labelCount.BackColor = System.Drawing.Color.Snow;
            this.labelCount.Location = new System.Drawing.Point(182, 3);
            this.labelCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(30, 35);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "1";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(157, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "－";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFdName
            // 
            this.labelFdName.BackColor = System.Drawing.Color.Snow;
            this.labelFdName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFdName.Location = new System.Drawing.Point(2, 2);
            this.labelFdName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelFdName.Name = "labelFdName";
            this.labelFdName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelFdName.Size = new System.Drawing.Size(105, 36);
            this.labelFdName.TabIndex = 0;
            this.labelFdName.Text = "음식";
            this.labelFdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(274, 40);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFdName;
    }
}
