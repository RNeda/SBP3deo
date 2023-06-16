using ProjekatSBP.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.DTOs
{
    public class SpisakPitanjaView
    {
        #region SpisakPitanja
       
        public SpisakPitanjaIdView Id { get; set; }
        

        public SpisakPitanjaView()
        {
           
        }
        public SpisakPitanjaView(SpisakPitanja pit)
        {
            this.Id = new SpisakPitanjaIdView(pit.Id);
        }
       
    }





    public class SpisakPitanjaIdView
    {
        public TVDueliView PripadaTVDuelu { get; set; }
        public string Pitanje { get; set; }

        public SpisakPitanjaIdView(){
        }
        public SpisakPitanjaIdView(SpisakPitanjaId p)
            {
            PripadaTVDuelu = new TVDueliView(p.PripadaTVDuelu);
            Pitanje =p.Pitanje;
            }

    }
        #endregion
    
}
