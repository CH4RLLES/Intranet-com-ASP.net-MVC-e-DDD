using IntranetCPT.Dominio.Entidades;
using IntranetCPT.Servicos.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntranetCPT.Servicos.Servicos
{
    public class ConteudoServicos : ServicoBase<Tb_Conteudo>
    {
        public bool CadastrarConteudo(Tb_Conteudo conteudo)
        {
            try
            {
                conteudo.Id = Guid.NewGuid();
                Inserir<ConteudoValidation>(conteudo);
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public List<Tb_Conteudo> ListaConteudo()
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

        public bool AlterarConteudo(Tb_Conteudo conteudo)
        {
            try
            {
                Editar<ConteudoValidation>(conteudo);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
