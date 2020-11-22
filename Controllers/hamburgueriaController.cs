using Microsoft.AspNetCore.Mvc;
using ListaBurguersOnline.db;
using System.Linq;
using System.Collections.Generic;

namespace ListaBurguersOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class hamburgueriaController : ControllerBase
    {
        private hamburgueriaContext _db { get; set; }
        public hamburgueriaController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }
        [HttpGet]
        public List<Burguer> Get()
        {
            var listaBurguers = _db.Burguer
                .OrderByDescending(b => b.Preco)
                .ThenBy(b => b.Nome)   
                .ToList(); 

            return listaBurguers;
        }
    }
}