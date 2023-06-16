using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class RezultatiId
    {
        public virtual Krugovi KrugoviRezultati { get; set; }   
        public virtual GlasackoMesto GlasackoMestoRezultati { get; set; }

        public override bool Equals(object obj)
        {
            if(Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() == typeof(RezultatiId))
                return false;

            RezultatiId reciveObject= (RezultatiId)obj;

            if((KrugoviRezultati.Id==reciveObject.KrugoviRezultati.Id) &&
                    (GlasackoMestoRezultati.Id == reciveObject.GlasackoMestoRezultati.Id))
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
