using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Project3_Adilbek.Khiiasov58981
{
    public partial class Project3 : Form
    {
        Graphics Rysownica;

        Point point = new Point(-1, -1);

        Pen pen;

        SolidBrush brush;

        List<dvBrylaAbstrakcyjna> LBG = new List<dvBrylaAbstrakcyjna>();

        private int indexLBG;

        public Project3()
        {
            InitializeComponent();

            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);

            Rysownica = Graphics.FromImage(pbRysownica.Image);
            
            point = Point.Empty;

            pen = new Pen(Color.Black, 1F);

            pen.DashStyle = DashStyle.Solid;

            pen.StartCap = LineCap.Round;

            brush = new SolidBrush(Color.Blue);
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "mainForm")
                {
                    Hide();
                    form.Show();
                    return;
                }
            }

            mainForm mainForm = new mainForm();
            mainForm.Show();
            Hide();
        }

        private void Project3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewFigure_Click(object sender, EventArgs e)
        {
            int FigureHeight = tbFigureHeight.Value;
            int Radius = tbFigureRadius.Value;
            int PolygonDegree = (int)nudPolygonDegree.Value;

            int XsP = point.X;
            int YsP = point.Y;

            switch (cbFigureType.SelectedItem)
            {
                case "Walec":
                    dvWalec Walec = new dvWalec(Radius, FigureHeight, PolygonDegree, XsP, YsP, 90, Color.Red, DashStyle.Solid, 3);
                    Walec.dvDraw(Rysownica);
                    LBG.Add(Walec);
                    break;

                case "Stożek":
                    dvStozek Stozek = new dvStozek(Radius, FigureHeight, PolygonDegree, XsP, YsP, 90, Color.Red, DashStyle.Solid, 3);
                    Stozek.dvDraw(Rysownica);
                    LBG.Add(Stozek);
                    break;

                case "Stożek pochiliony":
                    dvStozekPochiliony StozekPochiliony = new dvStozekPochiliony(Radius, FigureHeight, PolygonDegree, XsP, YsP, (float)nudSlopeAngle.Value, 90, Color.Red, DashStyle.Solid, 3);
                    StozekPochiliony.dvDraw(Rysownica);
                    LBG.Add(StozekPochiliony);
                    break;

                case "Kula":
                    dvKula Kula = new dvKula(Radius, PolygonDegree, XsP, YsP, Color.Red, DashStyle.Solid, 3);
                    Kula.dvDraw(Rysownica);
                    LBG.Add(Kula);
                    break;
                case "Graniastoslup":
                    dvGraniastoslup Graniastoslup = new dvGraniastoslup(Radius, FigureHeight, PolygonDegree, XsP, YsP, Color.Red, DashStyle.Solid, 3);
                    Graniastoslup.dvDraw(Rysownica);
                    LBG.Add(Graniastoslup);
                    break;
                case "Ostoslup":
                    dvOstroslup Ostoslup = new dvOstroslup(Radius, FigureHeight, PolygonDegree, XsP, YsP, Color.Red, DashStyle.Solid, 3);
                    Ostoslup.dvDraw(Rysownica);
                    LBG.Add(Ostoslup);
                    break;
                case "Dwa ostroslupy o wspolnej podstawie":
                    dvOStroslupyOWspolnejPodstawie OStroslupyOWspolnejPodstawie = new dvOStroslupyOWspolnejPodstawie(Radius, FigureHeight, PolygonDegree, XsP, YsP, Color.Red, DashStyle.Solid, 3);
                    OStroslupyOWspolnejPodstawie.dvDraw(Rysownica);
                    LBG.Add(OStroslupyOWspolnejPodstawie);
                    break;
                case "Walec Pochiliony":
                    dvWalecPochiliony WalecPochiliony = new dvWalecPochiliony(Radius, FigureHeight, PolygonDegree, XsP, YsP, (float)nudSlopeAngle.Value, Color.Red, DashStyle.Solid, 3);
                    WalecPochiliony.dvDraw(Rysownica);
                    LBG.Add(WalecPochiliony);
                    break;
                case "Ostroslup sciety":
                    dvOStroslupSciety OStroslupSciety = new dvOStroslupSciety(Radius, FigureHeight, PolygonDegree, XsP, YsP, Color.Red, DashStyle.Solid, 3);
                    OStroslupSciety.dvDraw(Rysownica);
                    LBG.Add(OStroslupSciety);
                    break;

            }

            pbRysownica.Refresh();
        }

        private void turnTimer_Tick(object sender, EventArgs e)
        {
            const float KatObrotu = 5;
            for (int i = 0; i < LBG.Count; i++)
            {
                LBG[i].dvTurnAndDraw(pbRysownica, Rysownica, KatObrotu);
            }
            pbRysownica.Refresh();
            Refresh();
        }

        private void Project3_Resize(object sender, EventArgs e)
        {
            //metoda dla zmienienia mapy bitowy przy zmienieniu parametru WindowState (czyli przechodzenie do fullScreen)
            if (this.WindowState != FormWindowState.Minimized)
            {
                //utworzenie mapy bitowej
                pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
                //utworzenie ekzemplarza powierchni graficznej
                Rysownica = Graphics.FromImage(pbRysownica.Image);
                //ponownie wykresliamy figury dla nowej Bitmap

                foreach (dvBrylaAbstrakcyjna figure in LBG)
                {
                    figure.dvDraw(Rysownica);
                }
                pbRysownica.Refresh();
            }
        }

        private void btnDeleteFirst_Click(object sender, EventArgs e)
        {
            if(LBG.Count != 0) 
            {
                LBG[0].dvErase(pbRysownica, Rysownica);
                LBG.Remove(LBG[0]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (LBG.Count != 0)
            {
                LBG[LBG.Count - 1].dvErase(pbRysownica, Rysownica);
                LBG.Remove(LBG[LBG.Count - 1]);
            }
        }

        private void btnDeleteChosenFigure_Click(object sender, EventArgs e)
        {
            if (LBG.Count != 0)
            {
                LBG[(int)nudNrOfFigureDelete.Value].dvErase(pbRysownica, Rysownica);
                LBG.Remove(LBG[(int)nudNrOfFigureDelete.Value]);
            }
        }

        private void nudNrOfFigureDelete_ValueChanged(object sender, EventArgs e)
        {
            if(nudNrOfFigureDelete.Value >= LBG.Count)
            {
                nudNrOfFigureDelete.Value = 0;
            }
        }

        private void pbRysownica_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pen.Color = pbRysownica.BackColor;
                pen.Width = 3;
                Rysownica.DrawEllipse(pen, new Rectangle(point.X, point.Y, 5, 5));

                point = e.Location;

                pen.Color = Color.Red;
                pen.Width = 3;
                Rysownica.DrawEllipse(pen, new Rectangle(e.Location.X, e.Location.Y, 5, 5));
               
            }
        }

        private void btnRandomLocation_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (dvBrylaAbstrakcyjna figure in LBG)
            {
                figure.dvReplace(pbRysownica, Rysownica, rnd.Next(150, pbRysownica.Width - 150), rnd.Next(150, pbRysownica.Height - 150));
            }
        }

        private void btnRandomAtributes_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            DashStyle[] styli = new DashStyle[5] { DashStyle.Solid, DashStyle.Dash, DashStyle.DashDot, DashStyle.Dot, DashStyle.DashDotDot };

            Rysownica.Clear(pbRysownica.BackColor);
            foreach (dvBrylaAbstrakcyjna figure in LBG)
            {
                figure.dvSetGraphicAttributes(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)), styli[rnd.Next(0, 5)], rnd.Next(3, 15));
            }
        }

        private void btnSlideON_Click(object sender, EventArgs e)
        {
            if (rbAuto.Checked)
            {
                indexLBG = 0;
                slideTimer.Enabled = true;
                groupBox4.Enabled = false;
                btnDeleteChosenFigure.Enabled = false;
                btnDeleteFirst.Enabled = false;
                button5.Enabled = false;
                for(int i = 0; i < LBG.Count; i++)
                {
                    LBG[i].dvErase(pbRysownica, Rysownica);
                }
            }
            else if (rbManual.Checked)
            {
                groupBox4.Enabled = false;
                btnDeleteChosenFigure.Enabled = false;
                btnDeleteFirst.Enabled = false;
                button5.Enabled = false;

                indexLBG = 0;
                for (int i = 0; i < LBG.Count; i++)
                {
                    LBG[i].dvErase(pbRysownica, Rysownica);
                }
                LBG[indexLBG].dvDraw(Rysownica);
                LBG[indexLBG].dvReplace(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
            }
            else
            {
                MessageBox.Show("Podaj tryb działania slajdera");
            }
        }

        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if(indexLBG != 0)
            {
                LBG[indexLBG - 1].dvErase(pbRysownica, Rysownica);
            }
            Rysownica.Clear(pbRysownica.BackColor);
            LBG[indexLBG].dvDraw(Rysownica);
            LBG[indexLBG].dvReplace(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
            indexLBG++;
            if (indexLBG == LBG.Count - 1)
            {
                slideTimer.Enabled = false;
                groupBox4.Enabled = true;
                btnDeleteChosenFigure.Enabled = true;
                btnDeleteFirst.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LBG[indexLBG].dvErase(pbRysownica, Rysownica);
            if (indexLBG == LBG.Count - 1)
            {
                indexLBG = 0;
            }
            else
            {
                indexLBG++;
            }

            nudNrOfFigureSlide.Value = indexLBG;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            LBG[indexLBG].dvErase(pbRysownica, Rysownica);
            if (indexLBG == 0)
            {
                indexLBG = LBG.Count - 1;
            }
            else
            {
                indexLBG--;
            }

            nudNrOfFigureSlide.Value = indexLBG;
        }

        private void nudNrOfFigureSlide_ValueChanged(object sender, EventArgs e)
        {
            LBG[indexLBG].dvDraw(Rysownica);
            LBG[indexLBG].dvReplace(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
        }

        private void rbPromien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPromien.Checked)
            {
                dvBrylaAbstrakcyjna temp;

                for(int i = 0; i < LBG.Count; i++)
                    for(int j = i + 1; j < LBG.Count; j++)
                    {
                        if(LBG[i].Radius > LBG[j].Radius) 
                        {
                            temp = LBG[i];
                            LBG[i] = LBG[j];
                            LBG[j] = temp;
                        }
                        
                    }
            }
        }

        private void rbWysokosc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWysokosc.Checked)
            {
                dvBrylaAbstrakcyjna temp;

                for (int i = 0; i < LBG.Count; i++)
                    for (int j = i + 1; j < LBG.Count; j++)
                    {
                        if (LBG[i].Height > LBG[j].Height)
                        {
                            temp = LBG[i];
                            LBG[i] = LBG[j];
                            LBG[j] = temp;
                        }

                    }
            }
        }

        private void rbPole_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPole.Checked)
            {
                dvBrylaAbstrakcyjna temp;

                for (int i = 0; i < LBG.Count; i++)
                    for (int j = i + 1; j < LBG.Count; j++)
                    {
                        if (LBG[i].GetArea() > LBG[j].GetArea())
                        {
                            temp = LBG[i];
                            LBG[i] = LBG[j];
                            LBG[j] = temp;
                        }
                    }
            }
        }

        private void rbObetosc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbObetosc.Checked)
            {
                dvBrylaAbstrakcyjna temp;

                for (int i = 0; i < LBG.Count; i++)
                    for (int j = i + 1; j < LBG.Count; j++)
                    {
                        if (LBG[i].GetVolume() > LBG[j].GetVolume())
                        {
                            temp = LBG[i];
                            LBG[i] = LBG[j];
                            LBG[j] = temp;
                        }
                    }
            }
        }

        private void btnSlideOFF_Click(object sender, EventArgs e)
        {
            slideTimer.Enabled = false;
            slideTimer.Enabled = false;
            groupBox4.Enabled = true;
            btnDeleteChosenFigure.Enabled = true;
            btnDeleteFirst.Enabled = true;
            button5.Enabled = true;
            nudNrOfFigureSlide.Value = 0;

            Random rnd = new Random();
            foreach (dvBrylaAbstrakcyjna figure in LBG)
            {
                figure.dvDraw(Rysownica);
                figure.dvReplace(pbRysownica, Rysownica, rnd.Next(150, pbRysownica.Width - 150), rnd.Next(150, pbRysownica.Height - 150));
            }
        }
    }
}
