using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GrafischeApplicaties
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnOpenFileDialog_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "XML files|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtFilename.Text = ofd.FileName;
            }
        }

        private void BtnParse_Click(object sender, EventArgs e)
        {
            if (TxtFilename.Text == "")
            {
                MessageBox.Show("You must select a file!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(MainForm));
            // open stream

            // deserialize

            // do something with data

            // and so on
        }
    }
}
