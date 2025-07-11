﻿using SignalR.EntityLayer.Entities.Concrete;

namespace SignalRProjectRestaurant.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool ProductStatus { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
