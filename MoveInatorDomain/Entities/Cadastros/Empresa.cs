﻿namespace MoveInatorDomain.Entities.Cadastros
{
    public class Empresa
    {
        public Guid Id { get; set; }

        public string RazaoSocial { get; set; }

        public string Cnpj { get; set; }

        public string ClientId { get; set; }

        public string ClientSecrect { get; set; }
    }
}