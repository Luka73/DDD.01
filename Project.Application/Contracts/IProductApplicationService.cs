using Project.Application.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Contracts
{
    public interface IProductApplicationService : IDisposable
    {
        void Cadastrar(CreateProductModel model);
        void Atualizar(UpdateProductModel model);
        void Excluir(int id);

        List<ReadProductModel> ConsultarTodos();
        ReadProductModel ConsultarPorId(int id);
    }
}
