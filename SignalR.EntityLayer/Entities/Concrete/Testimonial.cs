﻿namespace SignalRProjectRestaurant.EntityLayer.Concrete 
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
