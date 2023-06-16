using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.Mapiranja
{
    class IntervjuNovineMapiranja : ClassMap<ProjekatSBP.Entiteti.IntervjuNovine>
    {
        public IntervjuNovineMapiranja()
        {
            //Mapiranje tabele
            Table("INTERVJU_NOVINE");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("INTERVJU_NOVINE_ID_SEQ");

            //mapiranje svojstava
            Map(x => x.NazivLista, "NAZIV_LISTA");
            Map(x => x.DatumPisanja, "DATUM_PISANJA");
            Map(x => x.DatumObjavljivanja, "DATUM_OBJAVLJIVANJA");
            Map(x => x.Novinar1, "NOVINAR1");
            Map(x => x.Novinar2, "NOVINAR2");

        }
    }
}
