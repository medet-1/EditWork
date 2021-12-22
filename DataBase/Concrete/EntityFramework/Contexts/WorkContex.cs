using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class WorkContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       
            //         optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;initial catalog=Calisma;integrated security=true ");
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = Calisma; Trusted_Connection = True");
    //        Server = myServerAddress; Database = IDatabase; Trusted_Connection = True;
        }


        public DbSet<Work> Works { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Statu> Status { get; set; }
        
    }
}
