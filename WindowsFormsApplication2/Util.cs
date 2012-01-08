using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApplication1
{
    public static class Util
    {
        public static void write_file(List<Shape> shapes, string path)
        {
            FileStream f = new FileStream(path,　FileMode.Create,　FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(f, shapes);
            f.Close();
        }

        public static List<Shape> read_file(string path)
        {
            FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Object obj = formatter.Deserialize(f);
            f.Close();
            return obj as List<Shape>;
        }

        public static Rectangle get_rect(List<Point> paired_point)
        {
            Point lu = new Point();
            Size sz = new Size();
            Point p1 = paired_point[0];
            Point p2 = paired_point[1];
            lu.X = Math.Min(p1.X, p2.X);
            lu.Y = Math.Min(p1.Y, p2.Y);
            sz.Width = Math.Abs(p1.X - p2.X);
            sz.Height = Math.Abs(p1.Y - p2.Y);

            return new Rectangle(lu, sz);
        }
    }
}
