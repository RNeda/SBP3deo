using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace ProjekatSBP.Mapiranja
{
    class ProtivkandidatiMapiranja : ClassMap<ProjekatSBP.Entiteti.Protivkandidati>
    {
        public ProtivkandidatiMapiranja()
        {
            //Mapiranje tabele
            Table("PROTIVKANDIDATI");
            CompositeId(x => x.Id)
                .KeyProperty(x => x.Protivkandidat, "PROTIVKANDIDAT")
                .KeyReference(x => x.PripadaTVDuelu, "ID_DUELA");

        }
    }
}
