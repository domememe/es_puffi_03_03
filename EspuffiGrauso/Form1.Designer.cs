namespace EspuffiGrauso
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_mostra = new System.Windows.Forms.Button();
            this.pnl_area = new System.Windows.Forms.Panel();
            this.pnl_gargamella = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_casetta = new System.Windows.Forms.Panel();
            this.pnl_puffo = new System.Windows.Forms.Panel();
            this.lbl_punteggio = new System.Windows.Forms.Label();
            this.lbl_puntogarg = new System.Windows.Forms.Label();
            this.lbl_turno = new System.Windows.Forms.Label();
            this.pnl_albero = new System.Windows.Forms.Panel();
            this.pnl_albero2 = new System.Windows.Forms.Panel();
            this.pnl_albero3 = new System.Windows.Forms.Panel();
            this.pnl_albero4 = new System.Windows.Forms.Panel();
            this.pnl_albero6 = new System.Windows.Forms.Panel();
            this.pnl_albero5 = new System.Windows.Forms.Panel();
            this.pnl_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mostra
            // 
            this.btn_mostra.Location = new System.Drawing.Point(353, 43);
            this.btn_mostra.Name = "btn_mostra";
            this.btn_mostra.Size = new System.Drawing.Size(75, 23);
            this.btn_mostra.TabIndex = 3;
            this.btn_mostra.Text = "Avvia";
            this.btn_mostra.UseVisualStyleBackColor = true;
            this.btn_mostra.Click += new System.EventHandler(this.btn_mostra_Click);
            // 
            // pnl_area
            // 
            this.pnl_area.BackColor = System.Drawing.Color.Lime;
            this.pnl_area.Controls.Add(this.pnl_albero5);
            this.pnl_area.Controls.Add(this.pnl_albero6);
            this.pnl_area.Controls.Add(this.pnl_albero4);
            this.pnl_area.Controls.Add(this.pnl_albero3);
            this.pnl_area.Controls.Add(this.pnl_albero2);
            this.pnl_area.Controls.Add(this.pnl_albero);
            this.pnl_area.Controls.Add(this.pnl_gargamella);
            this.pnl_area.Controls.Add(this.panel1);
            this.pnl_area.Controls.Add(this.pnl_casetta);
            this.pnl_area.Controls.Add(this.pnl_puffo);
            this.pnl_area.Location = new System.Drawing.Point(146, 38);
            this.pnl_area.Name = "pnl_area";
            this.pnl_area.Size = new System.Drawing.Size(500, 400);
            this.pnl_area.TabIndex = 4;
            // 
            // pnl_gargamella
            // 
            this.pnl_gargamella.BackColor = System.Drawing.Color.Black;
            this.pnl_gargamella.Location = new System.Drawing.Point(223, 56);
            this.pnl_gargamella.Name = "pnl_gargamella";
            this.pnl_gargamella.Size = new System.Drawing.Size(30, 30);
            this.pnl_gargamella.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(207, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 3;
            // 
            // pnl_casetta
            // 
            this.pnl_casetta.BackColor = System.Drawing.Color.Red;
            this.pnl_casetta.Location = new System.Drawing.Point(235, 185);
            this.pnl_casetta.Name = "pnl_casetta";
            this.pnl_casetta.Size = new System.Drawing.Size(50, 50);
            this.pnl_casetta.TabIndex = 2;
            // 
            // pnl_puffo
            // 
            this.pnl_puffo.BackColor = System.Drawing.Color.Blue;
            this.pnl_puffo.Location = new System.Drawing.Point(122, 69);
            this.pnl_puffo.Name = "pnl_puffo";
            this.pnl_puffo.Size = new System.Drawing.Size(30, 30);
            this.pnl_puffo.TabIndex = 0;
            // 
            // lbl_punteggio
            // 
            this.lbl_punteggio.AutoSize = true;
            this.lbl_punteggio.Location = new System.Drawing.Point(143, 9);
            this.lbl_punteggio.Name = "lbl_punteggio";
            this.lbl_punteggio.Size = new System.Drawing.Size(135, 16);
            this.lbl_punteggio.TabIndex = 1;
            this.lbl_punteggio.Text = "Punteggio del puffo: 0";
            // 
            // lbl_puntogarg
            // 
            this.lbl_puntogarg.AutoSize = true;
            this.lbl_puntogarg.Location = new System.Drawing.Point(453, 9);
            this.lbl_puntogarg.Name = "lbl_puntogarg";
            this.lbl_puntogarg.Size = new System.Drawing.Size(177, 16);
            this.lbl_puntogarg.TabIndex = 5;
            this.lbl_puntogarg.Text = "Punteggio di Garagamella: 0";
            // 
            // lbl_turno
            // 
            this.lbl_turno.AutoSize = true;
            this.lbl_turno.Location = new System.Drawing.Point(42, 107);
            this.lbl_turno.Name = "lbl_turno";
            this.lbl_turno.Size = new System.Drawing.Size(0, 16);
            this.lbl_turno.TabIndex = 6;
            // 
            // pnl_albero
            // 
            this.pnl_albero.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero.Location = new System.Drawing.Point(259, 79);
            this.pnl_albero.Name = "pnl_albero";
            this.pnl_albero.Size = new System.Drawing.Size(40, 40);
            this.pnl_albero.TabIndex = 5;
            // 
            // pnl_albero2
            // 
            this.pnl_albero2.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero2.Location = new System.Drawing.Point(112, 213);
            this.pnl_albero2.Name = "pnl_albero2";
            this.pnl_albero2.Size = new System.Drawing.Size(40, 40);
            this.pnl_albero2.TabIndex = 6;
            // 
            // pnl_albero3
            // 
            this.pnl_albero3.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero3.Location = new System.Drawing.Point(337, 226);
            this.pnl_albero3.Name = "pnl_albero3";
            this.pnl_albero3.Size = new System.Drawing.Size(40, 40);
            this.pnl_albero3.TabIndex = 7;
            // 
            // pnl_albero4
            // 
            this.pnl_albero4.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero4.Location = new System.Drawing.Point(352, 134);
            this.pnl_albero4.Name = "pnl_albero4";
            this.pnl_albero4.Size = new System.Drawing.Size(40, 40);
            this.pnl_albero4.TabIndex = 8;
            // 
            // pnl_albero6
            // 
            this.pnl_albero6.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero6.Location = new System.Drawing.Point(223, 260);
            this.pnl_albero6.Name = "pnl_albero6";
            this.pnl_albero6.Size = new System.Drawing.Size(40, 40);
            this.pnl_albero6.TabIndex = 9;
            // 
            // pnl_albero5
            // 
            this.pnl_albero5.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero5.Location = new System.Drawing.Point(230, 180);
            this.pnl_albero5.Name = "pnl_albero5";
            this.pnl_albero5.Size = new System.Drawing.Size(40, 40);
            this.pnl_albero5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_turno);
            this.Controls.Add(this.lbl_puntogarg);
            this.Controls.Add(this.pnl_area);
            this.Controls.Add(this.lbl_punteggio);
            this.Controls.Add(this.btn_mostra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_area.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_mostra;
        private System.Windows.Forms.Panel pnl_area;
        private System.Windows.Forms.Panel pnl_puffo;
        private System.Windows.Forms.Label lbl_punteggio;
        private System.Windows.Forms.Panel pnl_casetta;
        private System.Windows.Forms.Panel pnl_gargamella;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_puntogarg;
        private System.Windows.Forms.Label lbl_turno;
        private System.Windows.Forms.Panel pnl_albero;
        private System.Windows.Forms.Panel pnl_albero5;
        private System.Windows.Forms.Panel pnl_albero6;
        private System.Windows.Forms.Panel pnl_albero4;
        private System.Windows.Forms.Panel pnl_albero3;
        private System.Windows.Forms.Panel pnl_albero2;
    }
}

