using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Personagens.Models;

namespace Personagens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Personagens : ControllerBase
    {
        private static List<Personagem> personagens =
            new List<Personagem>
        {
                new Personagem
                {
                    Id = 1,
                    Nome = "Peter",
                    Sobrenome = "Parker",
                    Fantasia = "Homem-aranha",
                    Local = "NY City"
                },
                new Personagem
                {
                    Id = 2,
                    Nome = "Wade",
                    Sobrenome = "Wilson",
                    Fantasia = "Deadpool",
                    Local = "NY City"
                },
        };

        [HttpGet]
        public ActionResult<List<Personagem>>
            LerTodosPersonagens()
        {
            return Ok(personagens);
        }

        [HttpGet("{id}")]
        public ActionResult<Personagem>
        LerUnicoPersonagem(int id)
        {
            var unico = personagens.Find(x => x.Id == id);

            if (unico is null)
                return NotFound("Este personagem não foi encontrado");

            return Ok(unico);
        }

        [HttpPost]
        public ActionResult<List<Personagem>>
            AddPersonagem(Personagem novo)
        {
            if (novo.Id == 0 && personagens.Count > 0)
                novo.Id = personagens[personagens.Count - 1].Id + 1;

            personagens.Add(novo);
            return Ok(personagens);


        }

        [HttpPut("{Id}")]
        public ActionResult<Personagem> AlterarPersonagem(int id, Personagem editar)
        {
            var pesquisa = personagens.Find(x => x.Id == id);

            if (pesquisa is null)
                return NotFound("Personagem nao existe");

            pesquisa.Nome = string.IsNullOrEmpty(editar.Nome) ||
            editar.Nome == "string" ?
            pesquisa.Nome :
            editar.Nome;

            pesquisa.Sobrenome = string.IsNullOrEmpty(editar.Sobrenome) ||
            editar.Sobrenome == "string" ?
            pesquisa.Sobrenome :
            editar.Sobrenome;

            pesquisa.Fantasia = string.IsNullOrEmpty(editar.Fantasia) ||
            editar.Fantasia == "string" ?
            pesquisa.Fantasia :
            editar.Fantasia;

            pesquisa.Local = string.IsNullOrEmpty(editar.Local) ||
            editar.Local == "string" ?
            pesquisa.Local :
            editar.Local;

            return Ok(pesquisa);

        }

        [HttpDelete("{id}")]
        public ActionResult<Personagem> DeletarPersonagem(int id)
        {
            var pesquisa = personagens.Find(x => x.Id == id);

            if (pesquisa == null)
                return NotFound("Personagem não encontrado");

            personagens.Remove(pesquisa);

            return Ok("Removido com sucesso!");
        }


        [HttpGet("local/{local}")]
        public ActionResult<List<Personagem>>
            BuscarLocal(string local)
        {
            var pesquisa =
                personagens.FindAll(x => x.Local == local);

            if (pesquisa is null)
                return NotFound( "Nenhum personagem encontrado.");

            return Ok(pesquisa);
        }

        [HttpGet("fantasia/{fantasia}")]
        public ActionResult BuscaFantasia(int id)
        {
            var pesquisa =
                personagens.Find(x => x.Id == id);

            if (pesquisa is null)
                return NotFound("Essa fantasia não existe.");

        return Ok(pesquisa.Fantasia);
        }
    }
}
