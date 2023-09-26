using Dashboard.Models.Müşteri;
using Dashboard.Models.Personel;
using Dashboard.Models.ProjeTakip;
using Dashboard.Models.Satis;
using Dashboard.Models.Urunler;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dashboard.Models.DataContext
{
    public class DashboardDbContext : DbContext
    {
            public DashboardDbContext() : base("DashboardDb")
            {

            }

            public DbSet<PersonelBilgileri> PersonelBilgileris { get; set; }
            public DbSet<PersonelProje> PersonelProjes { get; set; }
            public DbSet<MusteriBilgi> MusteriBilgis { get; set; }
            public DbSet<UrunBilgi> UrunBilgis { get; set; }
            public DbSet<SatisBilgi> SatisBilgis { get; set; }
       

    }


}
