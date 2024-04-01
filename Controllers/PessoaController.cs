using Financeiro.Interfaces;
using Financeiro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IActionResult Index()
        {
            var pessoas = _pessoaRepository.CarregarPessoas;
            return View(pessoas);
        }

        [HttpGet]
        public IActionResult Editar()
        {
            return View(new Pessoa());
        }

        [HttpPost]
        public IActionResult Editar(Pessoa pessoa)
        {
            if (pessoa is null)
                throw new ArgumentNullException(nameof(pessoa));

            if (ModelState.IsValid)
                _pessoaRepository.SalvarPessoa(pessoa);

            return RedirectToAction("Index");
        }
    }
}
