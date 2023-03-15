namespace WindowsFormsApp1
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnclick = new System.Windows.Forms.Button();
            this.lblhello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(89, 61);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(224, 59);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(75, 23);
            this.btnclick.TabIndex = 2;
            this.btnclick.Text = "클릭";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Location = new System.Drawing.Point(118, 116);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(0, 12);
            this.lblhello.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 159);
            this.Controls.Add(this.lblhello);
            this.Controls.Add(this.btnclick);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Basic Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label lblhello;
    }
}

