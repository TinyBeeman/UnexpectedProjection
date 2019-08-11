using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnexpectedProjection
{
    public partial class ImageProjectionForm : Form
    {
        private Timer m_timer;
        long m_ticksInitial;
        Bitmap m_lastBitmap;
        int m_lastAlpha;
        
        public ImageProjectionForm()
        {
            InitializeComponent();
            m_timer = new Timer();
            m_timer.Interval = 100;
            m_timer.Tick += TimerTick;
            m_lastAlpha = 255;
        }

        static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
            new float[] {1, 0, 0, 0, 0},
            new float[] {0, 1, 0, 0, 0},
            new float[] {0, 0, 1, 0, 0},
            new float[] {0, 0, 0, a, 0},
            new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            long msWait = 10000;
            long msFadeTime = 30000;
            long msDuration = (DateTime.Now.Ticks - m_ticksInitial) / TimeSpan.TicksPerMillisecond;

            if (msDuration > msWait && msDuration < (msWait + msFadeTime))
            {
                int alpha = (int)((1.0f - ((float)(msDuration - msWait) / (float)msFadeTime)) * 255);
                if (m_lastAlpha != alpha)
                {
                    m_lastAlpha = alpha;
                    pbProject.Image = SetAlpha(m_lastBitmap, alpha);
                }
            }

            if (msDuration >= msWait + msFadeTime)
            {
                pbProject.Image = SetAlpha(m_lastBitmap, 0);
                m_timer.Stop();
            }

        }

        public void MaxToScreen(Screen s)
        {
            if (!this.Visible)
            {
                this.Show();
            }

            if (s != null)
            {
                var workingArea = s.WorkingArea;
                this.Left = workingArea.Left;
                this.Top = workingArea.Top;
                this.Width = workingArea.Width;
                this.Height = workingArea.Height;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        public void ShowTestImage()
        {
            Image testImage = new Bitmap(pbProject.Width, pbProject.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            using (Graphics grp = Graphics.FromImage(testImage))
            {
                grp.FillRectangle(Brushes.PowderBlue, 0, 0, pbProject.Width, pbProject.Height);
                grp.FillRectangle(Brushes.Red, 0, 0, 20, pbProject.Height);
                grp.FillRectangle(Brushes.Red, 0, 0, pbProject.Width, 20);
                grp.FillRectangle(Brushes.Red, 0, pbProject.Height - 20, pbProject.Width, 20);
                grp.FillRectangle(Brushes.Red, pbProject.Width - 20, 0, 20, pbProject.Height);

                ShowImage(testImage);
            }
        }

        public void ShowImage(Image img)
        {
            if (img == null)
            {
                pbProject.Image = null;
                m_timer.Stop();
            }
            else
            {
                m_timer.Stop();
                m_lastBitmap = new Bitmap(img);
                pbProject.Image = m_lastBitmap;
                m_ticksInitial = DateTime.Now.Ticks;
                m_lastAlpha = 255;
                m_timer.Enabled = true;
                m_timer.Start();
            }
        }

        public void ShowImage(string imgPath)
        {
            if ((imgPath != null) && (imgPath.Length > 0))
            {
                try
                {
                    Image imgDisk = Image.FromFile(imgPath);
                    ShowImage(imgDisk);
                    imgDisk.Dispose();
                }
                catch(Exception)
                {
                }
            }
            else
            {
                ShowImage((Bitmap)null);
            }
        }

        internal void UpdateMargins(int left, int top, int right, int bottom)
        {
            pbProject.Left = left;
            pbProject.Top = top;
            pbProject.Width = panelContainer.Width - right;
            pbProject.Height = panelContainer.Height - bottom;
        }

        internal void BlackOut()
        {
            Image blackImage = new Bitmap(pbProject.Width, pbProject.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            using (Graphics grp = Graphics.FromImage(blackImage))
            {
                grp.FillRectangle(Brushes.Black, 0, 0, pbProject.Width, pbProject.Height);
                ShowImage(blackImage);
            }

        }
    }
}
