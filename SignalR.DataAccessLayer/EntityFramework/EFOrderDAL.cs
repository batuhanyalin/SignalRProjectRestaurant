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
    public class EFOrderDAL : GenericRepository<Order>, IOrderDAL
    {
        public EFOrderDAL(ProjectContext projectContext) : base(projectContext)
        {

        }

        public int ActiveOrderCount()
        {
            using var context = new ProjectContext();
            return context.Orders.Count(x => x.Status == true);
        }

        public decimal LastOrderPrice()
        {
            using var context = new ProjectContext();
            var value = context.Orders.OrderByDescending(x => x.OrderId).FirstOrDefault();
            if (value==null)
            {
                return 0;
            }
            return value.TotalPrice;
        }

        public int PassiveOrderCount()
        {
            using var context = new ProjectContext();
            return context.Orders.Count(x => x.Status == false);
        }

        public decimal TodayTotalPrice()
        {
            using var context= new ProjectContext(); 
            return context.Orders.Where(x=>x.Date.Date==DateTime.Today).Sum(x=>x.TotalPrice);
        }

        public int TotalOrderCount()
        {
            using var context = new ProjectContext();
            return context.Orders.Count();
        }
    }
}
