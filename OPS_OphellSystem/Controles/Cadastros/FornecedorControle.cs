using System;
using System.Collections.Generic;
using System.Data;
using Modelos;
using OPS_OphellSystem;
using Dao;
using System.Linq;
using Interfaces;

namespace Cadastros.Controles
{
    public class FornecedorControle
    {
        #region "Classes"
        FornecedorDao _dao = new FornecedorDao();
        #endregion

        #region "Variaveis"
        #endregion

        #region "Propriedades"
        #endregion

        #region "Metodos"
        public FornecedorControle()
        {

        }
        public bool DeleteFornecedor(long id)
        {
            try
            {
                if (id <= 0) throw new System.Exception("Nenhum fornecedor passado como parâmetro!");
                FornecedorModelo fornecedor = _dao.GetById(id);
                if (fornecedor == null) throw new System.Exception("Fornecedor não encontrado!");
                _dao.Delete(fornecedor);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return true;
        }
        public bool GravarFornecedor(FornecedorModelo fornecedor)
        {
            DataTable dtDados = new DataTable();
            try
            {
                if (fornecedor == null) throw new System.Exception("Nenhum fornecedor passa como parâmetro!");
                if (_dao.GetById(fornecedor.FornecedorId) == null)
                {
                    _dao.Create(fornecedor);
                }
                else
                {
                    _dao.Update(fornecedor);
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return true;
        }
        #endregion

        #region "Funções"
        public List<FornecedorModelo> GetListaFornecedores(string criterio = "")
        {
            try
            {
                List<FornecedorModelo> Fornecedores = new List<FornecedorModelo>();
                Fornecedores = _dao.SelectAll();
                long idCriterio = 0;
                if(long.TryParse(criterio, out long id) == true)
                {
                    idCriterio = id;
                }
                return Fornecedores.FindAll(f => f.FornecedorId == idCriterio ||f.InscricaoEstadual == criterio || f.CNPJ == criterio ||
                f.Razao.Contains(criterio) || f.Fantasia.Contains(criterio));
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public FornecedorModelo GetFornecedorById(long id)
        {            
            FornecedorModelo fornecedor;
            try
            {                
                fornecedor = _dao.GetById(id);
                if (fornecedor == null)
                {
                    return new FornecedorModelo();
                }

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return fornecedor;
        }
        private List<SqlParametro> RetornaParametros(FornecedorModelo fornecedor)
        {
            List<SqlParametro> list = new List<SqlParametro>();
            list.Add(new SqlParametro { Nome = "@id", Valor = fornecedor.FornecedorId });
            list.Add(new SqlParametro { Nome = "@cnpj", Valor = fornecedor.CNPJ });
            list.Add(new SqlParametro { Nome = "@fantasia", Valor = fornecedor.Fantasia });
            list.Add(new SqlParametro { Nome = "@razao", Valor = fornecedor.Razao });
            list.Add(new SqlParametro { Nome = "@status", Valor = fornecedor.Status ? 1 : 0 });
            list.Add(new SqlParametro { Nome = "@endereco", Valor = fornecedor.Endereco });
            list.Add(new SqlParametro { Nome = "@numero", Valor = fornecedor.Numero });
            list.Add(new SqlParametro { Nome = "@complemento", Valor = fornecedor.Complemento });
            list.Add(new SqlParametro { Nome = "@cidade", Valor = fornecedor.Cidade });
            list.Add(new SqlParametro { Nome = "@bairro", Valor = fornecedor.Bairro });
            list.Add(new SqlParametro { Nome = "@cep", Valor = fornecedor.CEP });
            list.Add(new SqlParametro { Nome = "@telefone", Valor = fornecedor.Telefone });
            list.Add(new SqlParametro { Nome = "@contato", Valor = fornecedor.NomeContato });
            list.Add(new SqlParametro { Nome = "@email", Valor = fornecedor.Email });
            list.Add(new SqlParametro { Nome = "@observacao", Valor = fornecedor.Observacao });
            list.Add(new SqlParametro { Nome = "@digitoVerificador", Valor = fornecedor.DigitoVerificadorCnpj });
            list.Add(new SqlParametro { Nome = "@operadorId", Valor = SessaoUsuario.ID });
            list.Add(new SqlParametro { Nome = "@operadorNome", Valor = SessaoUsuario.Nome });
            list.Add(new SqlParametro { Nome = "@dataAlteracao", Valor = DateTime.Now });
            list.Add(new SqlParametro { Nome = "@excluido", Valor = fornecedor.Excluido });
            list.Add(new SqlParametro { Nome = "@IE", Valor = fornecedor.InscricaoEstadual });

            return list;
        }
        #endregion






    }
}
