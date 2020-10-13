using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.ModelDTO;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatController : ControllerBase
    {
        CatService _service;
        public CatController(CatService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IReadOnlyCollection<CatDTO>> Get()
        {
            return await _service.Get();
        }

        [HttpPost]
        public async Task Post(CatDTO cat)
        {
            if (String.IsNullOrEmpty(cat.Name)) return;
            await _service.Add(cat);
        }
    }
}
