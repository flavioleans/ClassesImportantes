using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Assinatura basica");
            //MessageBox.Show("Mensagem Impressa", "Titulo");

            //MessageBox Button
            //DialogResult res =  MessageBox.Show("Mensagem Impressa", "Titulo", MessageBoxButtons.OKCancel);

            // if (res == DialogResult.OK)
            // {
            //     lblResultado.Text = "ok";
            // }
            // else if (res == DialogResult.Cancel)
            // {
            //     lblResultado.Text = "Clicou em cancelar";
            // }

            //icon
            //MessageBox.Show("Mensagem Impressa", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            //button de seleção default
            MessageBox.Show("Mensagem Impressa", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            //usando milisegundo para pegar um numero inteiro
            Random r = new Random(DateTime.Now.Millisecond);
            //minimo e maximo
            int v = r.Next(0,100);

            //valor double
            double v2 = r.NextDouble();

            lblResultado.Text = "Numero: " + v;
            
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //Calcula intervalo de tempo formatado
            //valores passados são em double

            //minutos
            //lblResultado.Text = TimeSpan.FromMinutes(75.5).ToString();

            //dias
            //lblResultado.Text = TimeSpan.FromDays(7.25).ToString();

            //ticks = menor intervalo de tempo
            //lblResultado.Text = TimeSpan.FromTicks(100000).ToString();

            //lblResultado.Text = TimeSpan.TicksPerMinute.ToString();

            //TimeSpan tempo = new TimeSpan(5,30,30);
            //lblResultado.Text = tempo.ToString();

            //calculando tempo
            TimeSpan inicio = new TimeSpan(5, 30, 30);
            TimeSpan fim = new TimeSpan(18, 30, 30);

             //TimeSpan intervalo = fim - inicio;

            //lblResultado.Text = intervalo.TotalSeconds.ToString();

            //adicionando
            //TimeSpan intervalo =  inicio.Add(fim);
            //lblResultado.Text = intervalo.ToString();

            //subtraindo
            TimeSpan intervalo = fim.Subtract(inicio);
            lblResultado.Text = intervalo.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //numeros de dia do mes
            //lblResultado.Text = DateTime.DaysInMonth(2021, 02).ToString();

            //retorna se ano é bisexto
            //lblResultado.Text = DateTime.IsLeapYear(2021).ToString();

            //retorno string por extenso
            //lblResultado.Text = DateTime.Now.ToLongDateString();
            //lblResultado.Text = DateTime.Now.ToShortDateString();
            //lblResultado.Text = DateTime.Now.ToLongTimeString();
            //lblResultado.Text = DateTime.Now.ToShortTimeString();

            //Alterando a string
            //lblResultado.Text = DateTime.Now.ToString("dd-MM-yyyy");

            //manipulando datas
            DateTime data = new DateTime(1987, 12, 08);
            //lblResultado.Text = data.AddYears(2).ToString();

            //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //lblResultado.Text = data.Add(tempo).ToString();

            // retorna dia da semana
            lblResultado.Text = data.DayOfWeek.ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color vermedo = Color.Red;
            Color amarelo = Color.Yellow;

            //Color rgb = Color.FromArgb(255, 125, yellow);
            //Color rgb = Color.FromArgb(255, 255, 125, 144);

            //cores conhecidas
            lblResultado.BackColor = Color.FromKnownColor(KnownColor.Coral);
            

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Arial", 36, FontStyle.Regular | FontStyle.Italic, GraphicsUnit.Pixel);

            lblResultado.Text = "Bem vindo ao C# ";
            lblResultado.Font = letra;
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            //ambientes do sistem
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dirAtual = Environment.CurrentDirectory;
            //lblResultado.Text = dirAtual;

            //string varAmb = Environment.GetEnvironmentVariable("Path");
            //lblResultado.Text = varAmb;

            //string[] discos = Environment.GetLogicalDrives();

            //foreach (string item in discos)
            //{
            //    lblResultado.Text += "\n " + item;
            //}

            //string user = Environment.UserName;
            //lblResultado.Text = user;

            //string dominio = Environment.UserDomainName;
            //lblResultado.Text = dominio;

            int cpu = Environment.ProcessorCount;
            lblResultado.Text = cpu.ToString();

        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            string exex = Application.ExecutablePath;
            //lblResultado.Text = exex;

            string pasta = Application.StartupPath;
            //lblResultado.Text = pasta;

            Application.Restart();
        }
    }
}
