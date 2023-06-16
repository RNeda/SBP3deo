using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.Mapiranja
{
    class GostMapiranja : ClassMap<ProjekatSBP.Entiteti.Gost>
    {
        public GostMapiranja()
        {
            Table("GOST");
            Id(x => x.id, "ID").GeneratedBy.SequenceIdentity("GOST_ID_SEQ");

            Map(x => x.ime, "IME");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.funkcija, "FUNKCIJA");

            HasManyToMany(x => x.mitinzi)
                .Table("JE_GOST")
                .ParentKeyColumn("ID_GOSTA")
                .ChildKeyColumn("ID_MITINGA");
            //.Cascade.All();
        }
    }
}