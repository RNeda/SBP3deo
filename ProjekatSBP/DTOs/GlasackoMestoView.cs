using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.DTOs
{

    #region GlasackoMesto
    public class GlasackoMestoView
    {
        public int Id { get; set; }
        public string NazivIzborneJedinice { get; set; }
        public int BrGlasackogMesta { get; set; }
        public int BrBiraca { get; set; }

        public GlasackoMestoView()
        {

        }

        public GlasackoMestoView(GlasackoMesto g)
        {
            Id=g.Id;
            NazivIzborneJedinice = g.NazivIzborneJedinice;
            BrGlasackogMesta=g.BrGlasackogMesta;
            BrBiraca=g.BrBiraca;
        }
    }

    
    #endregion

   
}



