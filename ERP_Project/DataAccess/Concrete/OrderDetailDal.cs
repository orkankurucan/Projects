﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class OrderDetailDal : EntityRepositoryBase<OrderDetail,Context>, IOrderDetailDal
    {
    }
}
