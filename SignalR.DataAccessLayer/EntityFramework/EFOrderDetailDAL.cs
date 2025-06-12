using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Context;
using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.API.DataAccessLayer.Repositories;
using SignalRProjectRestaurant.DataAccessLayer.Abstract;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFOrderDetailDAL : GenericRepository<OrderDetail>, IOrderDetailDAL
    {
        public EFOrderDetailDAL(ProjectContext projectContext) : base(projectContext)
        {
          
        }
    }
}
