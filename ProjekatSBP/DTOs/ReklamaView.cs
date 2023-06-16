using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.DTOs
{
    public class ReklamaView
    {
        public int ReklamaId { get; set; }
        public double CenaReklame { get; set; }
        public int VremenskiPeriod { get; set; }
        public string FPano { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public double Povrsina { get; set; }
        public string Agencija { get; set; }
        public string FNovine { get; set; }
        public string NazivNovina { get; set; }
        public string Boja { get; set; }
        public string FRadioTv { get; set; }
        public string NazivRadioTv { get; set; }
        public int BrEmitovanja { get; set; }
        public int Trajanje { get; set; }

        public ReklamaView(int id, double cena, int vr, string fp, string grad, string ulica, double p, string agencija, string fn, string naziv, string boja, string frtv, string nazivrtv, int brem, int trajanje)
            {
                this.ReklamaId = id;
                this.CenaReklame = cena;
                this.VremenskiPeriod = vr;
                this.FPano = fp;
                this.Grad = grad;
                this.Ulica = ulica;
                this.Povrsina = p;
                this.Agencija = agencija;
                this.FNovine = fn;
                this.NazivNovina = naziv;
                this.Boja = boja;
                this.FRadioTv = frtv;
                this.NazivRadioTv = nazivrtv;
                this.BrEmitovanja = brem;
                this.Trajanje = trajanje;
            }

            public ReklamaView()
            {

            }
        }
}
