﻿using Atomiv.Infrastructure.EntityFrameworkCore;
using Atomiv.Template.Core.Common.Orders;
using System;
using System.Collections.Generic;

namespace Atomiv.Template.Infrastructure.Domain.Persistence.Records
{
    public class OrderRecord : Record<Guid>
    {
        public Guid CustomerId { get; set; }
        
        public DateTime OrderDate { get; set; }
        
        public OrderStatus OrderStatusId { get; set; }

        public virtual CustomerRecord Customer { get; set; }
        
        public virtual OrderStatusRecord OrderStatus { get; set; }
        
        public virtual ICollection<OrderItemRecord> OrderItems { get; set; }
    }
}