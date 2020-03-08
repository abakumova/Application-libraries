using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Message_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr handle, string text, string title, uint type);

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox(this.Handle, "Hello world", "From WinAPI", 2 | 0x20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox(this.Handle, "Hello world", "From WinAPI", 3 | 0x40);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox(this.Handle, "Hello world", "From WinAPI", 0 | 0x10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox(this.Handle, "Hello world", "From WinAPI", 4 | 0x30 );
        }
    }
}