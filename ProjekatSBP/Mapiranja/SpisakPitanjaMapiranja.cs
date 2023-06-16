using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ProjekatSBP.Mapiranja
{
    class SpisakPitanjaMapiranja : ClassMap<ProjekatSBP.Entiteti.SpisakPitanja>
    {
        public SpisakPitanjaMapiranja()
        {
            //Mapiranje tabele
            Table("SPISAK_PITANJA");

            CompositeId(x => x.Id)
                .KeyProperty(x => x.Pitanje, "PITANJE")
                .KeyReference(x => x.PripadaTVDuelu, "ID_DUELA");

            
        }
    }
}
