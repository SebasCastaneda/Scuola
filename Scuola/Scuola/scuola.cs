using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    class scuola
    {

        string Nome { get; set; }

        string Cognome { get; set; }
        int Ore { get; set; }

        private scuola(string nome,string cognome,int ore)
        {
            Nome = nome;
            Cognome = cognome;
            Ore = ore;
        }

        //ciao
    }
}
