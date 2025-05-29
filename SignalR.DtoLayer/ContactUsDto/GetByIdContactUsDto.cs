using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ContactUsDto
{
    public class GetByIdContactUsDto
    {
        public int ContactUsId { get; set; }
        public string Location { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string FooterDescription { get; set; }
    }
}
