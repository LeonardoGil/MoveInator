﻿using MoveInatorApplication.Models;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorDomain.Entities.Importacao;
using MoveInatorDomain.Enums;
using UtilityLib.Domains.Entities.DocumentosFiscais;

namespace MoveInatorApplication.Services
{
    public class XmlService : IXmlService
    {
        private readonly IFileService fileService;

        public XmlService(IFileService fileService)
        {
            this.fileService = fileService;
        }

        public async Task<string> GenerateAsync(string path, List<ViagemXmlModel> mdfeViews)
        {
            var taskConvertMDFe = ConvertToMDFeAsync(mdfeViews);

            if (!Directory.Exists(path))
                throw new Exception("Diretório não existe!");

            var single = mdfeViews.First();
            var newFolder = Path.Combine(path, $"MDFe {single.Numero}-{single.Serie}");

            Directory.CreateDirectory(newFolder);

            var mdfe = await taskConvertMDFe;

            var tasksGenerate = new List<Task>();

            switch (mdfe.TipoDocumento)
            {
                case TipoDocumentoEnum.CTe:
                    tasksGenerate.AddRange(mdfe.CTes.Select(cte => GenerateCTeAsync(newFolder, cte)));
                    break;

                case TipoDocumentoEnum.NFe:
                    tasksGenerate.AddRange(mdfe.NFes.Select(nfe => GenerateNFeAsync(newFolder, nfe)));
                    break;
            }

            tasksGenerate.Add(GenerateMDFeAsync(newFolder, mdfe));
            
            Task.WaitAll([.. tasksGenerate]);

            return newFolder;
        }

        #region Private
        private async Task<MDFe> ConvertToMDFeAsync(List<ViagemXmlModel> mdfeViews)
        {
            var single = mdfeViews.First();
            var tipoDocumento = single.TipoDocumento;

            var mdfe = new MDFe
            {
                ChaveAcesso = new ChaveAcesso((int)ModeloDocumentoEnum.MDFe, 42, single.DataEmissao, long.Parse(single.Empresa.Cnpj), single.Serie, single.Numero),
                Emissor = single.Empresa.RazaoSocial,
                CnpjEmissor = single.Empresa.Cnpj,
                DataEmissao = single.DataEmissao,
                Motorista = single.Motorista.Nome,
                CpfMotorista = single.Motorista.Cpf,
                TipoDocumento = tipoDocumento,
                TipoVeiculo = single.TipoVeiculo
            };

            foreach (var documento in mdfeViews)
            {
                switch (tipoDocumento)
                {
                    case TipoDocumentoEnum.CTe:
                        mdfe.CTes.Add(new CTe
                        {
                            ChaveAcesso = new ChaveAcesso((int)ModeloDocumentoEnum.CTe, 42, documento.DataEmissao, long.Parse(documento.Empresa.Cnpj), documento.SerieDocumento, documento.NumeroDocumento),
                            ChaveAcessoNFe = new ChaveAcesso((int)ModeloDocumentoEnum.NFe, 42, documento.DataEmissao, long.Parse(documento.Empresa.Cnpj), documento.SerieDocumento, documento.NumeroDocumento),
                            CnpjEmissor = documento.Empresa.Cnpj,
                            DataEmissao = documento.DataEmissao
                        });
                        break;
                    
                    case TipoDocumentoEnum.NFe:
                        mdfe.NFes.Add(new NFe
                        {
                            ChaveAcesso = new ChaveAcesso((int)ModeloDocumentoEnum.NFe, 42, documento.DataEmissao, long.Parse(documento.Empresa.Cnpj), documento.SerieDocumento, documento.NumeroDocumento),
                            CnpjEmissor = documento.Empresa.Cnpj,
                            DataEmissao = documento.DataEmissao
                        });
                        break;

                }

            }

            return mdfe;
        }

        private async Task GenerateMDFeAsync(string path, MDFe mdfe)
        {
            var template = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "MDfeModelo.xml"));

