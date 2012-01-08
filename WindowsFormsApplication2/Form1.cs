using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public enum Cmd { SELECT, LINE, BOX, OVAL }
    public enum Mode { IDLE, BEGIN, END}

    //-------------------------------------------------
    public partial class Form1 : Form
    {
        private Shape rb;
        static public List<Shape> shapes;
        public Mode mode;
        public Cmd cmd;
        private Graphics graphic;

        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            mode = Mode.IDLE;
            cmd = Cmd.SELECT;
            graphic = pictureBox1.CreateGraphics();
        }

        private void draw_all_shapes()
        {
            foreach(Shape sh in shapes)
            {
                sh.draw(graphic);
            }
        }

        private Shape get_shape(Cmd cmd)
        {
            switch(cmd)
            {
                case Cmd.LINE: return new Line();
                case Cmd.BOX: return new Box();
                case Cmd.OVAL: return new Oval();
                default: return new Box();
            }
        }

        private void update_status_line(int x=0, int y=0)
        {
            label_pos.Text = cmd + " : " + shapes.Count + " : " + x + " : " + y;
        }

        //
        // event handlers
        //
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (mode == Mode.IDLE)
            {
                rb = get_shape(cmd);
                rb.coodinate.Add(new Point(e.X, e.Y)); // begin
                rb.coodinate.Add(new Point(e.X, e.Y)); // begin
                mode = Mode.BEGIN;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            update_status_line(e.X, e.Y);

            if (mode == Mode.BEGIN)
            {
                pictureBox1.Refresh();

                rb.coodinate[1] = new Point(e.X, e.Y);
                rb.draw_rubber(graphic);

                draw_all_shapes();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(mode == Mode.BEGIN)
            {
                if(cmd == Cmd.SELECT)
                {
                  // do nothing
                } else {
                    rb.coodinate[1] = new Point(e.X, e.Y);
                    shapes.Add(rb);
                }
                mode = Mode.IDLE;
            }

            pictureBox1.Refresh();
            draw_all_shapes();
        }

        private void cmdButtonLine_Click(object sender, EventArgs e)
        {
            cmd = Cmd.LINE;
            mode = Mode.IDLE;
            update_status_line();
        }
        private void cmdButtonSelect_Click(object sender, EventArgs e)
        {
            cmd  = Cmd.SELECT;
            mode = Mode.IDLE;
            update_status_line();
        }
        private void cmdButtonBox_Click(object sender, EventArgs e)
        {
            cmd = Cmd.BOX;
            mode = Mode.IDLE;
            update_status_line();
        }
        private void cmdButtonOval_Click(object sender, EventArgs e)
        {
            cmd = Cmd.OVAL;
            mode = Mode.IDLE;
            update_status_line();
        }

        private void cmdButtonOpen_Click(object sender, EventArgs e)
        {
            const string fn = @"c:\data.xml";
            List<Shape> ss = Util.read_file(fn);
            foreach (Shape s in ss)
            {
                s.pen = new Pen(Color.Black);
            }
            Form1.shapes = ss;

            pictureBox1.Refresh();
            draw_all_shapes();
        }

        private void cmdButtonSave_Click(object sender, EventArgs e)
        {
            const string fn = @"c:\data.xml";
            Util.write_file(Form1.shapes, fn);
        }
    }

    //-------------------------------------------------
    [Serializable()]
    public abstract class Shape : ICloneable
    {
        public List<Point> coodinate;
        [NonSerialized]
        public  Pen pen;
        public abstract void draw(Graphics g);
        public abstract void draw_rubber(Graphics g);

        public Shape()
        {
            coodinate = new List<Point>();
            pen = new Pen(Color.Black);
        }
        public Object Clone() { return MemberwiseClone(); }
    }
    [Serializable()]
    public class Box : Shape
    {
        public override void draw(Graphics g)
        {
            g.DrawRectangle(pen, Util.get_rect(coodinate));
        }
        public override void draw_rubber(Graphics g)
        {
            Pen p = new Pen(Color.Blue);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawRectangle(p, Util.get_rect(coodinate));
        }
    }
    [Serializable()]
    public class Oval : Shape
    {
        public override void draw(Graphics g)
        {
            g.DrawEllipse(pen, Util.get_rect(coodinate));
        }
        public override void draw_rubber(Graphics g)
        {
            Pen p = new Pen(Color.Blue);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawEllipse(p, Util.get_rect(coodinate));
        }
    }
    [Serializable()]
    public class Line : Shape
    {
        public override void draw(Graphics g)
        {
            g.DrawLine(pen, coodinate[0], coodinate[1]);
        }
        public override void draw_rubber(Graphics g)
        {
            Pen p = new Pen(Color.Blue);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(pen, coodinate[0], coodinate[1]);
        }
    }

}
