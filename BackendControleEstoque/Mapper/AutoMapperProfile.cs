using AutoMapper;
using BackendControleEstoque.DTOs.Request;
using BackendControleEstoque.DTOs.Response;
using BackendControleEstoque.Models;
using System.Security.Cryptography.X509Certificates;

namespace BackendControleEstoque.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            CreateMap<Item, ItemCreatedResponse>();
            CreateMap<ItemCreateRequest, Item>();
        }
    }
}
