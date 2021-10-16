using System;
using Microsoft.EntityFrameworkCore;

namespace Menghi.Massimo._5H.PrimoEF.Models
{
    public class DbPersone : DbContext
    {
        // Tabella di Persone
        public DbSet<Persona> Persone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=dbPersone.db");
        }
    }
}