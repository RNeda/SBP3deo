using NHibernate;
using ProjekatSBP.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.DTOs
{
    public class TVDueliView
    {
        #region TVDueli
            public int Id { get; set; }
        public string NazivStanice { get; set; }
        public string NazivEmisije { get; set; }
        public string ImeVoditelja { get; set; }
        public double Gledanost { get; set; }

        public TVDueliView()
            {


            }
            /* public TVDueliView(int Id, string NazivStanice, string NazivEmisije, string ImeVoditelja, double Gledanost)
             {
                 this.Id = Id;
                 this.NazivStanice = NazivStanice;
                 this.NazivEmisije = NazivEmisije;
                 this.ImeVoditelja = ImeVoditelja;
                 this.Gledanost = Gledanost;

             }*/
            public TVDueliView(TVDueli g)
            {
                Id = g.Id;
                NazivStanice = g.NazivStanice;
                NazivEmisije = g.NazivEmisije;
                ImeVoditelja = g.ImeVoditelja;
                Gledanost = g.Gledanost;

            }
       
        #endregion
    }
}
