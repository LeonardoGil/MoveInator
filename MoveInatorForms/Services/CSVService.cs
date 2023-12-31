using MoveInatorForms.Domain;
using MoveInatorForms.Models;
using MoveInatorForms.Services.Interfaces;

namespace MoveInatorForms.Services
{
    public class CSVService : ICSVService
    {
        public string Generate(List<ViagemViewModel> viagensViewModel)
        {
            var viagens = ConvertToViagemCSV(viagensViewModel);
            var csv = ViagemCSVModel.Header();

            foreach (var viagem in viagens)
            {
                csv += Environment.NewLine;
                csv += viagem.Row();
            }

            return csv;
        }

        #region Private

        private List<ViagemCSVModel> ConvertToViagemCSV(List<ViagemViewModel> viagensViewModel)
        {
            var taskProcessViagensCSV = viagensViewModel.Select(ProcessConvertToViagemCSVAsync);

            Task.WaitAll(taskProcessViagensCSV.ToArray());

            var viagens = taskProcessViagensCSV.SelectMany(x => x.Result).ToList();

            return viagens;
        }

        private async Task<List<ViagemCSVModel>> ProcessConvertToViagemCSVAsync(ViagemViewModel viagemViewModel)
        {
            var viagens = new List<ViagemCSVModel>();

            for (int i = 0; i < viagemViewModel.Quantidade; i++)
            {
                var viagem = new ViagemCSVModel()
                {
                    TipoDocumento = (int)viagemViewModel.TipoDocumento,
                    OrdemViagem = 1,
                    NumeroDocumento = viagemViewModel.NumeroViagem.ToString(),
                    SerieDocumento = viagemViewModel.SerieViagem?.ToString() ?? string.Empty,
                    DataEmissao = viagemViewModel.DataEmissao,
                    ChaveAcesso = default, // VERIFICAR
                    CNPJEmissor = viagemViewModel.CnpjEmissor,
                    ValorDaMercadoria = null,
                    UnidadeDeMedida = string.Empty,
                    QuantidadeDaCarga = null,
                    NomeDoMotorista = viagemViewModel.NomeMotorista,
                    CPFMotorista = viagemViewModel.CpfMotorista,
                    PlacaDoVeiculo = "MOV1E24",
                    NomeDestinatario = viagemViewModel.NomeDestinatario,
                    CNPJCPFDestinatario = viagemViewModel.CpfCnpjDestinatario,
                    Logradouro = "Rua Move",
                    Numero = "2024",
                    Bairro = "Polaris",
                    Municipio = "IComprova",
                    CEP = "88200000",
                    UF = "SC"
                };

                switch (viagemViewModel.TipoDocumento)
                {
                    case Enums.TipoDocumentoEnum.CTe:
                        ProcessEntregaCSVCTe(viagem, viagemViewModel, i);
                        viagem.QuantidadeCTe = viagemViewModel.Quantidade;
                        break;
                 
                    case Enums.TipoDocumentoEnum.NFe:
                        ProcessEntregaCSVNFe(viagem, viagemViewModel, i);
                        viagem.QuantidadeNFe = viagemViewModel.Quantidade;
                        break;
                }

                viagens.Add(viagem);
            }

            return viagens;
        }

        private void ProcessEntregaCSVCTe(ViagemCSVModel viagem, ViagemViewModel viagemViewModel, int index)
        {
            throw new NotImplementedException();
        }

        private void ProcessEntregaCSVNFe(ViagemCSVModel viagem, ViagemViewModel viagemViewModel, int index)
        {
            var mes = int.Parse(viagem.DataEmissao.ToString("MM"));
            var ano = int.Parse(viagem.DataEmissao.ToString("yy"));

            var numero = viagemViewModel.NumeroDocumento + index;

            var nfe = new NFe(2, mes, ano, long.Parse(viagem.CNPJEmissor), viagemViewModel.SerieDocumento, numero);

            viagem.SerieDaNFe = viagemViewModel.SerieDocumento;
            viagem.NumerodaNFe = numero;
            viagem.ChaveDeAcessoDaNFe = nfe.ChaveDeAcesso; 
        }

        #endregion
    }
}
