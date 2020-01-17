using Microsoft.EntityFrameworkCore.Storage;
using Project.Domain.Contracts.Repositories;
using Project.InfraStructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.InfraStructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext context;
        private IDbContextTransaction transaction;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void RollBack()
        {
            transaction.Rollback();
        }

        public IProductRepository ProductRepository => new ProductRepository(context);

        public IStockRepository StockRepository => new StockRepository(context);

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
