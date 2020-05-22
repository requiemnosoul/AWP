using System;
using System.Windows.Forms;

namespace awp
{
    internal partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(rbEn.Checked)
                Localization.En();
            if(rbRu.Checked)
                Localization.Ru();
        }
    }
}