using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspuffiGrauso
{
    struct Punto
    {
        public int X, Y, XGargamella, YGargamella;
        public Punto(int x, int y, int xgargamella, int ygargamella)
        {
            this.XGargamella = xgargamella;
            this.YGargamella = ygargamella;
            this.X = x;
            this.Y = y;
        }
    };

    public partial class Form1 : Form
    {
        Panel[] alberi;
        PictureBox pictureBox1 = new PictureBox();
        
        int contamosse;
        Random rnd = new Random();
        int punteggiop = 0;
        int punteggiog = 0;
        int velocita = 10;
        bool b;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown; // per far funzionare i tasti wasd
            contamosse = 0;
            b = true;
            alberi = new Panel[6] { pnl_albero, pnl_albero2, pnl_albero3, pnl_albero4, pnl_albero5, pnl_albero6 };
            pictureBox1.Image = System.Drawing.Bitmap.FromFile("C:\\Users\\graus\\Desktop||puffo.jpg");
            pictureBox1.Dock = DockStyle.Fill; //Riempe il pannello
            pnl_puffo.Controls.Add(pictureBox1);
        }
        private void txt_X_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_punteggio.Visible = false;
            lbl_puntogarg.Visible = false;
            btn_mostra.Visible = true;
            pnl_area.Visible = false;
        }
        private void btn_mostra_Click(object sender, EventArgs e)
        {
            lbl_punteggio.Visible = true;
            lbl_puntogarg.Visible = true;
            pnl_area.Visible = true;


            Punto posizione = new Punto(5, 5, 300, 300);
            pnl_gargamella.Left = posizione.XGargamella;
            pnl_gargamella.Top = posizione.YGargamella;
            pnl_puffo.Left = posizione.X;
            pnl_puffo.Top = posizione.Y;

            SpostaCasetta();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int nuovaX, nuovaY;
            if (b)
            {
                nuovaX = pnl_puffo.Left;
                nuovaY = pnl_puffo.Top;
            }
            else
            {
                nuovaX = pnl_gargamella.Left;
                nuovaY = pnl_gargamella.Top;
            }
            if (e.KeyCode == Keys.A)
                nuovaX -= velocita;
            if (e.KeyCode == Keys.D)
                nuovaX += velocita;
            if (e.KeyCode == Keys.W)
                nuovaY -= velocita;
            if (e.KeyCode == Keys.S)
                nuovaY += velocita;
            if (b)
            {
                if (nuovaX >= 0 && nuovaX + pnl_puffo.Width <= pnl_area.Width)
                    pnl_puffo.Left = nuovaX;

                if (nuovaY >= 0 && nuovaY + pnl_puffo.Height <= pnl_area.Height)
                    pnl_puffo.Top = nuovaY;
            }
            else
            {
                if (nuovaX >= 0 && nuovaX + pnl_gargamella.Width <= pnl_area.Width)
                    pnl_gargamella.Left = nuovaX;

                if (nuovaY >= 0 && nuovaY + pnl_gargamella.Height <= pnl_area.Height)
                    pnl_gargamella.Top = nuovaY;
            }
            ControllaToccoPGarg();
            ControllaCollisione();
            contamosse++;
            ControllaToccoAlbero();

            if (contamosse >= 10)
            {
                contamosse = 0;
                b = !b;
            }
        }
        private void ControllaCollisione()
        {
            if (b)
            {
                if (pnl_puffo.Bounds.IntersectsWith(pnl_casetta.Bounds))
                {
                    punteggiop++;
                    lbl_punteggio.Text = "Punteggio del puffo: " + punteggiop;
                    SpostaCasetta();

                }
            }
            else
            {
                if (pnl_gargamella.Bounds.IntersectsWith(pnl_casetta.Bounds))
                {
                    punteggiog++;
                    lbl_puntogarg.Text = "Punteggio di Garagamella: " + punteggiog;
                    SpostaCasetta();
                }
            }
        }
        private void ControllaToccoPGarg()
        {
            if (pnl_gargamella.Bounds.IntersectsWith(pnl_puffo.Bounds))
            {
                punteggiog++;
                if (punteggiop > 0)
                    punteggiop--;
                int maxX1 = pnl_area.Width - pnl_puffo.Width;
                int maxY1 = pnl_area.Height - pnl_puffo.Height;
                pnl_puffo.Left = rnd.Next(0, maxX1);
                pnl_puffo.Top = rnd.Next(0, maxY1);
                lbl_puntogarg.Text = "Punteggio di Garagamella: " + punteggiog;
                lbl_punteggio.Text = "Punteggio del puffo: " + punteggiop;
            }
        }
        private void ControllaToccoAlbero()
        {
            for (int i = 0; i < alberi.Length; i++)
            {
                if (b)
                {
                    if (alberi[i].Bounds.IntersectsWith(pnl_puffo.Bounds))
                        contamosse = 10;
                }

                else if (alberi[i].Bounds.IntersectsWith(pnl_gargamella.Bounds))
                    contamosse = 10;
            }
        }
        
        private void btn_avvia_Click(object sender, EventArgs e)
        {
        }
        private void SpostaCasetta()
        {
            int maxX = pnl_area.Width - pnl_casetta.Width; //posizione max fino a dove può arrivare la casetta
            int maxY = pnl_area.Height - pnl_casetta.Height;
            pnl_casetta.Left = rnd.Next(0, maxX);
            pnl_casetta.Top = rnd.Next(0, maxY);
            for (int i = 0; i < alberi.Length; i++)
            {
                int max2x = pnl_area.Width - pnl_albero.Width;
                int max2y = pnl_area.Height - pnl_albero.Height;
                alberi[i].Left = rnd.Next(0, max2x);
                alberi[i].Top = rnd.Next(0, max2y);
            }
        }
    }
}