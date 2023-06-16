using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class GlasackoMesto
    {
        public virtual int Id { get; set; }
        public virtual string NazivIzborneJedinice { get; set; }    
        public virtual int BrGlasackogMesta { get; set; }   
        public virtual int BrBiraca { get; set; }  

        public virtual IList<Aktivista> Aktivisti { get; set;}

        public virtual IList<Krugovi> KrugoviGlasanja { get; set; }

        public virtual IList<Rezultati> RezultatiKrugovi { get; set; }

        public GlasackoMesto()
        {
            //inicijalizacija liste za slucaj dodavanja novog ucesnika
            Aktivisti= new List<Aktivista>();

            KrugoviGlasanja= new List<Krugovi>();

            RezultatiKrugovi= new List<Rezultati>();

        }
    }
}
