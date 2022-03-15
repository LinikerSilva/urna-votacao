using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna4
{
    public partial class Urna : Form
    {
        String path = Class1.Candidatos.imagens;
        public Urna()
        {
            InitializeComponent();
            candidatePictureBox.Image = Image.FromFile(path + "/justica.jpg");
            confirmButton.Enabled = false;
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            String bolsonaro = Class1.Candidatos.bolsonaro;
            String lula = Class1.Candidatos.lula;
            String doria = Class1.Candidatos.doria;
            String marina = Class1.Candidatos.marina;
            String ciro = Class1.Candidatos.ciro;
            if (numberTextBox.Text.Length == 2)
            {
                if (numberTextBox.Text == "17")
                {
                    candidatePictureBox.Image = Image.FromFile(path + "bolsonaro.jpg");
                    candidateLabel.Text = bolsonaro;
                    statusLabel.Text = "Agora Confirme Seu Voto";
                    confirmButton.Enabled = true;
                }
                else if (numberTextBox.Text == "13")
                {
                    candidatePictureBox.Image = Image.FromFile(path + "lula.jpg");
                    candidateLabel.Text = lula;
                    statusLabel.Text = "Agora Confirme Seu Voto";
                    confirmButton.Enabled = true;
                }
                else if (numberTextBox.Text == "45")
                {
                    candidatePictureBox.Image = Image.FromFile(path + "doria.jpg");
                    candidateLabel.Text = doria;
                    statusLabel.Text = "Agora Confirme Seu Voto";
                    confirmButton.Enabled = true;
                }
                else if (numberTextBox.Text == "18")
                {
                    candidatePictureBox.Image = Image.FromFile(path + "marina.jpg");
                    candidateLabel.Text = marina;
                    statusLabel.Text = "Agora Confirme Seu Voto";
                    confirmButton.Enabled = true;
                }
                else if (numberTextBox.Text == "12")
                {
                    candidatePictureBox.Image = Image.FromFile(path + "ciro.jpg");
                    candidateLabel.Text = ciro;
                    statusLabel.Text = "Agora Confirme Seu Voto";
                    confirmButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Candidato Inválido");
                    candidatePictureBox.Image = Image.FromFile(path + "/justica.jpg");
                    confirmButton.Enabled = false;
                    numberTextBox.Text = "";
                }
            }
        }

        private void nullButton_Click(object sender, EventArgs e)
        {
            candidatePictureBox.Image = Image.FromFile(path + "nulo.png");
            statusLabel.Text = "Você Escolheu O Voto Nulo.\nPressione Confirmar";
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            candidatePictureBox.Image = Image.FromFile(path + "/branco.png");
            statusLabel.Text = "Você Escolheu O Voto em Branco.\nPressione Confirmar";
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (confirmButton.Enabled == true)
                {
                    votar();
                }
            }
        }

        private void votar()
        {
            if (numberTextBox.Text == "17")
            {
                Class1.Candidatos.votosBolsonaro++;
            }
            else if (numberTextBox.Text == "13")
            {
                Class1.Candidatos.votosLula++;
            }
            else if (numberTextBox.Text == "45")
            {
                Class1.Candidatos.votosDoria++;
            }
            else if (numberTextBox.Text == "18")
            {
                Class1.Candidatos.votosMarina++;
            }
            else if (numberTextBox.Text == "12")
            {
                Class1.Candidatos.votosCiro++;
            }
            Class1.Candidatos.totalVotos++;
            MessageBox.Show("Votação Encerrada");
            numberTextBox.Text = "";
            candidateLabel.Text = "";
            confirmButton.Enabled = false;
            candidatePictureBox.Image = Image.FromFile(path + "/justica.jpg");
        }

        private void Urna_Load(object sender, EventArgs e)
        {
            apuracao frmapuracao = new apuracao();
            frmapuracao.Show();
        }
    }
}
