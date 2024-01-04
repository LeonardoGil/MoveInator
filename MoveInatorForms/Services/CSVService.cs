using MoveInatorForms.Domains.Entities;
using MoveInatorForms.Domains.Enums;
using MoveInatorForms.Domains.Models;
using MoveInatorForms.Services.Interfaces;

namespace MoveInatorForms.Services
{
    public class CSVService : ICSVService
    {
        public string Generate(List<ViagemViewModel> viagensViewModel)
        {
            var viagens = ConvertToViagemCSV(viagensViewModel);
            var csv = ViagemCSV.Header();

            foreach (var viagem in viagens)
            {
                csv += Environment.NewLine;
                csv += viagem.Row();
            }

            return csv;
        }

        #region Private

        private List<ViagemCSV> ConvertToViagemCSV(List<ViagemViewModel> viagensViewModel)
        {
            var taskProcessViagensCSV = viagensViewModel.Select(ProcessConvertToViagemCSVAsync);

            Task.WaitAll(taskProcessViagensCSV.ToArray());

            var viagens = taskProcessViagensCSV.SelectMany(x => x.Result).ToList();

            return viagens;
        }

        private async Task<List<ViagemCSV>> ProcessConvertToViagemCSVAsync(ViagemViewModel viagemViewModel)
        {
            var viagens = new List<ViagemCSV>();
            var chaveAcesso = string.Empty;

            if (viagemViewModel.TipoViagem == TipoDocumentoViagemEnum.MDFe)
            {
                var mes = int.Parse(viagemViewModel.DataEmissao.ToString("MM"));
                var ano = int.Parse(viagemViewModel.DataEmissao.ToString("yy"));

                var mdfe = new ChaveAcesso(ModeloDocumentoEnum.MDFe, 42, mes, ano, long.Parse(viagemViewModel.CnpjEmissor), viagemViewModel.SerieViagem.Value, viagemViewModel.NumeroViagem);
                chaveAcesso = mdfe.ChaveDeAcesso;
            }
            

            for (int i = 0; i < viagemViewModel.Quantidade; i++)
            {
                var viagem = new ViagemCSV()
                {
                    TipoDocumento = (int)viagemViewModel.TipoDocumento,
                    OrdemViagem = 1,
                    NumeroDocumento = viagemViewModel.NumeroViagem.ToString(),
                    SerieDocumento = viagemViewModel.SerieViagem?.ToString() ?? string.Empty,
                    DataEmissao = viagemViewModel.DataEmissao,
                    ChaveAcesso = chaveAcesso,
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
                    case TipoDocumentoEnum.CTe:
                        ProcessEntregaCSVCTe(viagem, viagemViewModel, i);
                        ProcessEntregaCSVNFe(viagem, viagemViewModel, i);
                        viagem.QuantidadeCTe = viagemViewModel.Quantidade;
                        break;
                 
                    case TipoDocumentoEnum.NFe:
                        ProcessEntregaCSVNFe(viagem, viagemViewModel, i);
                        viagem.QuantidadeNFe = viagemViewModel.Quantidade;
                        break;
                }

                viagens.Add(viagem);
            }

            return viagens;
        }

        private void ProcessEntregaCSVCTe(ViagemCSV viagem, ViagemViewModel viagemViewModel, int index)
        {
            var mes = int.Parse(viagem.DataEmissao.ToString("MM"));
            var ano = int.Parse(viagem.DataEmissao.ToString("yy"));

            var numero = viagemViewModel.NumeroDocumento + index;

            var cte = new ChaveAcesso(ModeloDocumentoEnum.CTe, 42, mes, ano, long.Parse(viagem.CNPJEmissor), viagemViewModel.SerieDocumento, numero);

            viagem.SerieDoCTe = viagemViewModel.SerieDocumento;
            viagem.NumeroDoCTe = numero;
            viagem.ChaveDeAcessoDoCTe = cte.ChaveDeAcesso;
        }

        private void ProcessEntregaCSVNFe(ViagemCSV viagem, ViagemViewModel viagemViewModel, int index)
        {
            var mes = int.Parse(viagem.DataEmissao.ToString("MM"));
            var ano = int.Parse(viagem.DataEmissao.ToString("yy"));

            var numero = viagemViewModel.NumeroDocumento + index;

            var nfe = new ChaveAcesso(ModeloDocumentoEnum.NFe, 42, mes, ano, long.Parse(viagem.CNPJEmissor), viagemViewModel.SerieDocumento, numero);

            viagem.SerieDaNFe = viagemViewModel.SerieDocumento;
            viagem.NumerodaNFe = numero;
            viagem.ChaveDeAcessoDaNFe = nfe.ChaveDeAcesso; 
        }

        #endregion
    }
}
