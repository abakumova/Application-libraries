using System;
using System.Windows.Forms;
using System.IO;

namespace Task_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            StreamReader stream = new StreamReader(openFileDialog1.FileName);
            textBox1.Text = stream.ReadLine();
            stream.Close();
        }

        private void saveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            StreamWriter stream = new StreamWriter(saveFileDialog1.FileName);
            stream.Write(textBox1.Text);
            stream.Flush();
            stream.Close();
        }
    }
}