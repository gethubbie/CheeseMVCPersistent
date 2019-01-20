using CheeseMVC.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {

        public Menu Menu { get; set; }
        public IList<CheeseMenu> Items { get; set; }  
    }
}
