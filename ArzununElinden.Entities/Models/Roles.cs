using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class Roles : IEntity
    {
        public int RoleID { get; set; }
        [Required(ErrorMessage = "Lütfen Role Adını Boş Bırakmayınız.")]
        public string RoleName { get; set; }

        public Person Person { get; set; }
    }
}
