using AutoMapper;
using Project.Application.Contracts;
using Project.Application.Models.Products;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Services
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductDomainService domainService;
        private readonly IMapper mapper;

        public ProductApplicationService(IProductDomainService domainService, IMapper mapper)
        {
            this.domainService = domainService;
            this.mapper = mapper;
        }

        public void Cadastrar(CreateProductModel model)
        {
            domainService.Cadastrar(mapper.Map<Product>(model));
        }

        public void Atualizar(UpdateProductModel model)
        {
            domainService.Atualizar(mapper.Map<Product>(model));
        }

        public void Excluir(int id)
        {
            domainService.Excluir(id);
        }

        public List<ReadProductModel> ConsultarTodos()
        {
            return mapper.Map<List<ReadProductModel>>(domainService.ConsultarTodos());
        }

        public ReadProductModel ConsultarPorId(int id)
        {
            return mapper.Map<ReadProductModel>(domainService.ConsultarPorId(id));
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
