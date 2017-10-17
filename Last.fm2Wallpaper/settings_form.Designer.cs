namespace Lastfm2Wallpaper
{
    partial class settings_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings_form));
            this.display_font_button = new System.Windows.Forms.Button();
            this.settings_tabcontrol = new System.Windows.Forms.TabControl();
            this.config_tab = new System.Windows.Forms.TabPage();
            this.config_container = new System.Windows.Forms.TableLayoutPanel();
            this.config_save = new System.Windows.Forms.Button();
            this.config_load = new System.Windows.Forms.Button();
            this.config_combo = new System.Windows.Forms.ComboBox();
            this.config_l = new System.Windows.Forms.Label();
            this.align_tab = new System.Windows.Forms.TabPage();
            this.text_alignment_container = new System.Windows.Forms.GroupBox();
            this.text_align_combo = new System.Windows.Forms.ComboBox();
            this.text_align_cover_combo = new System.Windows.Forms.ComboBox();
            this.image_alignment_container = new System.Windows.Forms.GroupBox();
            this.image_mode_combo = new System.Windows.Forms.ComboBox();
            this.image_align_container = new System.Windows.Forms.TableLayoutPanel();
            this.image_vertical_combo = new System.Windows.Forms.ComboBox();
            this.image_horizonal_combo = new System.Windows.Forms.ComboBox();
            this.margin_l = new System.Windows.Forms.Label();
            this.margin_numeric = new System.Windows.Forms.NumericUpDown();
            this.info_tab = new System.Windows.Forms.TabPage();
            this.text_textboxes_container = new System.Windows.Forms.TableLayoutPanel();
            this.right_container = new System.Windows.Forms.GroupBox();
            this.right_textbox = new System.Windows.Forms.TextBox();
            this.center_container = new System.Windows.Forms.GroupBox();
            this.center_textbox = new System.Windows.Forms.TextBox();
            this.left_container = new System.Windows.Forms.GroupBox();
            this.left_textbox = new System.Windows.Forms.TextBox();
            this.markup_l = new System.Windows.Forms.Label();
            this.backdrop_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.display_shadow_streangth_slider_l = new System.Windows.Forms.Label();
            this.display_shadow_strength_slider = new System.Windows.Forms.TrackBar();
            this.display_shadow_checkbox = new System.Windows.Forms.CheckBox();
            this.bg_color_radio = new System.Windows.Forms.RadioButton();
            this.bg_auto_radio = new System.Windows.Forms.RadioButton();
            this.bg_autog_radio = new System.Windows.Forms.RadioButton();
            this.bg_img_radio = new System.Windows.Forms.RadioButton();
            this.bg_img_button = new System.Windows.Forms.Button();
            this.bg_color_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bg_color_text_button = new System.Windows.Forms.Button();
            this.bg_auto_text_radio = new System.Windows.Forms.RadioButton();
            this.bg_color_text_radio = new System.Windows.Forms.RadioButton();
            this.about_tab = new System.Windows.Forms.TabPage();
            this.lastfm_credit = new System.Windows.Forms.PictureBox();
            this.love = new System.Windows.Forms.PictureBox();
            this.source = new System.Windows.Forms.LinkLabel();
            this.credit = new System.Windows.Forms.LinkLabel();
            this.display_font_dialog = new System.Windows.Forms.FontDialog();
            this.bg_color_dialog = new System.Windows.Forms.ColorDialog();
            this.bg_img_dialog = new System.Windows.Forms.OpenFileDialog();
            this.bg_color_text_dialog = new System.Windows.Forms.ColorDialog();
            this.save_file_dialog = new System.Windows.Forms.SaveFileDialog();
            this.load_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.settings_tabcontrol.SuspendLayout();
            this.config_tab.SuspendLayout();
            this.config_container.SuspendLayout();
            this.align_tab.SuspendLayout();
            this.text_alignment_container.SuspendLayout();
            this.image_alignment_container.SuspendLayout();
            this.image_align_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.margin_numeric)).BeginInit();
            this.info_tab.SuspendLayout();
            this.text_textboxes_container.SuspendLayout();
            this.right_container.SuspendLayout();
            this.center_container.SuspendLayout();
            this.left_container.SuspendLayout();
            this.backdrop_tab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display_shadow_strength_slider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.about_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastfm_credit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.love)).BeginInit();
            this.SuspendLayout();
            // 
            // display_font_button
            // 
            this.display_font_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display_font_button.Location = new System.Drawing.Point(6, 233);
            this.display_font_button.Name = "display_font_button";
            this.display_font_button.Size = new System.Drawing.Size(323, 23);
            this.display_font_button.TabIndex = 23;
            this.display_font_button.Text = "Choose font";
            this.display_font_button.UseVisualStyleBackColor = true;
            this.display_font_button.Click += new System.EventHandler(this.display_font_button_Click);
            // 
            // settings_tabcontrol
            // 
            this.settings_tabcontrol.Controls.Add(this.config_tab);
            this.settings_tabcontrol.Controls.Add(this.align_tab);
            this.settings_tabcontrol.Controls.Add(this.info_tab);
            this.settings_tabcontrol.Controls.Add(this.backdrop_tab);
            this.settings_tabcontrol.Controls.Add(this.about_tab);
            this.settings_tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.settings_tabcontrol.Name = "settings_tabcontrol";
            this.settings_tabcontrol.SelectedIndex = 0;
            this.settings_tabcontrol.Size = new System.Drawing.Size(343, 288);
            this.settings_tabcontrol.TabIndex = 0;
            // 
            // config_tab
            // 
            this.config_tab.Controls.Add(this.config_container);
            this.config_tab.Controls.Add(this.config_combo);
            this.config_tab.Controls.Add(this.config_l);
            this.config_tab.Location = new System.Drawing.Point(4, 22);
            this.config_tab.Name = "config_tab";
            this.config_tab.Size = new System.Drawing.Size(335, 262);
            this.config_tab.TabIndex = 3;
            this.config_tab.Text = "Presets";
            this.config_tab.UseVisualStyleBackColor = true;
            // 
            // config_container
            // 
            this.config_container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.config_container.ColumnCount = 2;
            this.config_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.config_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.config_container.Controls.Add(this.config_save, 0, 0);
            this.config_container.Controls.Add(this.config_load, 1, 0);
            this.config_container.Location = new System.Drawing.Point(75, 140);
            this.config_container.Name = "config_container";
            this.config_container.RowCount = 1;
            this.config_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.config_container.Size = new System.Drawing.Size(188, 26);
            this.config_container.TabIndex = 3;
            // 
            // config_save
            // 
            this.config_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.config_save.Location = new System.Drawing.Point(0, 0);
            this.config_save.Margin = new System.Windows.Forms.Padding(0);
            this.config_save.Name = "config_save";
            this.config_save.Size = new System.Drawing.Size(94, 26);
            this.config_save.TabIndex = 4;
            this.config_save.Text = "Save";
            this.config_save.UseVisualStyleBackColor = true;
            this.config_save.Click += new System.EventHandler(this.config_save_Click);
            // 
            // config_load
            // 
            this.config_load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.config_load.Location = new System.Drawing.Point(94, 0);
            this.config_load.Margin = new System.Windows.Forms.Padding(0);
            this.config_load.Name = "config_load";
            this.config_load.Size = new System.Drawing.Size(94, 26);
            this.config_load.TabIndex = 5;
            this.config_load.Text = "Load";
            this.config_load.UseVisualStyleBackColor = true;
            this.config_load.Click += new System.EventHandler(this.config_load_Click);
            // 
            // config_combo
            // 
            this.config_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.config_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.config_combo.FormattingEnabled = true;
            this.config_combo.Items.AddRange(new object[] {
            "Side text",
            "Bottom text",
            "Fullscreen",
            "AlbumArt only"});
            this.config_combo.Location = new System.Drawing.Point(75, 113);
            this.config_combo.Name = "config_combo";
            this.config_combo.Size = new System.Drawing.Size(188, 21);
            this.config_combo.TabIndex = 2;
            this.config_combo.SelectedIndexChanged += new System.EventHandler(this.config_combo_SelectedIndexChanged);
            // 
            // config_l
            // 
            this.config_l.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.config_l.AutoSize = true;
            this.config_l.Location = new System.Drawing.Point(72, 97);
            this.config_l.Name = "config_l";
            this.config_l.Size = new System.Drawing.Size(37, 13);
            this.config_l.TabIndex = 1;
            this.config_l.Text = "Config";
            // 
            // align_tab
            // 
            this.align_tab.Controls.Add(this.text_alignment_container);
            this.align_tab.Controls.Add(this.image_alignment_container);
            this.align_tab.Location = new System.Drawing.Point(4, 22);
            this.align_tab.Name = "align_tab";
            this.align_tab.Size = new System.Drawing.Size(335, 262);
            this.align_tab.TabIndex = 5;
            this.align_tab.Text = "Alignment";
            this.align_tab.UseVisualStyleBackColor = true;
            // 
            // text_alignment_container
            // 
            this.text_alignment_container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_alignment_container.Controls.Add(this.text_align_combo);
            this.text_alignment_container.Controls.Add(this.text_align_cover_combo);
            this.text_alignment_container.Location = new System.Drawing.Point(8, 115);
            this.text_alignment_container.Name = "text_alignment_container";
            this.text_alignment_container.Size = new System.Drawing.Size(319, 46);
            this.text_alignment_container.TabIndex = 13;
            this.text_alignment_container.TabStop = false;
            this.text_alignment_container.Text = "Text Alignment";
            // 
            // text_align_combo
            // 
            this.text_align_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_align_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_align_combo.FormattingEnabled = true;
            this.text_align_combo.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom"});
            this.text_align_combo.Location = new System.Drawing.Point(6, 19);
            this.text_align_combo.Name = "text_align_combo";
            this.text_align_combo.Size = new System.Drawing.Size(307, 21);
            this.text_align_combo.TabIndex = 14;
            this.text_align_combo.SelectedIndexChanged += new System.EventHandler(this.text_align_combo_SelectedIndexChanged);
            // 
            // text_align_cover_combo
            // 
            this.text_align_cover_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_align_cover_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_align_cover_combo.FormattingEnabled = true;
            this.text_align_cover_combo.Items.AddRange(new object[] {
            "Top",
            "Center",
            "Bottom"});
            this.text_align_cover_combo.Location = new System.Drawing.Point(6, 41);
            this.text_align_cover_combo.Name = "text_align_cover_combo";
            this.text_align_cover_combo.Size = new System.Drawing.Size(307, 21);
            this.text_align_cover_combo.TabIndex = 15;
            this.text_align_cover_combo.SelectedIndexChanged += new System.EventHandler(this.text_align_cover_combo_SelectedIndexChanged);
            // 
            // image_alignment_container
            // 
            this.image_alignment_container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image_alignment_container.Controls.Add(this.image_mode_combo);
            this.image_alignment_container.Controls.Add(this.image_align_container);
            this.image_alignment_container.Controls.Add(this.margin_l);
            this.image_alignment_container.Controls.Add(this.margin_numeric);
            this.image_alignment_container.Location = new System.Drawing.Point(8, 3);
            this.image_alignment_container.Name = "image_alignment_container";
            this.image_alignment_container.Size = new System.Drawing.Size(319, 106);
            this.image_alignment_container.TabIndex = 6;
            this.image_alignment_container.TabStop = false;
            this.image_alignment_container.Text = "Image Alignment";
            // 
            // image_mode_combo
            // 
            this.image_mode_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image_mode_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.image_mode_combo.FormattingEnabled = true;
            this.image_mode_combo.Items.AddRange(new object[] {
            "Contain",
            "Cover",
            "Stretch",
            "Tile"});
            this.image_mode_combo.Location = new System.Drawing.Point(6, 19);
            this.image_mode_combo.Name = "image_mode_combo";
            this.image_mode_combo.Size = new System.Drawing.Size(307, 21);
            this.image_mode_combo.TabIndex = 7;
            this.image_mode_combo.SelectedIndexChanged += new System.EventHandler(this.image_mode_combo_SelectedIndexChanged);
            // 
            // image_align_container
            // 
            this.image_align_container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image_align_container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.image_align_container.ColumnCount = 2;
            this.image_align_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.image_align_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.image_align_container.Controls.Add(this.image_vertical_combo, 0, 0);
            this.image_align_container.Controls.Add(this.image_horizonal_combo, 1, 0);
            this.image_align_container.Location = new System.Drawing.Point(6, 43);
            this.image_align_container.Name = "image_align_container";
            this.image_align_container.RowCount = 1;
            this.image_align_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.image_align_container.Size = new System.Drawing.Size(307, 21);
            this.image_align_container.TabIndex = 8;
            // 
            // image_vertical_combo
            // 
            this.image_vertical_combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image_vertical_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.image_vertical_combo.FormattingEnabled = true;
            this.image_vertical_combo.Items.AddRange(new object[] {
            "Top",
            "Medium",
            "Bottom"});
            this.image_vertical_combo.Location = new System.Drawing.Point(0, 0);
            this.image_vertical_combo.Margin = new System.Windows.Forms.Padding(0);
            this.image_vertical_combo.Name = "image_vertical_combo";
            this.image_vertical_combo.Size = new System.Drawing.Size(153, 21);
            this.image_vertical_combo.TabIndex = 9;
            this.image_vertical_combo.SelectedIndexChanged += new System.EventHandler(this.image_vertical_combo_SelectedIndexChanged);
            // 
            // image_horizonal_combo
            // 
            this.image_horizonal_combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image_horizonal_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.image_horizonal_combo.FormattingEnabled = true;
            this.image_horizonal_combo.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.image_horizonal_combo.Location = new System.Drawing.Point(153, 0);
            this.image_horizonal_combo.Margin = new System.Windows.Forms.Padding(0);
            this.image_horizonal_combo.Name = "image_horizonal_combo";
            this.image_horizonal_combo.Size = new System.Drawing.Size(154, 21);
            this.image_horizonal_combo.TabIndex = 10;
            this.image_horizonal_combo.SelectedIndexChanged += new System.EventHandler(this.image_horizonal_combo_SelectedIndexChanged);
            // 
            // margin_l
            // 
            this.margin_l.AutoSize = true;
            this.margin_l.Location = new System.Drawing.Point(159, 83);
            this.margin_l.Name = "margin_l";
            this.margin_l.Size = new System.Drawing.Size(50, 13);
            this.margin_l.TabIndex = 12;
            this.margin_l.Text = "% Margin";
            // 
            // margin_numeric
            // 
            this.margin_numeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.margin_numeric.Location = new System.Drawing.Point(109, 80);
            this.margin_numeric.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.margin_numeric.Name = "margin_numeric";
            this.margin_numeric.Size = new System.Drawing.Size(50, 20);
            this.margin_numeric.TabIndex = 11;
            this.margin_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.margin_numeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.margin_numeric.ValueChanged += new System.EventHandler(this.margin_numeric_ValueChanged);
            // 
            // info_tab
            // 
            this.info_tab.Controls.Add(this.text_textboxes_container);
            this.info_tab.Controls.Add(this.markup_l);
            this.info_tab.Controls.Add(this.display_font_button);
            this.info_tab.Location = new System.Drawing.Point(4, 22);
            this.info_tab.Name = "info_tab";
            this.info_tab.Padding = new System.Windows.Forms.Padding(3);
            this.info_tab.Size = new System.Drawing.Size(335, 262);
            this.info_tab.TabIndex = 0;
            this.info_tab.Text = "Info";
            this.info_tab.UseVisualStyleBackColor = true;
            // 
            // text_textboxes_container
            // 
            this.text_textboxes_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_textboxes_container.ColumnCount = 3;
            this.text_textboxes_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.text_textboxes_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.text_textboxes_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.text_textboxes_container.Controls.Add(this.right_container, 2, 0);
            this.text_textboxes_container.Controls.Add(this.center_container, 1, 0);
            this.text_textboxes_container.Controls.Add(this.left_container, 0, 0);
            this.text_textboxes_container.Location = new System.Drawing.Point(6, 32);
            this.text_textboxes_container.Name = "text_textboxes_container";
            this.text_textboxes_container.RowCount = 1;
            this.text_textboxes_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.text_textboxes_container.Size = new System.Drawing.Size(323, 195);
            this.text_textboxes_container.TabIndex = 14;
            // 
            // right_container
            // 
            this.right_container.Controls.Add(this.right_textbox);
            this.right_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_container.Location = new System.Drawing.Point(214, 0);
            this.right_container.Margin = new System.Windows.Forms.Padding(0);
            this.right_container.Name = "right_container";
            this.right_container.Size = new System.Drawing.Size(109, 195);
            this.right_container.TabIndex = 21;
            this.right_container.TabStop = false;
            this.right_container.Text = "Right";
            // 
            // right_textbox
            // 
            this.right_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_textbox.Location = new System.Drawing.Point(3, 16);
            this.right_textbox.Multiline = true;
            this.right_textbox.Name = "right_textbox";
            this.right_textbox.Size = new System.Drawing.Size(103, 176);
            this.right_textbox.TabIndex = 22;
            this.right_textbox.TextChanged += new System.EventHandler(this.right_textbox_TextChanged);
            // 
            // center_container
            // 
            this.center_container.Controls.Add(this.center_textbox);
            this.center_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center_container.Location = new System.Drawing.Point(107, 0);
            this.center_container.Margin = new System.Windows.Forms.Padding(0);
            this.center_container.Name = "center_container";
            this.center_container.Size = new System.Drawing.Size(107, 195);
            this.center_container.TabIndex = 19;
            this.center_container.TabStop = false;
            this.center_container.Text = "Center";
            // 
            // center_textbox
            // 
            this.center_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center_textbox.Location = new System.Drawing.Point(3, 16);
            this.center_textbox.Multiline = true;
            this.center_textbox.Name = "center_textbox";
            this.center_textbox.Size = new System.Drawing.Size(101, 176);
            this.center_textbox.TabIndex = 20;
            this.center_textbox.Text = "[Track]\r\n[Album]\r\n[Artist]";
            this.center_textbox.TextChanged += new System.EventHandler(this.center_textbox_TextChanged);
            // 
            // left_container
            // 
            this.left_container.Controls.Add(this.left_textbox);
            this.left_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_container.Location = new System.Drawing.Point(0, 0);
            this.left_container.Margin = new System.Windows.Forms.Padding(0);
            this.left_container.Name = "left_container";
            this.left_container.Size = new System.Drawing.Size(107, 195);
            this.left_container.TabIndex = 17;
            this.left_container.TabStop = false;
            this.left_container.Text = "Left";
            // 
            // left_textbox
            // 
            this.left_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_textbox.Location = new System.Drawing.Point(3, 16);
            this.left_textbox.Multiline = true;
            this.left_textbox.Name = "left_textbox";
            this.left_textbox.Size = new System.Drawing.Size(101, 176);
            this.left_textbox.TabIndex = 18;
            this.left_textbox.TextChanged += new System.EventHandler(this.left_textbox_TextChanged);
            // 
            // markup_l
            // 
            this.markup_l.AutoSize = true;
            this.markup_l.Location = new System.Drawing.Point(8, 3);
            this.markup_l.Name = "markup_l";
            this.markup_l.Size = new System.Drawing.Size(117, 26);
            this.markup_l.TabIndex = 16;
            this.markup_l.Text = "Markup:\r\n[Track], [Album], [Artist]";
            // 
            // backdrop_tab
            // 
            this.backdrop_tab.Controls.Add(this.tableLayoutPanel1);
            this.backdrop_tab.Location = new System.Drawing.Point(4, 22);
            this.backdrop_tab.Name = "backdrop_tab";
            this.backdrop_tab.Padding = new System.Windows.Forms.Padding(3);
            this.backdrop_tab.Size = new System.Drawing.Size(335, 262);
            this.backdrop_tab.TabIndex = 1;
            this.backdrop_tab.Text = "Backdrop";
            this.backdrop_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 256);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.display_shadow_streangth_slider_l);
            this.groupBox1.Controls.Add(this.display_shadow_strength_slider);
            this.groupBox1.Controls.Add(this.display_shadow_checkbox);
            this.groupBox1.Controls.Add(this.bg_color_radio);
            this.groupBox1.Controls.Add(this.bg_auto_radio);
            this.groupBox1.Controls.Add(this.bg_autog_radio);
            this.groupBox1.Controls.Add(this.bg_img_radio);
            this.groupBox1.Controls.Add(this.bg_img_button);
            this.groupBox1.Controls.Add(this.bg_color_button);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 250);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backdrop color";
            // 
            // display_shadow_streangth_slider_l
            // 
            this.display_shadow_streangth_slider_l.AutoSize = true;
            this.display_shadow_streangth_slider_l.Location = new System.Drawing.Point(6, 183);
            this.display_shadow_streangth_slider_l.Name = "display_shadow_streangth_slider_l";
            this.display_shadow_streangth_slider_l.Size = new System.Drawing.Size(90, 13);
            this.display_shadow_streangth_slider_l.TabIndex = 33;
            this.display_shadow_streangth_slider_l.Text = "Shadow strength:";
            // 
            // display_shadow_strength_slider
            // 
            this.display_shadow_strength_slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display_shadow_strength_slider.BackColor = System.Drawing.Color.White;
            this.display_shadow_strength_slider.LargeChange = 10;
            this.display_shadow_strength_slider.Location = new System.Drawing.Point(6, 199);
            this.display_shadow_strength_slider.Maximum = 100;
            this.display_shadow_strength_slider.Name = "display_shadow_strength_slider";
            this.display_shadow_strength_slider.Size = new System.Drawing.Size(146, 45);
            this.display_shadow_strength_slider.TabIndex = 34;
            this.display_shadow_strength_slider.TickFrequency = 10;
            this.display_shadow_strength_slider.Value = 50;
            this.display_shadow_strength_slider.Scroll += new System.EventHandler(this.display_shadow_strength_slider_Scroll);
            // 
            // display_shadow_checkbox
            // 
            this.display_shadow_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.display_shadow_checkbox.AutoSize = true;
            this.display_shadow_checkbox.Checked = true;
            this.display_shadow_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.display_shadow_checkbox.Location = new System.Drawing.Point(6, 163);
            this.display_shadow_checkbox.Name = "display_shadow_checkbox";
            this.display_shadow_checkbox.Size = new System.Drawing.Size(100, 17);
            this.display_shadow_checkbox.TabIndex = 32;
            this.display_shadow_checkbox.Text = "Display shadow";
            this.display_shadow_checkbox.UseVisualStyleBackColor = true;
            this.display_shadow_checkbox.CheckedChanged += new System.EventHandler(this.display_shadow_checkbox_CheckedChanged);
            // 
            // bg_color_radio
            // 
            this.bg_color_radio.AutoSize = true;
            this.bg_color_radio.Location = new System.Drawing.Point(6, 22);
            this.bg_color_radio.Name = "bg_color_radio";
            this.bg_color_radio.Size = new System.Drawing.Size(49, 17);
            this.bg_color_radio.TabIndex = 26;
            this.bg_color_radio.Text = "Color";
            this.bg_color_radio.UseVisualStyleBackColor = true;
            this.bg_color_radio.CheckedChanged += new System.EventHandler(this.bg_color_radio_CheckedChanged);
            // 
            // bg_auto_radio
            // 
            this.bg_auto_radio.AutoSize = true;
            this.bg_auto_radio.Location = new System.Drawing.Point(6, 80);
            this.bg_auto_radio.Name = "bg_auto_radio";
            this.bg_auto_radio.Size = new System.Drawing.Size(71, 17);
            this.bg_auto_radio.TabIndex = 30;
            this.bg_auto_radio.Text = "Auto solid";
            this.bg_auto_radio.UseVisualStyleBackColor = true;
            this.bg_auto_radio.CheckedChanged += new System.EventHandler(this.bg_auto_radio_CheckedChanged);
            // 
            // bg_autog_radio
            // 
            this.bg_autog_radio.AutoSize = true;
            this.bg_autog_radio.Checked = true;
            this.bg_autog_radio.Location = new System.Drawing.Point(6, 109);
            this.bg_autog_radio.Name = "bg_autog_radio";
            this.bg_autog_radio.Size = new System.Drawing.Size(88, 17);
            this.bg_autog_radio.TabIndex = 31;
            this.bg_autog_radio.TabStop = true;
            this.bg_autog_radio.Text = "Auto gardient";
            this.bg_autog_radio.UseVisualStyleBackColor = true;
            this.bg_autog_radio.CheckedChanged += new System.EventHandler(this.bg_autog_radio_CheckedChanged);
            // 
            // bg_img_radio
            // 
            this.bg_img_radio.AutoSize = true;
            this.bg_img_radio.Location = new System.Drawing.Point(6, 51);
            this.bg_img_radio.Name = "bg_img_radio";
            this.bg_img_radio.Size = new System.Drawing.Size(54, 17);
            this.bg_img_radio.TabIndex = 28;
            this.bg_img_radio.Text = "Image";
            this.bg_img_radio.UseVisualStyleBackColor = true;
            this.bg_img_radio.CheckedChanged += new System.EventHandler(this.bg_img_radio_CheckedChanged);
            // 
            // bg_img_button
            // 
            this.bg_img_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_img_button.Location = new System.Drawing.Point(98, 48);
            this.bg_img_button.Name = "bg_img_button";
            this.bg_img_button.Size = new System.Drawing.Size(54, 23);
            this.bg_img_button.TabIndex = 29;
            this.bg_img_button.Text = "Browse";
            this.bg_img_button.UseVisualStyleBackColor = true;
            this.bg_img_button.Click += new System.EventHandler(this.bg_img_button_Click);
            // 
            // bg_color_button
            // 
            this.bg_color_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_color_button.Location = new System.Drawing.Point(98, 19);
            this.bg_color_button.Name = "bg_color_button";
            this.bg_color_button.Size = new System.Drawing.Size(54, 23);
            this.bg_color_button.TabIndex = 27;
            this.bg_color_button.Text = "Pick";
            this.bg_color_button.UseVisualStyleBackColor = true;
            this.bg_color_button.Click += new System.EventHandler(this.bg_color_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bg_color_text_button);
            this.groupBox2.Controls.Add(this.bg_auto_text_radio);
            this.groupBox2.Controls.Add(this.bg_color_text_radio);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(167, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 250);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text color";
            // 
            // bg_color_text_button
            // 
            this.bg_color_text_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_color_text_button.Location = new System.Drawing.Point(99, 19);
            this.bg_color_text_button.Name = "bg_color_text_button";
            this.bg_color_text_button.Size = new System.Drawing.Size(54, 23);
            this.bg_color_text_button.TabIndex = 37;
            this.bg_color_text_button.Text = "Pick";
            this.bg_color_text_button.UseVisualStyleBackColor = true;
            this.bg_color_text_button.Click += new System.EventHandler(this.bg_color_text_button_Click);
            // 
            // bg_auto_text_radio
            // 
            this.bg_auto_text_radio.AutoSize = true;
            this.bg_auto_text_radio.Checked = true;
            this.bg_auto_text_radio.Location = new System.Drawing.Point(6, 51);
            this.bg_auto_text_radio.Name = "bg_auto_text_radio";
            this.bg_auto_text_radio.Size = new System.Drawing.Size(47, 17);
            this.bg_auto_text_radio.TabIndex = 38;
            this.bg_auto_text_radio.TabStop = true;
            this.bg_auto_text_radio.Text = "Auto";
            this.bg_auto_text_radio.UseVisualStyleBackColor = true;
            this.bg_auto_text_radio.CheckedChanged += new System.EventHandler(this.bg_auto_text_radio_CheckedChanged);
            // 
            // bg_color_text_radio
            // 
            this.bg_color_text_radio.AutoSize = true;
            this.bg_color_text_radio.Location = new System.Drawing.Point(6, 22);
            this.bg_color_text_radio.Name = "bg_color_text_radio";
            this.bg_color_text_radio.Size = new System.Drawing.Size(49, 17);
            this.bg_color_text_radio.TabIndex = 36;
            this.bg_color_text_radio.Text = "Color";
            this.bg_color_text_radio.UseVisualStyleBackColor = true;
            this.bg_color_text_radio.CheckedChanged += new System.EventHandler(this.bg_color_text_radio_CheckedChanged);
            // 
            // about_tab
            // 
            this.about_tab.Controls.Add(this.lastfm_credit);
            this.about_tab.Controls.Add(this.love);
            this.about_tab.Controls.Add(this.source);
            this.about_tab.Controls.Add(this.credit);
            this.about_tab.Location = new System.Drawing.Point(4, 22);
            this.about_tab.Name = "about_tab";
            this.about_tab.Size = new System.Drawing.Size(335, 262);
            this.about_tab.TabIndex = 2;
            this.about_tab.Text = "About";
            this.about_tab.UseVisualStyleBackColor = true;
            // 
            // lastfm_credit
            // 
            this.lastfm_credit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastfm_credit.Image = global::Last.fm2Wallpaper.Properties.Resources.Lastfm_Logo_Black;
            this.lastfm_credit.Location = new System.Drawing.Point(91, 171);
            this.lastfm_credit.Name = "lastfm_credit";
            this.lastfm_credit.Size = new System.Drawing.Size(153, 40);
            this.lastfm_credit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lastfm_credit.TabIndex = 3;
            this.lastfm_credit.TabStop = false;
            this.lastfm_credit.Click += new System.EventHandler(this.lastfm_credit_Click);
            // 
            // love
            // 
            this.love.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.love.Image = global::Last.fm2Wallpaper.Properties.Resources.Heart;
            this.love.Location = new System.Drawing.Point(155, 73);
            this.love.Name = "love";
            this.love.Size = new System.Drawing.Size(25, 25);
            this.love.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.love.TabIndex = 2;
            this.love.TabStop = false;
            // 
            // source
            // 
            this.source.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.source.AutoSize = true;
            this.source.LinkArea = new System.Windows.Forms.LinkArea(15, 6);
            this.source.Location = new System.Drawing.Point(106, 105);
            this.source.Margin = new System.Windows.Forms.Padding(3);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(122, 17);
            this.source.TabIndex = 41;
            this.source.TabStop = true;
            this.source.Text = "Source code on GitHub";
            this.source.UseCompatibleTextRendering = true;
            this.source.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.source_LinkClicked);
            // 
            // credit
            // 
            this.credit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.credit.AutoSize = true;
            this.credit.LinkArea = new System.Windows.Forms.LinkArea(8, 9);
            this.credit.Location = new System.Drawing.Point(117, 51);
            this.credit.Margin = new System.Windows.Forms.Padding(3);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(101, 17);
            this.credit.TabIndex = 39;
            this.credit.TabStop = true;
            this.credit.Text = "Made by Ari Hanan";
            this.credit.UseCompatibleTextRendering = true;
            this.credit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.credit_LinkClicked);
            // 
            // display_font_dialog
            // 
            this.display_font_dialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            // 
            // bg_color_dialog
            // 
            this.bg_color_dialog.AnyColor = true;
            // 
            // bg_img_dialog
            // 
            this.bg_img_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.bg_img_dialog_FileOk);
            // 
            // bg_color_text_dialog
            // 
            this.bg_color_text_dialog.Color = System.Drawing.Color.White;
            // 
            // save_file_dialog
            // 
            this.save_file_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.save_file_dialog_FileOk);
            // 
            // load_file_dialog
            // 
            this.load_file_dialog.FileName = "openFileDialog1";
            this.load_file_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.load_file_dialog_FileOk);
            // 
            // settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(343, 288);
            this.Controls.Add(this.settings_tabcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(161, 169);
            this.Name = "settings_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.settings_tabcontrol.ResumeLayout(false);
            this.config_tab.ResumeLayout(false);
            this.config_tab.PerformLayout();
            this.config_container.ResumeLayout(false);
            this.align_tab.ResumeLayout(false);
            this.text_alignment_container.ResumeLayout(false);
            this.image_alignment_container.ResumeLayout(false);
            this.image_alignment_container.PerformLayout();
            this.image_align_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.margin_numeric)).EndInit();
            this.info_tab.ResumeLayout(false);
            this.info_tab.PerformLayout();
            this.text_textboxes_container.ResumeLayout(false);
            this.right_container.ResumeLayout(false);
            this.right_container.PerformLayout();
            this.center_container.ResumeLayout(false);
            this.center_container.PerformLayout();
            this.left_container.ResumeLayout(false);
            this.left_container.PerformLayout();
            this.backdrop_tab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display_shadow_strength_slider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.about_tab.ResumeLayout(false);
            this.about_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastfm_credit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.love)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button display_font_button;
        private System.Windows.Forms.TabControl settings_tabcontrol;
        private System.Windows.Forms.TabPage info_tab;
        private System.Windows.Forms.TabPage backdrop_tab;
        private System.Windows.Forms.Button bg_img_button;
        private System.Windows.Forms.Button bg_color_button;
        private System.Windows.Forms.RadioButton bg_img_radio;
        private System.Windows.Forms.RadioButton bg_color_radio;
        private System.Windows.Forms.RadioButton bg_auto_radio;
        private System.Windows.Forms.TabPage about_tab;
        private System.Windows.Forms.LinkLabel source;
        private System.Windows.Forms.LinkLabel credit;
        private System.Windows.Forms.FontDialog display_font_dialog;
        private System.Windows.Forms.ColorDialog bg_color_dialog;
        private System.Windows.Forms.OpenFileDialog bg_img_dialog;
        private System.Windows.Forms.PictureBox love;
        private System.Windows.Forms.Label markup_l;
        private System.Windows.Forms.TableLayoutPanel text_textboxes_container;
        private System.Windows.Forms.TabPage config_tab;
        private System.Windows.Forms.TabPage align_tab;
        private System.Windows.Forms.ComboBox image_horizonal_combo;
        private System.Windows.Forms.ComboBox text_align_combo;
        private System.Windows.Forms.ComboBox image_vertical_combo;
        private System.Windows.Forms.TableLayoutPanel image_align_container;
        private System.Windows.Forms.NumericUpDown margin_numeric;
        private System.Windows.Forms.Label margin_l;
        private System.Windows.Forms.ComboBox image_mode_combo;
        private System.Windows.Forms.TextBox left_textbox;
        private System.Windows.Forms.TextBox center_textbox;
        private System.Windows.Forms.TextBox right_textbox;
        private System.Windows.Forms.TableLayoutPanel config_container;
        private System.Windows.Forms.Button config_save;
        private System.Windows.Forms.Button config_load;
        private System.Windows.Forms.ComboBox config_combo;
        private System.Windows.Forms.Label config_l;
        private System.Windows.Forms.ComboBox text_align_cover_combo;
        private System.Windows.Forms.RadioButton bg_autog_radio;
        private System.Windows.Forms.GroupBox image_alignment_container;
        private System.Windows.Forms.GroupBox text_alignment_container;
        private System.Windows.Forms.GroupBox left_container;
        private System.Windows.Forms.GroupBox right_container;
        private System.Windows.Forms.GroupBox center_container;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bg_color_text_button;
        private System.Windows.Forms.RadioButton bg_auto_text_radio;
        private System.Windows.Forms.RadioButton bg_color_text_radio;
        private System.Windows.Forms.ColorDialog bg_color_text_dialog;
        private System.Windows.Forms.SaveFileDialog save_file_dialog;
        private System.Windows.Forms.OpenFileDialog load_file_dialog;
        private System.Windows.Forms.CheckBox display_shadow_checkbox;
        private System.Windows.Forms.PictureBox lastfm_credit;
        private System.Windows.Forms.Label display_shadow_streangth_slider_l;
        private System.Windows.Forms.TrackBar display_shadow_strength_slider;
    }
}