using Project.Application.Models.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Contracts
{
    public interface IStockApplicationService : IDisposable
    {
        void Cadastrar(CreateStockModel model);
        void Atualizar(UpdateStockModel model);
        void Excluir(int id);

        List<ReadStockModel> ConsultarTodos();
        ReadStockModel ConsultarPorId(int id);
    }
}
