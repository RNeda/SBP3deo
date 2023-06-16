using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ProjekatSBP.DTOs;
using ProjekatSBP.Entiteti;

namespace ProjekatSBP
{
    public class DataProvider
    {

        #region Glasacko Mesto

        public static List<GlasackoMestoView> VratiSvaGlasackaMesta()
        {
            List<GlasackoMestoView> glasackaMesta = new List<GlasackoMestoView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.GlasackoMesto> svaGlasackaMesta = from o in s.Query<ProjekatSBP.Entiteti.GlasackoMesto>()
                                                                                   select o;
                foreach (ProjekatSBP.Entiteti.GlasackoMesto g in svaGlasackaMesta)
                {
                    glasackaMesta.Add(new GlasackoMestoView(g));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return glasackaMesta;
        }

        public static void DodajGlasackoMesto(GlasackoMestoView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.GlasackoMesto g = new ProjekatSBP.Entiteti.GlasackoMesto();

                g.NazivIzborneJedinice = p.NazivIzborneJedinice;
                g.BrGlasackogMesta = p.BrGlasackogMesta;
                g.BrBiraca = p.BrBiraca;

                s.SaveOrUpdate(g);
                //s.Save(g)

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static void ObrisiGlasackoMesto(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.GlasackoMesto g = s.Load<Entiteti.GlasackoMesto>(p);

                s.Delete(g);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static GlasackoMestoView VratiGlasackoMesto(int id)
        {
            GlasackoMestoView pb = new GlasackoMestoView();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.GlasackoMesto o = s.Load<ProjekatSBP.Entiteti.GlasackoMesto>(id);
                pb = new GlasackoMestoView(o);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }

            return pb;
        }

        public static void AzurirajGlasackoMesto(GlasackoMestoView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.GlasackoMesto o = s.Load<ProjekatSBP.Entiteti.GlasackoMesto>(p.Id);


                o.NazivIzborneJedinice = p.NazivIzborneJedinice;
                o.BrGlasackogMesta = p.BrGlasackogMesta;
                o.BrBiraca = p.BrBiraca;


                s.SaveOrUpdate(o);
                //s.Save(g)

                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                //handle exceptin
            }
        }
        #endregion
        #region Krugovi

        public static List<KrugoviView> VratiSveKrugove()
        {
            List<KrugoviView> krugovi = new List<KrugoviView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.Krugovi> sviKrugovi = from o in s.Query<ProjekatSBP.Entiteti.Krugovi>()
                                                                       select o;
                foreach (ProjekatSBP.Entiteti.Krugovi k in sviKrugovi)
                {
                    krugovi.Add(new KrugoviView(k));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return krugovi;
        }

        public static void DodajKrug(KrugoviView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Krugovi k = new ProjekatSBP.Entiteti.Krugovi();

                k.BrKruga = p.BrKruga;
                k.BrBiracaIzasli = p.BrBiracaIzasli;
                k.ProcenatZa = p.ProcenatZa;

                s.SaveOrUpdate(k);
                //s.Save(k)

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static void ObrisiKrug(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Krugovi k = s.Load<Entiteti.Krugovi>(p);

                s.Delete(k);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static KrugoviView VratiKrug(int id)
        {
            KrugoviView pb = new KrugoviView();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Krugovi o = s.Load<ProjekatSBP.Entiteti.Krugovi>(id);
                pb = new KrugoviView(o);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }

            return pb;
        }

        public static void AzurirajKrug(KrugoviView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Krugovi k = s.Load<ProjekatSBP.Entiteti.Krugovi>(p.Id);

                k.BrKruga = p.BrKruga;
                k.BrBiracaIzasli = p.BrBiracaIzasli;
                k.ProcenatZa = p.ProcenatZa;



                s.SaveOrUpdate(k);
                //s.Save(g)

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptin
            }

        }
        #endregion
        #region Koordinator
        public static List<KoordinatorView> VratiSveKoordinator()
        {
            List<KoordinatorView> koordinatori = new List<KoordinatorView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.Koordinator> sviKoordinatori = from o in s.Query<ProjekatSBP.Entiteti.Koordinator>()
                                                                                select o;


                foreach (Koordinator u in sviKoordinatori)
                {
                    //koordinatori.Add(new KoordinatorView(u));
                    var koordinator = new KoordinatorView(u);
                    koordinator.Pomocnici = u.Pomocnici.Select(u => new PomocnikView(u)).ToList();
                    koordinatori.Add(koordinator);
                }
                s.Close();
            }
            catch (Exception ec)
            {
               //handle exception
            }
            return koordinatori;
        }

        public static void DodajKoordinatora(KoordinatorView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Koordinator u = new ProjekatSBP.Entiteti.Koordinator();

                u.LIme = p.Ime;
                u.ImeRoditelja = p.ImeRoditelja;
                u.Prezime = p.Prezime;
                u.DatumRodjenja = p.DatumRodjenja;
                u.Adresa = p.Adresa;
                u.BrTel1 = p.BrTel;
                u.Email1 = p.Email;
                u.ImeOpstine = p.ImeOpstine;
                u.AdresaKancelarije = p.AdresaKancelarije;

                s.SaveOrUpdate(u);
                //s.Save(o)

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static void ObrisiKoordinatora(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Koordinator u = s.Load<Entiteti.Koordinator>(p);

                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static KoordinatorView VratiKoordinatora(int id)
        {
            KoordinatorView pb = new KoordinatorView();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Koordinator o = s.Load<ProjekatSBP.Entiteti.Koordinator>(id);
                pb = new KoordinatorView(o);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }

            return pb;
        }

        public static void AzurirajKoordinator(KoordinatorView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Koordinator o = s.Load<ProjekatSBP.Entiteti.Koordinator>(p.Id);
                o.LIme = p.Ime;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrTel1 = p.BrTel;
                o.Email1 = p.Email;
                o.ImeOpstine = p.ImeOpstine;
                o.AdresaKancelarije = p.AdresaKancelarije;

                s.SaveOrUpdate(o);
                //s.Save(g)

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptin
            }

        }
        #endregion
        #region Pomocnik
        public static List<PomocnikView> VratiSvePomocnike()
        {
            List<PomocnikView> pomocnici = new List<PomocnikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.Pomocnik> sviPomocnici = from o in s.Query<ProjekatSBP.Entiteti.Pomocnik>()
                                                                          select o;


                foreach (Pomocnik u in sviPomocnici)
                {
                    pomocnici.Add(new PomocnikView(u));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return pomocnici;
        }
        public static List<PomocnikView> VratiSvePomocKoordinatora(int kor)
        {
            List<PomocnikView> pomocnici = new List<PomocnikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pomocnik> sviPom = from o in s.Query<Pomocnik>()
                                               where o.PripadaKoordinatoru.Id == kor
                                               select o;

                foreach (Pomocnik u in sviPom)
                {
                    pomocnici.Add(new PomocnikView(u));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return pomocnici;
        }
        public static void DodajPomocnikaKoordinatoru(PomocnikView p, int idK)
        {
           try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Pomocnik u = new ProjekatSBP.Entiteti.Pomocnik();
                Entiteti.Koordinator k = s.Load<Entiteti.Koordinator>(idK);
                if (k.Pomocnici.Count < 4)
                {
                    u.LIme = p.Ime;
                    u.ImeRoditelja = p.ImeRoditelja;
                    u.Prezime = p.Prezime;
                    u.DatumRodjenja = p.DatumRodjenja;
                    u.Adresa = p.Adresa;
                    u.BrTel1 = p.BrTel;
                    u.Email1 = p.Email;
                    u.PripadaKoordinatoru = k;
                    s.SaveOrUpdate(u);
                    //s.Save(o)

                    s.Flush();
                    s.Close();
                }
                else
                {
                    Console.Write( "Koordinator vec ima max broj pomoćnika(4)");
                    s.Close();
                }

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static void DodajPomocnika(PomocnikView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Pomocnik u = new ProjekatSBP.Entiteti.Pomocnik();

                u.LIme = p.Ime;
                u.ImeRoditelja = p.ImeRoditelja;
                u.Prezime = p.Prezime;
                u.DatumRodjenja = p.DatumRodjenja;
                u.Adresa = p.Adresa;
                u.BrTel1 = p.BrTel;
                u.Email1 = p.Email;

                s.SaveOrUpdate(u);
                //s.Save(o)

                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static void ObrisiPomocnika(int p)
        {
            try
             {
                 ISession s = DataLayer.GetSession();

                 Entiteti.Pomocnik u = s.Load<Entiteti.Pomocnik>(p);

                 s.Delete(u);
                 s.Flush();
                 s.Close();

             }
             catch (Exception ec)
             {
                 //handle exception
             }
        }

        public static PomocnikView VratiPomocnika(int id)
        {
            PomocnikView pb = new PomocnikView();
             try
             {
                 ISession s = DataLayer.GetSession();

                 ProjekatSBP.Entiteti.Pomocnik o = s.Load<ProjekatSBP.Entiteti.Pomocnik>(id);
                 pb = new PomocnikView(o);

                 s.Close();
             }
             catch (Exception ec)
             {
                 //handle exception
             }
            
            return pb;
        }



        public static void AzurirajPomocnika(PomocnikView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Pomocnik o = s.Load<ProjekatSBP.Entiteti.Pomocnik>(p.Id);
                o.LIme = p.Ime;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrTel1 = p.BrTel;
                o.Email1 = p.Email;


                s.SaveOrUpdate(o);
                //s.Save(g)

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptin
            }

        }
    

        #endregion
        #region Aktivista
        public static List<AktivistaView> VratiSveAktiviste()
        {
            List<AktivistaView> aktiviste = new List<AktivistaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.Aktivista> sveAktiviste = from o in s.Query<ProjekatSBP.Entiteti.Aktivista>()
                                                                           select o;


                foreach (Aktivista u in sveAktiviste)
                {
                    aktiviste.Add(new AktivistaView(u));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return aktiviste;
        }

        public static void DodajAktivistu(AktivistaView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista u = new ProjekatSBP.Entiteti.Aktivista();

                u.LIme = p.Ime;
                u.ImeRoditelja = p.ImeRoditelja;
                u.Prezime = p.Prezime;
                u.DatumRodjenja = p.DatumRodjenja;
                u.Adresa = p.Adresa;
                u.BrTel1 = p.BrTel;
                u.Email1 = p.Email;

                s.SaveOrUpdate(u);
                //s.Save(o)

                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static void ObrisiAktivistu(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Aktivista u = s.Load<Entiteti.Aktivista>(p);

                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exception
            }
        }

        public static AktivistaView VratiAktivistu(int id)
        {
            AktivistaView pb = new AktivistaView();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista o = s.Load<ProjekatSBP.Entiteti.Aktivista>(id);
                pb = new AktivistaView(o);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exception
            }
            return pb;
        }

        public static void AzurirajAktivistu(AktivistaView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista o = s.Load<ProjekatSBP.Entiteti.Aktivista>(p.Id);
                o.LIme = p.Ime;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrTel1 = p.BrTel;
                o.Email1 = p.Email;


                s.SaveOrUpdate(o);
                //s.Save(g)

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptin
            }

        }
        public static void PoveziAktivistuSaGM(int IdAkt, int IdGM)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista a = s.Load<ProjekatSBP.Entiteti.Aktivista>(IdAkt);
                ProjekatSBP.Entiteti.GlasackoMesto g = s.Load<GlasackoMesto>(IdGM);
                a.PripadaGlasackomMestu = g;
                g.Aktivisti.Add(a);

                s.SaveOrUpdate(a);
                //s.Save(g)
                //s.Update(a);
                s.Flush();
                s.Close();
            
            }
            catch (Exception ec)
            {
                 //handle exceptin
            }

        }

        public static void DodajPrimedbu(int id, string po)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Aktivista a = s.Load<ProjekatSBP.Entiteti.Aktivista>(id);
                a.Primedbe = po;


                s.SaveOrUpdate(a);
                //s.Save(g)
                //s.Update(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptin
            }

        }

