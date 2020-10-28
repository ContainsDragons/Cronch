using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cronch
{
    public partial class About : System.Windows.Forms.Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Process.Start("https://github.com/ChevyRay/crunch"); //opens file browser
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            Process.Start("https://stackoverflow.com/users/7444103/jimi");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ContainsDragons");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
