using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using System.Data; //importando as bibliotecas
using System.Data.SqlClient;


namespace DAL_ProjetoDS
{
    public class LoginDAL
    {

        

    }
    public class conect 
    {
        LoginDTO obj2 = new LoginDTO();

        public static SqlConnection connecter() //criando o metodo conecter retornando o sqlserver
        {
            try //bloco try catch para excessões
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=projetods;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"); //criando a variavel de conexão e ativando-a
                conn.Open();
                return conn;
            }
            catch 
            {
                throw new Exception("Não foi possivel conectar, por favor tente novamente!"); //sempre usar esse cod no try catch
            }
            

        }

    }
}
