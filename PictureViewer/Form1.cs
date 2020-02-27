using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        private PrintDocument ThePrintDocument = null;

        public Form1()
        {
            InitializeComponent();
            ThePrintDocument = new PrintDocument();
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            if(pictureBox1.Image != null)
            {
                Bitmap bmp = (Bitmap)pictureBox1.Image;
                ev.Graphics.DrawImageUnscaled(bmp, Point.Empty);
            }  else   {
                return;
            }
        }

        private void подогнатьРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)подогнатьРазмерToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)истинныйРазмерToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)поЦентруToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)автоматическийРазмерToolStripMenuItem).Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void истинныйРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)истинныйРазмерToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)подогнатьРазмерToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)поЦентруToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)автоматическийРазмерToolStripMenuItem).Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)поЦентруToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)истинныйРазмерToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)подогнатьРазмерToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)автоматическийРазмерToolStripMenuItem).Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void автоматическийРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)автоматическийРазмерToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)истинныйРазмерToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)подогнатьРазмерToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)поЦентруToolStripMenuItem).Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void открытьCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.истинныйРазмерToolStripMenuItem.Enabled = true;
                this.поЦентруToolStripMenuItem.Enabled = true;
                this.автоматическийРазмерToolStripMenuItem.Enabled = true;
                this.подогнатьРазмерToolStripMenuItem.Enabled = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                string a = openFileDialog1.FileName.Replace(@"\", @"\\");
                textBox1.Text = a;
                textBox2.Text = String.Concat(Image.FromFile(a).Height, "x", Image.FromFile(a).Width);
                pictureBox1.Image = Image.FromFile(a);
            }
        }

        private void сохранитьCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                saveFileDialog1.Title = "Save picture as...";
                Bitmap bmpSave = (Bitmap)pictureBox1.Image;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bmpSave.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Can't save the picture", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void выходAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printCtrlPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void pageSetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            pageSetupDialog1.Document = printDoc;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDoc.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThePrintDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintDocument printDocument1 = new PrintDocument();
            printPreviewDialog1.Document = this.ThePrintDocument;
            printPreviewDialog1.ShowDialog();
        }
    }
}