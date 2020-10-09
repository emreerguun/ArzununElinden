using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class Images : IEntity
    {
        public int ImageID { get; set; }
        [Required(ErrorMessage = "Lütfen Resim Yolunu Boş Bırakmayınız.")]
        public string Path { get; set; }
        [Required(ErrorMessage = "Lütfen Resim Adını Boş Bırakmayınız.")]
        public string Name { get; set; }
        public string Alt { get; set; }
        public char Role { get; set; }
        [Required(ErrorMessage = "Lütfen Buton Metnini Boş Bırakmayınız.")]
        public string ButtonText { get; set; }
        public string Title { get; set; }
        public int RecipeID { get; set; }
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Images Image { get; set; }


    }
}
