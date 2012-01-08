using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class File
    {
        static void writeXML(List<Shape> shapes, string path)
        {
            Record rec = new Record();
            rec.shapes = shapes;
            System.IO.FileStream f =
                new System.IO.FileStream(path, System.IO.FileMode.Create);
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(Record));
            foreach (Shape sh in shapes)
            {
                serializer.Serialize(f, sh);
            }
            f.Close();
        }
        static List<Shape> ReadXML(string path)
        {
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(Record));
            System.IO.FileStream f =
                new System.IO.FileStream(path, System.IO.FileMode.Open);
            Record rec = (Record)serializer.Deserialize(f);
            f.Close();
            List<Shape> shapes = rec.shapes;
            return shapes;
        }
    }
    class Record
    {
        public List<Shape> shapes;
    }
}
