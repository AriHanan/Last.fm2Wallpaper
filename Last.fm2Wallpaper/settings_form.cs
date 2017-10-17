using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace Lastfm2Wallpaper
{
    public partial class settings_form : Form
    {
        string loc = "savefile";
        TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
        bool working = true;

        public settings_form()
        {
            InitializeComponent();

            text_align_cover_combo.Location = text_align_combo.Location;

            if (File.Exists(loc))
            {
                Load_File(loc);
            }
            else
            {
                image_mode_combo.SelectedIndex = 0;
                image_vertical_combo.SelectedIndex = 1;
                image_horizonal_combo.SelectedIndex = 0;
                text_align_combo.SelectedIndex = 1;
                text_align_cover_combo.SelectedIndex = 1;
                config_combo.SelectedIndex = 0;
                Sync();
            }
        }
        
        private void config_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (working)
            {
                switch (config_combo.SelectedIndex)
                {
                    case 0://side text

                        image_mode_combo.SelectedIndex = 0;
                        image_vertical_combo.SelectedIndex = 1;
                        image_horizonal_combo.SelectedIndex = 0;
                        margin_numeric.Value = 15;
                        text_align_combo.SelectedIndex = 1;

                        left_textbox.Text = "";
                        center_textbox.Text = "[Track]" + Environment.NewLine + "[Album]" + Environment.NewLine + "[Artist]";
                        right_textbox.Text = "";

                        break;
                    case 1://bottom text

                        image_mode_combo.SelectedIndex = 0;
                        image_vertical_combo.SelectedIndex = 0;
                        image_horizonal_combo.SelectedIndex = 1;
                        margin_numeric.Value = 15;
                        text_align_combo.SelectedIndex = 3;

                        left_textbox.Text = "[Track]";
                        center_textbox.Text = Environment.NewLine + Environment.NewLine + "[Artist]";
                        right_textbox.Text = Environment.NewLine + "[Album]";

                        break;
                    case 2://fullscreen

                        image_mode_combo.SelectedIndex = 1;
                        image_vertical_combo.SelectedIndex = 1;
                        image_horizonal_combo.SelectedIndex = 0;
                        text_align_cover_combo.SelectedIndex = 2;

                        left_textbox.Text = "[Track]" + Environment.NewLine + "[Album]" + Environment.NewLine + "[Artist]";
                        center_textbox.Text = "";
                        right_textbox.Text = "";

                        break;
                    case 3://album art only

                        image_mode_combo.SelectedIndex = 0;
                        image_vertical_combo.SelectedIndex = 1;
                        image_horizonal_combo.SelectedIndex = 1;
                        margin_numeric.Value = 15;

                        left_textbox.Text = "";
                        center_textbox.Text = "";
                        right_textbox.Text = "";

                        break;
                }

                Save_File(loc);
            }
        }
        
        private void config_save_Click(object sender, EventArgs e)
        {
            save_file_dialog.ShowDialog();
        }
        
        private void save_file_dialog_FileOk(object sender, CancelEventArgs e)
        {
            Save_File(save_file_dialog.FileName);
        }

        private void Save_File(string path)
        {
            if (working)
            {
                try
                {
                    StreamWriter file = new StreamWriter(path);

                    file.WriteLine(config_combo.SelectedIndex);
                    file.WriteLine(image_mode_combo.SelectedIndex);
                    file.WriteLine(image_vertical_combo.SelectedIndex);
                    file.WriteLine(image_horizonal_combo.SelectedIndex);
                    file.WriteLine(margin_numeric.Value);
                    file.WriteLine(text_align_combo.SelectedIndex);
                    file.WriteLine(text_align_cover_combo.SelectedIndex);
                    file.WriteLine(left_textbox.Text);
                    file.WriteLine("--------randomnonsense--------");
                    file.WriteLine(center_textbox.Text);
                    file.WriteLine("--------randomnonsense--------");
                    file.WriteLine(right_textbox.Text);
                    file.WriteLine("--------randomnonsense--------");
                    file.WriteLine(converter.ConvertToString(display_font_dialog.Font));
                    if (bg_color_radio.Checked)
                    {
                        file.WriteLine(0);
                    }
                    else
                    {
                        if (bg_img_radio.Checked)
                        {
                            file.WriteLine(1);
                        }
                        else
                        {
                            if (bg_auto_radio.Checked)
                            {
                                file.WriteLine(2);
                            }
                            else
                            {
                                file.WriteLine(3);
                            }
                        }
                    }
                    file.WriteLine(bg_color_dialog.Color.ToArgb());
                    file.WriteLine(bg_img_dialog.FileName);
                    file.WriteLine(display_shadow_checkbox.Checked);
                    file.WriteLine(display_shadow_strength_slider.Value);
                    file.WriteLine(bg_color_text_radio.Checked);
                    file.WriteLine(bg_color_text_dialog.Color.ToArgb());

                    file.Close();
                }
                catch { }
            }
        }

        private void config_load_Click(object sender, EventArgs e)
        {
            load_file_dialog.ShowDialog();
        }
        
        private void load_file_dialog_FileOk(object sender, CancelEventArgs e)
        {
            Load_File(load_file_dialog.FileName);
        }

        private void Load_File(string path)
        {
            working = false;

            try
            {
                StreamReader file = new StreamReader(path);

                Int32.TryParse(file.ReadLine(), out int int_config_combo);
                Int32.TryParse(file.ReadLine(), out int int_image_mode_combo);
                Int32.TryParse(file.ReadLine(), out int int_image_vertical_combo);
                Int32.TryParse(file.ReadLine(), out int int_image_horizonal_combo);
                Int32.TryParse(file.ReadLine(), out int int_margin_numeric);
                Int32.TryParse(file.ReadLine(), out int int_text_align_combo);
                Int32.TryParse(file.ReadLine(), out int int_text_align_cover_combo);
                string string_left_textbox = "";
                while (true)
                {
                    string line = file.ReadLine();
                    if (line == "--------randomnonsense--------")
                    {
                        try
                        {
                            string_left_textbox = string_left_textbox.Substring(0, string_left_textbox.Length - 2);
                        }
                        catch
                        {
                            string_left_textbox = "";
                        }
                        
                        break;
                    }
                    else
                    {
                        string_left_textbox += line + Environment.NewLine;
                    }
                }
                string string_center_textbox = "";
                while (true)
                {
                    string line = file.ReadLine();
                    if (line == "--------randomnonsense--------")
                    {
                        try
                        {
                            string_center_textbox = string_center_textbox.Substring(0, string_center_textbox.Length - 2);
                        }
                        catch
                        {
                            string_center_textbox = "";
                        }
                        
                        break;
                    }
                    else
                    {
                        string_center_textbox += line + Environment.NewLine;
                    }
                }
                string string_right_textbox = "";
                while (true)
                {
                    string line = file.ReadLine();
                    if (line == "--------randomnonsense--------")
                    {
                        try
                        {
                            string_right_textbox = string_right_textbox.Substring(0, string_right_textbox.Length - 2);
                        }
                        catch
                        {
                            string_right_textbox = "";
                        }
                        
                        break;
                    }
                    else
                    {
                        string_right_textbox += line + Environment.NewLine;
                    }
                }
                string string_display_font_dialog = file.ReadLine();
                Int32.TryParse(file.ReadLine(), out int int_bg);
                Int32.TryParse(file.ReadLine(), out int int_bg_color_dialog);
                string string_bg_img_dialog = file.ReadLine();
                Boolean.TryParse(file.ReadLine(), out bool bool_display_shadow_checkbox);
                Int32.TryParse(file.ReadLine(), out int int_display_shadow_strength_slider);
                Boolean.TryParse(file.ReadLine(), out bool bool_bg_color_text_radio);
                Int32.TryParse(file.ReadLine(), out int int_bg_color_text_dialog);

                file.Close();

                config_combo.SelectedIndex = int_config_combo;
                image_mode_combo.SelectedIndex = int_image_mode_combo;
                image_vertical_combo.SelectedIndex = int_image_vertical_combo;
                image_horizonal_combo.SelectedIndex = int_image_horizonal_combo;
                margin_numeric.Value = int_margin_numeric;
                text_align_combo.SelectedIndex = int_text_align_combo;
                text_align_cover_combo.SelectedIndex = int_text_align_cover_combo;
                left_textbox.Text = string_left_textbox;
                center_textbox.Text = string_center_textbox;
                right_textbox.Text = string_right_textbox;
                display_font_dialog.Font = (Font)converter.ConvertFromString(string_display_font_dialog);
                switch (int_bg)
                {
                    case 0:
                        bg_color_radio.Checked = true;
                        break;
                    case 1:
                        bg_img_radio.Checked = true;
                        break;
                    case 2:
                        bg_auto_radio.Checked = true;
                        break;
                    case 3:
                        bg_autog_radio.Checked = true;
                        break;
                }
                bg_color_dialog.Color = Color.FromArgb(int_bg_color_dialog);
                bg_img_dialog.FileName = string_bg_img_dialog;
                display_shadow_checkbox.Checked = bool_display_shadow_checkbox;
                display_shadow_strength_slider.Value = int_display_shadow_strength_slider;
                bg_color_text_radio.Checked = bool_bg_color_text_radio;
                bg_auto_text_radio.Checked = !bool_bg_color_text_radio;
                bg_color_text_dialog.Color = Color.FromArgb(int_bg_color_text_dialog);
            }
            catch { }

            Sync();

            working = true;
        }

        private void Sync()
        {
            switch (image_mode_combo.SelectedIndex)
            {
                case 0:
                    text_align_cover_combo.Visible = false;
                    text_align_combo.Visible = true;
                    main_form.resize_mode = main_form.ResizeMode.Contain;
                    break;
                case 1:
                    text_align_cover_combo.Visible = true;
                    text_align_combo.Visible = false;
                    main_form.resize_mode = main_form.ResizeMode.Cover;
                    break;
                case 2:
                    text_align_cover_combo.Visible = true;
                    text_align_combo.Visible = false;
                    main_form.resize_mode = main_form.ResizeMode.Stretch;
                    break;
                case 3:
                    text_align_cover_combo.Visible = true;
                    text_align_combo.Visible = false;
                    main_form.resize_mode = main_form.ResizeMode.Tile;
                    break;
            }

            switch (image_vertical_combo.SelectedIndex)
            {
                case 0:
                    main_form.align_vert = main_form.AlignVert.Top;
                    break;
                case 1:
                    main_form.align_vert = main_form.AlignVert.Medium;
                    break;
                case 2:
                    main_form.align_vert = main_form.AlignVert.Bottom;
                    break;
            }

            switch (image_horizonal_combo.SelectedIndex)
            {
                case 0:
                    main_form.align_hor = main_form.AlignHor.Left;
                    break;
                case 1:
                    main_form.align_hor = main_form.AlignHor.Center;
                    break;
                case 2:
                    main_form.align_hor = main_form.AlignHor.Right;
                    break;
            }

            main_form.art_margin = (int)margin_numeric.Value;

            if (image_mode_combo.SelectedIndex == 0)
            {
                switch (text_align_combo.SelectedIndex)
                {
                    case 0:
                        main_form.align_text = main_form.AlignText.Left;
                        break;
                    case 1:
                        main_form.align_text = main_form.AlignText.Right;
                        break;
                    case 2:
                        main_form.align_text = main_form.AlignText.Top;
                        break;
                    case 3:
                        main_form.align_text = main_form.AlignText.Bottom;
                        break;
                }
            }
            else
            {
                switch (text_align_cover_combo.SelectedIndex)
                {
                    case 0:
                        main_form.align_text = main_form.AlignText.Top;
                        break;
                    case 1:
                        main_form.align_text = main_form.AlignText.Center;
                        break;
                    case 2:
                        main_form.align_text = main_form.AlignText.Bottom;
                        break;
                }
            }

            main_form.info_left = left_textbox.Text;
            main_form.info_center = center_textbox.Text;
            main_form.info_right = right_textbox.Text;

            main_form.display_font = display_font_dialog.Font;

            if (bg_color_radio.Checked)
            {
                main_form.bg_mode = main_form.Backdrop.Color;
            }
            else
            {
                if (bg_img_radio.Checked)
                {
                    main_form.bg_mode = main_form.Backdrop.Image;
                }
                else
                {
                    if (bg_auto_radio.Checked)
                    {
                        main_form.bg_mode = main_form.Backdrop.Auto;
                    }
                    else
                    {
                        main_form.bg_mode = main_form.Backdrop.AutoGardient;
                    }
                }
            }

            main_form.bg_color = bg_color_dialog.Color;

            main_form.bg_img = bg_img_dialog.FileName;

            main_form.display_shadow = display_shadow_checkbox.Checked;

            main_form.shadow_strength = display_shadow_strength_slider.Value * 0.01f;

            if (bg_color_text_radio.Checked)
            {
                main_form.bg_color_text_bool = true;
            }
            else
            {
                main_form.bg_color_text_bool = false;
            }

            main_form.bg_color_text = bg_color_text_dialog.Color;
        }

        private void image_mode_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (image_mode_combo.SelectedIndex)
            {
                case 0:
                    text_align_cover_combo.Visible = false;
                    text_align_combo.Visible = true;
                    main_form.resize_mode = main_form.ResizeMode.Contain;
                    switch (text_align_combo.SelectedIndex)
                    {
                        case 0:
                            main_form.align_text = main_form.AlignText.Left;
                            break;
                        case 1:
                            main_form.align_text = main_form.AlignText.Right;
                            break;
                        case 2:
                            main_form.align_text = main_form.AlignText.Top;
                            break;
                        case 3:
                            main_form.align_text = main_form.AlignText.Bottom;
                            break;
                    }
                    break;
                case 1:
                    text_align_cover_combo.Visible = true;
                    text_align_combo.Visible = false;
                    main_form.resize_mode = main_form.ResizeMode.Cover;
                    switch (text_align_cover_combo.SelectedIndex)
                    {
                        case 0:
                            main_form.align_text = main_form.AlignText.Top;
                            break;
                        case 1:
                            main_form.align_text = main_form.AlignText.Center;
                            break;
                        case 2:
                            main_form.align_text = main_form.AlignText.Bottom;
                            break;
                    }
                    break;
                case 2:
                    text_align_cover_combo.Visible = true;
                    text_align_combo.Visible = false;
                    main_form.resize_mode = main_form.ResizeMode.Stretch;
                    switch (text_align_cover_combo.SelectedIndex)
                    {
                        case 0:
                            main_form.align_text = main_form.AlignText.Top;
                            break;
                        case 1:
                            main_form.align_text = main_form.AlignText.Center;
                            break;
                        case 2:
                            main_form.align_text = main_form.AlignText.Bottom;
                            break;
                    }
                    break;
                case 3:
                    text_align_cover_combo.Visible = true;
                    text_align_combo.Visible = false;
                    main_form.resize_mode = main_form.ResizeMode.Tile;
                    switch (text_align_cover_combo.SelectedIndex)
                    {
                        case 0:
                            main_form.align_text = main_form.AlignText.Top;
                            break;
                        case 1:
                            main_form.align_text = main_form.AlignText.Center;
                            break;
                        case 2:
                            main_form.align_text = main_form.AlignText.Bottom;
                            break;
                    }
                    break;
            }
            Save_File(loc);
        }

        private void image_vertical_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (image_vertical_combo.SelectedIndex)
            {
                case 0:
                    main_form.align_vert = main_form.AlignVert.Top;
                    break;
                case 1:
                    main_form.align_vert = main_form.AlignVert.Medium;
                    break;
                case 2:
                    main_form.align_vert = main_form.AlignVert.Bottom;
                    break;
            }
            Save_File(loc);
        }

        private void image_horizonal_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (image_horizonal_combo.SelectedIndex)
            {
                case 0:
                    main_form.align_hor = main_form.AlignHor.Left;
                    break;
                case 1:
                    main_form.align_hor = main_form.AlignHor.Center;
                    break;
                case 2:
                    main_form.align_hor = main_form.AlignHor.Right;
                    break;
            }
            Save_File(loc);
        }

        private void margin_numeric_ValueChanged(object sender, EventArgs e)
        {
            main_form.art_margin = (int)margin_numeric.Value;
            Save_File(loc);
        }

        private void text_align_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (text_align_combo.SelectedIndex)
            {
                case 0:
                    main_form.align_text = main_form.AlignText.Left;
                    break;
                case 1:
                    main_form.align_text = main_form.AlignText.Right;
                    break;
                case 2:
                    main_form.align_text = main_form.AlignText.Top;
                    break;
                case 3:
                    main_form.align_text = main_form.AlignText.Bottom;
                    break;
            }
            Save_File(loc);
        }

        private void text_align_cover_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (text_align_cover_combo.SelectedIndex)
            {
                case 0:
                    main_form.align_text = main_form.AlignText.Top;
                    break;
                case 1:
                    main_form.align_text = main_form.AlignText.Center;
                    break;
                case 2:
                    main_form.align_text = main_form.AlignText.Bottom;
                    break;
            }
            Save_File(loc);
        }

        private void left_textbox_TextChanged(object sender, EventArgs e)
        {
            main_form.info_left = left_textbox.Text;
            Save_File(loc);
        }

        private void center_textbox_TextChanged(object sender, EventArgs e)
        {
            main_form.info_center = center_textbox.Text;
            Save_File(loc);
        }

        private void right_textbox_TextChanged(object sender, EventArgs e)
        {
            main_form.info_right = right_textbox.Text;
            Save_File(loc);
        }

        private void display_font_button_Click(object sender, EventArgs e)
        {
            DialogResult result = display_font_dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                main_form.display_font = display_font_dialog.Font;
            }
            Save_File(loc);
        }

        private void bg_color_radio_CheckedChanged(object sender, EventArgs e)
        {
            main_form.bg_mode = main_form.Backdrop.Color;
            Save_File(loc);
        }

        private void bg_color_button_Click(object sender, EventArgs e)
        {
            DialogResult result = bg_color_dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                main_form.bg_color = bg_color_dialog.Color;
            }
            Save_File(loc);
        }

        private void bg_img_radio_CheckedChanged(object sender, EventArgs e)
        {
            main_form.bg_mode = main_form.Backdrop.Image;
            Save_File(loc);
        }
        
        private void bg_img_button_Click(object sender, EventArgs e)
        {
            bg_img_dialog.ShowDialog();
        }

        private void bg_img_dialog_FileOk(object sender, CancelEventArgs e)
        {
            main_form.bg_img = bg_img_dialog.FileName;
            Save_File(loc);
        }

        private void bg_auto_radio_CheckedChanged(object sender, EventArgs e)
        {
            main_form.bg_mode = main_form.Backdrop.Auto;
            Save_File(loc);
        }
        
        private void bg_autog_radio_CheckedChanged(object sender, EventArgs e)
        {
            main_form.bg_mode = main_form.Backdrop.AutoGardient;
            Save_File(loc);
        }

        private void display_shadow_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            main_form.display_shadow = display_shadow_checkbox.Checked;
            Save_File(loc);
        }

        private void display_shadow_strength_slider_Scroll(object sender, EventArgs e)
        {
            main_form.shadow_strength = display_shadow_strength_slider.Value * 0.01f;
            Save_File(loc);
        }

        private void bg_color_text_radio_CheckedChanged(object sender, EventArgs e)
        {
            main_form.bg_color_text_bool = true;
            Save_File(loc);
        }

        private void bg_auto_text_radio_CheckedChanged(object sender, EventArgs e)
        {
            main_form.bg_color_text_bool = false;
            Save_File(loc);
        }
        
        private void bg_color_text_button_Click(object sender, EventArgs e)
        {
            DialogResult result = bg_color_text_dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                main_form.bg_color_text = bg_color_text_dialog.Color;
            }
            Save_File(loc);
        }

        private void credit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://arihanan.tumblr.com/");
        }

        private void source_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/AriHanan/Last.fm2Wallpaper");
        }

        private void lastfm_credit_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.last.fm/");
        }
    }
}
