using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprm
{

#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
    public partial class Main : Form
    {

#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        public Main()
        {
            InitializeComponent();
            visualizer.Left = btn_tasks.Left;
            visualizer.Width = btn_tasks.Width;
            tasks1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            visualizer.Left = btn_tasks.Left;
            visualizer.Width = btn_tasks.Width;
            tasks1.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            visualizer.Left = btn_proxys.Left;
            visualizer.Width = btn_proxys.Width;
            proxys1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            visualizer.Left = btn_billing.Left;
            visualizer.Width = btn_billing.Width;
            billing1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            visualizer.Left = btn_copped.Left;
            visualizer.Width = btn_copped.Width;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

    }
}
