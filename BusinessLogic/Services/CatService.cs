using BusinessLogic.Infrastructure;
using BusinessLogic.ModelDTO;
using DataAccess.Models;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class CatService
    {
        CatRepository _repository;
        MapperConfig _mapper;
        public CatService(CatRepository repository, MapperConfig mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyCollection<CatDTO>> Get()
        {
            return  _mapper.mapper.Map<IReadOnlyCollection<CatDTO>>(await _repository.Get());
        }
        public async Task Add (CatDTO cat)
        {
            await _repository.Add(_mapper.mapper.Map<Cat>(cat));
        }
        public async Task<CatDTO> Get(Expression<Func<Cat, bool>> predicate)
        {
            return _mapper.mapper.Map<CatDTO>(await _repository.Get(predicate));           
        }
    }
}