        #endregion


     
        #region IntervjuNovine
        public static List<IntervjuNovineView> VratiSveIntervjue()
        {
            List<IntervjuNovineView> intervjui = new List<IntervjuNovineView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.IntervjuNovine> sviIntervjui = from o in s.Query<ProjekatSBP.Entiteti.IntervjuNovine>()
                                                                                select o;

                foreach (ProjekatSBP.Entiteti.IntervjuNovine i in sviIntervjui)
                {
                    intervjui.Add(new IntervjuNovineView(i));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return intervjui;
        }

        public static void DodajIntervjuNovine(IntervjuNovineView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.IntervjuNovine o = new ProjekatSBP.Entiteti.IntervjuNovine();

                o.NazivLista = p.NazivLista;
                o.DatumPisanja = p.DatumPisanja;
                o.DatumObjavljivanja = p.DatumObjavljivanja;
                o.Novinar1 = p.Novinar1;
                o.Novinar2 = p.Novinar2;


                s.SaveOrUpdate(o);
                //s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        public static void ObrisiIntervju(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.IntervjuNovine u = s.Load<Entiteti.IntervjuNovine>(p);

               
                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        

        public static void AzurirajIntervju(IntervjuNovineView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.IntervjuNovine o = s.Load<ProjekatSBP.Entiteti.IntervjuNovine>(p.Id);
                o.NazivLista = p.NazivLista;
                o.DatumPisanja = p.DatumPisanja;
                o.DatumObjavljivanja = p.DatumObjavljivanja;
                o.Novinar1 = p.Novinar1;
                o.Novinar2 = p.Novinar2;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion

        #region TVIRadioEmisije
        public static List<TVIRadioEmisijeView> VratiSveEmisije()
        {
            List<TVIRadioEmisijeView> emisije = new List<TVIRadioEmisijeView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.TVIRadioEmisije> sveEmisije = from o in s.Query<ProjekatSBP.Entiteti.TVIRadioEmisije>()
                                                                               select o;

                foreach (ProjekatSBP.Entiteti.TVIRadioEmisije i in sveEmisije)
                {
                    emisije.Add(new TVIRadioEmisijeView(i));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return emisije;
        }
        public static void DodajEmisiju(TVIRadioEmisijeView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVIRadioEmisije o = new ProjekatSBP.Entiteti.TVIRadioEmisije();

                o.NazivStanice = p.NazivStanice;
                o.NazivEmisije = p.NazivEmisije;
                o.ImeVoditelja = p.ImeVoditelja;
                o.Gledanost = p.Gledanost;


                s.SaveOrUpdate(o);
                //s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        
        public static TVIRadioEmisijeView AzurirajEmisiju(TVIRadioEmisijeView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVIRadioEmisije o = s.Load<ProjekatSBP.Entiteti.TVIRadioEmisije>(p.Id);
                o.NazivStanice = p.NazivStanice;
                o.NazivEmisije = p.NazivEmisije;
                o.ImeVoditelja = p.ImeVoditelja;
                o.Gledanost = p.Gledanost;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static void ObrisiEmisiju(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.TVIRadioEmisije u = s.Load<Entiteti.TVIRadioEmisije>(p);

                
                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion
        #region TVDueli
        public static List<TVDueliView> VratiSveTVDuele()
        {
            List<TVDueliView> dueli = new List<TVDueliView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSBP.Entiteti.TVDueli> sviTVDueli = from o in s.Query<ProjekatSBP.Entiteti.TVDueli>()
                                                                       select o;

                foreach (ProjekatSBP.Entiteti.TVDueli i in sviTVDueli)
                {
                    dueli.Add(new TVDueliView(i));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return dueli;
        }
        public static void DodajDuel(TVDueliView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVDueli o = new ProjekatSBP.Entiteti.TVDueli();

                o.NazivStanice = p.NazivStanice;
                o.NazivEmisije = p.NazivEmisije;
                o.ImeVoditelja = p.ImeVoditelja;
                o.Gledanost = p.Gledanost;


                s.SaveOrUpdate(o);
                //s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        public static TVDueliView VratiDuel(int id)
        {
            TVDueliView pb = new TVDueliView();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVDueli o = s.Load<ProjekatSBP.Entiteti.TVDueli>(id);
                pb = new TVDueliView(o);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }
        public static TVDueliView AzurirajDuel(TVDueliView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.TVDueli o = s.Load<ProjekatSBP.Entiteti.TVDueli>(p.Id);
                o.NazivStanice = p.NazivStanice;
                o.NazivEmisije = p.NazivEmisije;
                o.ImeVoditelja = p.ImeVoditelja;
                o.Gledanost = p.Gledanost;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static void ObrisiDuel(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.TVDueli u = s.Load<Entiteti.TVDueli>(p);

                
                s.Delete(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion
        #region SpisakPitanja
        

        public static List<SpisakPitanjaView> VratiPitanjaDuela()
        {
            List<SpisakPitanjaView> odInfos = new List<SpisakPitanjaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SpisakPitanja> pitanja = from o in s.Query<SpisakPitanja>()
                                                     
                                                     select o;


                foreach (SpisakPitanja o in pitanja)
                {
                    odInfos.Add(new SpisakPitanjaView(o));
                }

                s.Close();

            }
            catch (Exception ec)
            {

            }

            return odInfos;
        }

        public static void SacuvajPitanje(SpisakPitanja pitanje, int idD)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpisakPitanja o = new SpisakPitanja();


                ProjekatSBP.Entiteti.TVDueli p = s.Load<ProjekatSBP.Entiteti.TVDueli>(idD);
                o = pitanje;
                o.Id.Pitanje = pitanje.Id.Pitanje;
                o.Id.PripadaTVDuelu = p;

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        public static void ObrisiPitanje(SpisakPitanja pit, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakPitanja o = new SpisakPitanja();
                ProjekatSBP.Entiteti.TVDueli p = s.Load<ProjekatSBP.Entiteti.TVDueli>(id);
                o = pit;
                o.Id.Pitanje = pit.Id.Pitanje;
                o.Id.PripadaTVDuelu = p;

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion
        #region Protivkandidati
        

        public static List<ProtivkandidatiView> VratiProtivkandidateDuela()
        {
            List<ProtivkandidatiView> odInfos = new List<ProtivkandidatiView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Protivkandidati> protiv = from o in s.Query<Protivkandidati>()
                                                      select o;


                foreach (Protivkandidati o in protiv)
                {
                    odInfos.Add(new ProtivkandidatiView(o));
                }

                s.Close();

            }
            catch (Exception ec)
            {

            }

            return odInfos;
        }
        public static void SacuvajProtivkandidata(Protivkandidati protiv, int idD)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Protivkandidati o = new Protivkandidati();

                ProjekatSBP.Entiteti.TVDueli p = s.Load<ProjekatSBP.Entiteti.TVDueli>(idD);
                o = protiv;
                o.Id.Protivkandidat = protiv.Id.Protivkandidat;
                o.Id.PripadaTVDuelu = p;

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        public static void ObrisiProtivkandidata(Protivkandidati pit, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Protivkandidati o = new Protivkandidati();
                ProjekatSBP.Entiteti.TVDueli p = s.Load<ProjekatSBP.Entiteti.TVDueli>(id);
                o = pit;
                o.Id.Protivkandidat = pit.Id.Protivkandidat;
                o.Id.PripadaTVDuelu = p;

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        #endregion


        #region Reklama
        public static List<ReklamaView> VratiSveReklame()
        {
            List<ReklamaView> reklame = new List<ReklamaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Reklama> sveReklame = from r in s.Query<ProjekatSBP.Entiteti.Reklama>()
                                                                       select r;
                foreach (ProjekatSBP.Entiteti.Reklama r in sveReklame)
                {
                    reklame.Add(new ReklamaView(r.id, r.cena, r.vremenski_period, r.f_pano, r.grad, r.ulica, r.povrsina, r.agencija, r.f_novine, r.naziv_novina, r.boja, r.f_radio_tv, r.naziv_radio_tv, r.br_emitovanja, r.trajanje));
                }
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reklame;
        }

        public static void DodajReklamu(ReklamaView r)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProjekatSBP.Entiteti.Reklama o = new ProjekatSBP.Entiteti.Reklama();
                o.cena = r.CenaReklame;
                o.vremenski_period = r.VremenskiPeriod;
                o.f_pano = r.FPano;
                o.grad = r.Grad;
                o.ulica = r.Ulica;
                o.povrsina = r.Povrsina;
                o.agencija = r.Agencija;
                o.f_novine = r.FNovine;
                o.naziv_novina = r.NazivNovina;
                o.boja = r.Boja;
                o.f_radio_tv = r.FRadioTv;
                o.naziv_radio_tv = r.NazivRadioTv;
                o.br_emitovanja = r.BrEmitovanja;
                o.trajanje = r.Trajanje;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void AzurirajReklamu(ReklamaView r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Reklama o = s.Load<ProjekatSBP.Entiteti.Reklama>(r.ReklamaId);
                o.cena = r.CenaReklame;
                o.vremenski_period = r.VremenskiPeriod;
                o.f_pano = r.FPano;
                o.grad = r.Grad;
                o.ulica = r.Ulica;
                o.povrsina = r.Povrsina;
                o.agencija = r.Agencija;
                o.f_novine = r.FNovine;
                o.naziv_novina = r.NazivNovina;
                o.boja = r.Boja;
                o.f_radio_tv = r.FRadioTv;
                o.naziv_radio_tv = r.NazivRadioTv;
                o.br_emitovanja = r.BrEmitovanja;
                o.trajanje = r.Trajanje;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }


        public static ReklamaView VratiReklamu(int id)
        {
            ReklamaView rb = new ReklamaView();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Reklama o = s.Load<ProjekatSBP.Entiteti.Reklama>(id);
                rb = new ReklamaView(o.id, o.cena, o.vremenski_period, o.f_pano, o.grad, o.ulica, o.povrsina, o.agencija, o.f_novine, o.naziv_novina, o.boja, o.f_radio_tv, o.naziv_radio_tv, o.br_emitovanja, o.trajanje);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rb;
        }

        public static void ObrisiReklamu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Reklama o = s.Load<ProjekatSBP.Entiteti.Reklama>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region Akcija

        public static void DodajKoordinatoraAkciji(AkcijaView a, int koordID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Akcija o = new ProjekatSBP.Entiteti.Akcija();
                Entiteti.Koordinator k = s.Load<Entiteti.Koordinator>(koordID);
                o.naziv = a.Naziv;
                o.grad = a.Grad;
                o.lokacija = a.Lokacija;
                o.f_deljenje_letaka = a.FDeljenjeLetaka;
                o.f_susret_sa_gradjanima = a.FSusretSaGradjanima;
                o.vreme = a.Vreme;
                o.f_miting = a.FMiting;
                o.f_na_otvorenom = a.FNaOtvorenom;
                o.f_na_zatvorenom = a.FNaZatvorenom;
                o.naziv_firme = a.NazivFirme;
                o.cena_prostora = a.CenaProstora;
                o.koordinator = k;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<AkcijaView> VratiSveAkcije()
        {
            List<AkcijaView> akcije = new List<AkcijaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Akcija> sveAkcije = from a in s.Query<ProjekatSBP.Entiteti.Akcija>()
                                                                     select a;
                foreach (ProjekatSBP.Entiteti.Akcija a in sveAkcije)
                {
                    akcije.Add(new AkcijaView(a));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return akcije;
        }



        public static void DodajAkciju(AkcijaView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProjekatSBP.Entiteti.Akcija o = new ProjekatSBP.Entiteti.Akcija();
                o.naziv = a.Naziv;
                o.grad = a.Grad;
                o.lokacija = a.Lokacija;
                o.f_deljenje_letaka = a.FDeljenjeLetaka;
                o.f_susret_sa_gradjanima = a.FSusretSaGradjanima;
                o.vreme = a.Vreme;
                o.f_miting = a.FMiting;
                o.f_na_otvorenom = a.FNaOtvorenom;
                o.f_na_zatvorenom = a.FNaZatvorenom;
                o.naziv_firme = a.NazivFirme;
                o.cena_prostora = a.CenaProstora;
                o.koordinator.Id= a.KoordinatorId;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AzurirajAkciju(AkcijaView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Akcija o = s.Load<ProjekatSBP.Entiteti.Akcija>(a.Id);
                o.naziv = a.Naziv;
                o.grad = a.Grad;
                o.lokacija = a.Lokacija;
                o.naziv = a.Naziv;
                o.grad = a.Grad;
                o.lokacija = a.Lokacija;
                o.f_deljenje_letaka = a.FDeljenjeLetaka;
                o.f_susret_sa_gradjanima = a.FSusretSaGradjanima;
                o.vreme = a.Vreme;
                o.f_miting = a.FMiting;
                o.f_na_otvorenom = a.FNaOtvorenom;
                o.f_na_zatvorenom = a.FNaZatvorenom;
                o.naziv_firme = a.NazivFirme;
                o.cena_prostora = a.CenaProstora;
                
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public static AkcijaView vratiAkciju(int id)
        {
            AkcijaView ab = new AkcijaView();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Akcija o = s.Load<ProjekatSBP.Entiteti.Akcija>(id);
                ab = new AkcijaView(o);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ab;
        }

        public static Akcija VratiAkciju(int id)
        {
            Akcija a = new Akcija();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Akcija o = s.Load<ProjekatSBP.Entiteti.Akcija>(id);
                a = o;

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return a;
        }

       
        public static void ObrisiAkciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Akcija o = s.Load<ProjekatSBP.Entiteti.Akcija>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<AkcijaView> MitingGosti(int idGosta)  
        {
            List<AkcijaView> mitinzi = new List<AkcijaView>();
            
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Akcija> sveAkcije = from g in s.Query<ProjekatSBP.Entiteti.Akcija>()
                                                                     where g.gosti_mitinga.Contains((VratiGosta(idGosta)))
                                                                     select g;
                foreach (ProjekatSBP.Entiteti.Akcija g in sveAkcije)
                {
                    mitinzi.Add(new AkcijaView(g));
                   
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return mitinzi;
        }
        #endregion
        #region Gost
        public static List<GostView> VratiSveGoste()
        {
            List<GostView> gosti = new List<GostView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProjekatSBP.Entiteti.Gost> sviGosti = from g in s.Query<ProjekatSBP.Entiteti.Gost>()
                                                                  select g;
                foreach (ProjekatSBP.Entiteti.Gost g in sviGosti)
                {
                    gosti.Add(new GostView(g.id, g.ime, g.prezime, g.funkcija));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return gosti;
        }

        public static void DodajGosta(Gost g, int idMitinga)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Gost gost = new Gost();

                
                gost = g;
                
                Akcija a = VratiAkciju(idMitinga);
                gost.mitinzi.Add(a);
                
                
                s.SaveOrUpdate(gost);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AzurirajGosta(GostView g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Gost o = s.Load<ProjekatSBP.Entiteti.Gost>(g.Id);
                o.ime = g.Ime;
                o.prezime = g.Prezime;
                o.funkcija = g.Funkcija;
                
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public static GostView vratiGosta(int id)
        {
            GostView gb = new GostView();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Gost o = s.Load<ProjekatSBP.Entiteti.Gost>(id);
                gb = new GostView(o.id, o.ime, o.prezime, o.funkcija);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return gb;
        }

        public static Gost VratiGosta(int id)
        {
            Gost g = new Gost();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Gost o = s.Load<ProjekatSBP.Entiteti.Gost>(id);
                g = o;

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return g;
        }

        public static void ObrisiGosta(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSBP.Entiteti.Gost o = s.Load<ProjekatSBP.Entiteti.Gost>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<GostView> GostiNaMitingu(int idMitinga)  
        {
            List<GostView> gosti = new List<GostView>();
            try
            {
                ISession s = DataLayer.GetSession();
                ProjekatSBP.Entiteti.Akcija a = VratiAkciju(idMitinga);
                IEnumerable<ProjekatSBP.Entiteti.Gost> sviGosti = from g in s.Query<ProjekatSBP.Entiteti.Gost>()
                                                                  where g.mitinzi.Contains((VratiAkciju(idMitinga)))
                                                                  select g;
                foreach (ProjekatSBP.Entiteti.Gost g in sviGosti)
                {
                    
                    gosti.Add(new GostView(g.id,g.ime,g.prezime,g.funkcija));
                   
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return gosti;
        }
        #endregion





    }



}





