﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.OrderDto
{
    public class CreateOrderDto
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
