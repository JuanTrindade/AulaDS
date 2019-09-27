using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_ProjetoDS
{
    public class FuncionarioDTO
    {
        public int idpessoa { get; set; }
        public string cargo { get; set; }
        public string DataNascimento { get; set; }
        public string sexo { get; set; }
        public string ativo { get; set; }
        public string TelFixo { get; set; }
        public string TelCelular { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
    }
}
