using SignalR.DtoLayer.CategoryDto;
using SignalRProjectRestaurant.BusinessLayer.Abstract;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
        public List<ResultCategoryWithProductCount> TCategoryListWithProduct();
        public void TCategoryStatusChange(int id);
    }
}
