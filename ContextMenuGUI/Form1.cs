using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuGUI
{
    public partial class Form1 : Form
    {
        ContextMenuStrip contextMenu;
        public Form1()
        {

            contextMenu = new ContextMenuStrip();

            var toolStrip = new ToolStripButton() { Text = "Item 1" };

            contextMenu.Items.Add(toolStrip);

            toolStrip.Click += ToolStrip_Click;

            InitializeComponent();
        }

        private void ToolStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripItem).Text);
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            contextMenu.Show(this, this.PointToClient(MousePosition));
        }
    }
}
