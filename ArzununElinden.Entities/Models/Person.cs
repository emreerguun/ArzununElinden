using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class Person : IEntity
    {
        public Person()
        {
            Comments = new HashSet<Comments>();
            Addresses = new HashSet<Addresses>();
        }
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Lütfen Adınızı Boş Bırakmayınız.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Boş Bırakmayınız.")]
        public string Surname { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public Roles Role { get; set; }
        public ICollection<Addresses> Addresses { get; set; }
        public PersonInfo PersonInfo { get; set; }

    }
}
