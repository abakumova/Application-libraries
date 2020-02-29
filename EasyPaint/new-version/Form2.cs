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
    public partial class Form2 : Form
    {
        int i;

        public decimal ValueForm
        {
            get { return numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDown1.Text = e.NewValue.ToString();
            numericUpDown1.Value = Int32.Parse(numericUpDown1.Text);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Text = hScrollBar1.Value.ToString();
            numericUpDown1.Value = Int32.Parse(numericUpDown1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = Int32.Parse(numericUpDown1.Text);
            ValueForm = numericUpDown1.Value;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
