using IntranetCPT.Dominio.Entidades;
using IntranetCPT.Servicos.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntranetCPT.Servicos.Servicos
{
    public class RamaisServicos : ServicoBase<Tb_Ramais>
    {
        public bool CadastrarRamais(Tb_Ramais ramal)
        {
            try
            {
                ramal.Id = Guid.NewGuid();
                Inserir<RamaisValidation>(ramal);
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public List<Tb_Ramais> ListaRamais()
        {
            try
            {
                return ListarTodos().ToList();
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public bool AlterarRamais(Tb_Ramais ramal)
        {
            try
            {
                Editar<RamaisValidation>(ramal);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
    }
}
