using System;
using System.Windows.Forms;

namespace awp
{
    internal partial class ucAbout : UserControl
    {
        public ucAbout()
        {
            InitializeComponent();
        }

        private void label1_Resize(object sender, EventArgs e)
        {
            float widthF = (sender as Label).Width;
            if(widthF > 10)
                label1.Font = new System.Drawing.Font("Chiller", widthF/10f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        }
    }
}