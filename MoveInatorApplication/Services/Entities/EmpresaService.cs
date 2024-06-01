using AutoMapper;
using MoveInatorApplication.Models;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorDomain.Entities.Cadastros;
using MoveInatorDomain.Entities.Outros;
using System.Reflection;

namespace MoveInatorApplication.Services.Entities
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IDatabaseService databaseService;
        private readonly IMapper mapper;

        public EmpresaService(IDatabaseService _databaseService,
                              IMapper _mapper)
        {
            databaseService = _databaseService;
            mapper = _mapper;
        }

        public async Task Add(EmpresaModel model)
        {
            var empresa = mapper.Map<Empresa>(model);

            databaseService.Database.Empresas.Add(empresa);

            await databaseService.Save();
        }

        public async Task Edit(EmpresaModel model)
        {
            var empresa = databaseService.Database.Empresas.First(x => x.Id == model.Id);

            databaseService.Database.Empresas.Remove(empresa);

            empresa = mapper.Map<Empresa>(model);

            databaseService.Database.Empresas.Add(empresa);

            await databaseService.Save();
        }

        public async Task Remove(Guid empresaId)
        {
            var empresa = databaseService.Database.Empresas.FirstOrDefault(x => x.Id == empresaId);

            if (empresa is default(Empresa))
                return;

            databaseService.Database.Empresas.Remove(empresa);

            await databaseService.Save();
        }

        public List<EmpresaModel> GetModels()
        {
            return mapper.Map<List<EmpresaModel>>(databaseService.Database.Empresas);
        }
    }
}
