using FarmeDms_Api.Models.Entities.Produtos;
using FarmeDms_Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmeDms_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosRepository repos;
        public ProdutosController(IProdutosRepository _repos)
        {
            repos = _repos;
        }

        // Get (Pesquisar) ===================================

        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute]ProdutoId produto)
        {
            var produto_db = repos.Read(produto.Id);
            return Ok(produto_db);
        }

        // Post (Criar) =====================================

        [HttpPost]
        public IActionResult Post(PostProdutos produtos)
        {
            if (repos.Create(produtos))
                return Ok();

            return BadRequest();
        }

        // Put (Atualizar/Substituir) =======================

        [HttpPut]
        public IActionResult Put(PutProdutos produtos)
        {
            if (repos.Update(produtos))
                return Ok();

            return BadRequest();
        }

        // Delete (Deletar/Remover) =========================

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] ProdutoId produto)
        {
            if (repos.Delete(produto.Id))
                return Ok();

            return BadRequest();
        }
    }
}
