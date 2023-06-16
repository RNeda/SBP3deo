using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class ProtivkandidatiId
    {
        public virtual string Protivkandidat { get; set; }
        public virtual TVDueli PripadaTVDuelu { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(ProtivkandidatiId))
                return false;

            ProtivkandidatiId recievedObject = (ProtivkandidatiId)obj;

            if ((PripadaTVDuelu.Id == recievedObject.PripadaTVDuelu.Id) &&
                (Protivkandidat == recievedObject.Protivkandidat))
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
