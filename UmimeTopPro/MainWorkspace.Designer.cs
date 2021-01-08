
namespace UmimeTopPro
{
    partial class MainWorkspace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWorkspace));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.panel_control = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_autoLogin = new System.Windows.Forms.Button();
            this.btn_modules = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_workArea = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_stopWork = new System.Windows.Forms.Button();
            this.btn_work = new System.Windows.Forms.Button();
            this.check_onTop = new System.Windows.Forms.CheckBox();
            this.panel_control.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.panel_workArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(103)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(83)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.btn_close.Location = new System.Drawing.Point(1006, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(103)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(83)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.btn_minimize.Location = new System.Drawing.Point(970, 6);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel_control.Controls.Add(this.label_name);
            this.panel_control.Controls.Add(this.btn_minimize);
            this.panel_control.Controls.Add(this.btn_close);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(1048, 42);
            this.panel_control.TabIndex = 0;
            this.panel_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_control_MouseDown);
            this.panel_control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_control_MouseMove);
            this.panel_control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_control_MouseUp);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.CausesValidation = false;
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.label_name.Location = new System.Drawing.Point(3, 12);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(179, 17);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "UmimeTopPro - Xopabyteh";
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel_nav.Controls.Add(this.btn_Help);
            this.panel_nav.Controls.Add(this.btn_autoLogin);
            this.panel_nav.Controls.Add(this.btn_modules);
            this.panel_nav.Controls.Add(this.btn_home);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 42);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(200, 358);
            this.panel_nav.TabIndex = 1;
            // 
            // btn_Help
            // 
            this.btn_Help.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btn_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(96)))));
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Help.Location = new System.Drawing.Point(0, 309);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(200, 49);
            this.btn_Help.TabIndex = 3;
            this.btn_Help.Text = "Help";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // btn_autoLogin
            // 
            this.btn_autoLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_autoLogin.FlatAppearance.BorderSize = 0;
            this.btn_autoLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btn_autoLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(96)))));
            this.btn_autoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.btn_autoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_autoLogin.Location = new System.Drawing.Point(0, 98);
            this.btn_autoLogin.Name = "btn_autoLogin";
            this.btn_autoLogin.Size = new System.Drawing.Size(200, 49);
            this.btn_autoLogin.TabIndex = 2;
            this.btn_autoLogin.Text = "Auto Login";
            this.btn_autoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_autoLogin.UseVisualStyleBackColor = true;
            this.btn_autoLogin.Click += new System.EventHandler(this.btn_autoLogin_Click);
            // 
            // btn_modules
            // 
            this.btn_modules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_modules.FlatAppearance.BorderSize = 0;
            this.btn_modules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btn_modules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(96)))));
            this.btn_modules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.btn_modules.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modules.Location = new System.Drawing.Point(0, 49);
            this.btn_modules.Name = "btn_modules";
            this.btn_modules.Size = new System.Drawing.Size(200, 49);
            this.btn_modules.TabIndex = 1;
            this.btn_modules.Text = "Modules";
            this.btn_modules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modules.UseVisualStyleBackColor = true;
            this.btn_modules.Click += new System.EventHandler(this.btn_modules_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(96)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(200, 49);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_workArea
            // 
            this.panel_workArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.panel_workArea.Controls.Add(this.check_onTop);
            this.panel_workArea.Controls.Add(this.pictureBox1);
            this.panel_workArea.Controls.Add(this.btn_stopWork);
            this.panel_workArea.Controls.Add(this.btn_work);
            this.panel_workArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_workArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.panel_workArea.Location = new System.Drawing.Point(200, 42);
            this.panel_workArea.Name = "panel_workArea";
            this.panel_workArea.Size = new System.Drawing.Size(848, 358);
            this.panel_workArea.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::UmimeTopPro.Properties.Resources.Logo;
            this.pictureBox1.InitialImage = global::UmimeTopPro.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(638, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_stopWork
            // 
            this.btn_stopWork.Enabled = false;
            this.btn_stopWork.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btn_stopWork.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(36)))));
            this.btn_stopWork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(36)))));
            this.btn_stopWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btn_stopWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stopWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.btn_stopWork.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stopWork.Location = new System.Drawing.Point(12, 68);
            this.btn_stopWork.Name = "btn_stopWork";
            this.btn_stopWork.Size = new System.Drawing.Size(200, 50);
            this.btn_stopWork.TabIndex = 5;
            this.btn_stopWork.Text = "Stop";
            this.btn_stopWork.UseVisualStyleBackColor = true;
            this.btn_stopWork.Click += new System.EventHandler(this.btn_stopWork_Click);
            // 
            // btn_work
            // 
            this.btn_work.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btn_work.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(36)))));
            this.btn_work.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(36)))));
            this.btn_work.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btn_work.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_work.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(182)))), ((int)(((byte)(196)))));
            this.btn_work.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_work.Location = new System.Drawing.Point(12, 12);
            this.btn_work.Name = "btn_work";
            this.btn_work.Size = new System.Drawing.Size(200, 50);
            this.btn_work.TabIndex = 4;
            this.btn_work.Text = "Work";
            this.btn_work.UseVisualStyleBackColor = true;
            this.btn_work.Click += new System.EventHandler(this.btn_work_Click);
            // 
            // check_onTop
            // 
            this.check_onTop.AutoSize = true;
            this.check_onTop.Location = new System.Drawing.Point(12, 124);
            this.check_onTop.Name = "check_onTop";
            this.check_onTop.Size = new System.Drawing.Size(91, 21);
            this.check_onTop.TabIndex = 7;
            this.check_onTop.Text = "Pin on top";
            this.check_onTop.UseVisualStyleBackColor = true;
            this.check_onTop.CheckedChanged += new System.EventHandler(this.check_onTop_CheckedChanged);
            // 
            // MainWorkspace
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(185)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1048, 400);
            this.ControlBox = false;
            this.Controls.Add(this.panel_workArea);
            this.Controls.Add(this.panel_nav);
            this.Controls.Add(this.panel_control);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 400);
            this.Name = "MainWorkspace";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            this.panel_workArea.ResumeLayout(false);
            this.panel_workArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Panel panel_workArea;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_home;
        public System.Windows.Forms.Button btn_modules;
        public System.Windows.Forms.Button btn_autoLogin;
        public System.Windows.Forms.Button btn_stopWork;
        public System.Windows.Forms.Button btn_work;
        private System.Windows.Forms.CheckBox check_onTop;
    }
}

