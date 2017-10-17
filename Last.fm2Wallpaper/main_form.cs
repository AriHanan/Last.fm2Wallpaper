using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Drawing;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using Last.fm2Wallpaper.Properties;

namespace Lastfm2Wallpaper
{
    public partial class main_form : Form
    {
        private string api_key = "";
        private settings_form settings_form_var = new settings_form();
        NotifyIcon tray = new NotifyIcon();

        public enum ResizeMode
        {
            Contain,
            Cover,
            Stretch,
            Tile
        }
        public static ResizeMode resize_mode;
        public enum AlignVert
        {
            Top,
            Medium,
            Bottom
        }
        public static AlignVert align_vert;
        public enum AlignHor
        {
            Left,
            Center,
            Right
        }
        public static AlignHor align_hor;
        public static int art_margin;
        public enum AlignText
        {
            Left,
            Right,
            Top,
            Bottom,
            Center
        }
        public static AlignText align_text;

        public static string info_left;
        public static string info_center;
        public static string info_right;
        public static Font display_font;

        public enum Backdrop : int
        {
            Color,
            Image,
            Auto,
            AutoGardient
        }
        public static Backdrop bg_mode;
        public static Color bg_color;
        public static string bg_img;
        public static bool display_shadow;
        public static float shadow_strength;
        public static bool bg_color_text_bool;
        public static Color bg_color_text;


        public static string AlbumArtURL;
        public static Bitmap AlbumArt;
        public static string Artist = "";
        public static string Album = "";
        public static string Song = "";


        private Bitmap bg;
        private double vp;
        private int vw;
        private int vh;
        private int w;
        private int h;
        private int x;
        private int y;
        private int txt_margin;
        private float ch;
        private float cs;
        private float cb;
        private Color blend;
        private Color top;
        private Color buttom;
        private float intensity = 0.4f;
        private SolidBrush txt_clr;
        private string info_left_temp;
        private string info_center_temp;
        private string info_right_temp;
        Rectangle rec_top;
        Rectangle rec_bottom;
        Rectangle rec_left;
        Rectangle rec_right;
        TextureBrush tb_top    = new TextureBrush(Resources.shadow_top);
        TextureBrush tb_bottom = new TextureBrush(Resources.shadow_bottom);
        TextureBrush tb_left   = new TextureBrush(Resources.shadow_left);
        TextureBrush tb_right  = new TextureBrush(Resources.shadow_right);


