using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.DTOs
{
    public class GostView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Funkcija { get; set; }
        public IList<AkcijaView> Mitinzi;

        public GostView()
        {
            Mitinzi = new List<AkcijaView>();
        }

        public GostView(int id, string ime, string prez, string func)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prez;
            this.Funkcija = func;
        }

    }
}
