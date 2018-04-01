﻿using Pickup_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup_Repository
{
    public interface IAdminRepository : IRepository<Admin>
    {
        int GetLastAdminId(Admin admin);
    }
}
