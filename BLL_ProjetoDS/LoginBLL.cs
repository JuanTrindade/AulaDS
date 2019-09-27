using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using DAL_ProjetoDS;


namespace BLL_ProjetoDS
{
    public class LoginBLL
    {
        

        public static FuncionarioDTO validar(LoginDTO obj3)
        {

            LoginDAL obj4 = new LoginDAL();
            if(string.IsNullOrWhiteSpace(obj3.usuario))
            {
                throw new Exception("Campo Login vazio");
            }
            if(string.IsNullOrWhiteSpace(obj3.senha))
            {
                throw new Exception("Campo senha vazio");
            }



            return DAL_Consulta.ValidarLogin(obj3);
        }


    }
}