        public main_form()
        {
            InitializeComponent();
            if(api_key == "")
            {
                key.Visible = true;
                key_l.Visible = true;
                Size = new Size(Size.Width, 111);
            }
            else
            {
                key.Visible = false;
                key_l.Visible = false;
                Size = new Size(Size.Width, 90);
            }

            AlbumArt = Resources._default;

            if (File.Exists("key_save"))
            {
                try
                {
                    StreamReader file = new StreamReader("key_save");
                    user.Text = file.ReadLine();
                    key.Text = file.ReadLine();
                    file.Close();
                }
                catch { }
            }

            try
            {
                if (Directory.Exists("temp"))
                {
                    Directory.Delete("temp", true);
                    while (Directory.Exists("temp")) { }
                }
                Directory.CreateDirectory("temp");
                while (!Directory.Exists("temp")) { }
            }
            catch { }
            
            tray.Icon = Resources.icon;
            tray.Visible = true;
            tray.MouseClick += tray_MouseClick;
            tray.ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Open", context_open),
                new MenuItem("Spanish inquasition"),
                new MenuItem("Exit application", context_exit),
            });
        }

        private void context_open(object sender, EventArgs e)
        {
            Show();
            BringToFront();
        }

        private void context_exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tray_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            BringToFront();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            settings_form_var.ShowDialog();
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            if (enable.Checked)
            {
                GetSong(user.Text, true);
            }
        }

        private async void GetSong(string user, bool hasinfo)
        {
            string OldURL = AlbumArtURL;
            Song = "";
            Artist = "";
            Album = "";
            AlbumArtURL = "";

            try
            {
                Lastfm.RootObject unicorn;

                if (api_key == "")
                {
                    unicorn = JsonConvert.DeserializeObject<Lastfm.RootObject>(await new WebClient().DownloadStringTaskAsync("http://ws.audioscrobbler.com/2.0/?method=user.getrecenttracks&user=" + user + "&api_key=" + key.Text + "&format=json"));
                }
                else
                {
                    unicorn = JsonConvert.DeserializeObject<Lastfm.RootObject>(await new WebClient().DownloadStringTaskAsync("http://ws.audioscrobbler.com/2.0/?method=user.getrecenttracks&user=" + user + "&api_key=" + api_key + "&format=json"));
                }

                if ((unicorn.recenttracks.track.FirstOrDefault().name != "") && (unicorn.recenttracks.track.FirstOrDefault().name != null))
                {
                    Song = unicorn.recenttracks.track.FirstOrDefault().name;
                }

                if ((unicorn.recenttracks.track.FirstOrDefault().artist.text != "") && (unicorn.recenttracks.track.FirstOrDefault().artist.text != null))
                {
                    Artist = unicorn.recenttracks.track.FirstOrDefault().artist.text;
                }

                if ((unicorn.recenttracks.track.FirstOrDefault().album.text != "") && (unicorn.recenttracks.track.FirstOrDefault().album.text != null))
                {
                    Album = unicorn.recenttracks.track.FirstOrDefault().album.text;
                }

                foreach (Lastfm.Image item in unicorn.recenttracks.track.FirstOrDefault().image)
                {
                    if ((item.text != "") && (item.text != null))
                    {
                        AlbumArtURL = item.text;
                    }
                }
            }
            catch { }
            
            if (AlbumArtURL == OldURL)
            {
                CreateImage();
            }
            else
            {
                AlbumArt = DownloadImage(AlbumArtURL);
                CreateImage();
            }
        }

        private Bitmap DownloadImage(string adress)
        {
            if (adress != "")
            {
                try
                {
                    WebRequest request = WebRequest.Create(adress);
                    WebResponse response = request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    return new Bitmap(responseStream);
                }
                catch { }
            }
            return Resources._default;
        }

        private void CreateImage()
        {
            try
            {
                if (File.Exists(@"temp\bg.png"))
                {
                    File.Delete(@"temp\bg.png");
                }

                vw = Screen.PrimaryScreen.Bounds.Width;
                vh = Screen.PrimaryScreen.Bounds.Height;
                if (vw > vh)
                {
                    vp = vh * 0.01;
                }
                else
                {
                    vp = vw * 0.01;
                }

                switch (resize_mode)
                {
                    case ResizeMode.Contain:
                        if (vw > vh)
                        {
                            w = Math.Max(67, vh - (int)(art_margin * 2 * vp));
                            h = w;
                        }
                        else
                        {
                            w = Math.Max(67, vw - (int)(art_margin * 2 * vp));
                            h = w;
                        }
                        switch (align_hor)
                        {
                            case AlignHor.Left:
                                x = (int)(art_margin * vp);
                                break;
                            case AlignHor.Center:
                                x = (int)((vw - w) * 0.5);
                                break;
                            case AlignHor.Right:
                                x = vw - w - (int)(art_margin * vp);
                                break;
                        }
                        switch (align_vert)
                        {
                            case AlignVert.Bottom:
                                y = (int)(art_margin * vp * 1.5);
                                break;
                            case AlignVert.Medium:
                                y = (int)(art_margin * vp * 1);
                                break;
                            case AlignVert.Top:
                                y = (int)(art_margin * vp * 0.5);
                                break;
                        }
                        break;

                    case ResizeMode.Cover:
                        if (vw > vh)
                        {
                            w = vw;
                            h = vw;
                        }
                        else
                        {
                            w = vh;
                            h = vh;
                        }
                        switch (align_hor)
                        {
                            case AlignHor.Left:
                                x = 0;
                                break;
                            case AlignHor.Center:
                                x = (int)(vw * 0.5 - w * 0.5);
                                break;
                            case AlignHor.Right:
                                x = vw - w;
                                break;
                        }
                        switch (align_vert)
                        {
                            case AlignVert.Bottom:
                                y = vh - h;
                                break;
                            case AlignVert.Medium:
                                y = (int)(vh * 0.5f - h * 0.5f);
                                break;
                            case AlignVert.Top:
                                y = 0;
                                break;
                        }
                        break;

                    case ResizeMode.Stretch:
                        w = vw;
                        h = vh;
                        x = 0;
                        y = 0;
                        break;

                    case ResizeMode.Tile:
                        w = (int)((50 - art_margin) * vp * 2);
                        h = w;
                        x = 0;
                        y = 0;
                        break;
                }

                info_left_temp   = info_left  .Replace("[Track]", Song).Replace("[Album]", Album).Replace("[Artist]", Artist);
                info_center_temp = info_center.Replace("[Track]", Song).Replace("[Album]", Album).Replace("[Artist]", Artist);
                info_right_temp  = info_right .Replace("[Track]", Song).Replace("[Album]", Album).Replace("[Artist]", Artist);

                if (bg_mode == Backdrop.Image)
                {
                    bg = new Bitmap(new Bitmap(bg_img), vw, vh);
                }
                else
                {
                    bg = new Bitmap(vw, vh);
                }
                using (Graphics g = Graphics.FromImage(bg))
                {
                    if (resize_mode == ResizeMode.Tile)
                    {
                        g.FillRectangle(new TextureBrush(new Bitmap(AlbumArt, w, h)), 0, 0, vw, vh);
                    }
                    else
                    {
                        switch (bg_mode)
                        {
                            case Backdrop.Auto:
                                top = AlbumArt.GetPixel(0, 0);
                                g.FillRectangle(new SolidBrush(top), 0, 0, vw, vh);
                                break;
                            case Backdrop.Color:
                                g.FillRectangle(new SolidBrush(bg_color), 0, 0, vw, vh);
                                break;
                            case Backdrop.AutoGardient:
                                top = AlbumArt.GetPixel(0, 0);
                                buttom = AlbumArt.GetPixel(AlbumArt.Width - 1, AlbumArt.Height - 1);
                                LinearGradientBrush linGrBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, vh), top, buttom);
                                g.FillRectangle(linGrBrush, 0, 0, vw, vh);
                                break;
                        }

                        if ((display_shadow) && (resize_mode == ResizeMode.Contain)) {
                            g.CompositingMode = CompositingMode.SourceOver;
                            g.SmoothingMode = SmoothingMode.None;
                            g.InterpolationMode = InterpolationMode.NearestNeighbor;

                            g.DrawImage(ChangeOpacity(Resources.shadow_top_left    , shadow_strength), x     - 32, y     - 32);
                            g.DrawImage(ChangeOpacity(Resources.shadow_top_right   , shadow_strength), x + w - 33, y     - 32);
                            g.DrawImage(ChangeOpacity(Resources.shadow_bottom_left , shadow_strength), x     - 32, y + h - 33);
                            g.DrawImage(ChangeOpacity(Resources.shadow_bottom_right, shadow_strength), x + w - 33, y + h - 33);

                            TextureBrush tb_top    = new TextureBrush(ChangeOpacity(Resources.shadow_top   , shadow_strength));
                            TextureBrush tb_bottom = new TextureBrush(ChangeOpacity(Resources.shadow_bottom, shadow_strength));
                            TextureBrush tb_left   = new TextureBrush(ChangeOpacity(Resources.shadow_left  , shadow_strength));
                            TextureBrush tb_right  = new TextureBrush(ChangeOpacity(Resources.shadow_right , shadow_strength));
                            rec_top    = new Rectangle(x     + 33, y     - 32,     w - 66, 65);
                            rec_bottom = new Rectangle(x     + 33, y + h - 33,     w - 66, 65);
                            rec_left   = new Rectangle(x     - 32, y     + 33, 65, h - 66    );
                            rec_right  = new Rectangle(x + w - 33, y     + 33, 65, h - 66    );
                            tb_top   .ResetTransform();
                            tb_bottom.ResetTransform();
                            tb_left  .ResetTransform();
                            tb_right .ResetTransform();
                            tb_top   .TranslateTransform(rec_top   .X, rec_top   .Y);
                            tb_bottom.TranslateTransform(rec_bottom.X, rec_bottom.Y);
                            tb_left  .TranslateTransform(rec_left  .X, rec_left  .Y);
                            tb_right .TranslateTransform(rec_right .X, rec_right .Y);
                            g.FillRectangle(tb_top   , rec_top   );
                            g.FillRectangle(tb_bottom, rec_bottom);
                            g.FillRectangle(tb_left  , rec_left  );
                            g.FillRectangle(tb_right , rec_right );
                        }

                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.DrawImage(new Bitmap(AlbumArt, w, h), x, y);
                    }

                    if (bg_color_text_bool)
                    {
                        txt_clr = new SolidBrush(bg_color_text);
                    }
                    else
                    {
                        switch (bg_mode)
                        {
                            case Backdrop.Auto:
                                ch = top.GetHue();
                                cs = top.GetSaturation();
                                cb = top.GetBrightness();
                                break;
                            case Backdrop.Color:
                                ch = bg_color.GetHue();
                                cs = bg_color.GetSaturation();
                                cb = bg_color.GetBrightness();
                                break;
                            case Backdrop.AutoGardient:
                                blend = BlendColors(top, buttom, 0.5f);
                                ch = blend.GetHue();
                                cs = blend.GetSaturation();
                                cb = blend.GetBrightness();
                                break;
                        }
                        if (cb < 0.5)
                        {
                            txt_clr = new SolidBrush(FromHSLA(ch, cs, Math.Max((1 - cb) * intensity + cb, 1 - cb), 1f));
                        }
                        else
                        {
                            txt_clr = new SolidBrush(FromHSLA(ch, cs, Math.Min(cb * (1 - intensity), 1 - cb), 1f));
                        }
                    }

                    StringFormat format = new StringFormat();
                    if (resize_mode == ResizeMode.Contain)
                    {
                        switch (align_text)
                        {
                            case AlignText.Bottom:
                                format.LineAlignment = StringAlignment.Near;
                                format.Alignment = StringAlignment.Near  ; g.DrawString(info_left_temp  , display_font, txt_clr, new Rectangle(x, y + h, w, vh - y - h), format);
                                format.Alignment = StringAlignment.Center; g.DrawString(info_center_temp, display_font, txt_clr, new Rectangle(x, y + h, w, vh - y - h), format);
                                format.Alignment = StringAlignment.Far   ; g.DrawString(info_right_temp , display_font, txt_clr, new Rectangle(x, y + h, w, vh - y - h), format);
                                break;
                            case AlignText.Left:
                                format.LineAlignment = StringAlignment.Center;
                                format.Alignment = StringAlignment.Near  ; g.DrawString(info_left_temp  , display_font, txt_clr, new Rectangle(0, y, x, h), format);
                                format.Alignment = StringAlignment.Center; g.DrawString(info_center_temp, display_font, txt_clr, new Rectangle(0, y, x, h), format);
                                format.Alignment = StringAlignment.Far   ; g.DrawString(info_right_temp , display_font, txt_clr, new Rectangle(0, y, x, h), format);
                                break;
                            case AlignText.Right:
                                format.LineAlignment = StringAlignment.Center;
                                format.Alignment = StringAlignment.Near  ; g.DrawString(info_left_temp  , display_font, txt_clr, new Rectangle(x + w, y, vw - x - w, h), format);
                                format.Alignment = StringAlignment.Center; g.DrawString(info_center_temp, display_font, txt_clr, new Rectangle(x + w, y, vw - x - w, h), format);
                                format.Alignment = StringAlignment.Far   ; g.DrawString(info_right_temp , display_font, txt_clr, new Rectangle(x + w, y, vw - x - w, h), format);
                                break;
                            case AlignText.Top:
                                format.LineAlignment = StringAlignment.Far;
                                format.Alignment = StringAlignment.Near  ; g.DrawString(info_left_temp  , display_font, txt_clr, new Rectangle(x, 0, w, y), format);
                                format.Alignment = StringAlignment.Center; g.DrawString(info_center_temp, display_font, txt_clr, new Rectangle(x, 0, w, y), format);
                                format.Alignment = StringAlignment.Far   ; g.DrawString(info_right_temp , display_font, txt_clr, new Rectangle(x, 0, w, y), format);
                                break;
                        }
                    }
                    else
                    {
                        if (resize_mode == ResizeMode.Tile)
                        {
                            txt_margin = 5;
                        }
                        else
                        {
                            txt_margin = art_margin;
                        }

                        switch (align_text)
                        {
                            case AlignText.Bottom:
                                format.LineAlignment = StringAlignment.Far;
                                break;
                            case AlignText.Center:
                                format.LineAlignment = StringAlignment.Center;
                                break;
                            case AlignText.Top:
                                format.LineAlignment = StringAlignment.Near;
                                break;
                        }
                        format.Alignment = StringAlignment.Near  ; g.DrawString(info_left_temp  , display_font, txt_clr, new Rectangle((int)(txt_margin * vp), (int)(txt_margin * vp), vw - (int)(txt_margin * vp * 2), vh - (int)(txt_margin * vp * 2)), format);
                        format.Alignment = StringAlignment.Center; g.DrawString(info_center_temp, display_font, txt_clr, new Rectangle((int)(txt_margin * vp), (int)(txt_margin * vp), vw - (int)(txt_margin * vp * 2), vh - (int)(txt_margin * vp * 2)), format);
                        format.Alignment = StringAlignment.Far   ; g.DrawString(info_right_temp , display_font, txt_clr, new Rectangle((int)(txt_margin * vp), (int)(txt_margin * vp), vw - (int)(txt_margin * vp * 2), vh - (int)(txt_margin * vp * 2)), format);
                    }
                }

                bg.Save(@"temp\bg.bmp", ImageFormat.Bmp);
                bg.Save(@"temp\bg.png", ImageFormat.Png);
                bg.Dispose();
                Wallpaper.Set(AppDomain.CurrentDomain.BaseDirectory + @"temp\bg.bmp", Wallpaper.Style.Centered);
                Wallpaper.Set(AppDomain.CurrentDomain.BaseDirectory + @"temp\bg.png", Wallpaper.Style.Centered);
            }
            catch { }
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            StreamWriter file = new StreamWriter("key_save");
            file.WriteLine(user.Text);
            file.WriteLine(key.Text);
            file.Close();
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            Save();
        }
        
        private Color FromHSLA(float H, float S, float L, float A)
        {
            Math.Max(Math.Min(H, 360), 0);
            Math.Max(Math.Min(S,   1), 0);
            Math.Max(Math.Min(L,   1), 0);
            Math.Max(Math.Min(A,   1), 0);

            float v;
            float r, g, b;

            r = L;   // default to gray
            g = L;
            b = L;
            v = (float)((L <= 0.5) ? (L * (1.0 + S)) : (L + S - L * S));
            if (v > 0)
            {
                float m;
                float sv;
                int sextant;
                float fract, vsf, mid1, mid2;

                m = L + L - v;
                sv = (v - m) / v;
                H *= 6f / 360;
                sextant = (int)H;
                fract = H - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;
                switch (sextant)
                {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;
                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;
                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;
                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;
                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }
            return Color.FromArgb(Convert.ToByte(A * 255.0f), Convert.ToByte(r * 255.0f), Convert.ToByte(g * 255.0f), Convert.ToByte(b * 255.0f));
        }
        
        private Color BlendColors(Color color, Color backColor, float amount)
        {
            byte r = (byte)((color.R * amount) + backColor.R * (1 - amount));
            byte g = (byte)((color.G * amount) + backColor.G * (1 - amount));
            byte b = (byte)((color.B * amount) + backColor.B * (1 - amount));
            return Color.FromArgb(r, g, b);
        }
        
        private Bitmap ChangeOpacity(Bitmap img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();
            return bmp;
        }

        private void key_l_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.last.fm/api/account/create");
        }

        private void main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
