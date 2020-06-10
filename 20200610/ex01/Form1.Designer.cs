namespace ex01
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Font = new System.Windows.Forms.ComboBox();
            this.check_Bold = new System.Windows.Forms.CheckBox();
            this.check_Italic = new System.Windows.Forms.CheckBox();
            this.textBox_FontTest = new System.Windows.Forms.TextBox();
            this.trackBar_Dummy = new System.Windows.Forms.TrackBar();
            this.progressBar_Dummy = new System.Windows.Forms.ProgressBar();
            this.button_Modal = new System.Windows.Forms.Button();
            this.button_Modaless = new System.Windows.Forms.Button();
            this.button_MessageBox = new System.Windows.Forms.Button();
            this.treeView_Dummy = new System.Windows.Forms.TreeView();
            this.listView_Dummy = new System.Windows.Forms.ListView();
            this.button_AddRoot = new System.Windows.Forms.Button();
            this.button_AddChild = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Dummy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "폰트: ";
            // 
            // combo_Font
            // 
            this.combo_Font.FormattingEnabled = true;
            this.combo_Font.Location = new System.Drawing.Point(53, 6);
            this.combo_Font.Name = "combo_Font";
            this.combo_Font.Size = new System.Drawing.Size(122, 20);
            this.combo_Font.TabIndex = 1;
            this.combo_Font.SelectedIndexChanged += new System.EventHandler(this.onFontSelect);
            // 
            // check_Bold
            // 
            this.check_Bold.AutoSize = true;
            this.check_Bold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_Bold.Location = new System.Drawing.Point(181, 8);
            this.check_Bold.Name = "check_Bold";
            this.check_Bold.Size = new System.Drawing.Size(50, 16);
            this.check_Bold.TabIndex = 2;
            this.check_Bold.Text = "굵게";
            this.check_Bold.UseVisualStyleBackColor = true;
            this.check_Bold.CheckedChanged += new System.EventHandler(this.onBold);
            // 
            // check_Italic
            // 
            this.check_Italic.AutoSize = true;
            this.check_Italic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_Italic.Location = new System.Drawing.Point(235, 8);
            this.check_Italic.Name = "check_Italic";
            this.check_Italic.Size = new System.Drawing.Size(60, 16);
            this.check_Italic.TabIndex = 3;
            this.check_Italic.Text = "기울임";
            this.check_Italic.UseVisualStyleBackColor = true;
            this.check_Italic.CheckedChanged += new System.EventHandler(this.onItalic);
            // 
            // textBox_FontTest
            // 
            this.textBox_FontTest.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_FontTest.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_FontTest.Location = new System.Drawing.Point(12, 46);
            this.textBox_FontTest.Name = "textBox_FontTest";
            this.textBox_FontTest.ReadOnly = true;
            this.textBox_FontTest.Size = new System.Drawing.Size(283, 21);
            this.textBox_FontTest.TabIndex = 4;
            this.textBox_FontTest.TabStop = false;
            this.textBox_FontTest.Text = "C# 프로그래밍";
            this.textBox_FontTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBar_Dummy
            // 
            this.trackBar_Dummy.AutoSize = false;
            this.trackBar_Dummy.LargeChange = 4;
            this.trackBar_Dummy.Location = new System.Drawing.Point(12, 91);
            this.trackBar_Dummy.Maximum = 20;
            this.trackBar_Dummy.Name = "trackBar_Dummy";
            this.trackBar_Dummy.Size = new System.Drawing.Size(282, 24);
            this.trackBar_Dummy.TabIndex = 5;
            this.trackBar_Dummy.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Dummy.Scroll += new System.EventHandler(this.tbDummy_Scroll);
            // 
            // progressBar_Dummy
            // 
            this.progressBar_Dummy.Location = new System.Drawing.Point(12, 121);
            this.progressBar_Dummy.Maximum = 20;
            this.progressBar_Dummy.Name = "progressBar_Dummy";
            this.progressBar_Dummy.Size = new System.Drawing.Size(282, 13);
            this.progressBar_Dummy.TabIndex = 6;
            // 
            // button_Modal
            // 
            this.button_Modal.Location = new System.Drawing.Point(12, 165);
            this.button_Modal.Name = "button_Modal";
            this.button_Modal.Size = new System.Drawing.Size(64, 23);
            this.button_Modal.TabIndex = 7;
            this.button_Modal.Text = "Modal";
            this.button_Modal.UseVisualStyleBackColor = true;
            this.button_Modal.Click += new System.EventHandler(this.onModal);
            // 
            // button_Modaless
            // 
            this.button_Modaless.Location = new System.Drawing.Point(97, 165);
            this.button_Modaless.Name = "button_Modaless";
            this.button_Modaless.Size = new System.Drawing.Size(78, 23);
            this.button_Modaless.TabIndex = 8;
            this.button_Modaless.Text = "Modaless";
            this.button_Modaless.UseVisualStyleBackColor = true;
            this.button_Modaless.Click += new System.EventHandler(this.onModaless);
            // 
            // button_MessageBox
            // 
            this.button_MessageBox.Location = new System.Drawing.Point(194, 165);
            this.button_MessageBox.Name = "button_MessageBox";
            this.button_MessageBox.Size = new System.Drawing.Size(101, 23);
            this.button_MessageBox.TabIndex = 9;
            this.button_MessageBox.Text = "MessageBox";
            this.button_MessageBox.UseVisualStyleBackColor = true;
            this.button_MessageBox.Click += new System.EventHandler(this.onMessageBox);
            // 
            // treeView_Dummy
            // 
            this.treeView_Dummy.Location = new System.Drawing.Point(12, 225);
            this.treeView_Dummy.Name = "treeView_Dummy";
            this.treeView_Dummy.Size = new System.Drawing.Size(282, 97);
            this.treeView_Dummy.TabIndex = 10;
            // 
            // listView_Dummy
            // 
            this.listView_Dummy.Location = new System.Drawing.Point(12, 357);
            this.listView_Dummy.Name = "listView_Dummy";
            this.listView_Dummy.Size = new System.Drawing.Size(282, 157);
            this.listView_Dummy.TabIndex = 11;
            this.listView_Dummy.UseCompatibleStateImageBehavior = false;
            // 
            // button_AddRoot
            // 
            this.button_AddRoot.Location = new System.Drawing.Point(12, 328);
            this.button_AddRoot.Name = "button_AddRoot";
            this.button_AddRoot.Size = new System.Drawing.Size(75, 23);
            this.button_AddRoot.TabIndex = 12;
            this.button_AddRoot.Text = "루트 추가";
            this.button_AddRoot.UseVisualStyleBackColor = true;
            this.button_AddRoot.Click += new System.EventHandler(this.onAddRoot);
            // 
            // button_AddChild
            // 
            this.button_AddChild.Location = new System.Drawing.Point(220, 328);
            this.button_AddChild.Name = "button_AddChild";
            this.button_AddChild.Size = new System.Drawing.Size(75, 23);
            this.button_AddChild.TabIndex = 13;
            this.button_AddChild.Text = "자식 추가";
            this.button_AddChild.UseVisualStyleBackColor = true;
            this.button_AddChild.Click += new System.EventHandler(this.onAddChild);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 535);
            this.Controls.Add(this.button_AddChild);
            this.Controls.Add(this.button_AddRoot);
            this.Controls.Add(this.listView_Dummy);
            this.Controls.Add(this.treeView_Dummy);
            this.Controls.Add(this.button_MessageBox);
            this.Controls.Add(this.button_Modaless);
            this.Controls.Add(this.button_Modal);
            this.Controls.Add(this.progressBar_Dummy);
            this.Controls.Add(this.trackBar_Dummy);
            this.Controls.Add(this.textBox_FontTest);
            this.Controls.Add(this.check_Italic);
            this.Controls.Add(this.check_Bold);
            this.Controls.Add(this.combo_Font);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "UI 컨트롤러 연습";
            this.Load += new System.EventHandler(this.formLoad);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Dummy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Font;
        private System.Windows.Forms.CheckBox check_Bold;
        private System.Windows.Forms.CheckBox check_Italic;
        private System.Windows.Forms.TextBox textBox_FontTest;
        private System.Windows.Forms.TrackBar trackBar_Dummy;
        private System.Windows.Forms.ProgressBar progressBar_Dummy;
        private System.Windows.Forms.Button button_Modal;
        private System.Windows.Forms.Button button_Modaless;
        private System.Windows.Forms.Button button_MessageBox;
        private System.Windows.Forms.TreeView treeView_Dummy;
        private System.Windows.Forms.ListView listView_Dummy;
        private System.Windows.Forms.Button button_AddRoot;
        private System.Windows.Forms.Button button_AddChild;
    }
}

