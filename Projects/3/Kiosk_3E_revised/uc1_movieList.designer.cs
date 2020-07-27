namespace KIOSK_v1
{
    partial class uc1_movieList
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
            this.choiceByTime = new System.Windows.Forms.TabPage();
            this.choiceByMovie = new System.Windows.Forms.TabPage();
            this.selectRound = new System.Windows.Forms.Label();
            this.quarterPanel = new System.Windows.Forms.Panel();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.selectTab = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.stackPanel = new System.Windows.Forms.Panel();
            this.choiceByTime.SuspendLayout();
            this.choiceByMovie.SuspendLayout();
            this.selectTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // choiceByTime
            // 
            this.choiceByTime.Controls.Add(this.stackPanel);
            this.choiceByTime.Controls.Add(this.label1);
            this.choiceByTime.Location = new System.Drawing.Point(4, 34);
            this.choiceByTime.Margin = new System.Windows.Forms.Padding(0);
            this.choiceByTime.Name = "choiceByTime";
            this.choiceByTime.Size = new System.Drawing.Size(376, 583);
            this.choiceByTime.TabIndex = 1;
            this.choiceByTime.Text = "시간대별 선택";
            this.choiceByTime.UseVisualStyleBackColor = true;
            // 
            // choiceByMovie
            // 
            this.choiceByMovie.Controls.Add(this.selectRound);
            this.choiceByMovie.Controls.Add(this.quarterPanel);
            this.choiceByMovie.Controls.Add(this.slidePanel);
            this.choiceByMovie.Location = new System.Drawing.Point(4, 34);
            this.choiceByMovie.Name = "choiceByMovie";
            this.choiceByMovie.Padding = new System.Windows.Forms.Padding(3);
            this.choiceByMovie.Size = new System.Drawing.Size(376, 583);
            this.choiceByMovie.TabIndex = 0;
            this.choiceByMovie.Text = "영화별 선택";
            this.choiceByMovie.UseVisualStyleBackColor = true;
            // 
            // selectRound
            // 
            this.selectRound.AutoSize = true;
            this.selectRound.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectRound.Location = new System.Drawing.Point(18, 15);
            this.selectRound.Name = "selectRound";
            this.selectRound.Size = new System.Drawing.Size(195, 25);
            this.selectRound.TabIndex = 52;
            this.selectRound.Text = "영화를 선택해주세요.";
            this.selectRound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quarterPanel
            // 
            this.quarterPanel.AutoScroll = true;
            this.quarterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quarterPanel.Location = new System.Drawing.Point(3, 54);
            this.quarterPanel.Name = "quarterPanel";
            this.quarterPanel.Size = new System.Drawing.Size(370, 526);
            this.quarterPanel.TabIndex = 51;
            // 
            // slidePanel
            // 
            this.slidePanel.Location = new System.Drawing.Point(236, 17);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(119, 20);
            this.slidePanel.TabIndex = 50;
            // 
            // selectTab
            // 
            this.selectTab.Controls.Add(this.choiceByMovie);
            this.selectTab.Controls.Add(this.choiceByTime);
            this.selectTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectTab.ItemSize = new System.Drawing.Size(190, 30);
            this.selectTab.Location = new System.Drawing.Point(0, 0);
            this.selectTab.Margin = new System.Windows.Forms.Padding(0);
            this.selectTab.Name = "selectTab";
            this.selectTab.Padding = new System.Drawing.Point(3, 3);
            this.selectTab.SelectedIndex = 0;
            this.selectTab.Size = new System.Drawing.Size(384, 621);
            this.selectTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.selectTab.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "영화를 선택해주세요.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stackPanel
            // 
            this.stackPanel.AutoScroll = true;
            this.stackPanel.Location = new System.Drawing.Point(3, 54);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(370, 526);
            this.stackPanel.TabIndex = 54;
            // 
            // uc1_movieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectTab);
            this.Name = "uc1_movieList";
            this.Size = new System.Drawing.Size(384, 621);
            this.choiceByTime.ResumeLayout(false);
            this.choiceByTime.PerformLayout();
            this.choiceByMovie.ResumeLayout(false);
            this.choiceByMovie.PerformLayout();
            this.selectTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage choiceByTime;
        private System.Windows.Forms.TabPage choiceByMovie;
        private System.Windows.Forms.TabControl selectTab;
        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Panel quarterPanel;
        private System.Windows.Forms.Label selectRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel stackPanel;
    }
}
