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

        private int nestrelas = 0, nnumero = 0;
        private string cruz = "✗";
        private void estrela(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            if (temp.Text == cruz)
            {
                temp.Text = "";
                nestrelas--;
            }
            else if (nestrelas < 2)
            {
                temp.Text = cruz;
                nestrelas++;
                teste.Text = temp.Tag.ToString();
            }
        }

        private void numero(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            if (temp.Text == cruz)
            {
                temp.Text = "";
                nnumero--;
            }
            else if (nnumero < 5)
            {
                temp.Text = cruz;
                nnumero++;
                teste.Text = temp.Tag.ToString();
            }
        }
    }
}
