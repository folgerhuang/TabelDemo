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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void newAnatherFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if((sender as Form).ActiveMdiChild== null)
            {
                this.tabControl1.Visible = false;
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
                if (this.ActiveMdiChild.Tag == null)
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabControl1;
                    tabControl1.SelectedTab = tp;
                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
                        
                }
                else
                {
                    (this.ActiveMdiChild.Tag as TabPage).Select();
                }

                if (!this.tabControl1.Visible) this.tabControl1.Visible = true;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //(tabControl1.SelectedTab.Tag as Form).Select();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab!=null &&
                tabControl1.SelectedTab.Tag != null)
            {
                (tabControl1.SelectedTab.Tag as Form).Select();
            }
        }
    }
}
