﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseMenu
    {
        public int CheeseID { get; set; }
        public Cheese Cheese { get; set; }

        public int MenuID { get; set; }
        public Menu Menu { get; set; }

        //IList<CheeseMenu> CheeseMenus { get; set; } = new List<CheeseMenu>();
    }
}
