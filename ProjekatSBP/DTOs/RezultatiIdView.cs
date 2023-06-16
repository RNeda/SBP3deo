using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.DTOs
{
  

   
    #region Rezultati

    public class RezultatiIdView
    {
        public KrugoviView KrugoviRezultati { get; set; }
        public GlasackoMestoView GlasackoMestoRezultati { get; set; }

        public RezultatiIdView()
        {

        }


        public RezultatiIdView(RezultatiId r)
        {
            KrugoviRezultati = new KrugoviView(r.KrugoviRezultati);
            GlasackoMestoRezultati = new GlasackoMestoView(r.GlasackoMestoRezultati);

        }

    }

    
    #endregion


   

}



