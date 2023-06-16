using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.Mapiranja
{
    public class GlasackoMestoMapiranje : ClassMap<ProjekatSBP.Entiteti.GlasackoMesto>
    {
        public GlasackoMestoMapiranje()
        {
            //Mapiranje tabele
            Table("GLASACKO_MESTO");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.Increment();

            //Mapiranje svojstava
            Map(x => x.NazivIzborneJedinice, "NAZIV_IZBORNE_JEDINICE");
            Map(x => x.BrGlasackogMesta, "BR_GLASACKOG_MESTA");
            Map(x => x.BrBiraca, "BR_BIRACA");

            //Mapiranje veze 1:N Ucesnik-GlasackoMesto
            //ovo je one-to-many, dugme je VezaGlasackoMesto-Ucesnik
            HasMany(x => x.Aktivisti).KeyColumn("ID_GL_MESTA").LazyLoad().Cascade.All().Inverse();

            //mapiranje many-to-many veze REZULTATI
            HasManyToMany(x => x.KrugoviGlasanja)
               .Table("REZULTATI")
               .ParentKeyColumn("ID_GLASACKOG_MESTA")
               .ChildKeyColumn("ID_KRUGA")
               .Cascade.All()
               .Inverse();

            HasMany(x => x.RezultatiKrugovi).KeyColumn("ID_GLASACKOG_MESTA").LazyLoad().Cascade.All().Inverse();
        }
    }
}


