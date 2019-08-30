﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace OPS_OphellSystem.Cadastros.Classes.Clientes
{
    public class CadastroDeClientes : PessoaJuridica
    {
        #region "Classes"
        #endregion

        #region "Variaveis"
        private int _idCliente;
        private string _nomeContato;
        private string _emailContato;
        private string _observacoes;
        private int _status;
        private string _complemento;
        private int _digitoVerificador;
        private List<SqlParametro> parametros;
        #endregion

        #region "Propriedades"
        public int IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
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
        public int StatusCliente
        {
            get { return _status; }
            set { _status = value; }
        }
        public long CNPJ
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
        public int DigitoVerificador
        {
            get { return _digitoVerificador; }
            set { _digitoVerificador = value; }
        }
        #endregion

        #region "Meodos"

        public CadastroDeClientes()
        {

        }
        public void GravarCliente()
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (ValidaDados() == false)
                {
                    return;
                }

                dtDados = utilitarios.RealizaConexaoBd("SELECT @id FROM Cliente WHERE cnpj_clt=@cnpj", RetornaParametros());
                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Cliente(cnpj_clt,nome_fantasia_clt,razao_social_clt,status_clt,endereco_clt,telefone_clt,nome_contato_clt" +
                        ",email_contato_clt,numero_clt,complemento_clt)VALUES(@cnpj,@fantasia,@razao,@satatus,@endereco,@telefone,@contato,@email,@numero,@complemento",
                        RetornaParametros());
                    dtDados = utilitarios.RealizaConexaoBd("SELECT @id FROM Cliente WHERE cnpj_clt=@cnpj", RetornaParametros());
                    _idCliente = int.Parse(dtDados.Rows[0]["id_clt"].ToString());
                }
                else
                {
                    AtualizarCliente();
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public void AtualizarCliente()
        {
            try
            {
                utilitarios.RealizaConexaoBd("UPDATE Clientes SET cnpj_clt=@cnpj,nome_fantasia_clt=@fantasia,razao_social_clt=@razao,status_clt=@status," +
                    "endereco_clt=@endereco,telefone_clt=@telefone,nome_contato=@contato,email_contato_clt=@email,numero_clt=@numero,complemento_clt=@complemento" +
                    " WHERE id_clt=@id", RetornaParametros());
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public void DesativarAtivarCliente()
        {
            try
            {
                utilitarios.RealizaConexaoBd("UPDATE Cliente SET status_clt=@status WHERE id_clt=@id", RetornaParametros());
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        #endregion

        #region "Funcoes"
        /// <summary>
        /// Retorna DataTable com os dados do Cliente
        /// </summary>
        /// <param name="opcaoBusca">Tipo de filtro da busca</param>
        /// <returns></returns>
        public DataTable BuscaCliente(string opcaoBusca)
        {
            try
            {
                DataTable dtDados = new DataTable();
                switch (opcaoBusca)
                {
                    case "CNPJ":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE cpj_clt=@cnpj", RetornaParametros());
                        break;
                    case "Nome Fantasia":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE nome_fantasia_clt=@fantasia", RetornaParametros());
                        break;
                    case "Razão Social":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE razao_social_clt=@razao", RetornaParametros());
                        break;
                    case "Status":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE status_clt=@status", RetornaParametros());
                        break;
                    case "Todos":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente", RetornaParametros());
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
            parametros = new List<SqlParametro>();
            parametros.Add(new SqlParametro { Nome = "@id", Valor = _idCliente });
            parametros.Add(new SqlParametro { Nome = "@fantasia", Valor = _fantasia });
            parametros.Add(new SqlParametro { Nome = "@razao", Valor = _razao });
            parametros.Add(new SqlParametro { Nome = "@contato", Valor = _nomeContato });
            parametros.Add(new SqlParametro { Nome = "@email", Valor = _emailContato });
            parametros.Add(new SqlParametro { Nome = "@observacao", Valor = _observacoes });
            parametros.Add(new SqlParametro { Nome = "@status", Valor = _status });
            parametros.Add(new SqlParametro { Nome = "@cnpj", Valor = _cnpj });
            parametros.Add(new SqlParametro { Nome = "@endereco", Valor = _endereco });
            parametros.Add(new SqlParametro { Nome = "@numero", Valor = _numero });
            parametros.Add(new SqlParametro { Nome = "@cidade", Valor = _cidade });
            parametros.Add(new SqlParametro { Nome = "@cep", Valor = _cep });
            parametros.Add(new SqlParametro { Nome = "@telefone", Valor = _telefone });
            parametros.Add(new SqlParametro { Nome = "@bairro", Valor = _bairro });
            parametros.Add(new SqlParametro { Nome = "@complemento", Valor = _complemento });
            parametros.Add(new SqlParametro { Nome = "@digitoV", Valor = _digitoVerificador });

            return parametros;
        }
        #endregion
    }
}
