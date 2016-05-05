namespace TabelDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAnatherFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fineToolStripMenuItem
            // 
            this.fineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFormToolStripMenuItem,
            this.newAnatherFormToolStripMenuItem});
            this.fineToolStripMenuItem.Name = "fineToolStripMenuItem";
            this.fineToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.fineToolStripMenuItem.Text = "Fine";
            // 
            // newFormToolStripMenuItem
            // 
            this.newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
            this.newFormToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newFormToolStripMenuItem.Text = "New Form";
            this.newFormToolStripMenuItem.Click += new System.EventHandler(this.newFormToolStripMenuItem_Click);
            // 
            // newAnatherFormToolStripMenuItem
            // 
            this.newAnatherFormToolStripMenuItem.Name = "newAnatherFormToolStripMenuItem";
            this.newAnatherFormToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newAnatherFormToolStripMenuItem.Text = "New Anather Form";
            this.newAnatherFormToolStripMenuItem.Click += new System.EventHandler(this.newAnatherFormToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 20);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Visible = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAnatherFormToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

