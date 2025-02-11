using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class UsersContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           options.UseSqlServer("Server=WILNELP12\\SQLEXPRESS;Initial Catalog=UsersP2;Integrated Security=True; TrustServerCertificate=True;");
        }

        public DbSet<Users> Users { get; set; }

    }
}
