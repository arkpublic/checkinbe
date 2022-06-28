﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.SetupModels
{
    public class DatabaseConnectionModel
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Password { get; set; }
        public string User { get; set; }
    }
}
