using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDITest
{
    public partial class GDITest : Form
    {
        public GDITest()
        {
            this.InitializeComponent();
        }
        Font font;
        Brush brush = Brushes.Black;
        private void comboCompositingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RedrawPic();
        }

        private void RedrawPic()
        {
            font = new Font("Arial", 200);
            picPicture.Image?.Dispose();
            picPicture.Image = new Bitmap(picPicture.Width, picPicture.Height);
            Graphics g=Graphics.FromImage(picPicture.Image);
            g.CompositingMode = (CompositingMode)(comboCompositingMode.SelectedIndex >= 0 ? comboCompositingMode.SelectedIndex : 0);
            g.InterpolationMode = (InterpolationMode)(comboInterpolationMode.SelectedIndex >= 0 ? comboInterpolationMode.SelectedIndex : 0);
            g.PixelOffsetMode = (PixelOffsetMode)(comboPixelOffsetMode.SelectedIndex >= 0 ? comboPixelOffsetMode.SelectedIndex : 0);
            g.SmoothingMode = (SmoothingMode)(comboSmoothingMode.SelectedIndex >= 0 ? comboSmoothingMode.SelectedIndex : 0);
            g.TextRenderingHint = (TextRenderingHint)(comboTextRenderingHint.SelectedIndex >= 0 ? comboTextRenderingHint.SelectedIndex : 0);
            g.CompositingQuality = (CompositingQuality)(comboCompositingQuality.SelectedIndex >= 0 ? comboCompositingQuality.SelectedIndex : 0);
            try
            {
                g.DrawString("ABCDEFG", font, brush, 10, 10);
            }
            catch { }
            g.Dispose();
        }

        private void comboInterpolationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RedrawPic();
        }

        private void comboSmoothingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RedrawPic();
        }

        private void comboPixelOffsetMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RedrawPic();
        }

        private void comboCompositingQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RedrawPic();
        }

        private void comboSmoothingMode_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.RedrawPic();
        }

        private void GDITest_Load(object sender, EventArgs e)
        {

        }
    }
}
