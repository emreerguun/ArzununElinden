using ArzununElinden.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.DAL.Concrete.EntityFramework.Mapping
{
    class CategoriesMapping:EntityTypeConfiguration<Categories>
    {
        public CategoriesMapping()
        {
            HasKey(a => a.CategoryID);

            Property(a => a.CategoryName).HasMaxLength(50).IsRequired();
        }
    }
}
