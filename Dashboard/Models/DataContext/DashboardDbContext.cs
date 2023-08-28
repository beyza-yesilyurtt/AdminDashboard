using Dashboard.Models.Personel;
using Dashboard.Models.ProjeTakip;
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
            public DbSet<PersonelProje> PersonelProjeleris { get; set; }

        }

    
}
