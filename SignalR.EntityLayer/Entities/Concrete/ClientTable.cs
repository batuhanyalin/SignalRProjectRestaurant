using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities.Concrete
{
    public class ClientTable
    {
        public int ClientTableId { get; set; }
        public string ClientTableName { get; set; }
        public bool ClientTableStatus { get; set; }
        public List<Order> Orders { get; set; }
    }
}
