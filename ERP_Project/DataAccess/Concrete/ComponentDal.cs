using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Data.Entity; 

namespace DataAccess.Concrete
{
    public class ComponentDal :EntityRepositoryBase<Components,Context>, IComponentDal
    {
    }
}
