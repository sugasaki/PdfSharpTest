using System;
using System.Windows.Forms;

using System.Diagnostics;


namespace PdfSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string filename = "HelloWorld.pdf";

            PdfCreator.HelloWorld(filename);


            // ...and start a viewer.
            Process.Start(filename);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = String.Format("{0}_tempfile.pdf", Guid.NewGuid().ToString("D").ToUpper());

            PdfImage.Graphics(filename);

        }
    }
}
