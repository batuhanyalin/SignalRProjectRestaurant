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
    public class EFMoneyCaseDAL : GenericRepository<MoneyCase>, IMoneyCaseDAL
    {
        public EFMoneyCaseDAL(ProjectContext projectContext) : base(projectContext)
        {

        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new ProjectContext();
            var value = context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
            if (value == null)
            {
                return 0;
            }
            else
            {
                return value;
            }

        }
    }
}
