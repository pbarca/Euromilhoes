using System;
using System.Windows.Forms;

namespace Euromilhoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private euromilhoes E = new euromilhoes();
        private void estrela(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.estrela(Convert.ToInt32(tmp.Tag)-1);
            estrelas.Text = E.listaestrelas;
        }

        private void numero(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.numero(Convert.ToInt32(tmp.Tag)-1);
            numeros.Text = E.listanum;
        }
    }
}
