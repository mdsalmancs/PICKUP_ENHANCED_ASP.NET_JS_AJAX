﻿using Pickup_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup_Repository
{
    public interface ISellerRepository : IRepository<Seller>
    {
        int GetLastSellerId(Seller seller);
    }
}
