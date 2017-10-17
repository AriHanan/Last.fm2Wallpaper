namespace Lastfm2Wallpaper
{
    partial class main_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.user_l = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.enable = new System.Windows.Forms.CheckBox();
            this.settings = new System.Windows.Forms.Button();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.buttons_container = new System.Windows.Forms.TableLayoutPanel();
            this.key = new System.Windows.Forms.TextBox();
            this.key_l = new System.Windows.Forms.LinkLabel();
            this.buttons_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_l
            // 
            this.user_l.AutoSize = true;
            this.user_l.Location = new System.Drawing.Point(-1, 3);
            this.user_l.Margin = new System.Windows.Forms.Padding(0);
            this.user_l.Name = "user_l";
            this.user_l.Size = new System.Drawing.Size(93, 13);
            this.user_l.TabIndex = 1;
            this.user_l.Text = "Last.fm username:";
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user.Location = new System.Drawing.Point(90, 1);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(147, 20);
            this.user.TabIndex = 2;
            this.user.Text = "AriHanan";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // enable
            // 
            this.enable.Appearance = System.Windows.Forms.Appearance.Button;
            this.enable.Checked = true;
            this.enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enable.Location = new System.Drawing.Point(0, 0);
            this.enable.Margin = new System.Windows.Forms.Padding(0);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(119, 29);
            this.enable.TabIndex = 3;
            this.enable.Text = "Enable";
            this.enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enable.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Location = new System.Drawing.Point(119, 0);
            this.settings.Margin = new System.Windows.Forms.Padding(0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(119, 29);
            this.settings.TabIndex = 9;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // main_timer
            // 
            this.main_timer.Enabled = true;
            this.main_timer.Interval = 10000;
            this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
            // 
            // buttons_container
            // 
            this.buttons_container.ColumnCount = 2;
            this.buttons_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons_container.Controls.Add(this.settings, 1, 0);
            this.buttons_container.Controls.Add(this.enable, 0, 0);
            this.buttons_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttons_container.Location = new System.Drawing.Point(0, 43);
            this.buttons_container.Name = "buttons_container";
            this.buttons_container.RowCount = 1;
            this.buttons_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttons_container.Size = new System.Drawing.Size(238, 29);
            this.buttons_container.TabIndex = 11;
            // 
            // key
            // 
            this.key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.key.Location = new System.Drawing.Point(90, 22);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(147, 20);
            this.key.TabIndex = 13;
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // key_l
            // 
            this.key_l.AutoSize = true;
            this.key_l.Location = new System.Drawing.Point(-1, 24);
            this.key_l.Name = "key_l";
            this.key_l.Size = new System.Drawing.Size(84, 13);
            this.key_l.TabIndex = 15;
            this.key_l.TabStop = true;
            this.key_l.Text = "Last.fm API key:";
            this.key_l.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.key_l_LinkClicked);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 72);
            this.Controls.Add(this.buttons_container);
            this.Controls.Add(this.key_l);
            this.Controls.Add(this.user);
            this.Controls.Add(this.user_l);
            this.Controls.Add(this.key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(9999, 111);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 90);
            this.Name = "main_form";
            this.ShowInTaskbar = false;
            this.Text = "Last.fm2Wallpaper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_form_FormClosing);
            this.buttons_container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user_l;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.CheckBox enable;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Timer main_timer;
        private System.Windows.Forms.TableLayoutPanel buttons_container;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.LinkLabel key_l;
    }
}

