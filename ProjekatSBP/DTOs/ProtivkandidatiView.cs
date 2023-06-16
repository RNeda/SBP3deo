using ProjekatSBP.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.DTOs
{
    #region Protivkandidati
   public class ProtivkandidatiView
    {
            // virtual string Protivkandidat { get; set; }
            public ProtivkandidatiIdView Id { get; set; }
        //public virtual TVDueli PripadaTVDuelu { get; set; }

        public ProtivkandidatiView()
            {
                
            }
            public ProtivkandidatiView(Protivkandidati p)
            {
                this.Id = new ProtivkandidatiIdView (p.Id);
            }
        
    }
        public class ProtivkandidatiIdView
        {
            public string Protivkandidat { get; set; }
        public TVDueliView PripadaTVDuelu { get; set; }
        public ProtivkandidatiIdView()
            {
                
            }
        public ProtivkandidatiIdView(ProtivkandidatiId pr)
        {
            Protivkandidat = pr.Protivkandidat;
            PripadaTVDuelu=new TVDueliView(pr.PripadaTVDuelu);

        }
        public ProtivkandidatiIdView(Protivkandidati pr)
        {
            Protivkandidat = pr.Id.Protivkandidat;
            PripadaTVDuelu = new TVDueliView(pr.Id.PripadaTVDuelu);
        }

    }
        #endregion
}
