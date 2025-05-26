using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _ProductDAL;

        public ProductManager(IProductDAL ProductDAL)
        {
            _ProductDAL = ProductDAL;
        }

        public void TChangeStatus(int id)
        {
           _ProductDAL.ChangeStatus(id);
        }

        public void TCreate(Product entity)
        {
            _ProductDAL.Create(entity);
        }

        public void TDelete(Product entity)
        {
            _ProductDAL.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _ProductDAL.GetListAll();
        }

        public Product TGetById(int id)
        {
            return _ProductDAL.GetById(id);
        }

        public List<ResultProductDto> TGetProductsWithCategories()
        {
            return _ProductDAL.GetProductWithCategories();
        }

        public void TUpdate(Product entity)
        {
            _ProductDAL.Update(entity);
        }
    }
}
