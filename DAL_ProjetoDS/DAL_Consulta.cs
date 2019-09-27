using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_ProjetoDS;

namespace DAL_ProjetoDS
{
    public class DAL_Consulta
    {
        public static FuncionarioDTO ValidarLogin(LoginDTO obj) 
        {
            try
            {
                string script = "SELECT * FROM Pessoa WHERE (userName = @userName or email = @userName) AND senha = @pass";
                //cria string com consulta sql
                SqlCommand cm = new SqlCommand(script, conect.connecter());
                //cria comando para rodar a instrução, passando instrução sql e conexão
                cm.Parameters.AddWithValue("@userName", obj.usuario);
                cm.Parameters.AddWithValue("@pass", obj.senha);

                //substitui as variaveis na instrução sql pelos valores digitados pelo usuario

                SqlDataReader dados = cm.ExecuteReader();
                //roda a instrução sql e atribui resultado mo SqlDataReader

                while (dados.Read())
                //le a proxima linha do resultado da sua instrução
                {
                    if (dados.HasRows)
                    //verifica se existe a linha com as credenciais
                    {
                        FuncionarioDTO func = new FuncionarioDTO();

                        func.idpessoa = int.Parse(dados["idPessoa"].ToString());
                        func.Nome = dados["Nome"].ToString();
                        func.RG = dados["Rg"].ToString();
                        func.Senha = dados["senha"].ToString();
                        func.sexo = dados["sexo"].ToString();
                        func.TelCelular = dados["telCelular"].ToString();
                        func.TelFixo = dados["telFixo"].ToString();
                        func.UserName = dados["userName"].ToString();
                        func.ativo = dados["ativo"].ToString();
                        func.DataNascimento = dados["dtNascimento"].ToString();
                        func.cargo = dados["cargo"].ToString();

                        return func;

                        /*return "Olá, seu e-mail é: " + dados["email"] + "\n" +
                            "Seja bem vindo senhor: " + dados["userName"] + "\n" +
                            "sua senha é: " + dados["senha"] + "\n";*/
                        
                    }
                }
                throw new Exception("Usuario ou senha invalido");
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }
        }
    }
}
