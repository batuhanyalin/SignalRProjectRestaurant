﻿using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.BusinessLayer.Abstract;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IMoneyCaseService:IGenericService<MoneyCase>
    {
        decimal TTotalMoneyCaseAmount();
    }
}
