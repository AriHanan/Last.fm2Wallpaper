using System;
using SingleInstance;
using System.Windows.Forms;

namespace Lastfm2Wallpaper
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                SingleApplication.Run(new main_form());
        }
    }
}
 