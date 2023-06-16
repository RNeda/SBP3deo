using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.Mapiranja
{
    class AkcijaMapiranja : ClassMap<ProjekatSBP.Entiteti.Akcija>
    {
        public AkcijaMapiranja()
        {
            Table("AKCIJA");
            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.naziv, "NAZIV");
            Map(x => x.grad, "GRAD");
            Map(x => x.lokacija, "LOKACIJA");
            Map(x => x.f_deljenje_letaka, "FDELJENJE_LETAKA");
            Map(x => x.f_susret_sa_gradjanima, "FSUSRET_SA_GRADJANIMA");
            Map(x => x.vreme, "VREME");
            Map(x => x.f_miting, "FMITING");
            Map(x => x.f_na_otvorenom, "FNA_OTVORENOM");
            Map(x => x.f_na_zatvorenom, "FNA_ZATVORENOM");
            Map(x => x.naziv_firme, "NAZIV_FIRME");
            Map(x => x.cena_prostora, "CENA_PROSTORA");
            //Map(x => x.id_koordinatora, "ID_KOORDINATORA");

            References(x => x.koordinator).Column("ID_KOORDINATORA").LazyLoad();

            HasManyToMany(x => x.gosti_mitinga)
                .Table("JE_GOST")
                .ParentKeyColumn("ID_MITINGA")
                .ChildKeyColumn("ID_GOSTA")
                .Cascade.All()
                .Inverse();
        }
    }
}
