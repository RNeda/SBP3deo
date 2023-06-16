using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.DTOs
{
    
    #region Krugovi

    public class KrugoviView
    {
        public int Id { get; set; }
        public string BrKruga { get; set; }
        public int BrBiracaIzasli { get; set; }
        public double ProcenatZa { get; set; }

        public KrugoviView()
        {

        }

       
        public KrugoviView(Krugovi k)
        {
            Id = k.Id;
            BrKruga = k.BrKruga;
            BrBiracaIzasli=k.BrBiracaIzasli;
            ProcenatZa = k.ProcenatZa;

        }

    }

   
    #endregion

    

}



