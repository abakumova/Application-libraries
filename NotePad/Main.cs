using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace NotePadC
{
    public partial class Main : Form
    {
        private int openDocuments = 0;

        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr handle, string text, string title, uint type);
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox(this.Handle, "NotePad C# 2020 All rights reserved", "About", 0 | 0x40);
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank form = new Blank();
            form.DocName = "Untitled " + ++openDocuments;
            form.MdiParent = this;
            form.Text = form.DocName;
            form.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank form = new Blank();
                form.Open(openFileDialog1.FileName);
                form.MdiParent = this;
                form.DocName = openFileDialog1.FileName;
                form.Text = form.DocName;
                form.Show();
                saveToolStripMenuItem.Enabled = true;
                ++openDocuments;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank form = (Blank) this.ActiveMdiChild;
            form.Save(form.DocName);
            form.IsSaved = true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Save(saveFileDialog1.FileName);
                form.MdiParent = this;
                form.DocName = saveFileDialog1.FileName;
                form.Text = form.DocName;
                form.IsSaved = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank form = (Blank)this.ActiveMdiChild;
            if (openDocuments > 0)
            {
                if (form.IsSaved == false)
                {
                    var result = MessageBox(this.Handle, "Your file has not been saved. Do you want to continue?", "Warning", 1 | 0x40);
                    if (result == 1)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void tbNew_Click(object sender, EventArgs e)
        {
            Blank form = new Blank();
            form.DocName = "Untitled " + ++openDocuments;
            form.MdiParent = this;
            form.Text = form.DocName;
            form.Show();
        }

        private void tbOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank form = new Blank();
                form.Open(openFileDialog1.FileName);
                form.MdiParent = this;
                form.DocName = openFileDialog1.FileName;
                form.Text = form.DocName;
                form.Show();
                saveToolStripMenuItem.Enabled = true;
                ++openDocuments;
            }
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            if (saveToolStripMenuItem.Enabled)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Save(form.DocName);
                form.IsSaved = true;
            } else  {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Blank form = (Blank)this.ActiveMdiChild;
                    form.Save(saveFileDialog1.FileName);
                    form.MdiParent = this;
                    form.DocName = saveFileDialog1.FileName;
                    form.Text = form.DocName;
                    form.IsSaved = true;
                }
            }
        }

        private void tbCut_Click(object sender, EventArgs e)
        {
            if (openDocuments>0)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Cut();
            }
            else
            {
                return;
            }
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Copy();
            }
            else
            {
                return;
            }
        }

        private void tbPaste_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Paste();
            }
            else
            {
                return;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Cut();
            }
            else
            {
                return;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Copy();
            }
            else
            {
                return;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Paste();
            }
            else
            {
                return;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Delete();
            }
            else
            {
                return;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.SelectAll();
            }
            else
            {
                return;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            {
                FindForm frm = new FindForm();
                if (frm.ShowDialog(this) == DialogResult.Cancel)
                {
                    return;
                }
                Blank form = (Blank)this.ActiveMdiChild;
                form.MdiParent = this;
                int start = form.richTextBox1.SelectionStart;
                form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
            }
            else
            {
                return;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            { 
                Blank form = (Blank)this.ActiveMdiChild;
                form.MdiParent = this;
                fontDialog1.ShowColor = true;
                fontDialog1.Font = form.richTextBox1.SelectionFont;
                fontDialog1.Color = form.richTextBox1.SelectionColor;
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    form.richTextBox1.SelectionFont = fontDialog1.Font;
                    form.richTextBox1.SelectionColor = fontDialog1.Color;
                }
                form.Show();
            }
            else
            {
                return;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDocuments > 0)
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.MdiParent = this;
                colorDialog1.Color = form.richTextBox1.SelectionColor;
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    form.richTextBox1.SelectionColor = colorDialog1.Color;
                }
                form.Show();
            }
            else
            {
                return;
            }
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}