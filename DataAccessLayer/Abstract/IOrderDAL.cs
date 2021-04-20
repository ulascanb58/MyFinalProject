using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IOrderDAL:IEntityRepository<Order>
    {

    }
}
