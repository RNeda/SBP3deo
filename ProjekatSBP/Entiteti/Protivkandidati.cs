using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class Protivkandidati
    {
        // virtual string Protivkandidat { get; set; }
        public virtual ProtivkandidatiId Id { get; set; }
        //public virtual TVDueli PripadaTVDuelu { get; set; }

        public Protivkandidati()
        {
            Id = new ProtivkandidatiId();
        }
        public Protivkandidati(ProtivkandidatiId Id)
        {
            this.Id = Id;
        }
    }
}
