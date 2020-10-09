using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class Recipe : IEntity
    {
        public Recipe()
        {
            Images = new HashSet<Images>();
            Categories = new HashSet<Categories>();
        }
        public int RecipeID { get; set; }
        [Required(ErrorMessage = "Lütfen Tarif Adını Boş Bırakmayınız.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Tarif Açıklamasını Boş Bırakmayınız.")]
        public string Description { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Images> Images { get; set; }
        public virtual ICollection<Categories> Categories { get; set; }

    }
}
