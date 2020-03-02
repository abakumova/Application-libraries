using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemTray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createIconMenuStructure();
            contextMenu1 = notifyIcon1.ContextMenu;
        }

        private void createIconMenuStructure()
        {
            contextMenu1.MenuItems.Add("Показать", new EventHandler(menuItem1_Click));
            contextMenu1.MenuItems.Add("Скрыть", new EventHandler(menuItem2_Click));
            notifyIcon1.Visible = true;
            notifyIcon1.Visible = true;
            notifyIcon1.ContextMenu = contextMenu1;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            contextMenu1.MenuItems[0].Enabled = false;
            contextMenu1.MenuItems[1].Enabled = true;
            this.Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            contextMenu1.MenuItems[1].Enabled = false;
            contextMenu1.MenuItems[0].Enabled = true;
            this.Hide();
        }

    }
}