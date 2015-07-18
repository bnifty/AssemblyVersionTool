using System;
using System.Windows.Forms;

namespace bnifty.AssemblyVersionTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Version version = Version.Parse(txtAssemblyVersion.Text);
                DateTime buildDate = new DateTime(2000, 1, 1).Add(new TimeSpan(TimeSpan.TicksPerDay * version.Build + TimeSpan.TicksPerSecond * 2 * version.Revision));
                lblBuildDate.Text = buildDate.ToString("dd/MM/yyyy HH:mm:ss");
            }
            catch
            {
                lblBuildDate.Text = "##ERROR##";
            }
        }
    }
}
