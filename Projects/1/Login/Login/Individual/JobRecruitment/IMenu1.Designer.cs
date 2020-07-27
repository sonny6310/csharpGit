namespace Login
{
    partial class IMenu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMenu1));
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.recent_search_btn = new System.Windows.Forms.Button();
            this.pay_search_btn = new System.Windows.Forms.Button();
            this.count_search_btn = new System.Windows.Forms.Button();
            this.apply_search_btn = new System.Windows.Forms.Button();
            this.panelInit = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            this.panelInit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSearch.Controls.Add(this.textSearch);
            this.panelSearch.Location = new System.Drawing.Point(54, 41);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(536, 48);
            this.panelSearch.TabIndex = 0;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textSearch.Font = new System.Drawing.Font("HY강M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textSearch.ForeColor = System.Drawing.Color.Gray;
            this.textSearch.Location = new System.Drawing.Point(19, 12);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(463, 25);
            this.textSearch.TabIndex = 0;
            this.textSearch.Text = "   검색할내용을 입력하세요";
            this.textSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textSearch_MouseClick);
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            // 
            // recent_search_btn
            // 
            this.recent_search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.recent_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.recent_search_btn.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.recent_search_btn.ForeColor = System.Drawing.Color.White;
            this.recent_search_btn.Location = new System.Drawing.Point(3, 3);
            this.recent_search_btn.Name = "recent_search_btn";
            this.recent_search_btn.Size = new System.Drawing.Size(71, 28);
            this.recent_search_btn.TabIndex = 0;
            this.recent_search_btn.Text = "최신순";
            this.recent_search_btn.UseVisualStyleBackColor = false;
            this.recent_search_btn.Click += new System.EventHandler(this.recent_search_btn_Click);
            // 
            // pay_search_btn
            // 
            this.pay_search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.pay_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pay_search_btn.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_search_btn.ForeColor = System.Drawing.Color.Gray;
            this.pay_search_btn.Location = new System.Drawing.Point(108, 3);
            this.pay_search_btn.Name = "pay_search_btn";
            this.pay_search_btn.Size = new System.Drawing.Size(71, 28);
            this.pay_search_btn.TabIndex = 1;
            this.pay_search_btn.Text = "급여순";
            this.pay_search_btn.UseVisualStyleBackColor = false;
            this.pay_search_btn.Click += new System.EventHandler(this.pay_search_btn_Click);
            // 
            // count_search_btn
            // 
            this.count_search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.count_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.count_search_btn.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.count_search_btn.ForeColor = System.Drawing.Color.Gray;
            this.count_search_btn.Location = new System.Drawing.Point(217, 3);
            this.count_search_btn.Name = "count_search_btn";
            this.count_search_btn.Size = new System.Drawing.Size(71, 28);
            this.count_search_btn.TabIndex = 2;
            this.count_search_btn.Text = "조회순";
            this.count_search_btn.UseVisualStyleBackColor = false;
            this.count_search_btn.Click += new System.EventHandler(this.count_search_btn_Click);
            // 
            // apply_search_btn
            // 
            this.apply_search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.apply_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.apply_search_btn.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.apply_search_btn.ForeColor = System.Drawing.Color.Gray;
            this.apply_search_btn.Location = new System.Drawing.Point(326, 3);
            this.apply_search_btn.Name = "apply_search_btn";
            this.apply_search_btn.Size = new System.Drawing.Size(87, 28);
            this.apply_search_btn.TabIndex = 3;
            this.apply_search_btn.Text = "지원자순";
            this.apply_search_btn.UseVisualStyleBackColor = false;
            this.apply_search_btn.Click += new System.EventHandler(this.apply_search_btn_Click);
            // 
            // panelInit
            // 
            this.panelInit.Controls.Add(this.recent_search_btn);
            this.panelInit.Controls.Add(this.apply_search_btn);
            this.panelInit.Controls.Add(this.pay_search_btn);
            this.panelInit.Controls.Add(this.count_search_btn);
            this.panelInit.Location = new System.Drawing.Point(48, 109);
            this.panelInit.Name = "panelInit";
            this.panelInit.Size = new System.Drawing.Size(568, 37);
            this.panelInit.TabIndex = 4;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(48, 161);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(915, 447);
            this.flowLayoutPanel.TabIndex = 5;
            // 
            // refreshBtn
            // 
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.Location = new System.Drawing.Point(909, 34);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(54, 55);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(48, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(915, 2);
            this.label2.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(615, 53);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "button1";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // IMenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panelInit);
            this.Controls.Add(this.panelSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IMenu1";
            this.Size = new System.Drawing.Size(995, 635);
            this.Load += new System.EventHandler(this.IMenu1_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelInit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

            #endregion

            private System.Windows.Forms.Panel panelSearch;
            private System.Windows.Forms.TextBox textSearch;
            private System.Windows.Forms.Button recent_search_btn;
            private System.Windows.Forms.Button pay_search_btn;
            private System.Windows.Forms.Button count_search_btn;
            private System.Windows.Forms.Button apply_search_btn;
            private System.Windows.Forms.Panel panelInit;
            private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
            private System.Windows.Forms.Button refreshBtn;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Button btnOk;
      }
}
