using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class Categories : IEntity
    {
        public Categories()
        {
            Recipes = new HashSet<Recipe>();
        }
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Lütfen Kategori Adını Boş Bırakmayınız.")]
        public string CategoryName { get; set; }
        public int ImageID { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
