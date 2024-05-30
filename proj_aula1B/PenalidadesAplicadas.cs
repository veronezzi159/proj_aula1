using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace proj_aula1B
{
    public class PenalidadesAplicadas
    {
        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }
        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }
        [JsonProperty("nome_motorista")]
        public string NomeMotorista { get; set; }
        [JsonProperty("cpf")]
        public string Cpf { get; set; }
        [JsonProperty("vigencia_do_cadastro")]
        public DateTime VigenciaCadastro { get; set; }

        public override string ToString() => $"Razão Social: {RazaoSocial}, CNPJ: {Cnpj}, Nome Motorista: {NomeMotorista}, CPF: {Cpf}, Vigencia do Cadastro: {VigenciaCadastro}";

        
    }
}
