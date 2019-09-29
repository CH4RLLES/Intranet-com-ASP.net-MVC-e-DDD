using FluentValidation;
using IntranetCPT.Dominio.Interfaces;
using IntranetCPT.Infra.Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IntranetCPT.Servicos.Servicos
{
    public class ServicoBase<T> : IServico<T> where T : class
    {
        private RepositorioBase<T> repository = new RepositorioBase<T>();

        public T Inserir<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Inserir(obj);
            return obj;
        }

        public bool InserirLista(List<T> obj)
        {
            try
            {
                repository.InserirLista(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Editar<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Editar(obj);
            return obj;
        }

        public void Delete(Guid id) => repository.Delete(id);

        public void Delete(IList<T> Entities) => repository.Delete(Entities);

        public void Delete(Expression<Func<T, bool>> Where) => repository.Delete(Where);

        public IList<T> ListarTodosInclude(string includes) => repository.ListarTodosInclude(includes);

        public IList<T> ListarTodos() => repository.ListarTodos();

        public T Obter(Guid id)
        {
            return repository.Obter(id);
        }

        public T ObterIncludes(Expression<Func<T, bool>> Where, string includes) => repository.ObterIncludes(Where, includes);

        public IList<T> Listar(Expression<Func<T, bool>> Where)
        {
            return repository.Listar(Where);
        }

        public IList<T> ListarInclude(Expression<Func<T, bool>> Where, string includes)
        {
            return repository.ListarInclude(Where, includes);
        }

        public bool VerExiste(Expression<Func<T, bool>> Where)
        {
            return repository.VerExiste(Where);
        }

        public int Quantidade(Expression<Func<T, bool>> Where)
        {
            return repository.Quantidade(Where);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
