namespace AXIE.WinUI.Account
{
    partial class frmAddAccount
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
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMMR = new System.Windows.Forms.Label();
            this.txtMMR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(29, 29);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(171, 20);
            this.txtAccName.TabIndex = 0;
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Location = new System.Drawing.Point(29, 10);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(76, 13);
            this.lblAccName.TabIndex = 1;
            this.lblAccName.Text = "Account name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(29, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(29, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(171, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblMMR
            // 
            this.lblMMR.AutoSize = true;
            this.lblMMR.Location = new System.Drawing.Point(29, 169);
            this.lblMMR.Name = "lblMMR";
            this.lblMMR.Size = new System.Drawing.Size(33, 13);
            this.lblMMR.TabIndex = 7;
            this.lblMMR.Text = "MMR";
            // 
            // txtMMR
            // 
            this.txtMMR.Location = new System.Drawing.Point(29, 188);
            this.txtMMR.Name = "txtMMR";
            this.txtMMR.Size = new System.Drawing.Size(171, 20);
            this.txtMMR.TabIndex = 6;
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 384);
            this.Controls.Add(this.lblMMR);
            this.Controls.Add(this.txtMMR);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.txtAccName);
            this.Name = "frmAddAccount";
            this.Text = "frmAddAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMMR;
        private System.Windows.Forms.TextBox txtMMR;
    }
}