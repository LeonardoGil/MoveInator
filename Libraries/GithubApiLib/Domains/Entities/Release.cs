using System.Text.Json.Serialization;

namespace GithubApiLib.Domains.Entities
{
    public class Release
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("tag_name")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("prerelease")]
        public bool PreRelease { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CriadoEm { get; set; }

        [JsonPropertyName("published_at")]
        public DateTime PublicadoEm { get; set; }

        [JsonPropertyName("assets")]
        public Asset[] Anexados { get; set; }

        [JsonPropertyName("body")]
        public string Conteudo { get; set; }
    }

    public class Asset
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("content_type")]
        public string Tipo { get; set; }

        [JsonPropertyName("size")]
        public int Tamanho { get; set; }

        [JsonPropertyName("download_count")]
        public int Baixados { get; set; }

        [JsonPropertyName("browser_download_url")]
        public string UrlDownload { get; set; }
    }
}
