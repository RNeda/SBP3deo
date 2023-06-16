using ProjekatSBP.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.DTOs
{
    public class IntervjuNovineView
    {
        #region Intervjui
        
            public int Id { get; set; }
            public string NazivLista { get; set; }
            public DateTime DatumPisanja { get; set; }
            public DateTime DatumObjavljivanja { get; set; }
            public string Novinar1 { get; set; }
            public string Novinar2 { get; set; }

        public IntervjuNovineView()
            {

            }
        /* public IntervjuNovineView(int Id, string NazivLista, DateTime DatumPisanja, DateTime DatumObjavljivanja, string Novinar1, string Novinar2)
          {
              this.Id = Id;
              this.NazivLista = NazivLista;
              this.DatumPisanja = DatumPisanja;
              this.DatumObjavljivanja = DatumObjavljivanja;
              this.Novinar1 = Novinar1;
              this.Novinar2 = Novinar2;

          }*/
        public IntervjuNovineView(IntervjuNovine i)
        {
            this.Id = i.Id;
            this.NazivLista = i.NazivLista;
            this.DatumPisanja = i.DatumPisanja;
            this.DatumObjavljivanja = i.DatumObjavljivanja;
            this.Novinar1 = i.Novinar1;
            this.Novinar2 = i.Novinar2;
        }

        #endregion
    }
}
