namespace PlaygroundGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openKassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kassa = new Kassa();
            kassa.MdiParent = this;

            kassa.Show();
        }

        private void hideMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu.Hide();
            Thread.Sleep(1000);
            Menu.Show();
        }
    }
}