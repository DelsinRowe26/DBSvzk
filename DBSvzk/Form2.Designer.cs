
namespace DBSvzk
{
    partial class AddForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassw = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPassw = new System.Windows.Forms.Label();
            this.btnRegistr = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(59, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbPassw
            // 
            this.tbPassw.Location = new System.Drawing.Point(59, 47);
            this.tbPassw.Name = "tbPassw";
            this.tbPassw.PasswordChar = '*';
            this.tbPassw.Size = new System.Drawing.Size(260, 20);
            this.tbPassw.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(1, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbPassw
            // 
            this.lbPassw.AutoSize = true;
            this.lbPassw.Location = new System.Drawing.Point(1, 50);
            this.lbPassw.Name = "lbPassw";
            this.lbPassw.Size = new System.Drawing.Size(53, 13);
            this.lbPassw.TabIndex = 3;
            this.lbPassw.Text = "Password";
            // 
            // btnRegistr
            // 
            this.btnRegistr.Location = new System.Drawing.Point(59, 73);
            this.btnRegistr.Name = "btnRegistr";
            this.btnRegistr.Size = new System.Drawing.Size(75, 23);
            this.btnRegistr.TabIndex = 4;
            this.btnRegistr.Text = "Registration";
            this.btnRegistr.UseVisualStyleBackColor = true;
            this.btnRegistr.Click += new System.EventHandler(this.btnRegistr_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(244, 73);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 106);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRegistr);
            this.Controls.Add(this.lbPassw);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbPassw);
            this.Controls.Add(this.tbName);
            this.Name = "AddForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassw;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPassw;
        private System.Windows.Forms.Button btnRegistr;
        private System.Windows.Forms.Button btnClose;
    }
}