using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.Mapiranja
{
    public class UcesnikMapiranja : ClassMap<ProjekatSBP.Entiteti.Ucesnik>
    {
        public UcesnikMapiranja()
        {
            //Mapiranje tabele
            Table("UCESNIK");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.Increment();

            //Mapiranje svojstava
            Map(x => x.LIme, "LIME");
            Map(x => x.ImeRoditelja, "IME_RODITELJA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrTel1, "BRTEL1");
            Map(x => x.BrTel2, "BRTEL2");
            Map(x => x.Email1, "EMAIL1");
            Map(x => x.Email2, "EMAIL2");



            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("TIP");




            //mapiranje veze 1:N Ucesnik-GlasackoMesto
            //ovo je many-to-one, dugme je VezaUcesnik_GlasackoMesto
            //References(x => x.PripadaGlasackomMestu).Column("ID_GL_MESTA").LazyLoad();

        }
    }

    class KoordinatorMapiranja : SubclassMap<Koordinator>
    {
        public KoordinatorMapiranja()
        {
            DiscriminatorValue("KOORDINATOR");
            Map(x => x.ImeOpstine, "IME_OPSTINE");
            Map(x => x.AdresaKancelarije, "ADRESA_KANCELARIJE");
            HasMany(x => x.Pomocnici).KeyColumn("ID_KOORDINATORA").LazyLoad().Cascade.All().Inverse();
        }
    }

    class PomocnikMapiranja : SubclassMap<Pomocnik>
    {
        public PomocnikMapiranja()
        {
            DiscriminatorValue("POMOĆNIK");
            References(x => x.PripadaKoordinatoru).Column("ID_KOORDINATORA").LazyLoad();
        }
    }

    class AktivistaMapiranja : SubclassMap<Aktivista>
    {
        public AktivistaMapiranja()
        {
            DiscriminatorValue("null");
            Map(x => x.Primedbe, "PRIMEDBE");
            References(x => x.PripadaGlasackomMestu).Column("ID_GL_MESTA").LazyLoad();
        }
    }

}
