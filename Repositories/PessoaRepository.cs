using Financeiro.Context;
using Financeiro.Interfaces;
using Financeiro.Models;

namespace Financeiro.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly DBContexto _dbctx;
        public PessoaRepository(DBContexto dbctx)
        {
            _dbctx = dbctx;
        }

        public IEnumerable<Pessoa> CarregarPessoas => _dbctx.Pessoas;

        public void SalvarPessoa(Pessoa pessoa)
        {
            _dbctx.Pessoas.Add(pessoa);
            _dbctx.SaveChanges();
        }
    }
}
