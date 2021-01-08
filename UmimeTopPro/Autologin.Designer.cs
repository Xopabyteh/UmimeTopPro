
namespace UmimeTopPro
{
    partial class Autologin
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_setupAutologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.txt_password.Location = new System.Drawing.Point(12, 49);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '#';
            this.txt_password.ShortcutsEnabled = false;
            this.txt_password.Size = new System.Drawing.Size(591, 31);
            this.txt_password.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.txt_username.Location = new System.Drawing.Point(12, 12);
            this.txt_username.Name = "txt_username";
            this.txt_username.ShortcutsEnabled = false;
            this.txt_username.Size = new System.Drawing.Size(591, 31);
            this.txt_username.TabIndex = 1;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_username.Location = new System.Drawing.Point(609, 12);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(139, 31);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(609, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // btn_setupAutologin
            // 
            this.btn_setupAutologin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btn_setupAutologin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(36)))));
            this.btn_setupAutologin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(36)))));
            this.btn_setupAutologin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btn_setupAutologin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setupAutologin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.btn_setupAutologin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setupAutologin.Location = new System.Drawing.Point(12, 86);
            this.btn_setupAutologin.Name = "btn_setupAutologin";
            this.btn_setupAutologin.Size = new System.Drawing.Size(200, 50);
            this.btn_setupAutologin.TabIndex = 8;
            this.btn_setupAutologin.Text = "Save autologin files";
            this.btn_setupAutologin.UseVisualStyleBackColor = true;
            this.btn_setupAutologin.Click += new System.EventHandler(this.btn_setupAutologin_Click);
            // 
            // Autologin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(760, 358);
            this.Controls.Add(this.btn_setupAutologin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Autologin";
            this.Text = "Autologin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_password;
        public System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_setupAutologin;
    }
}