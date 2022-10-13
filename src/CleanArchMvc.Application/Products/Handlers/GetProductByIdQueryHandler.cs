﻿using CleanArchMvc.Application.Products.Queries;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        public readonly IProductRepository _productRepository;
        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository ??
                throw new ArgumentNullException(nameof(productRepository));
        }

        public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
