﻿using Oracle.ManagedDataAccess.Client;
using Pickup_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_Repository
{
    public class CatagoryRepository : Repository<Catagory>
    {
        OracleConnection con = OraDataContext.GetInstance();

       
    }
}
