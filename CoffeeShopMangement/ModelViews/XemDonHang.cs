using System;
using System.Collections.Generic;
using CoffeeShopMangement.Models;

namespace CoffeeShopMangement.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
