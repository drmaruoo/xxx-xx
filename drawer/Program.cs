using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace drawer
{
    class Program
    {
        static void Main(string[] args)
        {
            float scale = 256f;
            Bitmap bmp = new Bitmap(512, 512);
            Graphics gdi = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Gray, 1);
            float[] values = new float[512];
            float xb = (-256) / scale;
            values[0] = xb * xb * xb - xb * xb;
            gdi.DrawLine(pen2, 0, 256, 512, 256);
            gdi.DrawLine(pen2, 256, 0, 256, 512h);
            for (int w = 1; w < 512; w++)
            {
                float x = (w - 256) / scale;
                values[w] = x * x * x - x * x;
                gdi.DrawLine(pen, w - 1, (-values[w - 1] * scale + 256), w, (-values[w] * scale + 256));
            }
            string path = Path.GetTempFileName() + ".png";
            bmp.Save(path);
            Process.Start(path);
        }
    }
}
