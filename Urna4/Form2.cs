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
    public partial class apuracao : Form
    {
        String path = Class1.Candidatos.imagens;
        public apuracao()
        {
            InitializeComponent();
        }

        private void apuracao_Load(object sender, EventArgs e)
        {
            mostrar();
            listarImagens();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mostrar();
        }

        private void listarImagens()
        {
            pictureBox1.Image = Image.FromFile(path + "bolsonaro.jpg");
            pictureBox2.Image = Image.FromFile(path + "lula.jpg");
            pictureBox3.Image = Image.FromFile(path + "doria.jpg");
            pictureBox5.Image = Image.FromFile(path + "marina.jpg");
            pictureBox4.Image = Image.FromFile(path + "ciro.jpg");
        }

        private void mostrar()
        {
            double votos = 0, totalVotos = 0, resultado = 0;
            totalVotos = Class1.Candidatos.totalVotos;
            if (Class1.Candidatos.totalVotos > 0)
            {
                votos = Class1.Candidatos.votosBolsonaro;
                resultado = votos / totalVotos * 100;
                totalVotesLabel.Text += "" + Class1.Candidatos.totalVotos;
                bolsonaroLabel.Text = "" + Class1.Candidatos.votosBolsonaro + " / " + resultado.ToString() + "%";

                votos = Class1.Candidatos.votosLula;
                resultado = votos / totalVotos * 100;
                totalVotesLabel.Text += "" + Class1.Candidatos.totalVotos;
                lulaLabel.Text = "" + Class1.Candidatos.votosLula + " / " + resultado.ToString() + "%";

                votos = Class1.Candidatos.votosDoria;
                resultado = votos / totalVotos * 100;
                totalVotesLabel.Text += "" + Class1.Candidatos.totalVotos;
                doriaLabel.Text = "" + Class1.Candidatos.votosDoria + " / " + resultado.ToString() + "%";

                votos = Class1.Candidatos.votosMarina;
                resultado = votos / totalVotos * 100;
                totalVotesLabel.Text += "" + Class1.Candidatos.totalVotos;
                marinaLabel.Text = "" + Class1.Candidatos.votosMarina + " / " + resultado.ToString() + "%";

                votos = Class1.Candidatos.votosCiro;
                resultado = votos / totalVotos * 100;
                totalVotesLabel.Text += "" + Class1.Candidatos.totalVotos;
                ciroLabel.Text = "" + Class1.Candidatos.votosCiro + " / " + resultado.ToString() + "%";
            }
            totalVotesLabel.Text = "Total de Votos: " + Class1.Candidatos.totalVotos;
        }

        private double calculaPorc(int votos, int totalVotos)
        {
            return votos / (100 * totalVotos);
        }
    }
}
