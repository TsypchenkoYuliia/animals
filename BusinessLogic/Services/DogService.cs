using BusinessLogic.Infrastructure;
using BusinessLogic.ModelDTO;
using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class DogService
    {
        DogRepository _repository;
        MapperConfig _mapper;
        public DogService(DogRepository repository, MapperConfig mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyCollection<DogDTO>> Get()
        {
            return _mapper.mapper.Map<IReadOnlyCollection<DogDTO>>(await _repository.Get());
        }
        public async Task Add(DogDTO dog)
        {
            await _repository.Add(_mapper.mapper.Map<Dog>(dog));
        }
    }
}
