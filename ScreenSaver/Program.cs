using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;

namespace ScreenSaver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //variables with default data
            DataSettings dataOne = new DataSettings("Arial", 14, FontStyle.Bold, Color.DarkGreen, 100, 1, 1,
                DataSettings.Direction.topToBottom, "0");
            DataSettings dataTwo = new DataSettings("Arial", 14, FontStyle.Bold, Color.LightGreen, 100, 1, 1,
                DataSettings.Direction.topToBottom, "1");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadRegister(ref dataOne, ref dataTwo);

            if (args.Length > 0)
            {

                switch (args[0].ToLower().Trim().Substring(0, 2))
                {
                    case "/c":
                        //settings
                        Application.Run(new frmSettings(dataOne, dataTwo));
                        break;
                    case "/s":
                        //test large screen
                        for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++)
                        {
                            Application.Run(new frmSaver(IntPtr.Zero, Screen.AllScreens[i].Bounds, dataOne, dataTwo));//qtde_1, qtde_2, cor_1, cor_2, font_1, font_2, velo_min_1, velo_min_2, velo_max_1, velo_max_2, cima, texto_1, texto_2));
                        }

                        break;
                    case "/p":
                        //view - small screen
                        IntPtr paramhandle = (IntPtr)uint.Parse(args[1].ToLower().Trim());
                        Application.Run(new frmSaver(paramhandle, new Rectangle(0, 0, 0, 0), dataOne, dataTwo));//qtde_1, qtde_2, cor_1, cor_2, font_1, font_2, velo_min_1, velo_min_2, velo_max_1, velo_max_2, cima, texto_1, texto_2));
                        break;
                    default:
                        //settings
                        Application.Run(new frmSettings(dataOne, dataTwo));
                        break;
                }
            }
            else
            {
                //settings
                Application.Run(new frmSettings(dataOne, dataTwo));
            }
        }

        /// <summary>
        /// Static function that loads the data from the windows registry in HKEY_LOCAL_MACHINE\SOFTWARE\ScreenSaverBill
        /// if it does not exist it maintains the default data and writes nothing in the registry
        /// </summary>
        /// <param name="dataOne">Settings of text one</param>
        /// <param name="dataTwo">Settings of text two</param>
        private static void LoadRegister(ref DataSettings dataOne, ref DataSettings dataTwo)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\ScreenSaverBill");

            if (key != null)
            {
                dataOne.MinimumTextSpeed = (double)key.GetValue("MinimumTextSpeedOne");
                dataTwo.MinimumTextSpeed = (double)key.GetValue("MinimumTextSpeedTwo");
                dataOne.MaximumTextSpeed = (double)key.GetValue("MaximumTextSpeedOne");
                dataTwo.MaximumTextSpeed = (double)key.GetValue("MaximumTextSpeedTwo");
                dataOne.AmountText = (int)key.GetValue("AmountTextOne");
                dataTwo.AmountText = (int)key.GetValue("AmountTextTwo");
                dataOne.TextDirection = (DataSettings.Direction)key.GetValue("TextDirectionOne");
                dataTwo.TextDirection = (DataSettings.Direction)key.GetValue("TextDirectionTwo");
                key = key.OpenSubKey("Font");

                if (key != null)
                {
                    dataOne.TextColor = Color.FromArgb((int)key.GetValue("TextColorOne"));
                    dataTwo.TextColor = Color.FromArgb((int)key.GetValue("TextColorTwo"));
                    dataOne.TextFont = new Font((string)key.GetValue("TextFontNameOne"), float.Parse(key.GetValue("TextFontSizeOne").ToString()),
                        (FontStyle)key.GetValue("TextFontStyleOne"));
                    dataTwo.TextFont = new Font((string)key.GetValue("TextFontNameTwo"), float.Parse(key.GetValue("TextFontSizeTwo").ToString()),
                        (FontStyle)key.GetValue("TextFontStyleTwo"));
                    dataOne.Text = (string)key.GetValue("TextOne");

                    if (dataOne.Text == "")
                        dataOne.Text = "0";

                    dataTwo.Text = (string)key.GetValue("TextTwo");

                    if (dataTwo.Text == "")
                        dataTwo.Text = "1";

                    key.Close();
                }
            }
        }
    }
}
