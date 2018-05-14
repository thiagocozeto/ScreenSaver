using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ScreenSaver
{
    public partial class frmSettings : Form
    {

        #region Variables

        DataSettings settingsOne = new DataSettings();
        DataSettings settingsTwo = new DataSettings();

        #endregion

        /// <summary>
        /// Calls the screen saver settings form, waits to call function the Show();
        /// </summary>
        /// <param name="dataOne">Settings of text one</param>
        /// <param name="dataTwo">Settings of text two</param>
        public frmSettings(DataSettings dataOne, DataSettings dataTwo)
        {
            InitializeComponent();
            settingsOne = dataOne;
            settingsTwo = dataTwo;
            lblTextOne.ForeColor = settingsOne.TextColor;
            lblTextTwo.ForeColor = settingsTwo.TextColor;
            lblTextOne.Font = settingsOne.TextFont;
            lblTextTwo.Font = settingsTwo.TextFont;
            nudAmountTextOne.Value = settingsOne.AmountText;
            nudAmountTextTwo.Value = settingsTwo.AmountText;
            tkbMinimumTextSpeedOne.Value = (int)settingsOne.MinimumTextSpeed;
            tkbMaximumTextSpeedOne.Value = (int)settingsOne.MaximumTextSpeed;
            tkbMinimumTextSpeedTwo.Value = (int)settingsTwo.MinimumTextSpeed;
            tkbMaximumTextSpeedTwo.Value = (int)settingsTwo.MaximumTextSpeed;
            rdoTopToBottomOne.Checked = (settingsOne.TextDirection == DataSettings.Direction.topToBottom);
            rdoTopToBottomTwo.Checked = (settingsTwo.TextDirection == DataSettings.Direction.topToBottom);
            txtTextOne.Text = settingsOne.Text;
            txtTextTwo.Text = settingsTwo.Text;
        }

        #region Buttons

        private void btnFontOne_Click(object sender, EventArgs e)
        {
            ftdFont.Font = settingsOne.TextFont;
            if (ftdFont.ShowDialog() == DialogResult.OK)
            {
                settingsOne.TextFont = ftdFont.Font;
                lblTextOne.Font = ftdFont.Font;
            }
        }

        private void btnFontTwo_Click(object sender, EventArgs e)
        {
            ftdFont.Font = settingsTwo.TextFont;
            if (ftdFont.ShowDialog() == DialogResult.OK)
            {
                settingsTwo.TextFont = ftdFont.Font;
                lblTextTwo.Font = ftdFont.Font;
            }
        }

        private void btnColorOne_Click(object sender, EventArgs e)
        {
            cldColor.Color = settingsOne.TextColor;
            if (cldColor.ShowDialog() == DialogResult.OK)
            {
                settingsOne.TextColor = cldColor.Color;
                lblTextOne.ForeColor = cldColor.Color;
            }
        }

        private void btnColorTwo_Click(object sender, EventArgs e)
        {
            cldColor.Color = settingsTwo.TextColor;
            if (cldColor.ShowDialog() == DialogResult.OK)
            {
                settingsTwo.TextColor = cldColor.Color;
                lblTextTwo.ForeColor = cldColor.Color;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveRegistration();
        }

        private void btnVisualize_Click(object sender, EventArgs e)
        {
            Visualize();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Functions

        /// <summary>
        /// Writes the information in the windows registry in HKEY_LOCAL_MACHINE\SOFTWARE\ScreenSaverBill
        /// creates if it does not exist and overwrites if it already exists.
        /// </summary>
        private void SaveRegistration()
        {
            RegistryKey registry = Registry.LocalMachine.OpenSubKey("Software\\ScreenSaverBill", true);

            if (registry == null)
            {
                registry = Registry.LocalMachine.OpenSubKey("Software", true);
                registry = registry.CreateSubKey("ScreenSaverBill");
            }

            registry.SetValue("MinimumTextSpeedOne", settingsOne.MinimumTextSpeed, RegistryValueKind.DWord);
            registry.SetValue("MinimumTextSpeedTwo", settingsTwo.MinimumTextSpeed, RegistryValueKind.DWord);
            registry.SetValue("MaximumTextSpeedOne", settingsOne.MaximumTextSpeed, RegistryValueKind.DWord);
            registry.SetValue("MaximumTextSpeedTwo", settingsTwo.MaximumTextSpeed, RegistryValueKind.DWord);
            registry.SetValue("AmountTextOne", settingsOne.AmountText, RegistryValueKind.DWord);
            registry.SetValue("AmountTextTwo", settingsTwo.AmountText, RegistryValueKind.DWord);
            registry.SetValue("TextDirectionOne", (int)settingsOne.TextDirection, RegistryValueKind.DWord);
            registry.SetValue("TextDirectionTwo", (int)settingsTwo.TextDirection, RegistryValueKind.DWord);
            registry = registry.OpenSubKey("Font", true);

            if (registry == null)
            {
                registry = Registry.LocalMachine.OpenSubKey("Software\\ScreenSaverBill", true);
                registry = registry.CreateSubKey("Font");
            }

            registry.SetValue("TextColorOne", settingsOne.TextColor.ToArgb(), RegistryValueKind.DWord);
            registry.SetValue("TextColorTwo", settingsTwo.TextColor.ToArgb(), RegistryValueKind.DWord);
            registry.SetValue("TextFontNameOne", settingsOne.TextFont.Name, RegistryValueKind.String);
            registry.SetValue("TextFontNameTwo", settingsTwo.TextFont.Name, RegistryValueKind.String);
            registry.SetValue("TextFontSizeOne", settingsOne.TextFont.Size, RegistryValueKind.DWord);
            registry.SetValue("TextFontSizeTwo", settingsTwo.TextFont.Size, RegistryValueKind.DWord);
            registry.SetValue("TextFontStyleOne", (int)settingsOne.TextFont.Style, RegistryValueKind.DWord);
            registry.SetValue("TextFontStyleTwo", (int)settingsTwo.TextFont.Style, RegistryValueKind.DWord);
            registry.SetValue("TextOne", txtTextOne.Text, RegistryValueKind.String);
            registry.SetValue("TextTwo", txtTextTwo.Text, RegistryValueKind.String);
            registry.Close();
            this.Close();
        }

        /// <summary>
        /// Call the form to view screen saver on full screen
        /// </summary>
        private void Visualize()
        {
            frmSaver screen;

            for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++)
            {
                screen = new frmSaver(IntPtr.Zero, Screen.AllScreens[i].Bounds, settingsOne, settingsTwo);
                Cursor.Hide();
                screen.Show();
            }

            Cursor.Show();
        }

        #endregion

        #region Load Variables

        #region Track Scroll

        private void tkbMaximumTextSpeedOne_ValueChanged(object sender, EventArgs e)
        {
            settingsOne.MaximumTextSpeed = (double)tkbMaximumTextSpeedOne.Value;
            lblnummax1.Text = tkbMaximumTextSpeedOne.Value.ToString();
        }

        private void tkbMinimumTextSpeedOne_ValueChanged(object sender, EventArgs e)
        {
            settingsOne.MinimumTextSpeed = (double)tkbMinimumTextSpeedOne.Value;
            lblnummin1.Text = tkbMinimumTextSpeedOne.Value.ToString();

            if (settingsOne.MinimumTextSpeed > settingsOne.MaximumTextSpeed)
                tkbMaximumTextSpeedOne.Value = (int)settingsOne.MinimumTextSpeed;

            tkbMaximumTextSpeedOne.Minimum = (int)settingsOne.MinimumTextSpeed;
        }

        private void tkbMaximumTextSpeedTwo_ValueChanged(object sender, EventArgs e)
        {
            settingsTwo.MaximumTextSpeed = (double)tkbMaximumTextSpeedTwo.Value;
            lblnummax2.Text = tkbMaximumTextSpeedTwo.Value.ToString();
        }

        private void tkbMinimumTextSpeedTwo_ValueChanged(object sender, EventArgs e)
        {
            settingsTwo.MinimumTextSpeed = (double)tkbMinimumTextSpeedTwo.Value;
            lblnummin2.Text = tkbMinimumTextSpeedTwo.Value.ToString();

            if (settingsTwo.MinimumTextSpeed > settingsTwo.MaximumTextSpeed)
                tkbMaximumTextSpeedTwo.Value = (int)settingsTwo.MinimumTextSpeed;

            tkbMaximumTextSpeedTwo.Minimum = (int)settingsTwo.MinimumTextSpeed;
        }

        #endregion

        #region Text

        private void txtTextOne_TextChanged(object sender, EventArgs e)
        {
            settingsOne.Text = txtTextOne.Text;
            lblTextOne.Text = settingsOne.Text;
        }

        private void txtTextTwo_TextChanged(object sender, EventArgs e)
        {
            settingsTwo.Text = txtTextTwo.Text;
            lblTextTwo.Text = settingsTwo.Text;
        }

        #endregion

        #region Number of Text

        private void nudAmountTextOne_ValueChanged(object sender, EventArgs e)
        {
            settingsOne.AmountText = (int)nudAmountTextOne.Value;
        }

        private void nudAmountTextTwo_ValueChanged(object sender, EventArgs e)
        {
            settingsTwo.AmountText = (int)nudAmountTextTwo.Value;
        }

        #endregion

        private void rdoTopToBottomOne_CheckedChanged(object sender, EventArgs e)
        {
            settingsOne.TextDirection = (((rdoTopToBottomOne.Checked == true) && (rdoUpwardsOne.Checked == false)) ? DataSettings.Direction.topToBottom :
                DataSettings.Direction.upwards);
        }

        private void rdoTopToBottomTwo_CheckedChanged(object sender, EventArgs e)
        {
            settingsTwo.TextDirection = (((rdoTopToBottomTwo.Checked == true) && (rdoUpwardsTwo.Checked == false)) ? DataSettings.Direction.topToBottom :
                DataSettings.Direction.upwards);
        }

        #endregion
    }
}
