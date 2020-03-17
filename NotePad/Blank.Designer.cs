using System;

namespace NotePadC
{
    partial class Blank
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.sbAmount = new System.Windows.Forms.StatusBarPanel();
            this.sbTime = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.sbAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTime)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AllowDrop = true;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 425);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 425);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sbAmount,
            this.sbTime});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(800, 25);
            this.statusBar1.TabIndex = 3;
            // 
            // sbAmount
            // 
            this.sbAmount.Name = "sbAmount";
            this.sbAmount.Text = "Amount of symbols";
            this.sbAmount.Width = 220;
            // 
            // sbTime
            // 
            this.sbTime.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sbTime.Name = "sbTime";
            this.sbTime.Text = "Time";
            this.sbTime.Width = 80;
            // 
            // Blank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusBar1);
            this.Name = "Blank";
            this.Text = "Blank";
            ((System.ComponentModel.ISupportInitialize)(this.sbAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel sbAmount;
        private System.Windows.Forms.StatusBarPanel sbTime;
    }
}