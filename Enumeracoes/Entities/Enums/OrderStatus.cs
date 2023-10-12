﻿using System;
using System.Collections.Generic;

namespace Enumeracoes.Entities.Enums
{
    public enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
