using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ndp_carpismalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class nokta
        {
            public int x, y, z;
        }

        class cember
        {
            public int x, y, r;
        }

        class dikdörtgen
        {
            public int x, y, h, g;
        }

        class küre
        {
            public int x, y, z, r;
        }

        class dörtgen
        {
            public int x1, x2, x3, x4, y1, y2, y3, y4;
        }

        class silindir
        {
            public int x, y, r,z, h;
        }
        class dikdörtgenprizma
        {
            public int x, y, z, g, d, h;
        }
        float silindirkürecarpisma(silindir sa, küre küre6, float mx, float my, float mz, float dist)
        {
            if (mx > (sa.r / 2 + küre6.r))
            {
                dist += (float)Math.Pow(mx - sa.r / 2 - küre6.r, 2);
            }
            if (my > (sa.r / 2 + küre6.r))
            {
                dist += (float)Math.Pow(my - sa.r / 2 - küre6.r, 2);
            }
            if (mz > (sa.r / 2 + küre6.r))
            {
                dist += (float)Math.Pow(mz - sa.r / 2 - küre6.r, 2);
            }

            if (dist <= Math.Pow(küre6.r, 2))
            {
                // Çarpışma var
                label16.Text = ("carpisma gozlenir");
            }
            else
            {
                label16.Text = ("carpisma gozlenmez");
            }

            return dist;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secenek= comboBox1.SelectedItem.ToString();
            if (secenek == "nokta-cember") { label15.Text = "sırayla noktanın x ve y cemberin x,y ve yarıçap verilerini giriniz"; }

            if (secenek == "dikdörtgen-cember") { label15.Text = "sırayla dikdörtgenin x,y uzunluk genislik verilerini ve cemberin x,y,r verilerini giriniz";  }


            if (secenek == "dikdörtgen-dikdörtgen") { label15.Text = "sırayla dikdörtgenlerin x,y ve genişlik,uzunluk verilerini giriniz"; }


            if (secenek == "çember-çember") { label15.Text = "sırayla çemberlerin x,y ve r verilerini giriniz"; }


            if (secenek == "nokta-küre") { label15.Text = "sırayla noktanın x,y,z ve kürenin x,y,z,r verilerini giriniz"; }


            if (secenek == "küre-küre") { label15.Text = "kürelerin x,y,z,r verilerini giriniz"; }

            if (secenek=="nokta-dörtgen") {
                label15.Text = "sırasıyla noktanın x,y verilerini ve tüm dörtgen koordinatlarını giriniz";

                label4.Text = "x1";
                label5.Text = "x2";
                label6.Text = "x3";
                label7.Text = "x4";

                label11.Text = "y1";
                label12.Text = "y2";
                label13.Text = "y3";
                label14.Text = "x4";

            }

            if(secenek=="nokta-silindir") { label15.Text = "sırayla noktanın x,y verilerini ve silindirin x,y,z,h,r verilerini giriniz"; }

            if (secenek == "silindir-silindir") { label15.Text = "silindirlerin x,y,z,h,r verilerini giriniz"; }

            if (secenek == "küre-silindir") { label15.Text = "sırayla silindirin x,y,z,h,r verilerini ve kürenin x,y,z,r verilerini giriniz"; }

            if (secenek == "yüzey-küre") { label15.Text = "ilk sıradaki kutucuklara kürenin x,y,z,r veilerini giriniz"; }

            if (secenek == "yüzey-silindir") { label15.Text = "ilk sıradaki kutucuklara silindirin x,y,z,h,r verilerini giriniz"; }

            if (secenek == "dikdörtgenlerprizması-yüzey") { label15.Text = "ilk sıradaki kutucuklara prizmanın x,y,z,genişlik,yükseklik,derinlik verilerini giriniz";}

            if (secenek == "dikdörtgenlerprizması-küre") { label15.Text = "sırayla prizmanın x,y,z,genişlik,yükseklik,derinlik verilerini ve kürenin x,y,z,r verilerini giriniz"; }

            if (secenek == "dikdörtgenlerprizması-nokta") { label15.Text = "sırayla prizmanın x,y,z,genişlik,yükseklik,derinlik verilerini ve noktanın x,y,z verilerini giriniz"; }

            if (secenek == "dikdörtgenlerprizması-dikdörtgenlerprizması") { label15.Text = "prizmaların x,y,z,genişlik,yükseklik,derinlik verilerini giriniz"; }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim = comboBox1.SelectedItem.ToString();

            if (secim == "nokta-cember")
            {
                nokta nokta2 = new nokta();
                cember cember2 = new cember();

                nokta2.x = Convert.ToInt32(txbx1.Text);
                nokta2.y = Convert.ToInt32(txby1.Text);

                cember2.x = Convert.ToInt32(txbx2.Text);
                cember2.y = Convert.ToInt32(txby2.Text);
                cember2.r = Convert.ToInt32(txbr2.Text);

                if (Math.Sqrt(Math.Pow(nokta2.x - cember2.y, 2) + Math.Pow(nokta2.y - cember2.y, 2)) <= cember2.r)
                {
                    label16.Text = ("Çember ve nokta çarpışır.");
                }
                else
                {
                    label16.Text = ("Çember ve nokta çarpışmaz.");
                }

                using (Graphics g = pictureBox1.CreateGraphics())
                {

                    Brush brush = new SolidBrush(Color.Magenta);

                    g.FillEllipse(brush, nokta2.x, nokta2.y, 5, 5);
                    brush.Dispose();
                }

                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black);
                    int cap = cember2.r * 2;
                    int merkezx = cember2.x - cember2.r;
                    int merkezy = cember2.y - cember2.r;

                    g.DrawEllipse(pen, merkezx, merkezy, cap, cap);
                    pen.Dispose();
                }
            }
            if (secim == "dikdörtgen-cember")
            {
                dikdörtgen dikdörtgen4 = new dikdörtgen();
                cember cember4 = new cember();


                dikdörtgen4.x = Convert.ToInt32(txbx1.Text);
                dikdörtgen4.y = Convert.ToInt32(txby1.Text);
                dikdörtgen4.h = Convert.ToInt32(txbh1.Text);
                dikdörtgen4.g = Convert.ToInt32(txbg1.Text);

                cember4.x = Convert.ToInt32(txbx2.Text);
                cember4.y = Convert.ToInt32(txby2.Text);
                cember4.r = Convert.ToInt32(txbr2.Text);

                float testX = cember4.x;
                float testY = cember4.y;
                {
                    if (cember4.x < dikdörtgen4.x) testX = dikdörtgen4.x;      // test left edge
                    else if (cember4.x > dikdörtgen4.x + dikdörtgen4.g) testX = dikdörtgen4.x + dikdörtgen4.g;   // right edge
                    if (cember4.y < dikdörtgen4.y) testY = dikdörtgen4.y;      // top edge
                    else if (cember4.y > dikdörtgen4.y + dikdörtgen4.h) testY = dikdörtgen4.y + dikdörtgen4.h;   // bottom edge


                    float distX = cember4.x - testX;
                    float distY = cember4.y - testY;
                    float distance = (float)Math.Sqrt((distX * distX) + (distY * distY));
                    if (distance < cember4.r)
                    {
                        label16.Text = ("dikdörtgen cember arasi carpisma gozlenir");
                    }
                    else
                    {
                        label16.Text = ("carpisma gozlenmez");
                    }
                }
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black);
                    int cap = cember4.r * 2;
                    int merkezx = cember4.x - cember4.r;
                    int merkezy = cember4.y - cember4.r;

                    g.DrawEllipse(pen, merkezx, merkezy, cap, cap);
                    pen.Dispose();
                }

                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black);
                    g.DrawRectangle(pen, dikdörtgen4.x, dikdörtgen4.y, dikdörtgen4.g, dikdörtgen4.h);
                    pen.Dispose();

                }
            }
            if (secim == "dikdörtgen-dikdörtgen")
            {
                dikdörtgen dikdörtgen3a = new dikdörtgen();
                dikdörtgen dikdörtgen3b = new dikdörtgen();

                dikdörtgen3a.x = Convert.ToInt32(txbx1.Text);
                dikdörtgen3a.y = Convert.ToInt32(txby1.Text);
                dikdörtgen3a.h = Convert.ToInt32(txbh1.Text);
                dikdörtgen3a.g = Convert.ToInt32(txbg1.Text);

                dikdörtgen3b.x = Convert.ToInt32(txbx2.Text);
                dikdörtgen3b.y = Convert.ToInt32(txby2.Text);
                dikdörtgen3b.h = Convert.ToInt32(txbh2.Text);
                dikdörtgen3b.g = Convert.ToInt32(txbg2.Text);

                int ilksonuc = dikdörtgen3a.x - dikdörtgen3b.x;
                int ikincisonuc = dikdörtgen3a.y - dikdörtgen3b.y;

                if (
           Math.Abs(ilksonuc) < dikdörtgen3a.g / 2 + dikdörtgen3b.g / 2 &&
           Math.Abs(ikincisonuc) < dikdörtgen3a.h / 2 + dikdörtgen3b.g / 2)
                {
                    label16.Text = ("dikdörtgenler carpisir");
                }

                else
                {
                    label16.Text = ("carpisma yok");
                }

                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black);
                    g.DrawRectangle(pen, dikdörtgen3a.x, dikdörtgen3a.y, dikdörtgen3a.g, dikdörtgen3a.h);
                    pen.Dispose();

                }

                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black);
                    g.DrawRectangle(pen, dikdörtgen3b.x, dikdörtgen3b.y, dikdörtgen3b.g, dikdörtgen3b.h);
                    pen.Dispose();

                }
            }
            if (secim == "çember-çember")
            {
                cember cember5a = new cember();
                cember cember5b = new cember();

                cember5a.x = Convert.ToInt32(txbx1.Text);
                cember5a.y = Convert.ToInt32(txby1.Text);
                cember5a.r = Convert.ToInt32(txbr1.Text);

                cember5b.x = Convert.ToInt32(txbx2.Text);
                cember5b.y = Convert.ToInt32(txby2.Text);
                cember5b.r = Convert.ToInt32(txbr2.Text);

                int uzaklıkx = Math.Abs(cember5a.x - cember5b.x);
                int uzaklıky = Math.Abs(cember5a.y - cember5b.y);

                double asiluzaklık = Math.Sqrt(uzaklıkx * uzaklıkx + uzaklıky * uzaklıky);

                if (asiluzaklık < cember5b.r + cember5b.r)
                {
                    label16.Text = ("cemberler carpisir");
                }
                else
                {
                    label16.Text = ("cemberler carpismaz");
                }
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black);
                    int cap = cember5a.r * 2;
                    int merkezx = cember5a.x - cember5a.r;
                    int merkezy = cember5a.y - cember5a.r;

                    g.DrawEllipse(pen, merkezx, merkezy, cap, cap);
                    pen.Dispose();
                }
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black);
                    int capp = cember5b.r * 2;
                    int merkezxx = cember5b.x - cember5b.r;
                    int merkezyy = cember5b.y - cember5b.r;

                    g.DrawEllipse(pen, merkezxx, merkezyy, capp, capp);
                    pen.Dispose();
                }
            }
            if (secim == "nokta-küre")
            {
                nokta nokta6 = new nokta();
                küre küre6 = new küre();
                nokta6.x = Convert.ToInt32(txbx1.Text);
                nokta6.y = Convert.ToInt32(txby1.Text);
                nokta6.z = Convert.ToInt32(txbz1.Text);

                küre6.x = Convert.ToInt32(txbx2.Text);
                küre6.y = Convert.ToInt32(txby2.Text);
                küre6.z = Convert.ToInt32(txbz2.Text);
                küre6.y = Convert.ToInt32(txbr2.Text);

                double mesafe = Math.Sqrt(
             (nokta6.x - küre6.x) * (nokta6.x - küre6.x) +
             (nokta6.y - küre6.y) * (nokta6.y - küre6.y) +
             (nokta6.z - küre6.z) * (nokta6.z - küre6.z));
                if (mesafe < küre6.r)
                {
                    label16.Text = ("nokta kürenin icindedir");
                }
                else
                {
                    label16.Text = ("küre ve nokta carpismaz");
                }

                using (Graphics g = pictureBox1.CreateGraphics())
                {

                    Brush brush1 = new SolidBrush(Color.Magenta);

                    g.FillEllipse(brush1, nokta6.x, nokta6.y, 10, 10);
                    brush1.Dispose();
                }

                Brush brush = new SolidBrush(Color.Black);

                // Çemberi çizen fonksiyonu çağır ve sonucu pictureBox'a ata
                DrawCircle(brush, pictureBox1);


                void DrawCircle(Brush brush1, PictureBox pictureBox)
                {

                    Graphics g = pictureBox.CreateGraphics();


                    g.DrawEllipse(Pens.Black, Convert.ToInt32(txbx2.Text) - Convert.ToInt32(txbr2.Text), Convert.ToInt32(txby2.Text) - Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text));


                    g.FillEllipse(brush, Convert.ToInt32(txbx2.Text) - Convert.ToInt32(txbr2.Text), Convert.ToInt32(txby2.Text) - Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text));


                    g.Dispose();
                }
            }
            if (secim == "küre-küre")
            {
                küre küre10a = new küre();
                küre küre10b = new küre();

                küre10a.x = Convert.ToInt32(txbx1.Text);
                küre10a.y = Convert.ToInt32(txby1.Text);
                küre10a.z = Convert.ToInt32(txbz1.Text);
                küre10a.y = Convert.ToInt32(txbr1.Text);

                küre10b.x = Convert.ToInt32(txbx2.Text);
                küre10b.y = Convert.ToInt32(txby2.Text);
                küre10b.z = Convert.ToInt32(txbz2.Text);
                küre10b.y = Convert.ToInt32(txbr2.Text);

                float küremesafe = (float)Math.Sqrt(Math.Pow(küre10b.x - küre10a.x, 2) + Math.Pow(küre10b.y - küre10a.y, 2) + Math.Pow(küre10b.z - küre10a.z, 2));


                if (küremesafe <= küre10a.r + küre10b.r)
                {
                   label16.Text=("küreler carpisir");
                }
                else
                {
                    label16.Text=("küreler carpismaz");
                }

                Brush brush = new SolidBrush(Color.Black);

                // Çemberi çizen fonksiyonu çağır ve sonucu pictureBox'a ata
                DrawCircle(brush, pictureBox1);


                void DrawCircle(Brush brush1, PictureBox pictureBox)
                {

                    Graphics g = pictureBox.CreateGraphics();


                    g.DrawEllipse(Pens.Black, Convert.ToInt32(txbx1.Text) - Convert.ToInt32(txbr1.Text), Convert.ToInt32(txby1.Text) - Convert.ToInt32(txbr1.Text), 2 * Convert.ToInt32(txbr1.Text), 2 * Convert.ToInt32(txbr1.Text));


                    g.FillEllipse(brush, Convert.ToInt32(txbx1.Text) - Convert.ToInt32(txbr1.Text), Convert.ToInt32(txby1.Text) - Convert.ToInt32(txbr1.Text), 2 * Convert.ToInt32(txbr1.Text), 2 * Convert.ToInt32(txbr1.Text));


                    g.Dispose();

                    Graphics gg = pictureBox.CreateGraphics();


                    gg.DrawEllipse(Pens.Black, Convert.ToInt32(txbx2.Text) - Convert.ToInt32(txbr2.Text), Convert.ToInt32(txby2.Text) - Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text));


                    gg.FillEllipse(brush, Convert.ToInt32(txbx2.Text) - Convert.ToInt32(txbr2.Text), Convert.ToInt32(txby2.Text) - Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text));


                    gg.Dispose();
                }

            }

            if(secim=="nokta-dörtgen")
            {
                nokta nokta1 = new nokta();
                dörtgen dörtgen = new dörtgen();
                //11 12 13v14
             


                nokta1.x = Convert.ToInt32(txbx1.Text);
                nokta1.y = Convert.ToInt32(txby1.Text);
                nokta1.z = Convert.ToInt32(txbz1.Text);

                dörtgen.x1= Convert.ToInt32(txbr1.Text);
                dörtgen.x2 = Convert.ToInt32(txbh1.Text);
                dörtgen.x3 = Convert.ToInt32(txbg1.Text);
                dörtgen.x4 = Convert.ToInt32(txbd1.Text);
                dörtgen.y1 = Convert.ToInt32(txbr2.Text);
                dörtgen.y2 = Convert.ToInt32(txbh2.Text);
                dörtgen.y3 = Convert.ToInt32(txbg2.Text);
                dörtgen.y4 = Convert.ToInt32(txbd2.Text);


                double minX = Math.Min(Math.Min(dörtgen.x1, dörtgen.x2), Math.Min(dörtgen.x3, dörtgen.x4));
                double maxX = Math.Max(Math.Max(dörtgen.x1, dörtgen.x2), Math.Max(dörtgen.x3, dörtgen.x4));
                double minY = Math.Min(Math.Min(dörtgen.y1, dörtgen.y2), Math.Min(dörtgen.y3, dörtgen.y4));
                double maxY = Math.Max(Math.Max(dörtgen.y1, dörtgen.y2), Math.Max(dörtgen.y3, dörtgen.y4));

                if (nokta1.x >= minX && nokta1.x <= maxX &&
                   nokta1.y >= minY && nokta1.y <= maxY)

                {
                    label16.Text = "nokta ve dörtgen carpisir";
                }
                else
                {
                    label16.Text = "nokta ve dörtgen carpismaz";
                }

                using (Graphics g = pictureBox1.CreateGraphics())
                {

                    Brush brush = new SolidBrush(Color.DarkOrange);

                    g.FillEllipse(brush, nokta1.x, nokta1.y, 15, 15);
                    brush.Dispose();
                }

                Graphics graphicsss = pictureBox1.CreateGraphics();
                graphicsss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbr1.Text), 
                    Convert.ToInt32(txbh1.Text)), new Point(Convert.ToInt32(txbg1.Text),
                    Convert.ToInt32(txbd1.Text)));

                Graphics graphicssss = pictureBox1.CreateGraphics();
                graphicssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbg1.Text), 
                    Convert.ToInt32(txbd1.Text)), new Point(Convert.ToInt32(txbr2.Text), 
                    Convert.ToInt32(txbh2.Text)));

                Graphics graphicsssss = pictureBox1.CreateGraphics();
                graphicsssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbr2.Text), 
                    Convert.ToInt32(txbh2.Text)), new Point(Convert.ToInt32(txbg2.Text),
                    Convert.ToInt32(txbd2.Text)));

                Graphics graphicssssss = pictureBox1.CreateGraphics();
                graphicssssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbg2.Text), 
                    Convert.ToInt32(txbd2.Text)), new Point(Convert.ToInt32(txbr1.Text),
                    Convert.ToInt32(txbh1.Text)));

            }

            if (secim=="nokta-silindir")
            {
                nokta nokta8 = new nokta();
                silindir silindir8 = new silindir();

                nokta8.x = Convert.ToInt32(txbx1.Text);
                nokta8.y = Convert.ToInt32(txby1.Text);

                silindir8.x= Convert.ToInt32(txbx2.Text);
                silindir8.y = Convert.ToInt32(txby2.Text);
                silindir8.z = Convert.ToInt32(txbz2.Text);
                silindir8.r = Convert.ToInt32(txbr2.Text);
                silindir8.h = Convert.ToInt32(txbh2.Text);

                float mesafee = (float)Math.Sqrt(Math.Pow(nokta8.x - silindir8.x, 2) + Math.Pow(nokta8.y - silindir8.y, 2));
                {
                    if (mesafee <= silindir8.r)
                    {
                        label16.Text=("Nokta silindirin içinde!");
                    }
                    else
                    {
                       label16.Text=("Nokta silindirin dışında.");
                    }
                }

                using (Graphics g = pictureBox1.CreateGraphics())
                {

                    Brush brush = new SolidBrush(Color.Magenta);

                    g.FillEllipse(brush, nokta8.x, nokta8.y, 5, 5);
                    brush.Dispose();
                }

                DrawCylinder(pictureBox1);

                void DrawCylinder(PictureBox pictureBox)
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    g.DrawEllipse(Pens.Red, silindir8.x - silindir8.r, silindir8.y - silindir8.r, 2 * silindir8.r, 2 * silindir8.r);
                    g.FillEllipse(Brushes.Blue, silindir8.x - silindir8.r, silindir8.y - silindir8.r, 2 * silindir8.r, 2 * silindir8.r);

                    g.DrawEllipse(Pens.Red, silindir8.x - silindir8.r, silindir8.y - silindir8.r, 2 * silindir8.r, 2 * silindir8.r);
                    g.FillEllipse(Brushes.Blue, silindir8.x - silindir8.r, silindir8.y - silindir8.r+silindir8.h, 2 * silindir8.r, 2 * silindir8.r);

                    g.DrawLine(Pens.Blue, silindir8.x - silindir8.r, silindir8.y,
                        silindir8.x - silindir8.r, silindir8.y +
                         silindir8.h);


                    g.DrawLine(Pens.Blue, silindir8.x + silindir8.r,
                        silindir8.y, silindir8.x + silindir8.r,
                        silindir8.y + silindir8.h);

                    g.Dispose();

                }

            }

            if(secim=="silindir-silindir")
            {
                silindir sa = new silindir();
                silindir sb = new silindir();

                sa.x = Convert.ToInt32(txbx1.Text);
                sa.y = Convert.ToInt32(txby1.Text);
                sa.z = Convert.ToInt32(txbz1.Text);
                sa.r = Convert.ToInt32(txbr1.Text);
                sa.h = Convert.ToInt32(txbh1.Text);

                sb.x = Convert.ToInt32(txbx2.Text);
                sb.y = Convert.ToInt32(txby2.Text);
                sb.z = Convert.ToInt32(txbz2.Text);
                sb.r = Convert.ToInt32(txbr2.Text);
                sb.h = Convert.ToInt32(txbh2.Text);

                float silmesafeler = (float)Math.Sqrt(Math.Pow(sb.x - sa.x, 2) + Math.Pow(sb.y - sa.y, 2));

                if (silmesafeler <= sa.r + sb.r)
                {
                    label16.Text=("Silindirler çarpıştı.");
                }
                else
                {
                    label16.Text=("Silindirler çarpışmadı.");
                }


                DrawCylinder(pictureBox1);

                void DrawCylinder(PictureBox pictureBox)
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    g.DrawEllipse(Pens.Red, sa.x - sa.r, sa.y - sa.r, 2 * sa.r, 2 * sa.r);
                    g.FillEllipse(Brushes.Blue, sa.x - sa.r, sa.y - sa.r, 2 * sa.r, 2 * sa.r);

                    g.DrawEllipse(Pens.Red, sa.x - sa.r, sa.y - sa.r, 2 * sa.r, 2 * sa.r);
                    g.FillEllipse(Brushes.Blue, sa.x - sa.r, sa.y - sa.r + sa.h, 2 * sa.r, 2 * sa.r);

                    g.DrawLine(Pens.Blue, sa.x - sa.r, sa.y,
                        sa.x - sa.r, sa.y +
                         sa.h);


                    g.DrawLine(Pens.Blue, sa.x + sa.r,
                        sa.y, sa.x + sa.r,
                        sa.y + sa.h);

                    g.Dispose();

                }

                DrawCylinder1(pictureBox1);

                void DrawCylinder1(PictureBox pictureBox)
                {
                    
                    Graphics g = pictureBox1.CreateGraphics();
                    g.DrawEllipse(Pens.Red, sb.x - sb.r, sb.y - sb.r, 2 * sb.r, 2 * sb.r);
                    g.FillEllipse(Brushes.Blue, sb.x - sb.r, sb.y - sb.r, 2 * sb.r, 2 * sb.r);

                    g.DrawEllipse(Pens.Red, sb.x - sb.r, sb.y - sb.r, 2 * sb.r, 2 * sb.r);
                    g.FillEllipse(Brushes.Blue, sb.x - sb.r, sb.y - sb.r + sb.h, 2 * sb.r, 2 * sb.r);

                    g.DrawLine(Pens.Blue, sb.x - sb.r, sb.y,
                        sb.x - sb.r, sb.y +
                         sb.h);


                    g.DrawLine(Pens.Blue, sb.x + sb.r,
                        sb.y, sb.x + sb.r,
                        sb.y + sb.h);

                    g.Dispose();

                }

            }
            if(secim=="küre-silindir")
            {
                küre küre6 = new küre();
                silindir sa = new silindir();

                sa.x = Convert.ToInt32(txbx1.Text);
                sa.y = Convert.ToInt32(txby1.Text);
                sa.z = Convert.ToInt32(txbz1.Text);
                sa.r = Convert.ToInt32(txbr1.Text);
                sa.h = Convert.ToInt32(txbh1.Text);


                küre6.x = Convert.ToInt32(txbx2.Text);
                küre6.y = Convert.ToInt32(txby2.Text);
                küre6.z = Convert.ToInt32(txbz2.Text);
                küre6.y = Convert.ToInt32(txbr2.Text);

                Drawsilindir(pictureBox1);

                void Drawsilindir(PictureBox pictureBox)
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    g.DrawEllipse(Pens.Red, sa.x - sa.r, sa.y - sa.r, 2 * sa.r, 2 * sa.r);
                    g.FillEllipse(Brushes.Blue, sa.x - sa.r, sa.y - sa.r, 2 * sa.r, 2 * sa.r);

                    g.DrawEllipse(Pens.Red, sa.x - sa.r, sa.y - sa.r, 2 * sa.r, 2 * sa.r);
                    g.FillEllipse(Brushes.Blue, sa.x - sa.r, sa.y - sa.r + sa.h, 2 * sa.r, 2 * sa.r);

                    g.DrawLine(Pens.Blue, sa.x - sa.r, sa.y,
                        sa.x - sa.r, sa.y +
                         sa.h);


                    g.DrawLine(Pens.Blue, sa.x + sa.r,
                        sa.y, sa.x + sa.r,
                        sa.y + sa.h);

                    g.Dispose();
                }
                    Brush brush = new SolidBrush(Color.Black);

                    // Çemberi çizen fonksiyonu çağır ve sonucu pictureBox'a ata
                    DrawCircle(brush, pictureBox1);

                    void DrawCircle(Brush brush1, PictureBox pictureBox1)
                    {

                        Graphics gg = pictureBox1.CreateGraphics();


                        gg.DrawEllipse(Pens.Black, Convert.ToInt32(txbx2.Text) - Convert.ToInt32(txbr2.Text), Convert.ToInt32(txby2.Text) - Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text));


                        gg.FillEllipse(brush, Convert.ToInt32(txbx2.Text) - Convert.ToInt32(txbr2.Text), Convert.ToInt32(txby2.Text) - Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text));


                        gg.Dispose();
                    }

                 // Silindirin ekseni boyunca merkez noktasına olan uzaklığı hesapla
                float mx = Math.Abs(küre6.x - sa.x);
                float my = Math.Abs(küre6.y - sa.y);
                float mz = Math.Abs(küre6.z - sa.z);

                // Silindirin ekseni boyunca kürenin merkezine olan uzaklığı hesapla
                float dist = 0.0f;

                dist = silindirkürecarpisma(sa, küre6, mx, my, mz, dist);
                //fonksiyon 
            }

            if (secim == "yüzey-küre")
            {
                küre küre1 = new küre();

                Graphics a = pictureBox1.CreateGraphics();
                a.DrawLine(Pens.Black, new Point(90, 200), new Point(300, 200));
                a.DrawLine(Pens.Black, new Point(300, 200), new Point(220, 250));
                a.DrawLine(Pens.Black, new Point(220, 250), new Point(10, 250));
                a.DrawLine(Pens.Black, new Point(10, 250), new Point(90, 200));

                küre1.x = Convert.ToInt32(txbx1.Text);
                küre1.y = Convert.ToInt32(txby1.Text);
                küre1.z = Convert.ToInt32(txbz1.Text);
                küre1.r = Convert.ToInt32(txbr1.Text);

                if (küre1.y + küre1.r < 110) { label16.Text = "yüzey küre çarpışma gözlenmez"; }
                else if (küre1.y + küre1.r == 110) { label16.Text = "yüzey küre çarpışır"; }
                else if (küre1.y - küre1.r == 150) { label16.Text = "yüzey küre çarpışır"; }
                else if (küre1.y < 110 && 150 < küre1.y) { label16.Text = "yüzey küre çarpışır"; }
                else { label16.Text = "çarpışmazlar"; }

                Brush brush = new SolidBrush(Color.Black);

                // Çemberi çizen fonksiyonu çağır ve sonucu pictureBox'a ata
                DrawCircle(brush, pictureBox1);


                void DrawCircle(Brush brush1, PictureBox pictureBox)
                {

                    Graphics g = pictureBox.CreateGraphics();


                    g.DrawEllipse(Pens.Black, Convert.ToInt32(txbx1.Text) - Convert.ToInt32(txbr1.Text), Convert.ToInt32(txby1.Text) - Convert.ToInt32(txbr1.Text), 2 * Convert.ToInt32(txbr1.Text), 2 * Convert.ToInt32(txbr1.Text));


                    g.FillEllipse(brush, Convert.ToInt32(txbx1.Text) - Convert.ToInt32(txbr1.Text), Convert.ToInt32(txby1.Text) - Convert.ToInt32(txbr1.Text), 2 * Convert.ToInt32(txbr1.Text), 2 * Convert.ToInt32(txbr1.Text));


                    g.Dispose();
                }
            }
            if (secim=="yüzey-silindir")
            {
                Graphics a = pictureBox1.CreateGraphics();
                a.DrawLine(Pens.Black, new Point(90, 200), new Point(300, 200));
                a.DrawLine(Pens.Black, new Point(300, 200), new Point(220, 250));
                a.DrawLine(Pens.Black, new Point(220, 250), new Point(10, 250));
                a.DrawLine(Pens.Black, new Point(10, 250), new Point(90, 200));

                silindir sa = new silindir();
                sa.x = Convert.ToInt32(txbx1.Text);
                sa.y = Convert.ToInt32(txby1.Text);
                sa.z = Convert.ToInt32(txbz1.Text);
                sa.r = Convert.ToInt32(txbr1.Text);
                sa.h = Convert.ToInt32(txbh1.Text);

                Drawsilindir(pictureBox1);

                void Drawsilindir(PictureBox pictureBox)
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    g.DrawEllipse(Pens.Red, sa.x - sa.r, sa.y - sa.r, 2 * sa.r, 2 * sa.r);
                    g.FillEllipse(Brushes.Blue, sa.x - sa.r, sa.y - sa.r, 2 * sa.r, 2 * sa.r);

                    g.DrawEllipse(Pens.Red, sa.x - sa.r, sa.y - sa.r, 2 * sa.r, 2 * sa.r);
                    g.FillEllipse(Brushes.Blue, sa.x - sa.r, sa.y - sa.r + sa.h, 2 * sa.r, 2 * sa.r);

                    g.DrawLine(Pens.Blue, sa.x - sa.r, sa.y,
                        sa.x - sa.r, sa.y +
                         sa.h);


                    g.DrawLine(Pens.Blue, sa.x + sa.r,
                        sa.y, sa.x + sa.r,
                        sa.y + sa.h);

                    g.Dispose();
                }

                if (sa.y + sa.r + sa.h > 200 && sa.y + sa.r + sa.h < 250)
                { label16.Text = "çarpışma gözlenir."; }
                else if (sa.y + sa.h > 200 && sa.y + sa.h < 250)
                {
                    label16.Text = "çarpışma gözlenir.";
                }
                else { label16.Text = "çarpışma gözlenmez."; }

            }

            if(secim=="dikdörtgenlerprizması-yüzey")
            {

                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(Pens.Black, new Point(90, 200), new Point(300, 200));
                g.DrawLine(Pens.Black, new Point(300, 200), new Point(220, 250));
                g.DrawLine(Pens.Black, new Point(220, 250), new Point(10, 250));
                g.DrawLine(Pens.Black, new Point(10, 250), new Point(90, 200));

                dikdörtgenprizma dk = new dikdörtgenprizma();

                dk.x = Convert.ToInt32(txbx1.Text);
                dk.y = Convert.ToInt32(txby1.Text);
                dk.z = Convert.ToInt32(txbz1.Text);
                dk.h = Convert.ToInt32(txbh1.Text);
                dk.g = Convert.ToInt32(txbg1.Text);
                dk.d = Convert.ToInt32(txbd1.Text);

                if (dk.y + dk.h > 200 && dk.y+ dk.h < 250)
                {
                    label16.Text = "Çarpışma gözlenir";
                }

                else { label16.Text = "Çarpışma gözlenmez"; }

                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.DrawRectangle(Pens.Black, Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text), 
                    Convert.ToInt32(txbh1.Text), Convert.ToInt32(txbg1.Text));

                Graphics graphicss = pictureBox1.CreateGraphics();
                graphicss.DrawRectangle(Pens.Black, Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text), 
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text), Convert.ToInt32(txbh1.Text), 
                    Convert.ToInt32(txbg1.Text));



                Graphics graphicsss = pictureBox1.CreateGraphics();
                graphicsss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text)),
                    new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbd1.Text)));

                Graphics graphicssss = pictureBox1.CreateGraphics();
                graphicssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbh1.Text), 
                    Convert.ToInt32(txby1.Text)), new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text) + 
                    Convert.ToInt32(txbh1.Text), Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text)));


                Graphics graphicsssss = pictureBox1.CreateGraphics();
                graphicsssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text) + 
                    Convert.ToInt32(txbg1.Text)), new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text), 
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text) + Convert.ToInt32(txbg1.Text)));


                Graphics graphicssssss = pictureBox1.CreateGraphics();
                graphicssssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbh1.Text), 
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbg1.Text)), new Point(Convert.ToInt32(txbx1.Text) +
                    Convert.ToInt32(txbd1.Text) + Convert.ToInt32(txbh1.Text), Convert.ToInt32(txby1.Text) + 
                    Convert.ToInt32(txbg1.Text) + Convert.ToInt32(txbd1.Text)));


            }
            if (secim == "dikdörtgenlerprizması-küre")
            {
                dikdörtgenprizma dk = new dikdörtgenprizma();

                dk.x = Convert.ToInt32(txbx1.Text);
                dk.y = Convert.ToInt32(txby1.Text);
                dk.z = Convert.ToInt32(txbz1.Text);
                dk.h = Convert.ToInt32(txbh1.Text);
                dk.g = Convert.ToInt32(txbg1.Text);
                dk.d = Convert.ToInt32(txbd1.Text);

                küre küre1 = new küre();
                küre1.x = Convert.ToInt32(txbx2.Text);
                küre1.y = Convert.ToInt32(txby2.Text);
                küre1.z = Convert.ToInt32(txbz2.Text);
                küre1.y = Convert.ToInt32(txbr2.Text);

                double enKisaMesafeX = Math.Max(dk.x - küre1.x, 0);
                enKisaMesafeX = Math.Max(enKisaMesafeX, küre1.x - dk.x - dk.g);
                double enKisaMesafeY = Math.Max(dk.y - küre1.y, 0);
                enKisaMesafeY = Math.Max(enKisaMesafeY, küre1.y - dk.y - dk.h);
                double enKisaMesafeZ = Math.Max(dk.z - küre1.z, 0);
                enKisaMesafeZ = Math.Max(enKisaMesafeZ, küre1.z - dk.z - dk.d);
                double enKisaMesafe = Math.Sqrt(enKisaMesafeX * enKisaMesafeX + enKisaMesafeY * enKisaMesafeY + enKisaMesafeZ * enKisaMesafeZ);

                {
                    if (enKisaMesafe <= küre1.r)
                    {
                        label16.Text=("Çarpışma meydana geldi.");
                    }
                    else
                        label16.Text=("çarpışma olmadı");
                }

                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.DrawRectangle(Pens.Black, Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text),
                    Convert.ToInt32(txbh1.Text), Convert.ToInt32(txbg1.Text));

                Graphics graphicss = pictureBox1.CreateGraphics();
                graphicss.DrawRectangle(Pens.Black, Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text),
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text), Convert.ToInt32(txbh1.Text),
                    Convert.ToInt32(txbg1.Text));



                Graphics graphicsss = pictureBox1.CreateGraphics();
                graphicsss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text)),
                    new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbd1.Text)));

                Graphics graphicssss = pictureBox1.CreateGraphics();
                graphicssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbh1.Text),
                    Convert.ToInt32(txby1.Text)), new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text) +
                    Convert.ToInt32(txbh1.Text), Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text)));


                Graphics graphicsssss = pictureBox1.CreateGraphics();
                graphicsssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbg1.Text)), new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text),
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text) + Convert.ToInt32(txbg1.Text)));


                Graphics graphicssssss = pictureBox1.CreateGraphics();
                graphicssssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbh1.Text),
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbg1.Text)), new Point(Convert.ToInt32(txbx1.Text) +
                    Convert.ToInt32(txbd1.Text) + Convert.ToInt32(txbh1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbg1.Text) + Convert.ToInt32(txbd1.Text)));

                Brush brush = new SolidBrush(Color.Black);

                // Çemberi çizen fonksiyonu çağır ve sonucu pictureBox'a ata
                DrawCircle(brush, pictureBox1);


                void DrawCircle(Brush brush1, PictureBox pictureBox)
                {

                    Graphics g = pictureBox.CreateGraphics();


                    g.DrawEllipse(Pens.Black, Convert.ToInt32(txbx2.Text) - Convert.ToInt32(txbr2.Text), Convert.ToInt32(txby2.Text) - Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text));


                    g.FillEllipse(brush, Convert.ToInt32(txbx2.Text) - Convert.ToInt32(txbr2.Text), Convert.ToInt32(txby2.Text) - Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text), 2 * Convert.ToInt32(txbr2.Text));


                    g.Dispose();
                }


            }

            if(secim=="dikdörtgenlerprizması-nokta")
            {

                dikdörtgenprizma dk = new dikdörtgenprizma();

                dk.x = Convert.ToInt32(txbx1.Text);
                dk.y = Convert.ToInt32(txby1.Text);
                dk.z = Convert.ToInt32(txbz1.Text);
                dk.h = Convert.ToInt32(txbh1.Text);
                dk.g = Convert.ToInt32(txbg1.Text);
                dk.d = Convert.ToInt32(txbd1.Text);

                nokta nokta2 = new nokta();
                nokta2.x = Convert.ToInt32(txbx2.Text);
                nokta2.y = Convert.ToInt32(txby2.Text);

                if ((nokta2.x >= dk.x - dk.g / 2) && (nokta2.x <= dk.x + dk.g / 2) &&
                                     (nokta2.y >= dk.y - dk.h / 2) && (nokta2.y <= dk.y + dk.h / 2) &&
                                     (nokta2.z >= dk.z - dk.d / 2) && (nokta2.z <= dk.z + dk.d / 2))


                { label16.Text=("Nokta dikdörtgenler prizması içinde."); }

                else
                { label16.Text=("Nokta dikdörtgenler prizması dışında."); }
            


            using (Graphics g = pictureBox1.CreateGraphics())
                {

                    Brush brush = new SolidBrush(Color.Magenta);

                    g.FillEllipse(brush, nokta2.x, nokta2.y, 5, 5);
                    brush.Dispose();
                }


                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.DrawRectangle(Pens.Black, Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text),
                    Convert.ToInt32(txbh1.Text), Convert.ToInt32(txbg1.Text));

                Graphics graphicss = pictureBox1.CreateGraphics();
                graphicss.DrawRectangle(Pens.Black, Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text),
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text), Convert.ToInt32(txbh1.Text),
                    Convert.ToInt32(txbg1.Text));



                Graphics graphicsss = pictureBox1.CreateGraphics();
                graphicsss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text)),
                    new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbd1.Text)));

                Graphics graphicssss = pictureBox1.CreateGraphics();
                graphicssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbh1.Text),
                    Convert.ToInt32(txby1.Text)), new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text) +
                    Convert.ToInt32(txbh1.Text), Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text)));


                Graphics graphicsssss = pictureBox1.CreateGraphics();
                graphicsssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbg1.Text)), new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text),
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text) + Convert.ToInt32(txbg1.Text)));


                Graphics graphicssssss = pictureBox1.CreateGraphics();
                graphicssssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbh1.Text),
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbg1.Text)), new Point(Convert.ToInt32(txbx1.Text) +
                    Convert.ToInt32(txbd1.Text) + Convert.ToInt32(txbh1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbg1.Text) + Convert.ToInt32(txbd1.Text)));
            }

            if(secim=="dikdörtgenlerprizması-dikdörtgenlerprizması")
            {
                dikdörtgenprizma dk = new dikdörtgenprizma();

                dk.x = Convert.ToInt32(txbx1.Text);
                dk.y = Convert.ToInt32(txby1.Text);
                dk.z = Convert.ToInt32(txbz1.Text);
                dk.h = Convert.ToInt32(txbh1.Text);
                dk.g = Convert.ToInt32(txbg1.Text);
                dk.d = Convert.ToInt32(txbd1.Text);

                dikdörtgenprizma dk1 = new dikdörtgenprizma();

                dk1.x = Convert.ToInt32(txbx2.Text);
                dk1.y = Convert.ToInt32(txby2.Text);
                dk1.z = Convert.ToInt32(txbz2.Text);
                dk1.h = Convert.ToInt32(txbh2.Text);
                dk1.g = Convert.ToInt32(txbg2.Text);
                dk1.d = Convert.ToInt32(txbd2.Text);

                double xOverlap = Math.Max(0, Math.Min(dk.x + dk.g, dk1.x + dk1.g) - Math.Max(dk.x, dk1.x));
                double yOverlap = Math.Max(0, Math.Min(dk.y + dk.h, dk1.y + dk1.h) - Math.Max(dk.y, dk1.y));
                double zOverlap = Math.Max(0, Math.Min(dk.z + dk.d, dk1.z + dk1.d) - Math.Max(dk.z, dk1.z));

                {
                    if (xOverlap * yOverlap * zOverlap > 0)
                    {
                       label16.Text=("Prizmalar birbirine çarpıyor.");
                    }
                    else
                    {
                        label16.Text=("Prizmalar birbirine çarpmıyor.");
                    }
                }


                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.DrawRectangle(Pens.Black, Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text),
                    Convert.ToInt32(txbh1.Text), Convert.ToInt32(txbg1.Text));

                Graphics graphicss = pictureBox1.CreateGraphics();
                graphicss.DrawRectangle(Pens.Black, Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text),
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text), Convert.ToInt32(txbh1.Text),
                    Convert.ToInt32(txbg1.Text));



                Graphics graphicsss = pictureBox1.CreateGraphics();
                graphicsss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text)),
                    new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbd1.Text)));

                Graphics graphicssss = pictureBox1.CreateGraphics();
                graphicssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbh1.Text),
                    Convert.ToInt32(txby1.Text)), new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text) +
                    Convert.ToInt32(txbh1.Text), Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text)));


                Graphics graphicsssss = pictureBox1.CreateGraphics();
                graphicsssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbg1.Text)), new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbd1.Text),
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbd1.Text) + Convert.ToInt32(txbg1.Text)));


                Graphics graphicssssss = pictureBox1.CreateGraphics();
                graphicssssss.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx1.Text) + Convert.ToInt32(txbh1.Text),
                    Convert.ToInt32(txby1.Text) + Convert.ToInt32(txbg1.Text)), new Point(Convert.ToInt32(txbx1.Text) +
                    Convert.ToInt32(txbd1.Text) + Convert.ToInt32(txbh1.Text), Convert.ToInt32(txby1.Text) +
                    Convert.ToInt32(txbg1.Text) + Convert.ToInt32(txbd1.Text)));

                /////
                ///
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawRectangle(Pens.Black, Convert.ToInt32(txbx2.Text), Convert.ToInt32(txby2.Text),
                    Convert.ToInt32(txbh2.Text), Convert.ToInt32(txbg2.Text));

                Graphics gg = pictureBox1.CreateGraphics();
                gg.DrawRectangle(Pens.Black, Convert.ToInt32(txbx2.Text) + Convert.ToInt32(txbd2.Text),
                    Convert.ToInt32(txby2.Text) + Convert.ToInt32(txbd2.Text), Convert.ToInt32(txbh2.Text),
                    Convert.ToInt32(txbg2.Text));



                Graphics ggg = pictureBox1.CreateGraphics();
                ggg.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx2.Text), Convert.ToInt32(txby2.Text)),
                    new Point(Convert.ToInt32(txbx2.Text) + Convert.ToInt32(txbd2.Text), Convert.ToInt32(txby2.Text) +
                    Convert.ToInt32(txbd2.Text)));

                Graphics k = pictureBox1.CreateGraphics();
                k.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx2.Text) + Convert.ToInt32(txbh2.Text),
                    Convert.ToInt32(txby2.Text)), new Point(Convert.ToInt32(txbx2.Text) + Convert.ToInt32(txbd2.Text) +
                    Convert.ToInt32(txbh2.Text), Convert.ToInt32(txby2.Text) + Convert.ToInt32(txbd2.Text)));


                Graphics l = pictureBox1.CreateGraphics();
                l.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx2.Text), Convert.ToInt32(txby2.Text) +
                    Convert.ToInt32(txbg2.Text)), new Point(Convert.ToInt32(txbx2.Text) + Convert.ToInt32(txbd2.Text),
                    Convert.ToInt32(txby2.Text) + Convert.ToInt32(txbd2.Text) + Convert.ToInt32(txbg2.Text)));


                Graphics m = pictureBox1.CreateGraphics();
                m.DrawLine(Pens.Black, new Point(Convert.ToInt32(txbx2.Text) + Convert.ToInt32(txbh2.Text),
                    Convert.ToInt32(txby2.Text) + Convert.ToInt32(txbg2.Text)), new Point(Convert.ToInt32(txbx2.Text) +
                    Convert.ToInt32(txbd2.Text) + Convert.ToInt32(txbh2.Text), Convert.ToInt32(txby2.Text) +
                    Convert.ToInt32(txbg2.Text) + Convert.ToInt32(txbd2.Text)));

            }
        }

      
    }
}