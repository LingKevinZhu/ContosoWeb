﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Contoso.Data
{
    public class DB_Helper
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["ContosoDB"].ConnectionString;
        }
    }
}
