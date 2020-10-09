using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class Addresses:IEntity
    {
        public int AddressID { get; set; }
        public int PersonID { get; set; }
        public int PostCode { get; set; }
        [Required(ErrorMessage = "Lütfen Ülkenizi Giriniz.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Lütfen Şehrinizi Giriniz.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Lütfen İlçenizi Giriniz.")]
        public string Province { get; set; }
        [Required(ErrorMessage = "Lütfen Açık Adresinizi Boş Bırakmayınız.")]
        public string FullAddress { get; set; }
        [Required(ErrorMessage = "Lütfen Adresinize Bir İsim Veriniz.")]
        public string AddressName { get; set; }

        public Person Person { get; set; }


    }
}
