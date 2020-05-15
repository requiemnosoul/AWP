using System;
using System.Drawing;
using System.Windows.Forms;

namespace awp
{
    internal partial class ucAbout : UserControl
    {
        private Font f;
        public ucAbout()
        {
            InitializeComponent();
            f = label1.Font;
        }

        private void label1_Resize(object sender, EventArgs e)
        {
            float f = (sender as Label).Width;
            label1.Font = new System.Drawing.Font("Chiller", (f/400f) * 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        }
    }
}