using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ScreenSaver
{
    public partial class frmSaver : Form
    {

        #region Variables

        DataSettings settingsOne = new DataSettings();
        DataSettings settingsTwo = new DataSettings();
        ListTextData listTextDataOne;
        ListTextData listTextDataTwo;
        Graphics image;
        Point position = new Point();//mouse position
        Rectangle dimension = new Rectangle();//user screen size
        bool preview = false;//indicates whether or not it is viewed
        IntPtr handlePreview = new IntPtr(0);//handle of the window "Screen Saver Settings"

        #endregion

        #region Windows Functions (DLL)

        [DllImport("user32.DLL", EntryPoint = "IsWindowVisible")]
        private static extern bool IsWindowVisible(IntPtr hWnd);//Checks if the screen saver preview window is still visible
        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);//Capture the size of the screen saver viewing window

        #endregion

        /// <summary>
        /// Starts the Screen Saver, waits for the call of the function Show();
        /// </summary>
        /// <param name="handle">Window handle only in the case of the preview thumbnail in the "Screen Saver Settings" screen of the windows</param>
        /// <param name="dimentions">Dimension of the screen where the protection is to be displayed, must be zeroed in the case of Preview</param>
        /// <param name="dataOne">Settings of text one</param>
        /// <param name="dataTwo">Settings of text two</param>
        public frmSaver(IntPtr handle, Rectangle dimentions, DataSettings dataOne, DataSettings dataTwo)
        {
            InitializeComponent();

            settingsOne = dataOne;
            settingsTwo = dataTwo;
            handlePreview = handle;
            listTextDataOne = new ListTextData(settingsOne.AmountText);
            listTextDataTwo = new ListTextData(settingsTwo.AmountText);

            if (handlePreview == IntPtr.Zero)
            {
                dimension = dimentions;
                preview = false;
                Cursor.Hide();
                position = Cursor.Position;
            }
            else
            {
                preview = true;

                if (!GetClientRect(handlePreview, out dimension))//Capture the size of the screen saver viewing window
                    dimension = dimentions;
            }
        }

        private void FrmProtecao_Load(object sender, EventArgs e)
        {
            Starts();
            tmrTimer.Enabled = true;//activates the tick of time
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {

            if (preview)
            {

                if (!IsWindowVisible(handlePreview))//Checks if the screen saver preview window is still visible
                    this.Close();

                Graphics g = Graphics.FromHwnd(handlePreview);//the preview screen
                GeneratesAnimation(g);
                g.Dispose();
            }
            else
                this.Invalidate();//Requires Screen Repaint

        }

        private void FrmProtecao_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;//the screen saver form
            g.Clear(this.BackColor);//black background
            GeneratesAnimation(g);
        }

        #region Functions

        /// <summary>
        /// Draws the texts on the screen and generates the animation, it is necessary that the data is loaded with the function Starts
        /// </summary>
        /// <param name="g">Graphic of where the screen saver should be drawn</param>
        private void GeneratesAnimation(Graphics g)
        {
            int n = 0;
            Random random = new Random();

            while (n < settingsOne.AmountText)
            {

                if (listTextDataOne[n].TextExhibited)
                    g.DrawImage(settingsOne.TextImage, listTextDataOne[n].Position);

                if (settingsOne.TextDirection == DataSettings.Direction.topToBottom)
                    listTextDataOne[n].Position = new Point(listTextDataOne[n].Position.X, listTextDataOne[n].Position.Y + (int)listTextDataOne[n].Speeds);
                else
                    listTextDataOne[n].Position = new Point(listTextDataOne[n].Position.X, listTextDataOne[n].Position.Y - (int)listTextDataOne[n].Speeds);

                if (((listTextDataOne[n].Position.Y + 20) < 0) || ((listTextDataOne[n].Position.Y - 20) > dimension.Height))
                {

                    if (settingsOne.TextDirection == DataSettings.Direction.topToBottom)
                        listTextDataOne[n].Position = new Point(random.Next(-20, dimension.Width + 20), -20);
                    else
                        listTextDataOne[n].Position = new Point(random.Next(-20, dimension.Width + 20), dimension.Height + 20);

                    if (n < settingsOne.AmountText)
                        listTextDataOne[n].Speeds = random.Next((int)settingsOne.MinimumTextSpeed, (int)settingsOne.MaximumTextSpeed);

                }
                else
                    n++;

            }

            n = 0;

            while (n < settingsTwo.AmountText)
            {

                if (listTextDataTwo[n].TextExhibited)
                    g.DrawImage(settingsTwo.TextImage, listTextDataTwo[n].Position);

                if (settingsTwo.TextDirection == DataSettings.Direction.topToBottom)
                    listTextDataTwo[n].Position = new Point(listTextDataTwo[n].Position.X, listTextDataTwo[n].Position.Y + (int)listTextDataTwo[n].Speeds);
                else
                    listTextDataTwo[n].Position = new Point(listTextDataTwo[n].Position.X, listTextDataTwo[n].Position.Y - (int)listTextDataTwo[n].Speeds);

                if (((listTextDataTwo[n].Position.Y + 20) < 0) || ((listTextDataTwo[n].Position.Y - 20) > dimension.Height))
                {

                    if (settingsTwo.TextDirection == DataSettings.Direction.topToBottom)
                        listTextDataTwo[n].Position = new Point(random.Next(-20, dimension.Width + 20), -20);
                    else
                        listTextDataTwo[n].Position = new Point(random.Next(-20, dimension.Width + 20), dimension.Height + 20);

                    if (n < settingsTwo.AmountText)
                        listTextDataTwo[n].Speeds = random.Next((int)settingsTwo.MinimumTextSpeed, (int)settingsTwo.MaximumTextSpeed);

                }
                else
                    n++;

            }

        }

        /// <summary>
        /// Function loads random speeds and random positions of texts with your images
        /// </summary>
        private void Starts()
        {
            Random random = new Random();
            Rectangle square = new Rectangle(0, 0, 100, 50);

            if (preview)
            {
                this.Hide();
                this.Opacity = 1.0;
                image = Graphics.FromImage(settingsOne.TextImage);
                image.DrawString(settingsOne.Text, settingsOne.TextFont, new SolidBrush(settingsOne.TextColor), dimension);
                image.Dispose();
                image = Graphics.FromImage(settingsOne.TextImage);
                image.DrawString(settingsTwo.Text, settingsTwo.TextFont, new SolidBrush(settingsTwo.TextColor), square);
                image.Dispose();
                image = Graphics.FromHwnd(handlePreview);
                image.Clear(Color.Black);
                image.Dispose();
            }
            else
            {
                this.Opacity = 1.0;
                image = Graphics.FromImage(settingsOne.TextImage);
                image.DrawString(settingsOne.Text, settingsOne.TextFont, new SolidBrush(settingsOne.TextColor), square);
                image.Dispose();
                image = Graphics.FromImage(settingsTwo.TextImage);
                image.DrawString(settingsTwo.Text, settingsTwo.TextFont, new SolidBrush(settingsTwo.TextColor), square);
                image.Dispose();
            }

            for (int n = 0; n < settingsOne.AmountText; n++)
            {
                listTextDataOne[n].Position = new Point(random.Next(-20, dimension.Width + 20), random.Next(-20, dimension.Height + 20));
                listTextDataOne[n].Speeds = random.Next((int)settingsOne.MinimumTextSpeed, (int)settingsOne.MaximumTextSpeed);
            }

            for (int n = 0; n < settingsTwo.AmountText; n++)
            {
                listTextDataTwo[n].Position = new Point(random.Next(-20, dimension.Width + 20), random.Next(-20, dimension.Height + 20));
                listTextDataTwo[n].Speeds = random.Next((int)settingsTwo.MinimumTextSpeed, (int)settingsTwo.MaximumTextSpeed);
            }

        }

        #endregion

        #region Screen Saver Exit

        private void FrmProtecao_MouseMove(object sender, MouseEventArgs e)
        {

            if (!preview)
            {
                if (!position.IsEmpty)
                {

                    if (position != new Point(e.X, e.Y))
                    {
                        ExitSaver();
                    }

                    if (e.Clicks > 0)
                    {
                        ExitSaver();
                    }
                }

                position = new Point(e.X, e.Y);
            }
        }

        private void ExitSaver()
        {
            Cursor.Show();
            this.Close();
        }

        private void FrmProtecao_KeyDown(object sender, KeyEventArgs e)
        {

            if (!preview)
            {
                ExitSaver();
            }

        }

        #endregion

    }
}
