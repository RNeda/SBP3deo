using ProjekatSBP.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSBP.DTOs
{
    public class AkcijaView
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Grad { get; set; }
        public string Lokacija { get; set; }
        public string FDeljenjeLetaka { get; set; }
        public string FSusretSaGradjanima { get; set; }
        public string Vreme { get; set; }
        public string FMiting { get; set; }
        public string FNaOtvorenom { get; set; }
        public string FNaZatvorenom { get; set; }
        public string NazivFirme { get; set; }
        public double CenaProstora { get; set; }
        public int KoordinatorId { get; set; }
        //public Koordinator Koordinator { get; set; }    
        public IList<GostView> GostiMitinga;

        //public AkcijaView(int id, string naziv, string grad, string lok, string fl, string fs, string vreme, string fm, string fo, string fz, string nazivfirme, double cena)
        //{
        //    this.Id = id;
        //    this.Naziv = naziv;
        //    this.Grad = grad;
        //    this.Lokacija = lok;
        //    this.FDeljenjeLetaka = fl;
        //    this.FSusretSaGradjanima = fs;
        //    this.Vreme = vreme;
        //    this.FMiting = fm;
        //    this.FNaOtvorenom = fo;
        //    this.FNaZatvorenom = fz;
        //    this.NazivFirme = nazivfirme;
        //    this.CenaProstora = cena;
        //    //this.Koordinator = koord;
            
        //}

        public AkcijaView(Akcija a)
        {
            Id = a.id;
            Naziv = a.naziv;
            Grad = a.grad;
            Lokacija = a.lokacija;
            FDeljenjeLetaka = a.f_deljenje_letaka;
            FSusretSaGradjanima = a.f_susret_sa_gradjanima;
            Vreme = a.vreme;
            FMiting = a.f_miting;
            FNaOtvorenom = a.f_na_otvorenom;
            FNaZatvorenom = a.f_na_zatvorenom;
            NazivFirme = a.naziv_firme;
            CenaProstora = a.cena_prostora;
            KoordinatorId = a.koordinator.Id;

        }

        public AkcijaView()
        {
            GostiMitinga = new List<GostView>();
        }
    }
}
