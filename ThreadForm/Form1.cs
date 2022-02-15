using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
       //1 private  delegate void AtualizarControle(Control controle, string propriedade, object valor);
        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive)
            {
                t.Start();
            }
        }

        //1 private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        //{
        //    if (controle.InvokeRequired) //retorna true caso controle seja atualizado pelo invoke
        //    {
        //        AtualizarControle d = new AtualizarControle(DefinirValorPropriedade);
        //        controle.Invoke(d, new object[] { controle, propriedade, valor });
        //    }
        //    else
        //    {
        //        Type t = controle.GetType();
        //        PropertyInfo[] props = t.GetProperties();

        //        foreach (PropertyInfo p in props)
        //        {
        //            if (p.Name.ToUpper() == propriedade.ToUpper())
        //            {
        //                p.SetValue(controle, valor, null);
        //            }
        //        }
        //    }
        //}

        private void Tarefa()
        {
            while (true)
            {
                //lblResultado.Text = DateTime.Now.Second.ToString();
                //DefinirValorPropriedade(lblResultado, "Text", DateTime.Now.Second.ToString());

                //acessar diretamente de outra thread
                lblResultado.Invoke(new Action(() => lblResultado.Text = DateTime.Now.Second.ToString()));
                lblResultado.Invoke(new Action(() => lblResultado.ForeColor = Color.DarkRed));
            }
        }

        // não ter a necessidade de criar um Delegate e o metodo DefinirValorPropriedade para
        //acessar o objeto diretamente de outra thread, basta chamar o metodo Invoke diretamente
        // no objeto:
        

    }
}
