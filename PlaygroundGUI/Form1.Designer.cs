namespace PlaygroundGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.openKassaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openKassaToolStripMenuItem,
            this.hideMenuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(871, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // openKassaToolStripMenuItem
            // 
            this.openKassaToolStripMenuItem.Name = "openKassaToolStripMenuItem";
            this.openKassaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.openKassaToolStripMenuItem.Text = "Open kassa";
            this.openKassaToolStripMenuItem.Click += new System.EventHandler(this.openKassaToolStripMenuItem_Click);
            // 
            // hideMenuToolStripMenuItem
            // 
            this.hideMenuToolStripMenuItem.Name = "hideMenuToolStripMenuItem";
            this.hideMenuToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.hideMenuToolStripMenuItem.Text = "hide menu";
            this.hideMenuToolStripMenuItem.Click += new System.EventHandler(this.hideMenuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 497);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem openKassaToolStripMenuItem;
        private ToolStripMenuItem hideMenuToolStripMenuItem;
    }
}