using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // form creation
            Text = "Mandelbrot Set Drawing";
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            //ClientSize = new Size(640, 640);
            ClientSize = new Size(320, 320);
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _thread = new Thread(thread_Proc)
            {
                IsBackground = true
            };

            _thread.Start(ClientSize);
        }

        const double MaxValueExtent = 2.0;
        Thread _thread;

        static double CalcMandelbrotSetColor(ComplexNumber c)
        {
            // from http://en.wikipedia.org/w/index.php?title=Mandelbrot_set
            const int MaxIterations = 1000;
            const double MaxNorm = MaxValueExtent * MaxValueExtent;

            int iteration = 0;
            ComplexNumber z = new ComplexNumber();
            do
            {
                z = z * z + c;
                iteration++;
            } while (z.Norm() < MaxNorm && iteration < MaxIterations);

            if (iteration < MaxIterations)
                return (double)iteration / MaxIterations;
            return 0; // black
        }

        static void GenerateBitmap(Bitmap bitmap)
        {
            double scale = 2 * MaxValueExtent / Math.Min(bitmap.Width, bitmap.Height);
            for (int i = 0; i < bitmap.Height; i++)
            {
                double y = (bitmap.Height / 2 - i) * scale;
                for (int j = 0; j < bitmap.Width; j++)
                {
                    double x = (j - bitmap.Width / 2) * scale;
                    double color = CalcMandelbrotSetColor(new ComplexNumber(x, y));
                    bitmap.SetPixel(j, i, GetColor(color));
                }
            }
        }

        static Color GetColor(double value)
        {
            const double MaxColor = 256;
            const double ContrastValue = 0.2;
            return Color.FromArgb(0, 0,
                (int)(MaxColor * Math.Pow(value, ContrastValue)));
        }

        void thread_Proc(object args)
        {
            // start from small image to provide instant display for user
            Size size = (Size)args;
            int width = 16;
            while (width * 2 < size.Width)
            {
                int height = width * size.Height / size.Width;
                Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                GenerateBitmap(bitmap);
                BeginInvoke(new SetNewBitmapDelegate(SetNewBitmap), bitmap);
                width *= 2;
            }
            // then generate final image
            Bitmap finalBitmap = new Bitmap(size.Width, size.Height, PixelFormat.Format24bppRgb);
            GenerateBitmap(finalBitmap);
            BeginInvoke(new SetNewBitmapDelegate(SetNewBitmap), finalBitmap);
        }

        void SetNewBitmap(Bitmap image)
        {
            if (BackgroundImage != null)
                BackgroundImage.Dispose();
            BackgroundImage = image;
            image.Save(Directory.GetCurrentDirectory() + "\\test.png", ImageFormat.Png);
        }

        delegate void SetNewBitmapDelegate(Bitmap image);
    }

    struct ComplexNumber
    {
        public double Re;
        public double Im;

        public ComplexNumber(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Re + y.Re, x.Im + y.Im);
        }

        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Re * y.Re - x.Im * y.Im,
                x.Re * y.Im + x.Im * y.Re);
        }

        public double Norm()
        {
            return Re * Re + Im * Im;
        }
    }
}
