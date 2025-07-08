﻿using FIT.Data;
using FIT.Data.IB210240;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Semestar> Semestri { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<PolozenPredmet> PolozeniPredmeti { get; set; }
        public DbSet<Prostorija> Prostorije { get; set; }
        public DbSet<Nastava> Nastava { get; set; }
        public DbSet<Prisustvo> Prisustva { get; set; }

    }
}