            template = template.Replace("[ChaveAcesso]", mdfe.ChaveAcesso.ToString())
                               .Replace("[DigitoVerificar]", mdfe.ChaveAcesso.DigitoVerificador)
                               .Replace("[Estado]", mdfe.ChaveAcesso.UF)
                               .Replace("[Serie]", mdfe.ChaveAcesso.Serie.TrimStart('0'))
                               .Replace("[Numero]", mdfe.ChaveAcesso.Numero.TrimStart('0'))
                               .Replace("[DataEmissao]", mdfe.DataEmissao.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"))
                               .Replace("[Emissor]", mdfe.Emissor)
                               .Replace("[CnpjEmissor]", mdfe.CnpjEmissor)
                               .Replace("[NomeMotorista]", mdfe.Motorista)
                               .Replace("[CpfMotorista]", mdfe.CpfMotorista)
                               .Replace("[TipoVeiculo]", ((int)mdfe.TipoVeiculo).ToString("D2"));

            switch (mdfe.TipoDocumento)
            {
                case TipoDocumentoEnum.CTe:
                    var ctes = string.Empty;
                    foreach (var cte in mdfe.CTes)
                    {
                        ctes += "<infCTe>";
                        ctes += Environment.NewLine;

                        ctes += $"<chCTe>{cte.ChaveAcesso}</chCTe>";
                        ctes += Environment.NewLine;

                        ctes += "</infCTe>";
                        ctes += Environment.NewLine;
                    }
                    template = template.Replace("[QuantidadeDocumentos]", $"<qCTe>{mdfe.QuantidadeCTes}</qCTe>")
                               .Replace("[Documentos]", ctes);
                    break;
                case TipoDocumentoEnum.NFe:
                    var nfes = string.Empty;
                    foreach (var nfe in mdfe.NFes)
                    {
                        nfes += "<infNFe>";
                        nfes += Environment.NewLine;

                        nfes += $"<chNFe>{nfe.ChaveAcesso}</chNFe>";
                        nfes += Environment.NewLine;

                        nfes += "</infNFe>";
                        nfes += Environment.NewLine;
                    }
                    template = template.Replace("[QuantidadeDocumentos]", $"<qNFe>{mdfe.QuantidadeNFes}</qNFe>")
                               .Replace("[Documentos]", nfes);
                    break;

            }

            var filePath = Path.Combine(path, $"MoveInator_MDFe{mdfe.ChaveAcesso}.xml");

            await fileService.GenerateFileAsync(filePath, template);
        }

        private async Task GenerateCTeAsync(string path, CTe cte)
        {
            var template = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "CTeModelo.xml"));

            template = template.Replace("[ChaveAcesso]", cte.ChaveAcesso.ToString())
                               .Replace("[ChaveAcessoNFe]", cte.ChaveAcessoNFe.ToString())
                               .Replace("[DigitoVerificador]", cte.ChaveAcesso.DigitoVerificador)
                               .Replace("[Estado]", cte.ChaveAcesso.UF)
                               .Replace("[Serie]", cte.ChaveAcesso.Serie.TrimStart('0'))
                               .Replace("[Numero]", cte.ChaveAcesso.Numero.TrimStart('0'))
                               .Replace("[DataEmissao]", cte.DataEmissao.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"))
                               .Replace("[CnpjEmissor]", cte.CnpjEmissor);

            var filePath = Path.Combine(path, $"MoveInator_CTe{cte.ChaveAcesso}.xml");

            await fileService.GenerateFileAsync(filePath, template);
        }

        private async Task GenerateNFeAsync(string path, NFe nfe)
        {
            var template = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "NFeModelo.xml"));

            template = template.Replace("[ChaveAcesso]", nfe.ChaveAcesso.ToString())
                               .Replace("[DigitoVerificador]", nfe.ChaveAcesso.DigitoVerificador)
                               .Replace("[Estado]", nfe.ChaveAcesso.UF)
                               .Replace("[Serie]", nfe.ChaveAcesso.Serie.TrimStart('0'))
                               .Replace("[Numero]", nfe.ChaveAcesso.Numero.TrimStart('0'))
                               .Replace("[DataEmissao]", nfe.DataEmissao.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"))
                               .Replace("[CnpjEmissor]", nfe.CnpjEmissor);

            var filePath = Path.Combine(path, $"MoveInator_NFe{nfe.ChaveAcesso}.xml");

            await fileService.GenerateFileAsync(filePath, template);
        }

        #endregion
    }
}