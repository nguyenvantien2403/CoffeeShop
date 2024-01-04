using System;
using System.Collections.Generic;
using CoffeeShopMangement.Models;

namespace CoffeeShopMangement.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
