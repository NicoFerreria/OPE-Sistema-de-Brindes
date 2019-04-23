﻿using System;
using System.Data;


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
        private string _status;
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
        public string StatusCliente
        {
            get { return _status; }
            set { _status = value; }
        }
        public int CNPJ
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
        #endregion

        #region "Meodos"
        public void GravarCliente()
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (ValidaDados() == false)
                {
                    return;
                }

                dtDados = utilitarios.RealizaConexaoBd("SELECT id_clt FROM Cliente WHERE cnpj_clt='" + _cnpj + "'");
                if (_idCliente <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Cliente(cnpj_clt)VALUES('" + _cnpj + "')");
                }
                else
                {
                    utilitarios.RealizaConexaoBd("UPDATE Clientes SET cnpj_clt='" + _cnpj + "',nome_fantasia_clt='" + _fantasia + "',razao_social_clt='" + _razao +
                    "',status_clt='" + _status + "',endereco_clt='" + _endereco + "',telefone_clt='" + _telefone + "',nome_contato='" + _nomeContato +
                    "',email_contato_clt='" + _emailContato + "'WHERE id_clt='" + _idCliente + "'");
                }
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
                utilitarios.RealizaConexaoBd("UPDATE Cliente SET status_clt='" + _status + "' WHERE id_clt='" + _idCliente + "'");
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
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE cpj_clt='" + _cnpj + "'");
                        break;
                    case "Nome Fantasia":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE nome_fantasia_clt='" + _fantasia + "'");
                        break;
                    case "Razão Social":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE razao_social_clt='" + _razao + "'");
                        break;
                    case "Status":
                        dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE status_clt='" + _status + "'");
                        break;
                }

                return dtDados;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private bool ValidaCnpj(int CNPJ)
        {
            return true;
        }
        private bool ValidaDados()
        {
            try
            {
                if (ValidaCnpj(123) == false)
                {
                    return false;
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
        #endregion
    }
}