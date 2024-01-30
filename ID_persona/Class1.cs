using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID_persona
{
    public class ID_persona
    {
        public string _nome { get; set; }
        public string _cognome { get; set; }
        public int _età { get; set; }
        public string _CF { get; set; }
        public string _indirizzo { get; set; }

       public ID_persona(string nome, string cognome, int età, string CF, string indirizzo)
        {
            _nome = nome;
            _cognome = cognome;
            _età = età;
            _CF = CF;
            _indirizzo = indirizzo;

        }
        public void nome()
        {
            _nome = "Alessio";
        }

        public void cognome() 
        {
            _cognome = "Guida";
        }

        public void età ()
        {
            _età = 27;
        }

        public void CF ()
        {
            _CF = "GDULSS97A10M088Q";
        }

        public void indirizzo ()
        {
            _indirizzo = "Via Neghelli 91";
        }

        public void getDettagli()
        {
            Console.WriteLine($"il tuo nome è {_nome} {_cognome} hai {27} anni abiti in {_indirizzo}. Il tuo codice fiscale è {_CF}");
        }
    }
}
