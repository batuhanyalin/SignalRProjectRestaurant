﻿namespace SignalRProjectRestaurant.EntityLayer.Concrete
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string ImageUrl { get; set; }

    }
}
