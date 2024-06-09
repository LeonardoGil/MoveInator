using MoveInatorApplication.Models;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorDomain.Entities.Importacao;
using MoveInatorDomain.Enums;
using UtilityLib.Domains.Entities.DocumentosFiscais;

namespace MoveInatorApplication.Services
{
    public class CSVService : ICSVService
    {
        private readonly IFileService fileService;

        public CSVService(IFileService fileService)
        {
            this.fileService = fileService;
        }

        public async Task<string> GenerateAsync(string path, List<ViagemCsvModel> viagensViewModel)
        {
            if (!Directory.Exists(path))
                throw new Exception("Diretório não existe!");

            var viagens = ConvertToViagemCSV(viagensViewModel);
            var csv = Manifesto.Header();

            foreach (var viagem in viagens)
            {
                csv += Environment.NewLine;
                csv += viagem.Row();
            }

            var filePath = Path.Combine(path, $"Move_{DateTime.Now:dd-MM-yyTHH-mm-ss}.csv");

            await fileService.GenerateFileAsync(filePath, csv);

            return filePath;
        }

        #region Private

        private List<Manifesto> ConvertToViagemCSV(List<ViagemCsvModel> viagensViewModel)
        {
            var taskProcessViagensCSV = viagensViewModel.Select(ProcessConvertToViagemCSVAsync);

            Task.WaitAll(taskProcessViagensCSV.ToArray());

            var viagens = taskProcessViagensCSV.SelectMany(x => x.Result).ToList();

            return viagens;
        }

        private async Task<List<Manifesto>> ProcessConvertToViagemCSVAsync(ViagemCsvModel viagemViewModel)
        {
            var viagens = new List<Manifesto>();
            var chaveAcesso = string.Empty;

            if (viagemViewModel.TipoViagem == TipoDocumentoViagemEnum.MDFe)
            {
                var mes = int.Parse(viagemViewModel.DataEmissao.ToString("MM"));
                var ano = int.Parse(viagemViewModel.DataEmissao.ToString("yy"));

                var mdfe = new ChaveAcesso((int)ModeloDocumentoEnum.MDFe, 42, mes, ano, long.Parse(viagemViewModel.CnpjEmissor), viagemViewModel.SerieViagem.Value, viagemViewModel.NumeroViagem);
                chaveAcesso = mdfe.ChaveDeAcesso;
            }


            for (int i = 0; i < viagemViewModel.Quantidade; i++)
            {
                var viagem = new Manifesto()
                {
                    TipoDocumento = (int)viagemViewModel.TipoViagem,
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
                    CodigoVeiculo = viagemViewModel.CodigoVeiculo,
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

        private void ProcessEntregaCSVCTe(Manifesto viagem, ViagemCsvModel viagemViewModel, int index)
        {
            var mes = int.Parse(viagem.DataEmissao.ToString("MM"));
            var ano = int.Parse(viagem.DataEmissao.ToString("yy"));

            var numero = viagemViewModel.NumeroDocumento + index;

            var cte = new ChaveAcesso((int)ModeloDocumentoEnum.CTe, 42, mes, ano, long.Parse(viagem.CNPJEmissor), viagemViewModel.SerieDocumento, numero);

            viagem.SerieDoCTe = viagemViewModel.SerieDocumento;
            viagem.NumeroDoCTe = numero;
            viagem.ChaveDeAcessoDoCTe = cte.ChaveDeAcesso;
        }

        private void ProcessEntregaCSVNFe(Manifesto viagem, ViagemCsvModel viagemViewModel, int index)
        {
            var mes = int.Parse(viagem.DataEmissao.ToString("MM"));
            var ano = int.Parse(viagem.DataEmissao.ToString("yy"));

            var numero = viagemViewModel.NumeroDocumento + index;

            var nfe = new ChaveAcesso((int)ModeloDocumentoEnum.NFe, 42, mes, ano, long.Parse(viagem.CNPJEmissor), viagemViewModel.SerieDocumento, numero);

            viagem.SerieDaNFe = viagemViewModel.SerieDocumento;
            viagem.NumerodaNFe = numero;
            viagem.ChaveDeAcessoDaNFe = nfe.ChaveDeAcesso;
        }

        #endregion
    }
}
