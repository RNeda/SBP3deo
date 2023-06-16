using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class TVDueli
    {

        public virtual int Id { get; set; }
        public virtual string NazivStanice { get; set; }
        public virtual string NazivEmisije { get; set; }
        public virtual string ImeVoditelja { get; set; }
        public virtual double Gledanost { get; set; }
        public virtual IList<Protivkandidati> Protivkandidatii { get; set; }
        public virtual IList<SpisakPitanja> Pitanja { get; set; }

        public TVDueli()
        {
            Protivkandidatii = new List<Protivkandidati>();
            Pitanja = new List<SpisakPitanja>();
        }


    }
}
