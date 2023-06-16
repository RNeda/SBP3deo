using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class SpisakPitanjaId
    {
        public virtual string Pitanje { get; set; }
        public virtual TVDueli PripadaTVDuelu { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(SpisakPitanjaId))
                return false;

            SpisakPitanjaId recievedObject = (SpisakPitanjaId)obj;

            if ((PripadaTVDuelu.Id == recievedObject.PripadaTVDuelu.Id) &&
                (Pitanje == recievedObject.Pitanje))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
