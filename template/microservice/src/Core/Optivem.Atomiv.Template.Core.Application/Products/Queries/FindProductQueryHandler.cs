﻿using System.Threading.Tasks;
using Optivem.Atomiv.Core.Application;
using Optivem.Atomiv.Template.Core.Application.Products.Repositories;

namespace Optivem.Atomiv.Template.Core.Application.Products.Queries
{
    public class FindProductQueryHandler : IRequestHandler<FindProductQuery, FindProductQueryResponse>
    {
        private readonly IProductQueryRepository _productReadRepository;

        public FindProductQueryHandler(IProductQueryRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<FindProductQueryResponse> HandleAsync(FindProductQuery request)
        {
            var response = await _productReadRepository.QueryAsync(request);

            return response;
        }
    }
}