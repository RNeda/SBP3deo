using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.Mapiranja
{
    class ReklamaMapiranja : ClassMap<ProjekatSBP.Entiteti.Reklama>
    {
        public ReklamaMapiranja()
        {
            Table("REKLAMA"); //mapiranje tabele

            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity(); //mapiranje primernog kljuca

            //mapiranje svojstava
            Map(x => x.cena, "CENA");
            Map(x => x.vremenski_period, "VREMENSKI_PERIOD");
            Map(x => x.f_pano, "FPANO");
            Map(x => x.grad, "GRAD");
            Map(x => x.ulica, "ULICA");
            Map(x => x.povrsina, "POVRSINA");
            Map(x => x.agencija, "AGENCIJA");
            Map(x => x.f_novine, "FNOVINE");
            Map(x => x.naziv_novina, "NAZIV_NOVINA");
            Map(x => x.boja, "BOJA");
            Map(x => x.f_radio_tv, "FRADIO_TV");
            Map(x => x.naziv_radio_tv, "NAZIV_RADIO_TV");
            Map(x => x.br_emitovanja, "BR_EMITOVANJA");
            Map(x => x.trajanje, "TRAJANJE");



        }
    }
}
