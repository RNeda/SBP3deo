using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class Rezultati
    {
        //kompozitni kljuc

        public virtual RezultatiId Id { get; set; }


        public Rezultati()
        {
            Id = new RezultatiId();
        }
    }
}
