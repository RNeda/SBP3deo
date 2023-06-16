using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.DTOs
{
    #region Pomocnik
   
    public class PomocnikView : UcesnikView
    {
        //public KoordinatorView PripadaKoordinatoru { get; set; }
        public PomocnikView(Ucesnik u) : base(u)
        {
            //PripadaKoordinatoru=new KoordinatorView(u);
        }

        public PomocnikView()
        {

        }

      

    }

    #endregion

   

}



