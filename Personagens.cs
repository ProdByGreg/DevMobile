using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                Name = "Greg",
                Sobrenome = "Ak",
                Fantasia = "Miranha",
                Local = "Houston"
            },
            new Personagem
            {
                Id = 2,
                Name = "Jhon",
                Sobrenome = "Ak",
                Fantasia = "Wolf",
                Local = "NY"
            },
        };
    }
}
