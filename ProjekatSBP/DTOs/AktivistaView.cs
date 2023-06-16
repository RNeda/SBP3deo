using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.DTOs
{
    #region Aktivista

    public class AktivistaView : UcesnikView
    {
        public string Primedbe;
        public GlasackoMestoView PripadaGlasackomMestu;
        

        public AktivistaView(Ucesnik u) : base(u)
        {
            this.Primedbe = Primedbe;
            PripadaGlasackomMestu = new GlasackoMestoView();
        }

        public AktivistaView()
        {
        }

        
       
    }

    #endregion  

}



