using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class SpisakPitanja
    {
        //public virtual int PripadaTVDuelu { get; set; }
        public virtual SpisakPitanjaId Id { get; set; }
        // public virtual string Pitanje { get; set; }

        public SpisakPitanja()
        {
            Id = new SpisakPitanjaId();
        }
        public SpisakPitanja(SpisakPitanjaId Id)
        {
            this.Id = Id;
        }


    }
}
