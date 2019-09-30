using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastros.Modelos;

namespace OPS_OphellSystem.Dados
{
    public class FornececedorDados
    {
        //private FornecedorModelo _fornecedor;
        private List<FornecedorModelo> _fornecedores = new List<FornecedorModelo>();
        #region "Classes"
        #endregion

        #region "Variaveis"
        #endregion

        #region "Propriedades"
        public List<FornecedorModelo> Fornecedores
        {
            get { return _fornecedores; }
            set { _fornecedores = value; }
        }
        #endregion

        #region "Metodos"
        public FornececedorDados()
        {
            CarregaDados();
        }        
        public void Add(FornecedorModelo fornecedor)
        {
            var obj = _fornecedores.Find(f => f.FornecedorId == fornecedor.FornecedorId);
            if(obj == null)
            {
                _fornecedores.Add(obj);
            }
            else
            {
                _fornecedores.Remove(obj);
                _fornecedores.Add(obj);
            }
        }
        public void Save()
        {
            DataTable dtDados = new DataTable();

            foreach(FornecedorModelo fornecedor in _fornecedores)
            {
                try
                {
                    int index = _fornecedores.FindIndex(f => f.FornecedorId == fornecedor.FornecedorId);
                    dtDados = utilitarios.RealizaConexaoBd("SELECT id FROM Fornecedor WHERE id=@id", RetornaParametros(index));
                    if (dtDados.Rows.Count <= 0)
                    {
                        utilitarios.RealizaConexaoBd("INSERT INTO Fornecedor(cnpj,fantasia,razao,status,endereco,numero,complemento,cidade,bairro,cep,telefone,contato,email" +
                    ",observacao,digito_verificador,operador_cadastro_id,operador_cadastro_nome,datahora_cadastro,datahora_alteracao)VALUES(@cnpj,@fantasia,@razao,@status" +
                    ",@endereco,@numero,@complemento,@cidade,@bairro,@cep,@telefone,@contato,@email,@observacao,@digitoVerificador,@operadorId,@operadorNome,@dataAlteracao" +
                    ",@dataAlteracao)");
                    }
                    else
                    {
                        utilitarios.RealizaConexaoBd("UPDATE Fornecedor SET cnpj=@cnpj,fantasia=@fantasia,razao=@razao,status=@status,endereco=@endereco,numero=@numero" +
                    ",complemento=@complemento,cidade=@cidade,bairro=@bairro,cep=@cep,telefone=@telefone,contato=@contato,email=@email,observacao=@observacao" +
                    ",digito_verificador=@digitoVerificador,operador_alteracao_id=@operadorId,operador_alteracao_nome=@operadorNome,datahora_alteracao=@dataAlteracao", RetornaParametros(index));
                    }
                }catch(Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }                
            }
        }
        private void CarregaDados()
        {
            try
            {
                DataTable dtFornecedor = new DataTable();
                dtFornecedor = utilitarios.RealizaConexaoBd("SELECT * FROM Fornecedor");

                if (dtFornecedor.Rows.Count > 0)
                {
                    _fornecedores.Clear();
                    FornecedorModelo fornecedor = new FornecedorModelo();
                    fornecedor.FornecedorId = long.Parse(dtFornecedor.Rows[0]["id"].ToString());
                    fornecedor.CNPJ = dtFornecedor.Rows[0]["cnpj"].ToString();
                    fornecedor.Fantasia = dtFornecedor.Rows[0]["fantasia"].ToString();
                    fornecedor.Razao = dtFornecedor.Rows[0]["razao"].ToString();
                    fornecedor.Status = dtFornecedor.Rows[0]["status"].ToString() == "1" ? true : false;
                    fornecedor.Endereco = dtFornecedor.Rows[0]["endereco"].ToString();
                    fornecedor.Numero = int.Parse(dtFornecedor.Rows[0]["numero"].ToString());
                    fornecedor.Complemento = dtFornecedor.Rows[0]["complemento"].ToString();
                    fornecedor.Cidade = dtFornecedor.Rows[0]["cidade"].ToString();
                    fornecedor.Bairro = dtFornecedor.Rows[0]["bairro"].ToString();
                    fornecedor.CEP = int.Parse(dtFornecedor.Rows[0]["cep"].ToString());
                    fornecedor.Telefone = int.Parse(dtFornecedor.Rows[0]["telefone"].ToString());
                    fornecedor.NomeContato = dtFornecedor.Rows[0]["contato"].ToString();
                    fornecedor.Email = dtFornecedor.Rows[0]["email"].ToString();
                    fornecedor.Observacao = dtFornecedor.Rows[0]["observacao"].ToString();
                    fornecedor.DigitoVerificadorCnpj = dtFornecedor.Rows[0]["digito_verificador"].ToString();

                    _fornecedores.Add(fornecedor);
                }

            }
            catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Funções"        
        private List<SqlParametro> RetornaParametros(int index)
        {
            List<SqlParametro> list = new List<SqlParametro>();
            list.Add(new SqlParametro { Nome = "@id", Valor = _fornecedores[index].FornecedorId });
            list.Add(new SqlParametro { Nome = "@cnpj", Valor = _fornecedores[index].CNPJ });
            list.Add(new SqlParametro { Nome = "@fantasia", Valor = _fornecedores[index].Fantasia });
            list.Add(new SqlParametro { Nome = "@razao", Valor = _fornecedores[index].Razao });
            list.Add(new SqlParametro { Nome = "@status", Valor = _fornecedores[index].Status?1:0 });
            list.Add(new SqlParametro { Nome = "@endereco", Valor = _fornecedores[index].Endereco });
            list.Add(new SqlParametro { Nome = "@numero", Valor = _fornecedores[index].Numero });
            list.Add(new SqlParametro { Nome = "@complemento", Valor = _fornecedores[index].Complemento });
            list.Add(new SqlParametro { Nome = "@cidade", Valor = _fornecedores[index].Cidade });
            list.Add(new SqlParametro { Nome = "@bairro", Valor = _fornecedores[index].Bairro });
            list.Add(new SqlParametro { Nome = "@cep", Valor = _fornecedores[index].CEP });
            list.Add(new SqlParametro { Nome = "@telefone", Valor = _fornecedores[index].Telefone });
            list.Add(new SqlParametro { Nome = "@contato", Valor = _fornecedores[index].NomeContato });
            list.Add(new SqlParametro { Nome = "@email", Valor = _fornecedores[index].Email });
            list.Add(new SqlParametro { Nome = "@observacao", Valor = _fornecedores[index].Observacao });
            list.Add(new SqlParametro { Nome = "@digitoVerificador", Valor = _fornecedores[index].DigitoVerificadorCnpj });
            list.Add(new SqlParametro { Nome = "@operadorId", Valor = SessaoUsuario.ID });
            list.Add(new SqlParametro { Nome = "@operadorNome", Valor = SessaoUsuario.Nome });
            list.Add(new SqlParametro { Nome = "@dataAlteracao", Valor = DateTime.Now });
            list.Add(new SqlParametro { Nome = "@excluido", Valor = _fornecedores[index].Excluido});

            return list;
        }
        public FornecedorModelo GetFornecedorById(long id)
        {
            try
            {
                return _fornecedores.Find(f => f.FornecedorId == id);
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion
    }
}
