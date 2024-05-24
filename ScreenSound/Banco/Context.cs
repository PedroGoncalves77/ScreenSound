using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class Context : DbContext
    {
        public DbSet<Musica> Musica { get; set; }
        public DbSet<Artista> Artista { get; set; }
        private string strincgConnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound2U;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(strincgConnection).UseLazyLoadingProxies();
        }
    }
}
