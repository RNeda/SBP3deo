using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;
using FluentNHibernate.Mapping;

namespace ProjekatSBP.Mapiranja
{
    public class RezultatiMapiranja : ClassMap<Rezultati>
    {
        public RezultatiMapiranja()
        {
            //mapiranje tabele
            Table("REZULTATI");

            //mapiranje kompozitnog kljuca
            CompositeId(x => x.Id)
                .KeyReference(x => x.KrugoviRezultati, "ID_KRUGA")
                .KeyReference(x => x.GlasackoMestoRezultati, "ID_GLASACKOG_MESTA");

        }
    }
}
