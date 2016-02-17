using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.DataEntites;
using Lumia_Trial.DataAccess.entites;

namespace Lumia_Trial.DataAccess.Context
{
    public class LumiaContext : DbContext
    {

        public LumiaContext() : base("LumiaContext")
        {
        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<SelectionDate> SelectionDates { get; set; }

        public DbSet<TimeFrame> TimeFrames { get; set; }

        public DbSet<HandsetOpotunity> HandsetOpotunitieses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}