using AutoMapper;
using MVC_CRUD.Data.Entities;
using MVC_CRUD.Data.EntitiesDTO;

namespace MVC_CRUD.Services.AutoMapperInServiceProfile
{
    public class ServiceProfile:Profile
    {
        public ServiceProfile()
        {
            CreateMap<CategoryEntrieDTO, Category>();
        }
    }
}
