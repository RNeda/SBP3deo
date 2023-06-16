using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using ProjekatSBP.Mapiranja;

namespace ProjekatSBP
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();


        //funkcija na zahtev otvara sesiju
        public static ISession GetSession()
        {
            //ukoliko session factory nije kreiran
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        //konfiguracija i kreiranje session factory
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ConnectionString(c =>
                    c.Is("DATA SOURCE=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;PERSIST SECURITY INFO=True;USER ID=S18348;Password=S18348"));

                return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UcesnikMapiranja>())
                    //.ExposeConfiguration(BuildSchema)
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                //System.Windows.Forms.MessageBox.Show(ec.Message);
                return null;
            }

        }
    }
}
