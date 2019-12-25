﻿using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Template.Core.Application.Orders.Commands;

namespace Optivem.Template.Infrastructure.Validation.Orders
{
    public class UpdateOrderRequestValidator : BaseValidator<UpdateOrderRequest>
    {
        public UpdateOrderRequestValidator()
        {
            RuleFor(e => e.OrderItems).NotNull();
        }
    }
}