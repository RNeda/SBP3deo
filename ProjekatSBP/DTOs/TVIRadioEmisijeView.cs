using ProjekatSBP.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.DTOs
{
    public class TVIRadioEmisijeView
    {
         public int Id { get; set; }
        public string NazivStanice { get; set; }
        public string NazivEmisije { get; set; }
        public string ImeVoditelja { get; set; }
        public double Gledanost { get; set; }

        public TVIRadioEmisijeView()
            {

            }
        /*   public TVIRadioEmisijeView(int Id, string NazivStanice, string NazivEmisije, string ImeVoditelja, double Gledanost)
           {
               this.Id = Id;
               this.NazivStanice = NazivStanice;
               this.NazivEmisije = NazivEmisije;
               this.ImeVoditelja = ImeVoditelja;
               this.Gledanost = Gledanost;
           }*/
        public TVIRadioEmisijeView(TVIRadioEmisije i)
        {
            Id = i.Id;
            NazivStanice = i.NazivStanice;
            NazivEmisije = i.NazivEmisije;
            ImeVoditelja = i.ImeVoditelja;
            Gledanost = i.Gledanost;
        }

    }
       
}
