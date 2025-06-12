using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ClientTableId { get; set; }
        public ClientTable ClientTable { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
