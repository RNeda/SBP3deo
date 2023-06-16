using ProjekatSBP.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public abstract class Ucesnik
    {
        public virtual int Id { get; set; }
        public virtual string LIme { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Adresa { get; set; }
        public virtual int BrTel1 { get; set; }
        public virtual int BrTel2 { get; set; }
        public virtual string Email1 { get; set; }
        public virtual string Email2 { get; set; }

        //public virtual GlasackoMesto PripadaGlasackomMestu { get; set; }

        public Ucesnik()
        {

        }
    }

    public class Koordinator : Ucesnik
    {
        public virtual string ImeOpstine { get; set; }
        public virtual string AdresaKancelarije { get; set; }
        public virtual IList<Pomocnik> Pomocnici { get; set; }
        //public virtual GlasackoMesto PripadaGlasackomMestu { get; set; }
        public Koordinator() : base()
        {
            Pomocnici = new List<Pomocnik>();
        }


    }

    public class Pomocnik : Ucesnik
    {
        public virtual Koordinator PripadaKoordinatoru { get; set; }

    }

    public class Aktivista : Ucesnik
    {
        public virtual string Primedbe { get; set; }
        public virtual GlasackoMesto PripadaGlasackomMestu { get; set; }
    }

}


