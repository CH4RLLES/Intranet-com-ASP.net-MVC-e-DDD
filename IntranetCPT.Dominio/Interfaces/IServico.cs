using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace IntranetCPT.Dominio.Interfaces
{
    public interface IServico<T> where T : class
    {
        T Inserir<V>(T obj) where V : AbstractValidator<T>;

        T Editar<V>(T obj) where V : AbstractValidator<T>;

        void Delete(Guid id);

        T Obter(Guid id);

        T ObterIncludes(Expression<Func<T, bool>> Where, string includes);

        IList<T> ListarTodos();

        IList<T> Listar(Expression<Func<T, bool>> Where);

        bool VerExiste(Expression<Func<T, bool>> Where);

        bool InserirLista(List<T> obj);

        IList<T> ListarInclude(Expression<Func<T, bool>> Where, string includes);

        IList<T> ListarTodosInclude(string includes);
    }
}
