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
    public class EFClientTableDAL : GenericRepository<ClientTable>, IClientTableDAL
    {
        public EFClientTableDAL(ProjectContext projectContext) : base(projectContext)
        {
          
        }

        public int ClientTableCount()
        {
            using var context = new ProjectContext();
            return context.ClientTables.Count();
        }
    }
}
