﻿using Optivem.Atomiv.Core.Domain;
using Optivem.Atomiv.Template.Core.Application.Orders.Queries;
using System;
using System.Threading.Tasks;

namespace Optivem.Atomiv.Template.Core.Application.Orders.Repositories
{
    public interface IOrderQueryRepository : IRepository
    {
        Task<BrowseOrdersQueryResponse> QueryAsync(BrowseOrdersQuery query);

        Task<FindOrderQueryResponse> QueryAsync(FindOrderQuery query);

        Task<ListOrdersQueryResponse> QueryAsync(ListOrdersQuery query);
        
        Task<bool> ExistsAsync(Guid orderId);

        Task<long> CountAsync();
    }
}