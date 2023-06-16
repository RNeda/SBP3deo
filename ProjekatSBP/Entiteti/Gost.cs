using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class Gost
    {
        public virtual int id { get; protected set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual string funkcija { get; set; }

        public virtual IList<Akcija> mitinzi { get; set; }

        public Gost()
        {
            mitinzi = new List<Akcija>();
        }
    }
}
