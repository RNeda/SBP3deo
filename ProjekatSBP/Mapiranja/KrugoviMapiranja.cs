using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.Mapiranja
{
    public class KrugoviMapiranja : ClassMap<ProjekatSBP.Entiteti.Krugovi>
    {
        public KrugoviMapiranja()
        {
            //Mapiranje tabele
            Table("KRUGOVI");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.Increment();


            //Mapiranje svojstava
            Map(x => x.BrKruga, "BR_KRUGA");
            Map(x => x.BrBiracaIzasli, "BR_BIRACA_IZASLI");
            Map(x => x.ProcenatZa, "PROCENAT_ZA");

            //mapiranje veze REZULTATI
            HasManyToMany(x => x.GlasackaMesta)
                .Table("REZULTATI")
                .ParentKeyColumn("ID_KRUGA")
                .ChildKeyColumn("ID_GLASACKOG_MESTA")
                .Cascade.All();

            HasMany(x => x.RezultatiGlasackaMesta).KeyColumn("ID_KRUGA").LazyLoad().Cascade.All().Inverse();


        }
    }
}
