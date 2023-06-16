using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.Entiteti
{
    public class IntervjuNovine
    {
        public virtual int Id { get; protected set; }
        public virtual string NazivLista { get; set; }
        public virtual DateTime DatumPisanja { get; set; }
        public virtual DateTime DatumObjavljivanja { get; set; }
        public virtual string Novinar1 { get; set; }
        public virtual string Novinar2 { get; set; }

        public IntervjuNovine()
        {

        }

    }
}
