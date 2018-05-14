using System.Drawing;

namespace ScreenSaver
{
    public class DataSettings
    {
        public enum Direction : int
        {
            topToBottom,
            upwards
        }

        public DataSettings()
        {
            this.TextFont = new Font("Arial", 14, FontStyle.Bold);
            this.TextColor = Color.Green;
            this.AmountText = 100;
            this.MaximumTextSpeed = 1;
            this.MinimumTextSpeed = 1;
            this.Text = "";
            this.TextDirection = Direction.topToBottom;
            this.TextImage = new Bitmap(100, 100);
        }

        public DataSettings(Font font, Color color, int amount, double maximumSpeed, double minimumSpeed, Direction direction,
            string text)
        {
            this.TextFont = font;
            this.TextColor = color;
            this.AmountText = amount;
            this.MaximumTextSpeed = maximumSpeed;
            this.MinimumTextSpeed = minimumSpeed;
            this.Text = text;
            this.TextDirection = direction;
            this.TextImage = new Bitmap(100, 100);
        }

        public DataSettings(string familyNameFont, float emSizeFont, FontStyle styleFont, Color color, int amount, double maximumSpeed, double minimumSpeed,
            Direction direction, string text)
        {
            this.TextFont = new Font(familyNameFont, emSizeFont, styleFont);
            this.TextColor = color;
            this.AmountText = amount;
            this.MaximumTextSpeed = maximumSpeed;
            this.MinimumTextSpeed = minimumSpeed;
            this.Text = text;
            this.TextDirection = direction;
            this.TextImage = new Bitmap(100, 100);
        }

        public Font TextFont
        {
            get;
            set;
        }

        public Color TextColor
        {
            get;
            set;
        }

        public int AmountText
        {
            get;
            set;
        }

        public double MaximumTextSpeed
        {
            get;
            set;
        }

        public double MinimumTextSpeed
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }

        public Direction TextDirection
        {
            get;
            set;
        }

        public Bitmap TextImage
        {
            get;
            set;
        }
    }
}
