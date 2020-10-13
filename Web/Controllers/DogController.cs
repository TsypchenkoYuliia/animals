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
    public class DogController : ControllerBase
    {
        DogService _service;
        public DogController(DogService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IReadOnlyCollection<DogDTO>> Get()
        {
            return await _service.Get();
        }

        [HttpPost]
        public async Task Post(DogDTO dog)
        {
            try
            {
                if (String.IsNullOrEmpty(dog.Name)) return;
                await _service.Add(dog);
            }catch(Exception ex)
            {
                var d = ex.Message;
            }
        }
    }
}
