﻿using System;
using System.Collections.Generic;
using System.Data;

namespace OPS_OphellSystem.Cadastros.Classes.Fornecedor
{
    public class CadastroDeFornecedor : PessoaJuridica
    {
        #region "Classes"
        #endregion

        #region "Variaveis"
        private int _idFornecedor;
        private string _nomeContato;
        private string _emailContato;
        private string _observacoes;
        private int _status;
        private string _complemento;
        private int _terceiro;
        private string _digitoVerificador;
        private List<SqlParametro> parametros;
        #endregion

        #region "Propriedades"
        public int IDFornecedor
        {
            get { return _idFornecedor; }
            set { _idFornecedor = value; }
        }
        public string NomeContato
        {
            get { return _nomeContato; }
            set { _nomeContato = value; }
        }
        public string EmailContato
        {
            get { return _emailContato; }
            set { _emailContato = value; }
        }
        public string Observacoes
        {
            get { return _observacoes; }
            set { _observacoes = value; }
        }
        public int StatusFornecedor
        {
            get { return _status; }
            set { _status = value; }
        }
        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }
        public string Fantasia
        {
            get { return _fantasia; }
            set { _fantasia = value; }
        }
        public string Razao
        {
            get { return _razao; }
            set { _razao = value; }
        }
        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public int CEP
        {
            get { return _cep; }
            set { _cep = value; }
        }
        public int Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }
        public int Terceiro
        {
            get { return _terceiro; }
            set { _terceiro = value; }
        }
        public string DigitoVerificador
        {
            get { return _digitoVerificador; }
            set { _digitoVerificador = value; }
        }
        #endregion

        #region "Meodos"
        public void GravarFornecedor()
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (ValidaDados() == false)
                {
                    return;
                }

                dtDados = utilitarios.RealizaConexaoBd("SELECT id_forn FROM Fornecedor WHERE cnpj_forn=@cnpj",RetornaParametros());
                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Fornecedor (cnpj_forn,nome_fantasia_forn,razao_social_forn)VALUES(@cnpj,@fantasia,@razao)",
                        RetornaParametros());

                    dtDados = utilitarios.RealizaConexaoBd("SELECT id_forn FROM Fornecedor WHERE cnpj_forn=@cnpj",RetornaParametros());
                    _idFornecedor = int.Parse(dtDados.Rows[0]["id_forn"].ToString());
                    AtualizaFornecedor();
                }
                else
                {
                    AtualizaFornecedor();
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public void AtualizaFornecedor()
        {
            try
            {
                utilitarios.RealizaConexaoBd("UPDATE Fornecedor SET cnpj_forn=@cnpj,nome_fantasia_forn=@fantasia,razao_social_forn=@razao,status_forn=@status," +
                    "endereco_forn=@endereco,telefone_forn=@telefone,nome_contato_forn=@contato,email_contato_forn=@email,numero_forn=@numero," +
                    "complemento_forn=@complemento,observacao_forn=@observacao,terceiro=@terceiro WHERE id_forn=@id",RetornaParametros());
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public void DesativarAtivarFornecedor()
        {
            try
            {
                utilitarios.RealizaConexaoBd("UPDATE Fornecedor SET status_forn=@status WHERE id_forn=@id",RetornaParametros());
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        #endregion

        #region "Funcoes"
        /// <summary>
        /// Retorna DataTable com os dados do Fornecedor
        /// </summary>
        /// <param name="opcaoBusca">Tipo de filtro da busca</param>
        /// <returns></returns>
        public DataTable BuscaFornecedor(string opcaoBusca)
        {
            try
            {
                DataTable dtDados = new DataTable();
                switch (opcaoBusca)
                {
                    case "CNPJ":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE cpj_forn=@cnpj",RetornaParametros());
                        break;
                    case "Nome Fantasia":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE nome_fantasia_forn=@fantasia",RetornaParametros());
                        break;
                    case "Razão Social":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE razao_social_forn=@razao",RetornaParametros());
                        break;
                    case "Status":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE status_forn=@status",RetornaParametros());
                        break;
                }

                return dtDados;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private bool ValidaDados()
        {
            try
            {
                if (utilitarios.ValidaCnpj(_cnpj.ToString(), _digitoVerificador.ToString()) == false)
                {
                    throw new System.Exception("CNPJ inválido! Confira se este é um CNPJ válido.");
                }
                if (_cnpj.ToString().Length < 14 || _cnpj.ToString().Length > 14)
                {
                    throw new System.Exception("CNPJ está com a quantidade de dígitos inferior ou superior a 14!");
                }
                if (_fantasia == "" || _fantasia == null)
                {
                    throw new System.Exception("Nome fantasia inválido!");
                }
                if (_razao == "" || _razao == null)
                {
                    throw new System.Exception("Razão Social inválida!");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }
        private List<SqlParametro> RetornaParametros()
        {
            try
            {
                parametros = new List<SqlParametro>();

                parametros.Add(new SqlParametro { Nome = "@id", Valor = _idFornecedor });
                parametros.Add(new SqlParametro { Nome = "@contato", Valor = _nomeContato });
                parametros.Add(new SqlParametro { Nome = "@email", Valor = _emailContato });
                parametros.Add(new SqlParametro { Nome = "@observacao", Valor = _observacoes });
                parametros.Add(new SqlParametro { Nome = "@status", Valor = _status });
                parametros.Add(new SqlParametro { Nome = "@complemento", Valor = _complemento });
                parametros.Add(new SqlParametro { Nome = "@terceiro", Valor = _terceiro });
                parametros.Add(new SqlParametro { Nome = "@digitoV", Valor = _digitoVerificador });
                parametros.Add(new SqlParametro { Nome = "@cnpj", Valor = _cnpj });
                parametros.Add(new SqlParametro { Nome = "@fantasia", Valor = _fantasia });
                parametros.Add(new SqlParametro { Nome = "@razao", Valor = _razao });
                parametros.Add(new SqlParametro { Nome = "@endereco", Valor = _endereco });
                parametros.Add(new SqlParametro { Nome = "@numero", Valor = _numero });
                parametros.Add(new SqlParametro { Nome = "@cidade", Valor = _cidade  });
                parametros.Add(new SqlParametro { Nome = "@cep", Valor = _cep });
                parametros.Add(new SqlParametro { Nome = "@telefone", Valor = _telefone });
                parametros.Add(new SqlParametro { Nome = "@bairro", Valor = _bairro });                

                return parametros;

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion
    }
}
