using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfServiceKonfirmasiVaksin_20;

namespace WcfServiceKonfirmasiVaksin_20
{
    public class PasienContext : DbContext
    {
        public DbSet<Data_Pasien> data_Pasiens { get; set; }
        public PasienContext() : base("PasienDataCS")
        {

        }
    }
}