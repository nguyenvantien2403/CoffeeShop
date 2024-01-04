using System;
using System.Collections.Generic;
using CoffeeShopMangement.Models;

namespace CoffeeShopMangement.ModelViews
{
    public class HomeViewVM
    {
        public List<TinDang> TinTucs { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> categories { get; set; }
        public QuangCao quangcao { get; set; }
    }
}
