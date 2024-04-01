using Financeiro.Models;

namespace Financeiro.Interfaces
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> CarregarPessoas { get; }

        void SalvarPessoa(Pessoa pessoa);
    }
}
