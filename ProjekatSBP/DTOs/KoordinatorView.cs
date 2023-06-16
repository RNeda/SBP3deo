using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.DTOs
{
    #region Koordinator
    
    public class KoordinatorView : UcesnikView
    {
        public string ImeOpstine;
        public string AdresaKancelarije;
        public virtual IList<PomocnikView> Pomocnici { get; set; }
        public virtual IList<AkcijaView> Akcije { get; set; }

        public KoordinatorView(Ucesnik u) : base(u)
        {
            this.ImeOpstine = ImeOpstine;
            this.AdresaKancelarije = AdresaKancelarije;
        }

        public KoordinatorView()
        {
            Pomocnici=new List<PomocnikView>();
            Akcije=new List<AkcijaView>();

        }


    }
    

    #endregion

   

}



