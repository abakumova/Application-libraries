using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        public static Pen pen;

        int x = -1;
        int y = -1;
        bool isMoving = false;

        public Form1()
        {
            InitializeComponent();
            this.Cursor = new Cursor("PENCIL.CUR");
            graphics = panel1.CreateGraphics();
            panel1.BackColor = Color.White;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Violet);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            graphics = panel1.CreateGraphics();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving && x!=-1 && y!=-1)
            {
                graphics.DrawLine(pen, new Point(x,y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            x = -1;
            y = -1;
        }

        private void толщинаЛинийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);       
        }
    }
}