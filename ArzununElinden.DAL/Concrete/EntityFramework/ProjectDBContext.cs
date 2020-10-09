using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ArzununElinden.Entities.Models;

namespace ArzununElinden.DAL.Concrete.EntityFramework
{
    public class ProjectDBContext : DbContext
    {/*@"Server=EMRE\SQLEXPRESS; Database = ArzununElinden;uid=admin; pwd = 321;"*/
        public ProjectDBContext() : base(/*connectionstring*/)
        {

        }

        public DbSet<Addresses> Adress { get; set; }
        public DbSet<Categories> Category { get; set; }
        public DbSet<Comments> Comment { get; set; }
        public DbSet<Images> Image { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonInfo> PersonInfo { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Roles> Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
        }
    }
}
