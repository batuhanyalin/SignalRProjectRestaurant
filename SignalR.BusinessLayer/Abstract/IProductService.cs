using SignalR.DtoLayer.ProductDto;
using SignalRProjectRestaurant.BusinessLayer.Abstract;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        public List<ResultProductDto> TGetProductsWithCategories();
        public void TChangeStatus(int id);
        public int TProductCount();
        int TProductCountByCategoryNameHamburger();
        int TProductCountByCategoryNameDrink();
        public Product TMostPriceProduct();
        public Product TLeastPriceProduct();
        decimal TAveragePrice();
        decimal TAverageHamburgerPrice();
    }
}
