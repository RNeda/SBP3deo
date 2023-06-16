using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class Reklama
    {
        public virtual int id { get; protected set; }
        public virtual double cena { get; set; }
        public virtual int vremenski_period { get; set; }
        public virtual string f_pano { get; set; } //da ne
        public virtual string grad { get; set; }
        public virtual string ulica { get; set; }
        public virtual double povrsina { get; set; }
        public virtual string agencija { get; set; }
        public virtual string f_novine { get; set; }  //da ne
        public virtual string naziv_novina { get; set; }
        public virtual string boja { get; set; }  //da ne
        public virtual string f_radio_tv { get; set; }  //da ne
        public virtual string naziv_radio_tv { get; set; }
        public virtual int br_emitovanja { get; set; }
        public virtual int trajanje { get; set; }


        public Reklama()
        {

        }

    }
}
