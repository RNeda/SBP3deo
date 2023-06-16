using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class Krugovi
    {
        public virtual int Id { get; set; }
        public virtual string BrKruga { get; set; }
        public virtual int BrBiracaIzasli { get; set; }
        public virtual double ProcenatZa { get; set; }

        public virtual IList<GlasackoMesto> GlasackaMesta { get; set; }

        public virtual IList<Rezultati> RezultatiGlasackaMesta { get; set; }

        public Krugovi()
        {
            GlasackaMesta=new List<GlasackoMesto>();

            RezultatiGlasackaMesta = new List<Rezultati>();

        }
    }
}
