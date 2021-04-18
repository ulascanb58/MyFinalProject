using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
