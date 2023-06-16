using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP.DTOs
{
    #region Ucesnik
    public class UcesnikView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string ImeRoditelja { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public int BrTel { get; set; }
        public string Email { get; set; }


        public UcesnikView()
        {

        }

        public UcesnikView(Ucesnik u)
        {
            Id = u.Id;
            Ime = u.LIme;
            ImeRoditelja = u.ImeRoditelja;
            Prezime = u.Prezime;
            DatumRodjenja = u.DatumRodjenja;
            Adresa = u.Adresa;
            BrTel = u.BrTel1;
            Email = u.Email1;

        }
    }
   

    #endregion

   

}



