using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID_persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
         ID_persona tizio = new ID_persona("","",0,"","");
            tizio.nome();
            tizio.cognome();
            tizio.indirizzo();
            tizio.età();
            tizio.CF();

            tizio.getDettagli();
        }
    }
}
