using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ProjekatSBP.Mapiranja
{
    class TVDueliMapiranja: ClassMap<ProjekatSBP.Entiteti.TVDueli>
    {
        public TVDueliMapiranja()
        {
            //Mapiranje tabele
            Table("TV_DUELI");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("TV_DUELI_ID_SEQ");

            //mapiranje svojstava
            Map(x => x.NazivStanice, "NAZIV_STANICE");
            Map(x => x.NazivEmisije, "NAZIV_EMISIJE");
            Map(x => x.ImeVoditelja, "IME_VODITELJA");
            Map(x => x.Gledanost, "GLEDANOST");


            //mapiranje veze 1:N 
            HasMany(x => x.Protivkandidatii).KeyColumn("ID_DUELA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Pitanja).KeyColumn("ID_DUELA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
