namespace Login.Individual.JobRecruitment
{
      partial class checkApply
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
                  this.label1 = new System.Windows.Forms.Label();
                  this.Apply_Ok_btn = new System.Windows.Forms.Button();
                  this.Apply_Cancel_btn = new System.Windows.Forms.Button();
                  this.SuspendLayout();
                  // 
                  // label1
                  // 
                  this.label1.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                  this.label1.Location = new System.Drawing.Point(63, 23);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(155, 25);
                  this.label1.TabIndex = 3;
                  this.label1.Text = "지원 하시겠습니까 ?";
                  // 
                  // Apply_Ok_btn
                  // 
                  this.Apply_Ok_btn.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                  this.Apply_Ok_btn.Location = new System.Drawing.Point(22, 66);
                  this.Apply_Ok_btn.Name = "Apply_Ok_btn";
                  this.Apply_Ok_btn.Size = new System.Drawing.Size(117, 30);
                  this.Apply_Ok_btn.TabIndex = 4;
                  this.Apply_Ok_btn.Text = "확인";
                  this.Apply_Ok_btn.UseVisualStyleBackColor = true;
                  this.Apply_Ok_btn.Click += new System.EventHandler(this.Apply_Ok_btn_Click);
                  // 
                  // Apply_Cancel_btn
                  // 
                  this.Apply_Cancel_btn.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                  this.Apply_Cancel_btn.Location = new System.Drawing.Point(145, 66);
                  this.Apply_Cancel_btn.Name = "Apply_Cancel_btn";
                  this.Apply_Cancel_btn.Size = new System.Drawing.Size(117, 30);
                  this.Apply_Cancel_btn.TabIndex = 5;
                  this.Apply_Cancel_btn.Text = "취소";
                  this.Apply_Cancel_btn.UseVisualStyleBackColor = true;
                  this.Apply_Cancel_btn.Click += new System.EventHandler(this.Apply_Cancel_btn_Click);
                  // 
                  // checkApply
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(284, 108);
                  this.Controls.Add(this.Apply_Cancel_btn);
                  this.Controls.Add(this.Apply_Ok_btn);
                  this.Controls.Add(this.label1);
                  this.Name = "checkApply";
                  this.Text = "checkApply";
                  this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Button Apply_Ok_btn;
            private System.Windows.Forms.Button Apply_Cancel_btn;
      }
}