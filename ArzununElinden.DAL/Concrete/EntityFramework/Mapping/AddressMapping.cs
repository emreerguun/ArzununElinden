using ArzununElinden.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.DAL.Concrete.EntityFramework.Mapping
{
    class AddressMapping:EntityTypeConfiguration<Addresses>
    {
        public AddressMapping()
        {
            HasKey(x => x.AddressID);

            HasRequired(a => a.Person).WithMany(a => a.Addresses).HasForeignKey(a => a.PersonID).WillCascadeOnDelete(false);

            Property(a => a.AddressName).IsRequired().HasMaxLength(30);
            Property(x => x.City).IsRequired().HasMaxLength(30);
            Property(x => x.Country).IsRequired().HasMaxLength(30);
            Property(x => x.Province).IsRequired().HasMaxLength(30);
            Property(x => x.FullAddress).IsRequired().HasMaxLength(30);
        }
    }
}
