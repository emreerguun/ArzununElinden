using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.Entities.Models
{
    public class RecipeCategories : IEntity
    {
        public int RecipeID { get; set; }
        public int CategoryID { get; set; }
    }
}
