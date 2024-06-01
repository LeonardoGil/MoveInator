using AutoMapper;
using MoveInatorApplication.Models;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorDomain.Entities.Cadastros;

namespace MoveInatorApplication.Services.Entities
{
    public class MotoristaService : IMotoristaService
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public MotoristaService(IDatabaseService databaseService, 
                                IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task Add(MotoristaModel model)
        {
            var motorista = _mapper.Map<Motorista>(model);

            _databaseService.Database.Motoristas.Add(motorista);

            await _databaseService.Save();
        }

        public async Task Edit(MotoristaModel model)
        {
            var motorista = _databaseService.Database.Motoristas.First(x => x.Id == model.Id);

            _databaseService.Database.Motoristas.Remove(motorista);

            motorista = _mapper.Map<Motorista>(model);

            _databaseService.Database.Motoristas.Add(motorista);

            await _databaseService.Save();
        }

        public async Task Remove(Guid motoristaId)
        {
            var motorista = _databaseService.Database.Motoristas.FirstOrDefault(x => x.Id == motoristaId);

            if (motorista is default(Motorista))
                return;

            _databaseService.Database.Motoristas.Remove(motorista);

            await _databaseService.Save();
        }

        public List<MotoristaModel> GetModels()
        {
            return _mapper.Map<List<MotoristaModel>>(_databaseService.Database.Motoristas);
        }
    }
}
