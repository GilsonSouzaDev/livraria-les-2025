using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace livraria_api.api.Domain.Interfaces.IStrategies;

public interface IStrategieBase<T> where T : class
{
    Task<string> Processar(T entidade);
}
