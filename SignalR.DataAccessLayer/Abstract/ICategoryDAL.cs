using SignalR.DtoLayer.CategoryDto;
using SignalRProjectRestaurant.DataAccessLayer.Abstract;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface ICategoryDAL : IGenericDAL<Category>
    {
        public List<ResultCategoryWithProductCount> CategoryListWithProduct();
        public void CategoryStatusChange(int id);
        public int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();

    }
}
