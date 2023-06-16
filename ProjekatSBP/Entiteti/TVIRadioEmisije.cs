using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class TVIRadioEmisije
    {
        public virtual int Id { get; protected set; }
        public virtual string NazivStanice { get; set; }
        public virtual string NazivEmisije { get; set; }
        public virtual string ImeVoditelja { get; set; }
        public virtual double Gledanost { get; set; }

        public TVIRadioEmisije()
        {

        }
    }
}
