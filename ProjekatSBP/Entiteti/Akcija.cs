using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class Akcija
    {
        public virtual int id { get; protected set; }
        public virtual string naziv { get; set; }
        public virtual string grad { get; set; }
        public virtual string lokacija { get; set; }
        public virtual string f_deljenje_letaka { get; set; }
        public virtual string f_susret_sa_gradjanima { get; set; }
        public virtual string vreme { get; set; }
        public virtual string f_miting { get; set; }
        public virtual string f_na_otvorenom { get; set; }
        public virtual string f_na_zatvorenom { get; set; }
        public virtual string naziv_firme { get; set; }
        public virtual double cena_prostora { get; set; }
        public virtual Koordinator koordinator { get; set; } //??
        //public virtual int id_koordinatora { get; set; }
        public virtual IList<Gost> gosti_mitinga { get; set; }

        public Akcija()
        {
            gosti_mitinga = new List<Gost>();

        }
    }
}
