﻿using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.DataAccessLayer.Abstract;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IOrderDetailDAL:IGenericDAL<OrderDetail>
    {
    }
}
