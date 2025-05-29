using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Context;
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
    public class EFSocialMediaDAL : GenericRepository<SocialMedia>, ISocialMediaDAL
    {
        public EFSocialMediaDAL(ProjectContext projectContext) : base(projectContext)
        {

        }

        public void ChangeStatus(int id)
        {
            var context = new ProjectContext();
            var value = context.SocialMedias.Find(id);
            if (value.Status == true)
            {
                value.Status = false;
            }
            else
            {
                value.Status = true;
            }
            context.SaveChanges();
        }
    }
}
