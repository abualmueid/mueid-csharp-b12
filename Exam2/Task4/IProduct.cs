﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal interface IProduct
    {
        public abstract string GenerateQRCode();
        public abstract string GetDiscount(double discountPercent);
    }
}
