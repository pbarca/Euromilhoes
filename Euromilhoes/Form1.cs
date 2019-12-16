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
        }

        private void numero(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.numero(Convert.ToInt32(tmp.Tag)-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ns = E.nsorteio;
            n1.Text = ns[0].ToString();
            n2.Text = ns[1].ToString();
            n3.Text = ns[2].ToString();
            n4.Text = ns[3].ToString();
            n5.Text = ns[4].ToString();
            int[] es = E.esorteio;
            e1.Text = es[0].ToString();
            e2.Text = es[1].ToString();
        }

    }
}
