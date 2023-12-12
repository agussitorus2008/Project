using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfServiceRegistrasiVaksin_20;

namespace WcfServiceRegistrasiVaksin_20
{
    public class VaksinContext : DbContext
    {

        public DbSet<VaksinData> VaksinDatas { get; set; }
        public VaksinContext() : base("VaksinDataCS")
        {

        }
    }
}