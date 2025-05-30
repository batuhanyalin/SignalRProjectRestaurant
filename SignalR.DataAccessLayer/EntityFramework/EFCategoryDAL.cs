using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Context;
using SignalR.DtoLayer.CategoryDto;
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
    public class EFCategoryDAL : GenericRepository<Category>, ICategoryDAL
    {
        public EFCategoryDAL(ProjectContext projectContext) : base(projectContext)
        {

        }

        public int ActiveCategoryCount()
        {
            using var context = new ProjectContext();

            return context.Categories.Count(x => x.CategoryStatus == true);
        }

        public int CategoryCount()
        {
            using var context = new ProjectContext();
            return context.Categories.Count();

        }

        public List<ResultCategoryWithProductCount> CategoryListWithProduct()
        {
            var context = new ProjectContext();

            return context.Categories.Include(x => x.Products).Select(x => new ResultCategoryWithProductCount()
            {
                ProductCount = x.Products.Count,
                CategoryStatus = x.CategoryStatus,
                CategoryName = x.CategoryName,
                CategoryId = x.CategoryId,
            }).ToList();
        }

        public void CategoryStatusChange(int id)
        {
            ProjectContext projectContext = new ProjectContext();
            var value = projectContext.Categories.Find(id);
            if (value.CategoryStatus == true)
            {
                value.CategoryStatus = false;
            }
            else
            {
                value.CategoryStatus = true;
            }
            projectContext.SaveChanges();
        }

        public int PassiveCategoryCount()
        {
            using var context = new ProjectContext();
            return context.Categories.Count(x => x.CategoryStatus == false);
        }
    }
}
