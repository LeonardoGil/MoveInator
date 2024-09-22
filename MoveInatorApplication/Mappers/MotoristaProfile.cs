using AutoMapper;
using MoveInatorApplication.Models;
using MoveInatorDomain.Entities.Cadastros;

namespace MoveInatorApplication.Mappers
{
    public class MotoristaProfile : Profile
    {
        public MotoristaProfile()
        {
            CreateMap<Motorista, MotoristaModel>()
                .ReverseMap();
        }
    }
}
