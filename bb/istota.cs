using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb
{
    abstract class Istota
    {
        public string Opis;
        public abstract string Inne();
       

        public virtual string Wyswietl()
        {
            return Opis + Inne();
        }
    }

    class Kosmita : Istota
    {

        public string oko;

        public Kosmita(string o)
        {
            oko = o;
        }
        public override string Inne()
        {
            return oko;
        }



    }
    class Wąż : Istota
    {
        public string długość;

        public Wąż(string d)
        {
            długość = d;
        }
        public override string Inne()
        {
            return długość;
        }

    }
}
