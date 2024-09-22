using AutoMapper;
using MoveInatorApplication.Models;
using MoveInatorDomain.Entities.Cadastros;

namespace MoveInatorApplication.Mappers
{
    public class EmpresaProfile : Profile
    {
        public EmpresaProfile()
        {
            CreateMap<Empresa, EmpresaModel>()
                .ReverseMap();
        }
    }
}
