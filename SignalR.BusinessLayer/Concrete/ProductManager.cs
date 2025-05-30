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

        public decimal TAverageHamburgerPrice()
        {
           return _ProductDAL.AverageHamburgerPrice();
        }

        public decimal TAveragePrice()
        {
           return _ProductDAL.AveragePrice();
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

        public Product TLeastPriceProduct()
        {
            return _ProductDAL.LeastPriceProduct();
        }

        public Product TMostPriceProduct()
        {
            return _ProductDAL.MostPriceProduct();
        }

        public int TProductCount()
        {
           return _ProductDAL.ProductCount();
        }

        public int TProductCountByCategoryNameDrink()
        {
            return _ProductDAL.ProductCountByCategoryNameDrink();
        }

        public int TProductCountByCategoryNameHamburger()
        {
            return _ProductDAL.ProductCountByCategoryNameHamburger();
        }

        public void TUpdate(Product entity)
        {
            _ProductDAL.Update(entity);
        }
    }
}
