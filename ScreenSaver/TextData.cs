using System.Collections.Generic;
using System.Drawing;

namespace ScreenSaver
{
    public class TextData
    {
        public TextData()
        {
            Position = new Point(0, 0);
            Speeds = 0;
            TextExhibited = true;
        }

        public Point Position
        {
            get;
            set;
        }

        public double Speeds
        {
            get;
            set;
        }

        public bool TextExhibited
        {
            get;
            set;
        }
    }

    public class ListTextData
    {
        List<TextData> baseTextData = new List<TextData>();

        public ListTextData()
        {

        }

        public ListTextData(int quantity)
        {
            TextData[] arrayTextData = new TextData[quantity];

            for (int n = 0; n < quantity; n++)
                arrayTextData[n] = new TextData();

            baseTextData.AddRange(arrayTextData);
        }

        public TextData this[int index]
        {
            get
            {
                return baseTextData[index];
            }
        }

        public void Add(TextData item)
        {
            baseTextData.Add(item);
        }

        public void Remove(TextData item)
        {
            baseTextData.Remove(item);
        }

        public void RemoveAt(int index)
        {
            baseTextData.RemoveAt(index);
        }

        public void Clear()
        {
            baseTextData.Clear();
        }
    }
}
