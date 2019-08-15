﻿using System;
using System.Collections.Generic;
using System.Data;

namespace OPS_OphellSystem.Cadastros.Classes.Operadores
{
    public class CadastroDeOperadores
    {
        #region "Classes"
        #endregion

        #region "Propriedades"
        public int OperadorId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Perfil { get; set; }
        public int Contas { get; set; }
        public string Senha { get; set; }
        public string ContraSenha { get; set; }
        public long CPF { get; set; }
        public int Status { get; set; }

        #endregion

        #region "Metodos"
        public void SalvarOperador()
        {
            try
            {
                ValidaDadosOperador();
                DataTable dtDados = new DataTable();

                dtDados = utilitarios.RealizaConexaoBd("SELECT id FROM Usuario WHERE nome='" + Nome + "' AND sobrenome='" + Sobrenome + "' AND cpf='" + CPF + "'");

                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Usuario(nome,sobrenome,contas,senha_login,perfil,status,cpf)VALUES('" + Nome + "','" + Sobrenome +
                        "','" + Contas + "','" + Senha + "','" + Perfil + "','" + Status + "','" + CPF + "')");
                }
                else
                {
                    AltualizarOperador(int.Parse(dtDados.Rows[0]["id"].ToString()));
                }

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private void AltualizarOperador(int id)
        {
            try
            {
                if (id <= 0) throw new Exception("Id do Operador inválido!");
                utilitarios.RealizaConexaoBd("UPDATE Usuario SET nome='" + Nome + "',sobrenome='" + Sobrenome + "',contas='" + Contas + "',senha_login='" + Senha +
                    "',perfil='" + Perfil + "',status='" + Status + "',cpf='" + CPF + "'");
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private void ValidaDadosOperador()
        {
            try
            {
                if (OperadorId <= 0)
                {
                   // throw new Exception("Id do operador inválido!");
                }
                if (Nome == "")
                {
                    throw new Exception("Nome do operador não pode estar vazio!");
                }
                if (Sobrenome == "")
                {
                    throw new Exception("Sobrenome do operador não pode ser vazio!");
                }
                if (Perfil == "")
                {
                    throw new Exception("Pefil de operador inválido!");
                }
                if (Senha == "")
                {
                    throw new Exception("Senha do operador não pode ser em branco!");
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Funcoes"
        public List<CadastroDeOperadores> GetAllOperadoresAtivos()
        {
            try
            {
                List<CadastroDeOperadores> lstOperadores = new List<CadastroDeOperadores>();
                DataTable dtDados = new DataTable();

                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Usuario WHERE status=1");

                if (dtDados.Rows.Count > 0)
                {
                    for (int inicio = 0; inicio < dtDados.Rows.Count; inicio++)
                    {
                        CadastroDeOperadores operador = new CadastroDeOperadores();
                        operador.OperadorId = int.Parse(dtDados.Rows[inicio]["id"].ToString());
                        operador.Nome = dtDados.Rows[inicio]["nome"].ToString();
                        operador.Sobrenome = dtDados.Rows[inicio]["sobrenome"].ToString();
                        operador.Contas = int.Parse(dtDados.Rows[inicio]["contas"].ToString());
                        operador.Perfil = dtDados.Rows[inicio]["perfil"].ToString();
                        operador.Senha = dtDados.Rows[inicio]["senha_login"].ToString();
                        operador.CPF = long.Parse(dtDados.Rows[inicio]["cpf"].ToString());

                        lstOperadores.Add(operador);
                    }
                }

                return lstOperadores;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public CadastroDeOperadores GetOperador(int id)
        {
            try
            {
                if (id <= 0) throw new Exception("Id do Operador Inválido!");

                DataTable dtDados = new DataTable();
                CadastroDeOperadores operador;

                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Usuario WHERE id='" + id + "' LIMIT 0,1");

                if (dtDados.Rows.Count > 0)
                {
                    operador = new CadastroDeOperadores();
                    operador.OperadorId = int.Parse(dtDados.Rows[0]["id"].ToString());
                    operador.Nome = dtDados.Rows[0]["nome"].ToString();
                    operador.Sobrenome = dtDados.Rows[0]["sobrenome"].ToString();
                    operador.Contas = int.Parse(dtDados.Rows[0]["contas"].ToString());
                    operador.Perfil = dtDados.Rows[0]["perfil"].ToString();
                    operador.Senha = dtDados.Rows[0]["senha"].ToString();
                    operador.CPF = long.Parse(dtDados.Rows[0]["cpf"].ToString());

                    return operador;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        /// <summary>
        /// Forneça os valores para as propriedades Senha e Contrasenha da classe de Cadastro de Operadores.
        /// </summary>
        /// <returns>Esta função retorna Verdadeiro caso a senha e Contrasenha sejam iguais.</returns>
        public bool ValidaSenhaOperador()
        {
            try
            {
                if (Senha != ContraSenha) return false;

                return true;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion


    }
}
