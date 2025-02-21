using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace JogoDaVelha
{
    public partial class FrmPrincipal : Form
    {
        public int jogada;
        int fimDeJogo;
        public FrmPrincipal()
        {
            InitializeComponent();

            jogada = 1; // comecar o jogo com X
            fimDeJogo = 0;
            foreach (Control control in this.Controls)
            {
                if (control is Button && (control.Name != "btReiniciar"))
                {
                    control.Font = new Font("Arial", 16, FontStyle.Bold); ;
                    control.Click += button_click;
                }
            }
            LBoxLog.Items.Clear();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "" && jogada == 1 && fimDeJogo == 0)
            {
                (sender as Button).Text = "X";
                LBoxLog.Items.Add("Jogador 1 jogou X");
                jogada = 0;
                if(Verificar_Vitoria(sender, e) == 1)
                {
                    fimDeJogo = 1;
                    MessageBox.Show($"Jogador 1 venceu!");
                }

            }
            if ((sender as Button).Text == "" && jogada == 0 && fimDeJogo == 0)
            {
                (sender as Button).Text = "0";
                jogada = 1;
                LBoxLog.Items.Add("Jogador 2 jogou 0");
                if (Verificar_Vitoria(sender, e) == 1)
                {
                    fimDeJogo = 1;
                    MessageBox.Show($"Jogador 2 venceu!");
                }
                        
            }
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            jogada = 1; // recomeca com a primeira jogada com X
            fimDeJogo = 0;
            foreach (Control control in this.Controls)
            {
                if (control is Button && (control.Name != "btReiniciar"))
                    control.Text = "";
                
            }
            LBoxLog.Items.Clear();
        }

        public int Verificar_Vitoria(object sender, EventArgs e)
        {
            if( (fimDeJogo == 0) &&
                (bt1.Text == bt2.Text && bt2.Text == bt3.Text && bt1.Text != "") || // Linha 1
                (bt4.Text == bt5.Text && bt5.Text == bt6.Text && bt4.Text != "") ||  // Linha 2
                (bt7.Text == bt8.Text && bt8.Text == bt9.Text && bt7.Text != "") ||  // Linha 3
                (bt1.Text == bt4.Text && bt4.Text == bt7.Text && bt1.Text != "") || // Coluna 1
                (bt2.Text == bt5.Text && bt5.Text == bt8.Text && bt2.Text != "") || // Coluna 2
                (bt3.Text == bt6.Text && bt6.Text == bt9.Text && bt3.Text != "") || //Coluna 3
                (bt1.Text == bt5.Text && bt5.Text == bt9.Text && bt1.Text != "") || // Diagonal principal
                (bt3.Text == bt5.Text && bt5.Text == bt7.Text && bt3.Text != "")    // Diagonal secundaria
                )
                return 1;
            return 0;
        }
    }
}
