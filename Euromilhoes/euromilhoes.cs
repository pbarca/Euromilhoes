namespace Euromilhoes
{
    class euromilhoes
    {
        private int nestrelas = 0, nnumero = 0;
        private const string cruz = "✗";
        private bool[] numeros = new bool[50];
        private bool[] estrelas = new bool[12];
        public string numero(int n)
        {
            if (numeros[n])
            {
                numeros[n] = false;
                nnumero--;
            }
            else if (nnumero < 5)
            {
                numeros[n] = true;
                nnumero++;
            }

            if (numeros[n]) return cruz;
            else return "";
        }
        public string estrela(int n)
        {
            if (estrelas[n])
            {
                estrelas[n] = false;
                nestrelas--;
            }
            else if (nestrelas < 2)
            {
                estrelas[n] = true;
                nestrelas++;
            }

            if (estrelas[n]) return cruz;
            else return "";
        }
        public string listanum
        {
            get
            {
                string lista = "";
                for (int i = 0; i < 50; i++)
                    if (numeros[i])
                    {
                        if (lista != "") lista += "-";
                        lista += (i + 1).ToString();
                    }
                return lista;
            }
        }
        public string listaestrelas
        {
            get
            {
                string lista = "";
                for (int i = 0; i < 12; i++)
                    if (estrelas[i])
                    {
                        if (lista != "") lista += "-";
                        lista += (i + 1).ToString();
                    }
                return lista;
            }
        }
    }
}
