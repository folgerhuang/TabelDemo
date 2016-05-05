using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelDemo
{
    public partial class Launch : Form
    {
        public Launch()
        {
            InitializeComponent();
        }
        private static int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 3)
            {

                this.Hide() ;
                MainForm mf = new MainForm();
                mf.Show();
            }
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
