using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace Project3_Adilbek.Khiiasov58981
{
    public abstract class dvBrylaAbstrakcyjna
    {
        protected int Promien;
        protected const float KatProsty = 90;
        public enum TypyBryl { dvWalec, dvStozek, dvStozekPochiliony, dvKula, dvOstroslup, dvGraniastoslup, dvSzescian, dvOstroslupyOWspolnejPodstawie }

        protected int XsP, YsP;
        protected int WysokoscBryly;
        protected float KatPochilenia;

        protected Color KolorLinii;
        protected DashStyle StylLinii;
        protected int GruboscLinii;

        public TypyBryl RodzajBryly;
        public bool KirunekObrotu;
        protected float PowierchniaBruly;
        protected float ObjetoscBruly;

        protected bool Widoczny;
        private float volume;

        public abstract float GetVolume();

        private void SetVolume(float value)
        {
            volume = value;
        }

        private float area;

        public abstract float GetArea();

        private void SetArea(float value)
        {
            area = value;
        }

        //promien
        public float Radius
        {
            get
            {
                return Promien;
            }
            private set { }
        }

        //wysokosc
        public float Height
        {
            get
            {
                return WysokoscBryly;
            }
            private set { }
        }


        //konstruktor
        public dvBrylaAbstrakcyjna(Color KolorLinii, DashStyle StylLinii, int GruboscLinii)
        {
            this.KolorLinii = KolorLinii;
            this.StylLinii = StylLinii;
            this.GruboscLinii = GruboscLinii;
            this.KatPochilenia = KatProsty;
        }
        //metody abstrakcyjne 
        public abstract void dvDraw(Graphics Rysownica);
        public abstract void dvErase(Control Kontrolka, Graphics Rysownica);
        public abstract void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu);
        public abstract void dvReplace(Control Kontrolka, Graphics Rysownica, int x, int y);

        //metody publiczne 
        public void dvSetGraphicAttributes(Color KolorLinii, DashStyle StylLinii, int GruboscLinii)
        {
            this.KolorLinii = KolorLinii;
            this.StylLinii = StylLinii;
            this.GruboscLinii = GruboscLinii;
        }
    }

    public class dvBrylyObrotowe : dvBrylaAbstrakcyjna
    {

        public dvBrylyObrotowe(int R, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) : base(KolorLinii,  StylLinii, GruboscLinii)
        {
            Promien = R;
        }

        public override float GetArea()
        {
            throw new NotImplementedException();
        }

        public override float GetVolume()
        {
            throw new NotImplementedException();
        }

        public override void dvDraw(Graphics Rysownica)
        {

        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {

        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {

        }

        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int x, int y)
        {

        }
    }

    public class dvWielosciany : dvBrylaAbstrakcyjna
    {
        protected Point[] WielokatPodlogi;
        protected Point[] WielokatSufitu;

        protected int XsS, YsS;

        protected int StopieNwielokataPodstawy;

        public dvWielosciany(int R, int StopieNwielokataPodstawy, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) : base(KolorLinii, StylLinii, GruboscLinii)
        {
            this.Promien = R;
            this.StopieNwielokataPodstawy = StopieNwielokataPodstawy;
        }
        public override float GetArea()
        {
            throw new NotImplementedException();
        }

        public override float GetVolume()
        {
            throw new NotImplementedException();
        }

        public override void dvDraw(Graphics Rysownica)
        {
            throw new NotImplementedException();
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            throw new NotImplementedException();
        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            throw new NotImplementedException();
        }
        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
    public class dvWalec : dvBrylyObrotowe
    {
        private Point[] WielokatPodlogi;
        private Point[] WielokatSufitu;

        int XsS, YsS;

        int StopieNwielokataPodstawy;
        float OsDuza, OsMala;

        float KatMiedzyWiercholkami;
        float KatPolozenia;

        //objętosc
        public override float GetVolume()
        {
            return (float)Math.PI * (float)this.WysokoscBryly * (float)(OsDuza / 2) * (float)(OsDuza / 2);
        }

        //pole
        public override float GetArea()
        {
            return (float)(2 * Math.PI * WysokoscBryly * Radius + 2 * Math.PI * Radius * Radius);
        }

        public dvWalec(int R, int WysokoscWlaca, int StopieNwielokataPodstawy, int XsP, int YsP, float KatPochileniaWalca, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) :
            base(R, KolorLinii, StylLinii, GruboscLinii)
        {
            RodzajBryly = TypyBryl.dvWalec;
            WysokoscBryly = WysokoscWlaca;
            this.StopieNwielokataPodstawy = StopieNwielokataPodstawy;
            OsDuza = Promien * 2;
            OsMala = Promien / 2;

            this.XsP = XsP;
            this.YsP = YsP;


                XsS = XsP;

            YsS = YsP - WysokoscWlaca;

            KatMiedzyWiercholkami = 360 / StopieNwielokataPodstawy;
            KatPolozenia = 0;

            WielokatPodlogi = new Point[StopieNwielokataPodstawy + 1];
            WielokatSufitu = new Point[StopieNwielokataPodstawy + 1];

            for (int i = 0; i <= StopieNwielokataPodstawy; i++)
            {
                WielokatPodlogi[i] = new Point();
                WielokatSufitu[i] = new Point();

                WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
            }
        }

        public override void dvDraw(Graphics Rysownica)
        {
            using(Pen pen = new Pen(KolorLinii, GruboscLinii))
            {
                pen.DashStyle = StylLinii;

                Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                Rysownica.DrawEllipse(pen, XsS - OsDuza / 2, YsS - OsMala / 2, OsDuza, OsMala);

                using(Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                {
                    LinePen.DashStyle = StylLinii;
                    for(int i = 0; i <= StopieNwielokataPodstawy; i++)
                    {
                        Rysownica.DrawLine(LinePen, WielokatPodlogi[i], WielokatSufitu[i]);
                    }
                }

                Rysownica.DrawLine(pen, XsP - OsDuza / 2, YsP, XsS - OsDuza / 2, YsS);
                Rysownica.DrawLine(pen, XsP + OsDuza / 2, YsP, XsS + OsDuza / 2, YsS);

                Widoczny = true;
            }
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            if (Widoczny)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                    Rysownica.DrawEllipse(pen, XsS - OsDuza / 2, YsS - OsMala / 2, OsDuza, OsMala);

                    using (Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                    {
                        LinePen.DashStyle = StylLinii;
                        for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(LinePen, WielokatPodlogi[i], WielokatSufitu[i]);
                        }
                    }

                    Rysownica.DrawLine(pen, XsP - OsDuza / 2, YsP, XsS - OsDuza / 2, YsS);
                    Rysownica.DrawLine(pen, XsP + OsDuza / 2, YsP, XsS + OsDuza / 2, YsS);

                    Widoczny = false;
                }
            }

        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            if (Widoczny)
            {
                dvErase(Kontrolka, Rysownica);


                if (KirunekObrotu)
                {
                    KatPolozenia -= KatObrotu;
                }
                else
                {
                    KatPolozenia += KatObrotu;
                }

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int X, int Y)
        {
            if (Widoczny)
            {
                int dX, dY;

                dvErase(Kontrolka, Rysownica);

                dX = XsP > X ? X - XsP : -(XsP - X);
                dY = YsP > Y ? Y - YsP : -(YsP - Y);

                XsP += dX;
                YsP += dY;

                XsS += dX;
                YsS += dY;

                for (int i = 0; i < StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
    }

    public class dvWalecPochiliony : dvWalec
    {
        private Point[] WielokatPodlogi;
        private Point[] WielokatSufitu;

        int XsS, YsS;

        int StopieNwielokataPodstawy;
        float OsDuza, OsMala;

        float KatMiedzyWiercholkami;
        float KatPolozenia;

        //objętosc
        public override float GetVolume()
        {
            return (float)Math.PI * (float)this.WysokoscBryly * (float)(OsDuza / 2) * (float)(OsDuza / 2);
        }

        //pole
        public override float GetArea()
        {
            return (float)(2 * Math.PI * WysokoscBryly * Radius + 2 * Math.PI * Radius * Radius);
        }

        public dvWalecPochiliony(int R, int WysokoscWalca, int StopieNwielokataPodstawy, int XsP, int YsP, float KatPochileniaWalca, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) :
            base(R, WysokoscWalca, StopieNwielokataPodstawy, XsP, YsP, KatPochileniaWalca, KolorLinii, StylLinii, GruboscLinii)
        {
            RodzajBryly = TypyBryl.dvWalec;
            WysokoscBryly = WysokoscWalca;
            this.StopieNwielokataPodstawy = StopieNwielokataPodstawy;
            OsDuza = Promien * 2;
            OsMala = Promien / 2;

            this.XsP = XsP + (int)(WysokoscWalca / Math.Tan(Math.PI * KatPochileniaWalca / 180));
            this.YsP = YsP;

                XsS = XsP;


            YsS = YsP - WysokoscWalca;

            KatMiedzyWiercholkami = 360 / StopieNwielokataPodstawy;
            KatPolozenia = 0;

            WielokatPodlogi = new Point[StopieNwielokataPodstawy + 1];
            WielokatSufitu = new Point[StopieNwielokataPodstawy + 1];

            for (int i = 0; i <= StopieNwielokataPodstawy; i++)
            {
                WielokatPodlogi[i] = new Point();
                WielokatSufitu[i] = new Point();

                WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
            }
        }

        public override void dvDraw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(KolorLinii, GruboscLinii))
            {
                pen.DashStyle = StylLinii;

                Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                Rysownica.DrawEllipse(pen, XsS - OsDuza / 2, YsS - OsMala / 2, OsDuza, OsMala);

                using (Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                {
                    LinePen.DashStyle = StylLinii;
                    for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                    {
                        Rysownica.DrawLine(LinePen, WielokatPodlogi[i], WielokatSufitu[i]);
                    }
                }

                Rysownica.DrawLine(pen, XsP - OsDuza / 2, YsP, XsS - OsDuza / 2, YsS);
                Rysownica.DrawLine(pen, XsP + OsDuza / 2, YsP, XsS + OsDuza / 2, YsS);

                Widoczny = true;
            }
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            if (Widoczny)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                    Rysownica.DrawEllipse(pen, XsS - OsDuza / 2, YsS - OsMala / 2, OsDuza, OsMala);

                    using (Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                    {
                        LinePen.DashStyle = StylLinii;
                        for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(LinePen, WielokatPodlogi[i], WielokatSufitu[i]);
                        }
                    }

                    Rysownica.DrawLine(pen, XsP - OsDuza / 2, YsP, XsS - OsDuza / 2, YsS);
                    Rysownica.DrawLine(pen, XsP + OsDuza / 2, YsP, XsS + OsDuza / 2, YsS);

                    Widoczny = false;
                }
            }

        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            if (Widoczny)
            {
                dvErase(Kontrolka, Rysownica);


                if (KirunekObrotu)
                {
                    KatPolozenia -= KatObrotu;
                }
                else
                {
                    KatPolozenia += KatObrotu;
                }

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int X, int Y)
        {
            if (Widoczny)
            {
                int dX, dY;

                dvErase(Kontrolka, Rysownica);

                dX = XsP > X ? X - XsP : -(XsP - X);
                dY = YsP > Y ? Y - YsP : -(YsP - Y);

                XsP += dX;
                YsP += dY;

                XsS += dX;
                YsS += dY;

                for (int i = 0; i < StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
    }

    public class dvStozek : dvBrylyObrotowe
    {
        private Point[] WielokatPodlogi;

        int XsS, YsS;

        int StopieNwielokataPodstawy;
        float OsDuza, OsMala;

        float KatMiedzyWiercholkami;
        float KatPolozenia;

        //objętosc
        public override float GetVolume()
        {
            return (float)(1 / 3 * Math.PI * Radius * Radius * Height);
        }

        //pole
        public override float GetArea()
        {
            float L = (float)Math.Sqrt(Radius * Radius + Height * Height);
            return (float)(Math.PI * Radius * L + Math.PI * Radius * Radius);
        }

        public dvStozek(int R, int WysokoscWlaca, int StopieNwielokataPodstawy, int XsP, int YsP, float KatPochileniaWalca, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) :
            base(R, KolorLinii, StylLinii, GruboscLinii)
        {
            RodzajBryly = TypyBryl.dvStozek;
            WysokoscBryly = WysokoscWlaca;
            this.StopieNwielokataPodstawy = StopieNwielokataPodstawy;
            OsDuza = Promien * 2;
            OsMala = Promien / 2;

            this.XsP = XsP;
            this.YsP = YsP;

            if (KatPochileniaWalca == KatProsty)
                XsS = XsP;

            YsS = YsP - WysokoscWlaca;

            KatMiedzyWiercholkami = 360 / StopieNwielokataPodstawy;
            KatPolozenia = 0;

            WielokatPodlogi = new Point[StopieNwielokataPodstawy + 1];

            for (int i = 0; i <= StopieNwielokataPodstawy; i++)
            {
                WielokatPodlogi[i] = new Point();

                WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
            }
        }

        public override void dvDraw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(KolorLinii, GruboscLinii))
            {
                pen.DashStyle = StylLinii;

                Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);

                using (Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                {
                    LinePen.DashStyle = StylLinii;
                    for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                    {
                        Rysownica.DrawLine(LinePen, WielokatPodlogi[i], new Point(XsS, YsS));
                    }
                }

                Rysownica.DrawLine(pen, XsP - OsDuza / 2, YsP, XsS, YsS);
                Rysownica.DrawLine(pen, XsP + OsDuza / 2, YsP, XsS, YsS);

                Widoczny = true;
            }
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            if (Widoczny)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);

                    using (Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                    {
                        LinePen.DashStyle = StylLinii;
                        for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(LinePen, WielokatPodlogi[i], new Point(XsS, YsS));
                        }
                    }
                    Rysownica.DrawLine(pen, XsP - OsDuza / 2, YsP, XsS, YsS);
                    Rysownica.DrawLine(pen, XsP + OsDuza / 2, YsP, XsS, YsS);

                    Widoczny = false;
                }
            }

        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            if (Widoczny)
            {
                dvErase(Kontrolka, Rysownica);


                if (KirunekObrotu)
                {
                    KatPolozenia -= KatObrotu;
                }
                else
                {
                    KatPolozenia += KatObrotu;
                }

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int X, int Y)
        {
            if (Widoczny)
            {
                int dX, dY;

                dvErase(Kontrolka, Rysownica);

                dX = XsP > X ? X - XsP : -(XsP - X);
                dY = YsP > Y ? Y - YsP : -(YsP - Y);

                XsP += dX;
                YsP += dY;

                XsS += dX;
                YsS += dY;

                for (int i = 0; i < StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
    }

    public class dvStozekPochiliony : dvStozek
    {
        private Point[] WielokatPodlogi;

        int XsS, YsS;

        int StopieNwielokataPodstawy;
        float OsDuza, OsMala;

        float KatMiedzyWiercholkami;
        float KatPolozenia;

        public dvStozekPochiliony(int R, int WysokoscStozka, int StopieNwielokataPodstawy, int XsP, int YsP, float KatPochilenia, float KatPochileniaWalca, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) :
            base(R, WysokoscStozka, StopieNwielokataPodstawy, XsP, YsP, KatPochilenia, KolorLinii, StylLinii, GruboscLinii)
        {
            RodzajBryly = TypyBryl.dvStozekPochiliony;
            this.StopieNwielokataPodstawy = StopieNwielokataPodstawy;
            OsDuza = Promien * 2;
            OsMala = Promien / 2;

            this.XsP = XsP + (int)(WysokoscStozka / Math.Tan(Math.PI * KatPochilenia / 180  ));
            this.YsP = YsP;

            if (KatPochileniaWalca == KatProsty)
                XsS = XsP;

            YsS = YsP - WysokoscStozka;

            KatMiedzyWiercholkami = 360 / StopieNwielokataPodstawy;
            KatPolozenia = 0;

            WielokatPodlogi = new Point[StopieNwielokataPodstawy + 1];

            for (int i = 0; i <= StopieNwielokataPodstawy; i++)
            {
                WielokatPodlogi[i] = new Point();

                WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
            }
        }

        public override void dvDraw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(KolorLinii, GruboscLinii))
            {
                pen.DashStyle = StylLinii;

                Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);

                using (Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                {
                    LinePen.DashStyle = StylLinii;
                    for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                    {

                        Rysownica.DrawLine(LinePen, WielokatPodlogi[i], new Point(XsS, YsS));
                    }
                }

                Rysownica.DrawLine(pen, XsP - OsDuza / 2, YsP, XsS, YsS);
                Rysownica.DrawLine(pen, XsP + OsDuza / 2, YsP, XsS, YsS);

                Widoczny = true;
            }
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            if (Widoczny)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);

                    using (Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                    {
                        LinePen.DashStyle = StylLinii;
                        for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(LinePen, WielokatPodlogi[i], new Point(XsS, YsS));
                        }
                    }
                    Rysownica.DrawLine(pen, XsP - OsDuza / 2, YsP, XsS, YsS);
                    Rysownica.DrawLine(pen, XsP + OsDuza / 2, YsP, XsS, YsS);

                    Widoczny = false;
                }
            }

        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            if (Widoczny)
            {
                dvErase(Kontrolka, Rysownica);


                if (KirunekObrotu)
                {
                    KatPolozenia -= KatObrotu;
                }
                else
                {
                    KatPolozenia += KatObrotu;
                }

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int X, int Y)
        {
            if (Widoczny)
            {
                int dX, dY;

                dvErase(Kontrolka, Rysownica);

                dX = XsP > X ? X - XsP : -(XsP - X);
                dY = YsP > Y ? Y - YsP : -(YsP - Y);

                XsP += dX;
                YsP += dY;

                XsS += dX;
                YsS += dY;

                for (int i = 0; i < StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
    }

    public class dvKula : dvBrylyObrotowe
    {
        private Point[] WielokatPodlogi;
        private Point[] WielokatUp;
        private Point[] WielokatLow;
        private int R2;
        private float OsDuza2, OsMala2;
        private int XsS1, YsS1;
        private int XsS2, YsS2;

        protected int StopieNwielokataPodstawy;
        protected float OsDuza, OsMala;

        protected float KatMiedzyWiercholkami;
        protected float KatPolozenia;

        //objętosc
        public override float GetVolume()
        {
            return (float)((4 * Math.PI * Promien * Promien * Promien) / 3);
        }

        //pole
        public override float GetArea()
        {
            return (float)(4 * Math.PI * Promien * Promien);
        }

        public dvKula(int R, int StopieNwielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) :
            base(R, KolorLinii, StylLinii, GruboscLinii)
        {
            this.KolorLinii = KolorLinii;
            this.StylLinii = StylLinii;
            this.GruboscLinii = GruboscLinii;
            RodzajBryly = TypyBryl.dvKula;
            this.StopieNwielokataPodstawy = StopieNwielokataPodstawy;
            this.R2 = R  * 3 / 5;
            OsDuza2 = R2 * 2;
            OsMala2 = R2 / 2;

            OsDuza = Promien * 2;
            OsMala = Promien / 2;

            this.XsP = XsP;
            this.YsP = YsP;
            this.XsS1 = XsP;
            this.YsS1 = YsP - R / 4 * 3;
            this.XsS2 = XsP;
            this.YsS2 = YsP + R / 4 * 3;

            KatMiedzyWiercholkami = 360 / StopieNwielokataPodstawy;
            KatPolozenia = 0;

            WielokatPodlogi = new Point[StopieNwielokataPodstawy + 1];
            WielokatUp = new Point[StopieNwielokataPodstawy + 1];
            WielokatLow = new Point[StopieNwielokataPodstawy + 1];

            for (int i = 0; i <= StopieNwielokataPodstawy; i++)
            {
                WielokatPodlogi[i] = new Point();
                WielokatUp[i] = new Point();
                WielokatLow[i] = new Point();

                WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));


                WielokatUp[i].X = (int)(XsS1 + OsDuza2 / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatUp[i].Y = (int)(YsS1 + OsMala2 / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));


                WielokatLow[i].X = (int)(XsS2 + OsDuza2 / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatLow[i].Y = (int)(YsS2 + OsMala2 / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
            }
        }

        public override void dvDraw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(KolorLinii, GruboscLinii))
            {
                pen.DashStyle = StylLinii;

                Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsDuza / 2, OsDuza, OsDuza);
                Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);

                using (Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                {
                    LinePen.DashStyle = StylLinii;

                    for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                    {
                        Point[] linePoints = new Point[5] { new Point(XsP, YsP + Promien), WielokatLow[i], WielokatPodlogi[i], WielokatUp[i], new Point(XsP, YsP - Promien)};
                        //Point[] linePoints = new Point[3] { new Point(XsP, YsP + Promien), WielokatPodlogi[i], new Point(XsP, YsP - Promien)};
                            Rysownica.DrawCurve(LinePen, linePoints, 0.6F);
                    }
                }

                Widoczny = true;
            }
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            if (Widoczny)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsDuza / 2, OsDuza, OsDuza);
                    Rysownica.DrawEllipse(pen, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);

                    using (Pen LinePen = new Pen(pen.Color, pen.Width / 3))
                    {
                        LinePen.DashStyle = StylLinii;
                        for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                        {
                            Point[] linePoints = new Point[5] { new Point(XsP, YsP + Promien), WielokatLow[i], WielokatPodlogi[i], WielokatUp[i], new Point(XsP, YsP - Promien) };
                            //Point[] linePoints = new Point[3] { new Point(XsP, YsP + Promien), WielokatPodlogi[i], new Point(XsP, YsP - Promien) };
                            Rysownica.DrawCurve(LinePen, linePoints, 0.6F);
                        }

                    }

                    Widoczny = false;
                }
            }
        }

        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            if (Widoczny)
            {
                dvErase(Kontrolka, Rysownica);


                if (KirunekObrotu)
                {
                    KatPolozenia -= KatObrotu;
                }
                else
                {
                    KatPolozenia += KatObrotu;
                }

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));


                    WielokatUp[i].X = (int)(XsS1 + OsDuza2 / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatUp[i].Y = (int)(YsS1 + OsMala2 / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));


                    WielokatLow[i].X = (int)(XsS2 + OsDuza2 / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatLow[i].Y = (int)(YsS2 + OsMala2 / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }

        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int X, int Y)
        {
            if (Widoczny)
            {
                int dX, dY;

                dvErase(Kontrolka, Rysownica);

                dX = XsP > X ? X - XsP : -(XsP - X);
                dY = YsP > Y ? Y - YsP : -(YsP - Y);

                XsP += dX;
                YsP += dY;

                for (int i = 0; i < StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));


                    WielokatUp[i].X = (int)(XsS1 + OsDuza2 / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatUp[i].Y = (int)(YsS1 + OsMala2 / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));


                    WielokatLow[i].X = (int)(XsS2 + OsDuza2 / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatLow[i].Y = (int)(YsS2 + OsMala2 / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
    }

    public class dvGraniastoslup : dvWielosciany
    {
        protected float OsDuza, OsMala;
        protected float KatMiedzyWiercholkami;
        protected float KatPolozenia;

        //objetosc
        public override float GetVolume()
        {
            return (float)(((Promien * Promien * StopieNwielokataPodstawy * Math.Sin(Math.PI / StopieNwielokataPodstawy)) / 2) * WysokoscBryly);
        }

        //pole
        public override float GetArea()
        {
            return (float)((Promien * Promien * StopieNwielokataPodstawy * Math.Sin(Math.PI / StopieNwielokataPodstawy)) + StopieNwielokataPodstawy * (2 * Promien * Math.Sin(Math.PI / StopieNwielokataPodstawy)));
        }

        public dvGraniastoslup(int R, int WysokoscGraniastoslupa, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) :
            base(R, StopienWielokataPodstawy, KolorLinii, StylLinii, GruboscLinii)
        {
            RodzajBryly = TypyBryl.dvGraniastoslup;
            Widoczny = false;
            KirunekObrotu = false;
            this.StopieNwielokataPodstawy = StopienWielokataPodstawy;

            this.XsP = XsP;
            this.YsP = YsP;

            XsS = XsP;
            YsS = YsP - WysokoscGraniastoslupa;

            OsDuza = 2 * R;
            OsMala = R / 2;

            KatMiedzyWiercholkami = 360 / StopienWielokataPodstawy;
            KatPochilenia = 0;

            WielokatPodlogi = new Point[StopienWielokataPodstawy + 1];
            WielokatSufitu = new Point[StopienWielokataPodstawy + 1];

            for (int i = 0; i <= StopieNwielokataPodstawy; i++)
            {
                WielokatPodlogi[i] = new Point();
                WielokatSufitu[i] = new Point();

                WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
            }
        }

        public override void dvDraw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(KolorLinii, GruboscLinii))
            {
                pen.DashStyle = StylLinii;

                Rysownica.DrawPolygon(pen, WielokatPodlogi);
                Rysownica.DrawPolygon(pen, WielokatSufitu);


                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    Rysownica.DrawLine(pen, WielokatPodlogi[i], WielokatSufitu[i]);
                }                               
                

                Widoczny = true;
            }
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            if (Widoczny)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawPolygon(pen, WielokatPodlogi);
                    Rysownica.DrawPolygon(pen, WielokatSufitu);


                    for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                    {
                        Rysownica.DrawLine(pen, WielokatPodlogi[i], WielokatSufitu[i]);
                    }


                    Widoczny = false;
                }
            }
        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            if (Widoczny)
            {
                dvErase(Kontrolka, Rysownica);


                if (KirunekObrotu)
                {
                    KatPolozenia -= KatObrotu;
                }
                else
                {
                    KatPolozenia += KatObrotu;
                }

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int X, int Y)
        {
            if (Widoczny)
            {
                int dX, dY;

                dvErase(Kontrolka, Rysownica);

                dX = XsP > X ? X - XsP : -(XsP - X);
                dY = YsP > Y ? Y - YsP : -(YsP - Y);

                XsP += dX;
                YsP += dY;

                XsS += dX;
                YsS += dY;

                for (int i = 0; i < StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
    }

    public class dvOstroslup : dvWielosciany
    {
        protected int OsDuza, OsMala;
        protected float KatMiedzyWiercholkami;
        protected float KatPolozenia;

        public  override float GetVolume()
        {
            return (float)(((Promien * Promien * StopieNwielokataPodstawy * Math.Sin(Math.PI / StopieNwielokataPodstawy)) / 6) * WysokoscBryly);
        }

        //pole
        public override float GetArea()
        {
            return (float)((Promien * Promien * StopieNwielokataPodstawy * Math.Sin(Math.PI / StopieNwielokataPodstawy)) + StopieNwielokataPodstawy * (2 * Promien * Math.Sin(Math.PI / StopieNwielokataPodstawy))) / 2;
        }

        public dvOstroslup(int R, int WysokoscOstoslupa, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) :
            base(R, StopienWielokataPodstawy, KolorLinii, StylLinii, GruboscLinii)
        {
            RodzajBryly = TypyBryl.dvOstroslup;
            Widoczny = false;
            KirunekObrotu = false;
            this.StopieNwielokataPodstawy = StopienWielokataPodstawy;
            WysokoscBryly = WysokoscOstoslupa;

            this.XsP = XsP;
            this.YsP = YsP;

            XsS = XsP;
            YsS = YsP - WysokoscOstoslupa;

            OsDuza = 2 * R;
            OsMala = R / 2;

            KatMiedzyWiercholkami = 360 / StopienWielokataPodstawy;
            KatPochilenia = 0;

            WielokatPodlogi = new Point[StopienWielokataPodstawy + 1];
            

            for (int i = 0; i <= StopieNwielokataPodstawy; i++)
            {
                WielokatPodlogi[i] = new Point();
            
                WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
            }
        }

        public override void dvDraw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(KolorLinii, GruboscLinii))
            {
                pen.DashStyle = StylLinii;

                Rysownica.DrawPolygon(pen, WielokatPodlogi);

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    Rysownica.DrawLine(pen, WielokatPodlogi[i], new Point(XsS, YsS));
                }


                Widoczny = true;
            }
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            if (Widoczny)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawPolygon(pen, WielokatPodlogi);

                    for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                    {
                        Rysownica.DrawLine(pen, WielokatPodlogi[i], new Point(XsS, YsS));
                    }


                    Widoczny = false;
                }
            }
        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            if (Widoczny)
            {
                dvErase(Kontrolka, Rysownica);


                if (KirunekObrotu)
                {
                    KatPolozenia -= KatObrotu;
                }
                else
                {
                    KatPolozenia += KatObrotu;
                }

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int X, int Y)
        {
            if (Widoczny)
            {
                int dX, dY;

                dvErase(Kontrolka, Rysownica);

                dX = XsP > X ? X - XsP : -(XsP - X);
                dY = YsP > Y ? Y - YsP : -(YsP - Y);

                XsP += dX;
                YsP += dY;

                XsS += dX;
                YsS += dY;

                for (int i = 0; i < StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
    }

    public class dvOStroslupyOWspolnejPodstawie : dvOstroslup
    {
        protected int XsS2, YsS2;
        public override float GetVolume()
        {
            return (float)(((Promien * Promien * StopieNwielokataPodstawy * Math.Sin(Math.PI / StopieNwielokataPodstawy)) / 3) * WysokoscBryly);
        }

        //pole
        public override float GetArea()
        {
            return (float)(StopieNwielokataPodstawy * (2 * Promien * Math.Sin(Math.PI / StopieNwielokataPodstawy)));
        }

        public dvOStroslupyOWspolnejPodstawie(int R, int WysokoscOstoslupa, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) :
            base(R, WysokoscOstoslupa, StopienWielokataPodstawy, XsP, YsP, KolorLinii, StylLinii, GruboscLinii)
        {
            RodzajBryly = TypyBryl.dvOstroslupyOWspolnejPodstawie;
            Widoczny = false;
            KirunekObrotu = false;
            this.StopieNwielokataPodstawy = StopienWielokataPodstawy;
            WysokoscBryly = WysokoscOstoslupa * 2;

            this.XsP = XsP;
            this.YsP = YsP;
            this.XsS2 = XsP;
            this.YsS2 = YsP + WysokoscOstoslupa;
            XsS = XsP;
            YsS = YsP - WysokoscOstoslupa;

            OsDuza = 2 * R;
            OsMala = R / 2;

            KatMiedzyWiercholkami = 360 / StopienWielokataPodstawy;
            KatPochilenia = 0;

            WielokatPodlogi = new Point[StopienWielokataPodstawy + 1];


            for (int i = 0; i <= StopieNwielokataPodstawy; i++)
            {
                WielokatPodlogi[i] = new Point();

                WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
            }
        }

        public override void dvDraw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(KolorLinii, GruboscLinii))
            {
                pen.DashStyle = StylLinii;

                Rysownica.DrawPolygon(pen, WielokatPodlogi);

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    Rysownica.DrawLine(pen, WielokatPodlogi[i], new Point(XsS, YsS));
                    Rysownica.DrawLine(pen, WielokatPodlogi[i], new Point(XsS2, YsS2));
                }


                Widoczny = true;
            }
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            if (Widoczny)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawPolygon(pen, WielokatPodlogi);

                    for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                    {
                        Rysownica.DrawLine(pen, WielokatPodlogi[i], new Point(XsS, YsS));
                        Rysownica.DrawLine(pen, WielokatPodlogi[i], new Point(XsS2, YsS2));
                    }


                    Widoczny = false;
                }
            }
        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            if (Widoczny)
            {
                dvErase(Kontrolka, Rysownica);


                if (KirunekObrotu)
                {
                    KatPolozenia -= KatObrotu;
                }
                else
                {
                    KatPolozenia += KatObrotu;
                }

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int X, int Y)
        {
            if (Widoczny)
            {
                int dX, dY;

                dvErase(Kontrolka, Rysownica);

                dX = XsP > X ? X - XsP : -(XsP - X);
                dY = YsP > Y ? Y - YsP : -(YsP - Y);

                XsP += dX;
                YsP += dY;

                XsS += dX;
                YsS += dY;

                for (int i = 0; i < StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
    }
    
    public class dvOStroslupSciety : dvOstroslup
    {
        protected int R2;
        protected int OsDuza2, OsMala2;

        public override float GetVolume()
        {
            return (float)(((Promien * Promien * StopieNwielokataPodstawy * Math.Sin(Math.PI / StopieNwielokataPodstawy)) / 6) * WysokoscBryly);
        }

        //pole
        public override float GetArea()
        {
            return (float)((Promien * Promien * StopieNwielokataPodstawy * Math.Sin(Math.PI / StopieNwielokataPodstawy)) + StopieNwielokataPodstawy * (2 * Promien * Math.Sin(Math.PI / StopieNwielokataPodstawy))) / 2;
        }

        public dvOStroslupSciety(int R, int WysokoscOstoslupa, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, int GruboscLinii) :
            base(R, WysokoscOstoslupa, StopienWielokataPodstawy, XsP, YsP, KolorLinii, StylLinii, GruboscLinii)
        {
            RodzajBryly = TypyBryl.dvOstroslup;
            Widoczny = false;
            KirunekObrotu = false;
            this.StopieNwielokataPodstawy = StopienWielokataPodstawy;
            WysokoscBryly = WysokoscOstoslupa;
            this.R2 = R / 2;

            this.XsP = XsP;
            this.YsP = YsP;

            XsS = XsP;
            YsS = YsP - WysokoscOstoslupa;

            OsDuza = 2 * R;
            OsMala = R / 2;
            OsDuza2 = 2 * R2;
            OsMala2 = R2 / 2;

            KatMiedzyWiercholkami = 360 / StopienWielokataPodstawy;
            KatPochilenia = 0;

            WielokatPodlogi = new Point[StopienWielokataPodstawy + 1];
            WielokatSufitu = new Point[StopienWielokataPodstawy + 1];


            for (int i = 0; i <= StopieNwielokataPodstawy; i++)
            {
                WielokatPodlogi[i] = new Point();
                WielokatSufitu[i] = new Point();

                WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));   
                
                WielokatSufitu[i].X = (int)(XsS + OsDuza2 / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                WielokatSufitu[i].Y = (int)(YsS + OsMala2/ 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
            }
        }

        public override void dvDraw(Graphics Rysownica)
        {
            using (Pen pen = new Pen(KolorLinii, GruboscLinii))
            {
                pen.DashStyle = StylLinii;

                Rysownica.DrawPolygon(pen, WielokatPodlogi);
                Rysownica.DrawPolygon(pen, WielokatSufitu);

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    Rysownica.DrawLine(pen, WielokatPodlogi[i], WielokatSufitu[i]);
                }


                Widoczny = true;
            }
        }
        public override void dvErase(Control Kontrolka, Graphics Rysownica)
        {
            if (Widoczny)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawPolygon(pen, WielokatPodlogi);
                    Rysownica.DrawPolygon(pen, WielokatSufitu);

                    for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                    {
                        Rysownica.DrawLine(pen, WielokatPodlogi[i], WielokatSufitu[i]);
                    }


                    Widoczny = false;
                }
            }
        }
        public override void dvTurnAndDraw(Control Kontrolka, Graphics Rysownica, float KatObrotu)
        {
            if (Widoczny)
            {
                dvErase(Kontrolka, Rysownica);


                if (KirunekObrotu)
                {
                    KatPolozenia -= KatObrotu;
                }
                else
                {
                    KatPolozenia += KatObrotu;
                }

                for (int i = 0; i <= StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza2 / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala2 / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
        public override void dvReplace(Control Kontrolka, Graphics Rysownica, int X, int Y)
        {
            if (Widoczny)
            {
                int dX, dY;

                dvErase(Kontrolka, Rysownica);

                dX = XsP > X ? X - XsP : -(XsP - X);
                dY = YsP > Y ? Y - YsP : -(YsP - Y);

                XsP += dX;
                YsP += dY;

                XsS += dX;
                YsS += dY;

                for (int i = 0; i < StopieNwielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza2 / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala2 / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWiercholkami) / 180));
                }

                dvDraw(Rysownica);
            }
        }
    }

}
