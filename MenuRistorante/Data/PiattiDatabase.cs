using System;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;


namespace MenuRistorante.Data
{
    public class PiattiDatabase : DbContext
    {
        public DbSet<PiattiRistorante> TabellaPiatti { get; set; }

        public PiattiDatabase(DbContextOptions options) : base(options) { }
    }
}
