using System.Drawing;

namespace DpGen
{
    public class Dp
    {
        public static Image Generate(string text, int dimensions, float fontSize)
        {
            text = text.ToUpper();
            Random rnd = new Random();
            int red = rnd.Next(256);
            int green = rnd.Next(256);
            int blue = rnd.Next(256);
            Font font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            Color textColor = Color.FromArgb(red, green, blue);
            Color backColor = Color.FromArgb(blue, red, green);
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);
            SizeF textSize = drawing.MeasureString(text.FirstOrDefault().ToString(), font);
            img.Dispose();
            drawing.Dispose();
            img = new Bitmap(dimensions, dimensions);
            drawing = Graphics.FromImage(img);
            drawing.Clear(backColor);
            Brush brush = new SolidBrush(textColor);
            StringFormat stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
            RectangleF rectangleF = new RectangleF(0, 0, img.Width, img.Height);
            drawing.DrawString(text.FirstOrDefault().ToString(), font, brush, rectangleF, stringFormat);
            drawing.Save();
            brush.Dispose();
            drawing.Dispose();
            return img;
        }
    }
}