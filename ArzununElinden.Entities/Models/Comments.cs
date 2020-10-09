using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class Comments : IEntity
    {
        public int CommentID { get; set; }
        public int PersonID { get; set; }
        [Required(ErrorMessage = "Lütfen Yorumunuzu Boş Bırakmayınız.")]
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int ProductID { get; set; }
        public int CommentNumber { get; set; }
        public virtual Product Product { get; set; }
        public virtual Person  Person { get; set; }
    }
}
