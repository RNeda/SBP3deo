using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.DTOs
{
    
    #region Rezultati

    public class RezultatiView
    {
        public RezultatiIdView Id { get; set; }

        public RezultatiView(Rezultati r)
        {
           Id = new RezultatiIdView(r.Id);
        }

        public RezultatiView()
        {
            
        }


    }


    #endregion



}



