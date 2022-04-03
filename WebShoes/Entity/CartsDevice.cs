﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShoes.Entity
{
    public class CartsDevice
    {
        public Device DeviceCD { get; set; }
        public string cartd_Id { get; set; }
        public string cartd_DeviceId { get; set; }
        public List<ProductInCartDevices> ProductInCartDevicesCD { get; set; }
        public int cartd_Discount { set; get; }

    }
}
