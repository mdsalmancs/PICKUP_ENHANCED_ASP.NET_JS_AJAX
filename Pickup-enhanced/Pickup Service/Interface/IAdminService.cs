﻿using Pickup_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup_Service
{
    public interface IAdminService : IService<Admin>
    {
        int GetLastAdminId(Admin admin);
    }
}
