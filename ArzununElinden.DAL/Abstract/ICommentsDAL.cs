using ArzununElinden.Core.DataAccess.EntityFramework;
using ArzununElinden.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzununElinden.DAL.Abstract
{
    public interface ICommentsDAL:IEntityRepository<Comments>
    {
    }
}
