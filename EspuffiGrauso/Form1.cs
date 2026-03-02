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
        public int X, Y;
        public Punto (int x, int y)
        {
            X = x;
            Y = y;
        }
    };
    public partial class Form1 : Form
    {
        int x, y;
        Random rnd = new Random();
        int punteggio = 0;
        int velocita = 10;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown; // per far funzionare i tasti wasd
        }
        private void txt_X_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load (object sender, EventArgs e)
        {
            lbl_punteggio.Visible = false;
            btn_mostra.Visible = true;
            pnl_nascosto.Visible = false;
            pnl_area.Visible = false;
        }
        private void btn_mostra_Click(object sender, EventArgs e)
        {
            btn_mostra.Visible = false;
            pnl_nascosto.Visible = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int nuovaX = pnl_puffo.Left; //distanza del puffo da sinistra
            int nuovaY = pnl_puffo.Top;  //distanza del puffo dall'alto
            if (e.KeyCode == Keys.A) 
                nuovaX -= velocita;

            if (e.KeyCode == Keys.D)
                nuovaX += velocita;

            if (e.KeyCode == Keys.W)
                nuovaY -= velocita;

            if (e.KeyCode == Keys.S) 
                nuovaY += velocita;

                if (nuovaX >= 0 && nuovaX + pnl_puffo.Width <= pnl_area.Width) //controlla se il puffo va oltre i bordi laterali
                pnl_puffo.Left = nuovaX;

            if (nuovaY >= 0 && nuovaY + pnl_puffo.Height <= pnl_area.Height)
                pnl_puffo.Top = nuovaY;

            ControllaCollisione();
        }
        private void ControllaCollisione()
        {
            if (pnl_puffo.Bounds.IntersectsWith(pnl_casetta.Bounds))
            {
                punteggio++;
                lbl_punteggio.Text = "Punteggio: " + punteggio;
                SpostaCasetta();
            }
        }
        private void btn_avvia_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_X.Text, out x) || !int.TryParse(txt_Y.Text, out y))
            {
                MessageBox.Show("Inserisci solo numeri!");
                return;
            }
            if (x < 0 || x > 500 || y < 0 || y > 400) {
                MessageBox.Show("Inserisci numeri validi (x [0, 500] e y[0,400] ");
                return;
            }
            pnl_area.Visible = true;
            lbl_punteggio.Visible=true;
            if (x < 0 || x + pnl_puffo.Width > pnl_area.Width ||
                y < 0 || y + pnl_puffo.Height > pnl_area.Height)
            {
                MessageBox.Show("Inserisci valori validi!");
                return;
            }
            Punto posizione = new Punto(x, y);
            pnl_puffo.Left = posizione.X;
            pnl_puffo.Top = posizione.Y;
            SpostaCasetta();
        }
        private void SpostaCasetta()
        {
            int maxX = pnl_area.Width - pnl_casetta.Width; //posizione max fino a dove può arrivare la casetta
            int maxY = pnl_area.Height - pnl_casetta.Height;
            pnl_casetta.Left = rnd.Next(0, maxX);
            pnl_casetta.Top = rnd.Next(0, maxY);
        }
    }
}
