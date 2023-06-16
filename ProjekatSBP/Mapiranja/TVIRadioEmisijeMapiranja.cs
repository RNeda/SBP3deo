using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ProjekatSBP.Mapiranja
{
    class TVIRadioEmisijeMapiranja : ClassMap<ProjekatSBP.Entiteti.TVIRadioEmisije>
    {
        public TVIRadioEmisijeMapiranja()
        {
            //Mapiranje tabele
            Table("TV_I_RADIO_EMISIJE");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("TV_I_RADIO_EMISIJE_ID_SEQ");

            //mapiranje svojstava
            Map(x => x.NazivStanice, "NAZIV_STANICE");
            Map(x => x.NazivEmisije, "NAZIV_EMISIJE");
            Map(x => x.ImeVoditelja, "IME_VODITELJA");
            Map(x => x.Gledanost, "GLEDANOST");

        }
    }
}
