using System.Windows.Forms;

namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подогнатьРазмерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.истинныйРазмерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоматическийРазмерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьCtrlOToolStripMenuItem,
            this.сохранитьCtrlSToolStripMenuItem,
            this.pageSetUpToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printCtrlPToolStripMenuItem,
            this.выходAltF4ToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьCtrlOToolStripMenuItem
            // 
            this.открытьCtrlOToolStripMenuItem.Name = "открытьCtrlOToolStripMenuItem";
            this.открытьCtrlOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьCtrlOToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.открытьCtrlOToolStripMenuItem.Text = "Открыть";
            this.открытьCtrlOToolStripMenuItem.Click += new System.EventHandler(this.открытьCtrlOToolStripMenuItem_Click);
            // 
            // сохранитьCtrlSToolStripMenuItem
            // 
            this.сохранитьCtrlSToolStripMenuItem.Name = "сохранитьCtrlSToolStripMenuItem";
            this.сохранитьCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьCtrlSToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьCtrlSToolStripMenuItem.Text = "Сохранить";
            this.сохранитьCtrlSToolStripMenuItem.Click += new System.EventHandler(this.сохранитьCtrlSToolStripMenuItem_Click);
            // 
            // pageSetUpToolStripMenuItem
            // 
            this.pageSetUpToolStripMenuItem.Name = "pageSetUpToolStripMenuItem";
            this.pageSetUpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pageSetUpToolStripMenuItem.Text = "Page SetUp";
            this.pageSetUpToolStripMenuItem.Click += new System.EventHandler(this.pageSetUpToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printCtrlPToolStripMenuItem
            // 
            this.printCtrlPToolStripMenuItem.Name = "printCtrlPToolStripMenuItem";
            this.printCtrlPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printCtrlPToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.printCtrlPToolStripMenuItem.Text = "Print";
            this.printCtrlPToolStripMenuItem.Click += new System.EventHandler(this.printCtrlPToolStripMenuItem_Click);
            // 
            // выходAltF4ToolStripMenuItem
            // 
            this.выходAltF4ToolStripMenuItem.Name = "выходAltF4ToolStripMenuItem";
            this.выходAltF4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходAltF4ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.выходAltF4ToolStripMenuItem.Text = "Выход";
            this.выходAltF4ToolStripMenuItem.Click += new System.EventHandler(this.выходAltF4ToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подогнатьРазмерToolStripMenuItem,
            this.истинныйРазмерToolStripMenuItem,
            this.поЦентруToolStripMenuItem,
            this.автоматическийРазмерToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // подогнатьРазмерToolStripMenuItem
            // 
            this.подогнатьРазмерToolStripMenuItem.Checked = true;
            this.подогнатьРазмерToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.подогнатьРазмерToolStripMenuItem.Enabled = false;
            this.подогнатьРазмерToolStripMenuItem.Name = "подогнатьРазмерToolStripMenuItem";
            this.подогнатьРазмерToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.подогнатьРазмерToolStripMenuItem.Text = "Подогнать размер";
            this.подогнатьРазмерToolStripMenuItem.Click += new System.EventHandler(this.подогнатьРазмерToolStripMenuItem_Click);
            // 
            // истинныйРазмерToolStripMenuItem
            // 
            this.истинныйРазмерToolStripMenuItem.Enabled = false;
            this.истинныйРазмерToolStripMenuItem.Name = "истинныйРазмерToolStripMenuItem";
            this.истинныйРазмерToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.истинныйРазмерToolStripMenuItem.Text = "Истинный размер ";
            this.истинныйРазмерToolStripMenuItem.Click += new System.EventHandler(this.истинныйРазмерToolStripMenuItem_Click);
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.Enabled = false;
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.поЦентруToolStripMenuItem.Text = "По центру";
            this.поЦентруToolStripMenuItem.Click += new System.EventHandler(this.поЦентруToolStripMenuItem_Click);
            // 
            // автоматическийРазмерToolStripMenuItem
            // 
            this.автоматическийРазмерToolStripMenuItem.Enabled = false;
            this.автоматическийРазмерToolStripMenuItem.Name = "автоматическийРазмерToolStripMenuItem";
            this.автоматическийРазмерToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.автоматическийРазмерToolStripMenuItem.Text = "Автоматический размер";
            this.автоматическийРазмерToolStripMenuItem.Click += new System.EventHandler(this.автоматическийРазмерToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(602, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(620, 416);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(168, 22);
            this.textBox2.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "picture";
            this.openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.FileName = "picture";
            this.saveFileDialog1.Filter = "(*.jpg)|*.jpg|All files (*.*)|*.*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 379);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Document = this.printDocument1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printCtrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подогнатьРазмерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem истинныйРазмерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоматическийРазмерToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox1;
        private PrintDialog printDialog1;
        private PageSetupDialog pageSetupDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}