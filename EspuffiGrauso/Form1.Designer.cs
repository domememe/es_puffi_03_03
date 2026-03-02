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
            this.lbl_puffo = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.pnl_nascosto = new System.Windows.Forms.Panel();
            this.btn_avvia = new System.Windows.Forms.Button();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.lbl_X = new System.Windows.Forms.Label();
            this.btn_mostra = new System.Windows.Forms.Button();
            this.pnl_area = new System.Windows.Forms.Panel();
            this.pnl_casetta = new System.Windows.Forms.Panel();
            this.lbl_punteggio = new System.Windows.Forms.Label();
            this.pnl_puffo = new System.Windows.Forms.Panel();
            this.pnl_nascosto.SuspendLayout();
            this.pnl_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_puffo
            // 
            this.lbl_puffo.AutoSize = true;
            this.lbl_puffo.Location = new System.Drawing.Point(27, 39);
            this.lbl_puffo.Name = "lbl_puffo";
            this.lbl_puffo.Size = new System.Drawing.Size(185, 16);
            this.lbl_puffo.TabIndex = 0;
            this.lbl_puffo.Text = "Inserisci la posizione del puffo";
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(257, 36);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(100, 22);
            this.txt_X.TabIndex = 1;
            this.txt_X.TextChanged += new System.EventHandler(this.txt_X_TextChanged);
            // 
            // pnl_nascosto
            // 
            this.pnl_nascosto.Controls.Add(this.btn_avvia);
            this.pnl_nascosto.Controls.Add(this.lbl_Y);
            this.pnl_nascosto.Controls.Add(this.txt_Y);
            this.pnl_nascosto.Controls.Add(this.lbl_X);
            this.pnl_nascosto.Controls.Add(this.txt_X);
            this.pnl_nascosto.Controls.Add(this.lbl_puffo);
            this.pnl_nascosto.Location = new System.Drawing.Point(187, 120);
            this.pnl_nascosto.Name = "pnl_nascosto";
            this.pnl_nascosto.Size = new System.Drawing.Size(403, 193);
            this.pnl_nascosto.TabIndex = 2;
            // 
            // btn_avvia
            // 
            this.btn_avvia.Location = new System.Drawing.Point(166, 121);
            this.btn_avvia.Name = "btn_avvia";
            this.btn_avvia.Size = new System.Drawing.Size(75, 48);
            this.btn_avvia.TabIndex = 5;
            this.btn_avvia.Text = "Avvia il gioco";
            this.btn_avvia.UseVisualStyleBackColor = true;
            this.btn_avvia.Click += new System.EventHandler(this.btn_avvia_Click);
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(233, 67);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(19, 16);
            this.lbl_Y.TabIndex = 4;
            this.lbl_Y.Text = "Y:";
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(257, 64);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(100, 22);
            this.txt_Y.TabIndex = 3;
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(233, 39);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(18, 16);
            this.lbl_X.TabIndex = 2;
            this.lbl_X.Text = "X:";
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
            this.pnl_area.Controls.Add(this.pnl_casetta);
            this.pnl_area.Controls.Add(this.pnl_puffo);
            this.pnl_area.Location = new System.Drawing.Point(146, 38);
            this.pnl_area.Name = "pnl_area";
            this.pnl_area.Size = new System.Drawing.Size(500, 400);
            this.pnl_area.TabIndex = 4;
            // 
            // pnl_casetta
            // 
            this.pnl_casetta.BackColor = System.Drawing.Color.Red;
            this.pnl_casetta.Location = new System.Drawing.Point(235, 185);
            this.pnl_casetta.Name = "pnl_casetta";
            this.pnl_casetta.Size = new System.Drawing.Size(30, 30);
            this.pnl_casetta.TabIndex = 2;
            // 
            // lbl_punteggio
            // 
            this.lbl_punteggio.AutoSize = true;
            this.lbl_punteggio.Location = new System.Drawing.Point(143, 9);
            this.lbl_punteggio.Name = "lbl_punteggio";
            this.lbl_punteggio.Size = new System.Drawing.Size(81, 16);
            this.lbl_punteggio.TabIndex = 1;
            this.lbl_punteggio.Text = "Punteggio: 0";
            // 
            // pnl_puffo
            // 
            this.pnl_puffo.BackColor = System.Drawing.Color.Blue;
            this.pnl_puffo.Location = new System.Drawing.Point(122, 69);
            this.pnl_puffo.Name = "pnl_puffo";
            this.pnl_puffo.Size = new System.Drawing.Size(30, 30);
            this.pnl_puffo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_area);
            this.Controls.Add(this.lbl_punteggio);
            this.Controls.Add(this.btn_mostra);
            this.Controls.Add(this.pnl_nascosto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_nascosto.ResumeLayout(false);
            this.pnl_nascosto.PerformLayout();
            this.pnl_area.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_puffo;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.Panel pnl_nascosto;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.Button btn_avvia;
        private System.Windows.Forms.Button btn_mostra;
        private System.Windows.Forms.Panel pnl_area;
        private System.Windows.Forms.Panel pnl_puffo;
        private System.Windows.Forms.Label lbl_punteggio;
        private System.Windows.Forms.Panel pnl_casetta;
    }
}

