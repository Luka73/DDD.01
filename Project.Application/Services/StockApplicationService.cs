using AutoMapper;
using Project.Application.Contracts;
using Project.Application.Models.Stock;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Services
{
    public class StockApplicationService : IStockApplicationService
    {
        private readonly IStockDomainService domainService;
        private readonly IMapper mapper;

        public StockApplicationService(IStockDomainService domainService, IMapper mapper)
        {
            this.domainService = domainService;
            this.mapper = mapper;
        }

        public void Cadastrar(CreateStockModel model)
        {
            domainService.Cadastrar(mapper.Map<Stock>(model));
        }

        public void Atualizar(UpdateStockModel model)
        {
            domainService.Atualizar(mapper.Map<Stock>(model));
        }

        public void Excluir(int id)
        {
            domainService.Excluir(id);
        }

        public List<ReadStockModel> ConsultarTodos()
        {
            return mapper.Map<List<ReadStockModel>>(domainService.ConsultarTodos());
        }

        public ReadStockModel ConsultarPorId(int id)
        {
            return mapper.Map<ReadStockModel>(domainService.ConsultarPorId(id));
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
