using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimatedWindow
{
    public partial class Form1 : Form
    {
        private bool but1 = false;
        private bool but2 = false;
        private bool but3 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            but1 = true;
            this.Hide();
            Form1_Load(sender, e);
            but1 = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            but2 = true;
            this.Hide();
            Form1_Load(sender, e);
            but2 = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            but3 = true;
            this.Hide();
            Form1_Load(sender, e);
            but3 = false;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        private void Form1_Load(object sender, EventArgs e)
        {
            callonload();
        }

        private void callonload()
        {
            if (but1 == true)
            {
                AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND);
            }
            else if (but2 == true)
            {
                AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_HOR_POSITIVE);
            }
            else if (but3 == true)
            {
                AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_CENTER);
            }
        }
    }
}
