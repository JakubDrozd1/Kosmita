using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb
{
    abstract class Istota
    {
        public string Opis { get; }
        public abstract string Inne();
       
        public Istota(string opis)
        {
            Opis = opis;
        }
        public virtual string Wyswietl()
        {
            return Opis + Inne();
        }
    }

    class Kosmita : Istota
    {
        public string oko;

        public Kosmita():base("Kosmita")
        {
            oko = "Siema";
        }
        public override string Inne()
        {
            return oko;
        }
    }

    class Wąż : Istota
    {
        public string długość;

        public Wąż():base("Wąż")
        {
            długość = "Siema";
        }
        public override string Inne()
        {
            return długość;
        }

    }
}
