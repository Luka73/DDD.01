using Project.Domain.Contracts.Repositories;
using Project.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Service
{
    public abstract class BaseDomainService<TEntity> : IBaseDomainService<TEntity>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity> repository;

        public BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual void Cadastrar(TEntity entidade)
        {
            repository.Create(entidade);
        }

        public virtual void Atualizar(TEntity entidade)
        {
            repository.Update(entidade);
        }

        public virtual void Excluir(int id)
        {
            repository.Delete(repository.FindById(id));
        }

        public virtual List<TEntity> ConsultarTodos()
        {
            return repository.FindAll();
        }

        public List<TEntity> ConsultarTodos(Func<TEntity, bool> filtro)
        {
            return repository.FindAll(filtro);
        }

        public TEntity ConsultarPorId(int id)
        {
            return repository.FindById(id);
        }

        public TEntity Obter(Func<TEntity, bool> filtro)
        {
            return repository.FindOne(filtro);
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
