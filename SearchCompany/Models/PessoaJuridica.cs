using System;
using System.Text.Json.Serialization;

namespace SearchCompany
{
    public class PessoaJuridica
    {
        [JsonIgnore]
        public int PessoaJuridicaId { get; set; }
        public string NumeroInscricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public string NomeEmpresarial { get; set; }        
        public string Logradouro { get; set; }     
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}
