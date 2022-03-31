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

    public class Wąż /*: Istota*/
    {
        public int a;
        public int b;

        public string długość;
        public Wąż(int a1)
        {
            this.a = a1;
            
        }

        //public Wąż():base("Wąż")
        //{
        //    długość = "Siema";
        //}
        //public override string Inne()
        //{
        //    return długość;
        //}
        public static Wąż operator+(Wąż a2, Wąż b2)
        {
            return new Wąż(a2.a + b2.a);
        }

    }
}
