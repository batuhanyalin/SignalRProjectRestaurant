using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public List<ResultCategoryWithProductCount> TCategoryListWithProduct()
        {
            return _categoryDAL.CategoryListWithProduct();
        }

        public void TCategoryStatusChange(int id)
        {
            _categoryDAL.CategoryStatusChange(id);
        }

        public void TCreate(Category entity)
        {
            _categoryDAL.Create(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDAL.GetListAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public void TUpdate(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}
