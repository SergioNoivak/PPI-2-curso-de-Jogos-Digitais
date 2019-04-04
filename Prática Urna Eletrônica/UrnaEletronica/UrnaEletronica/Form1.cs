using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        string numero_corrente;
        bool ehPossivelComputar = false;


        List<Voto> votosArmazenados = new List<Voto>();


        public Form1()
        {
            InitializeComponent();
            this.numero_corrente = "";
        }

        //Acontece toda vez que o botão 0 for clicado
        private void button0_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "0";
            textBoxVisor.Text = numero_corrente;
            ehPossivelComputar = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "1";
            textBoxVisor.Text = numero_corrente;
            ehPossivelComputar = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "2";
            textBoxVisor.Text = numero_corrente;
            ehPossivelComputar = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "3";
            textBoxVisor.Text = numero_corrente;
            ehPossivelComputar = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "4";
            textBoxVisor.Text = numero_corrente;
            ehPossivelComputar = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "5";
            textBoxVisor.Text = numero_corrente;
            ehPossivelComputar = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "6";
            textBoxVisor.Text = numero_corrente;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "7";
            textBoxVisor.Text = numero_corrente;
            ehPossivelComputar = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "8";
            textBoxVisor.Text = numero_corrente;
            ehPossivelComputar = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.numero_corrente += "9";
            textBoxVisor.Text = numero_corrente;
            ehPossivelComputar = false;

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            textBoxVisor.Text = "";
            numero_corrente="";
            visor.Image = null;
            ehPossivelComputar = false;


        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (ehPossivelComputar)
            {
                Console.WriteLine("Aqui nessa parte será possível computar o voto");

                Candidato candidatoCorrente = new Candidato(int.Parse(textBoxVisor.Text));
                Voto votoCorrente = new Voto(candidatoCorrente);
                votosArmazenados.Add(votoCorrente);

                Console.WriteLine();
                foreach(Voto voto in votosArmazenados)
                {
                    Console.WriteLine(voto.getCandidato().getNumero());
                }

                ehPossivelComputar = false;

            }


            try{
            Image image = Image.FromFile(@"..\..\assets\img\" + textBoxVisor.Text + ".jpg");
            visor.Image = image;
            ehPossivelComputar = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Candidato não cadastrado");
                visor.Image = null; //para zerar objetos atribui-se null
                textBoxVisor.Text = "";
                this.numero_corrente = "";
            }



        }

        private void buttonComputarVotos_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(@"..\..\assets\resultado\Resultado.txt");
            foreach (Voto v in votosArmazenados)
            {

                sw.WriteLine(v.getCandidato().getNumero());
                sw.WriteLine(v.getTime());


            }
            sw.Close();


        }
    }
}
