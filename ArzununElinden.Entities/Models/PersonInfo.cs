using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class PersonInfo : IEntity
    {
        public int PersonInfoID { get; set; }
        public int PersonID { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen E-mail Adresinizi Giriniz.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail Adresiniz Geçerli Değil.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz.")]
        public string Phone { get; set; }

        public Person Person { get; set; }


    }
}
