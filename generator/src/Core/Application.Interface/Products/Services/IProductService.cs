﻿using Optivem.Framework.Core.Application;
using Optivem.Generator.Core.Application.Products.Requests;
using Optivem.Generator.Core.Application.Products.Responses;
using System.Threading.Tasks;

namespace Optivem.Generator.Core.Application.Products.Services
{
    public interface IProductService : IApplicationService
    {
        Task<BrowseProductsResponse> BrowseProductsAsync(BrowseProductsRequest request);

        Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request);

        Task<FindProductResponse> FindProductAsync(FindProductRequest request);

        Task<ListProductsResponse> ListProductsAsync(ListProductsRequest request);

        Task<RelistProductResponse> RelistProductAsync(RelistProductRequest request);

        Task<UnlistProductResponse> UnlistProductAsync(UnlistProductRequest request);

        Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request);
    }
}