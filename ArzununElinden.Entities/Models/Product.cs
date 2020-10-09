using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class Product : IEntity
    {
        public Product()
        {
            Categories = new HashSet<Categories>();
            Images = new HashSet<Images>();
            Comments = new HashSet<Comments>();
        }
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Lütfen Ürün Adını Boş Bırakmayınız.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Lütfen Ürün Detayını Boş Bırakmayınız.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Lütfen Ürün Adedini Boş Bırakmayınız.")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public int Stock { get; set; }
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Buy { get; set; }
        [Required(ErrorMessage = "Lütfen Ürün Satış Fiyatını Boş Bırakmayınız.")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Sale { get; set; }
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Discount { get; set; }
        public int CategoryID { get; set; }
        public DateTime Date { get; set; }
        public int RecipeID { get; set; }

        public virtual ICollection<Categories> Categories { get; set; }
        public virtual ICollection<Images> Images { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
