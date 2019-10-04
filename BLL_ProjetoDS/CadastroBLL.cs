using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using DAL_ProjetoDS;

namespace BLL_ProjetoDS
{
    class CadastroBLL
    {
        public static string cadastrofuncionario(FuncionarioDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nome))
            {
                throw new Exception("Valide o campo nome");
            }
            if (string.IsNullOrWhiteSpace(obj.RG))
            {
                throw new Exception("Valide o campo RG");
            }
            if (string.IsNullOrWhiteSpace(obj.CPF))
            {
                throw new Exception("Valide o campo CPF");
            }
            if (obj.CPF.Length != 11)
            {
                throw new Exception("Campo CPF precisa ter 11 caracteres");
            }
            try 
	        {	        

	        }
	        catch (Exception)
	       {	
		    throw;
	        }
            if (string.IsNullOrWhiteSpace(obj.cargo))
            {
                throw new Exception("Valide o campo Cargo");
            }

            return null;
        }
    }
}
