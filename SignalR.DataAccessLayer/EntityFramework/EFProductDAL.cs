using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Context;
using SignalR.DtoLayer.ProductDto;
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
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        public EFProductDAL(ProjectContext projectContext) : base(projectContext)
        {

        }

        public decimal AverageHamburgerPrice()
        {
            using var context = new ProjectContext();

            var value = context.Products.Where(x => x.Category.CategoryName == "Hamburger").Select(x => x.Price).ToList();
            return value.Average();

        }

        public decimal AveragePrice()
        {
            using var context = new ProjectContext();

            return context.Products.Average(x => x.Price);

        }

        public void ChangeStatus(int id)
        {
            var context = new ProjectContext();
            var value = context.Products.Find(id);
            if (value.ProductStatus == true)
            {
                value.ProductStatus = false;
            }
            else
            {
                value.ProductStatus = true;
            }
            context.SaveChanges();
        }

        public List<ResultProductDto> GetProductWithCategories()
        {
            var context = new ProjectContext();
            return context.Products.Include(x => x.Category).Select(y => new ResultProductDto
            {
                CategoryName = y.Category.CategoryName,
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductId = y.ProductId,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus
            }).ToList();
        }

        public Product LeastPriceProduct()
        {
            var context = new ProjectContext();
            var value = context.Products.OrderBy(x => x.Price).ToList().FirstOrDefault();
            return value;

        }

        public Product MostPriceProduct()
        {
            var context = new ProjectContext();
            var value = context.Products.OrderByDescending(x => x.Price).ToList().FirstOrDefault();
            return value;
        }

        public int ProductCount()
        {
            using var context = new ProjectContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new ProjectContext();
            return context.Products.Include(x => x.Category).Count(x => x.Category.CategoryName == "İçecek");
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new ProjectContext();
            return context.Products.Include(x => x.Category).Count(x => x.Category.CategoryName == "Hamburger");
        }
    }
}
