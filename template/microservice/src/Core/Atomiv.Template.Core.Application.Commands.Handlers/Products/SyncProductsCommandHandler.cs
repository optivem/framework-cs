﻿using Atomiv.Core.Application;
using Atomiv.Template.Core.Application.Commands.Products;
using Atomiv.Template.Core.Domain.Products;
using System.Threading.Tasks;

namespace Atomiv.Template.Core.Application.Commands.Handlers.Products
{
    public class SyncProductsCommandHandler : IRequestHandler<SyncProductsCommand, SyncProductsCommandResponse>
    {
        private readonly IProductProviderService _productProviderService;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SyncProductsCommandHandler(IProductProviderService productProviderService,
            IProductRepository productRepository,
            IUnitOfWork unitOfWork)
        {
            _productProviderService = productProviderService;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<SyncProductsCommandResponse> HandleAsync(SyncProductsCommand request)
        {
            var products = await _productProviderService.GetProductsAsync();

            await _productRepository.SyncAsync(products);

            await _unitOfWork.CommitAsync();

            return new SyncProductsCommandResponse();
        }
    }
}
