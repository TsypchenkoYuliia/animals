using AutoMapper;
using AutoMapper.Configuration;
using BusinessLogic.ModelDTO;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Infrastructure
{
    public class MapperConfig
    {
        public IMapper mapper;
        public MapperConfig()
        {
            this.mapper = new MapperConfiguration(cfg => {
                cfg.CreateMap<Cat, CatDTO>();
                cfg.CreateMap<CatDTO, Cat>();
                cfg.CreateMap<Dog, DogDTO>();
                cfg.CreateMap<DogDTO, Dog>();
            }).CreateMapper();
        }
    }
}
