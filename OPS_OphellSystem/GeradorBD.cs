﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPS_OphellSystem
{
    public class GeradorBD
    {
        public string[,] ObterCampos(string tabela)
        {
            try
            {
                string[,] campos = { };
                switch (tabela)
                {
                    case "Usuario":
                        campos = new string[,]
                         {
                           {"id","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE"},
                           {"nome","TEXT NOT NULL" },
                           {"sobrenome","TEXT NOT NULL" },
                           {"contas","INTEGER" },
                           {"senha_login","TEXT NOT NULL" },
                           {"perfil","TEXT NOT NULL" },
                           {"status","INTEGER NOT NULL DEFAULT 1" },
                           {"cpf","INTEGER NOT NULL" }
                         };
                        break;
                    case "Cliente":
                        campos = new string[,]
                        {
                            {"id_clt","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE" },
                            {"cnpj_clt","TEXT NOT NULL UNIQUE" },
                            {"nome_fantasia_clt","TEXT NOT NULL" },
                            {"razao_social_clt","TEXT NOT NULL" },
                            {"status_clt","INTEGER NOT NULL DEFAULT 1" },
                            {"endereco_clt","TEXT" },
                            {"numero_clt","INTEGER" },
                            {"complemento_clt","TEXT" },
                            {"cidade","TEXT" },
                            {"bairro","TEXT" },
                            {"cep","INTEGER" },
                            {"telefone_clt","INTEGER" },
                            {"nome_contato_clt","TEXT" },                            
                            {"email_contato_clt","TEXT" },
                            {"observacao_clt","TEXT" },
                            {"digito_verificador","INTEGER" },
                            {"operador_cadastro_id","INTEGER" },
                            {"operador_cadastro_nome","TEXT" },
                            {"datahora_cadastro","TEXT" },
                            {"datahora_alteracao","TEXT" },
                            {"excluido","INTEGER NOT NULL DEFAULT 0" }
                        };
                        break;
                    case "Produto":
                        {
                            campos = new string[,]
                            {
                                { "id","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE"},
                                {"codigo","INTEGER NOT NULL" },
                                {"nome","TEXT NOT NULL" },
                                {"descricao","TEXT NOT NULL" },
                                {"status","INTEGER NOT NULL DEFAULT 1" },
                                {"excluido","INTEGER NOT NULL DEFAULT 0" },
                                {"cor","TEXT NOT NULL" },
                                {"observacao","TEXT" }
                            };
                        }
                        break;
                    case "Fornecedor":
                        {
                            campos = new string[,]
                            {
                                {"id_forn","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE" },
                                {"cnpj_forn", "INTEGER NOT NULL UNIQUE" },
                                {"nome_fantasia_forn","TEXT NOT NULL" },
                                {"razao_social_forn","TEXT NOT NULL" },
                                {"status_forn","INTEGER NOT NULL DEFAULT 1" },
                                {"endereco_forn","TEXT" },
                                {"numero_forn","INTEGER" },
                                {"telefone_forn","INTEGER" },
                                {"nome_contato_forn","TEXT" },
                                {"complemento_forn","TEXT" },
                                {"email_contato_forn","Text" },
                                {"observacao_forn","TEXT" },
                                {"terceiro","INTEGER NOT NULL DEFAULT 0" }
                            };                            
                        }
                        break;

                    case "Pagamento":
                        {
                            campos = new string[,] {
                                { "id","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE"},
                                {"duplicata","INTEGER NOT NULL DEFAULT 1" },                                
                                {"data_lancamento","TEXT" },                                
                                {"total","DOUBLE" }
                            };                            
                        }
                        break;
                    case "PagamentoConta":
                        {
                            campos = new string[,] {
                                {"id","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE" },
                                {"data_lancamento","TEXT" },
                                {"data_vencimento","TEXT" },
                                {"valor","DOUBLE" }                                
                            };
                        }
                        break;
                    case "FormasPagamento":
                        {
                            campos = new string[,]
                            {
                                {"id","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE" },
                                {"descricao","TEXT" },
                                {"tipo","TEXT" },
                                {"excluido","INTEGER NOT NULL DEFAULT 0" },
                                {"status","INTEGER NOT NULL DEFAULT 1" }
                            };
                        }
                        break;
                        
                }

                return campos;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public string[] ObterTabelas()
        {
            try
            {
                string[] tabelas = new string[]
                {
                    "Usuario",
                    "Cliente",
                    "Produto",
                    "Fornecedor",
                    "Pagamento",
                    "PagamentoConta",
                    "FormasPagamento"
                };

                return tabelas;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public string[] ObterComandosSql()
        {
            string[] comandos = { };
            string comando = "";
            string[] tabelas = ObterTabelas();
            comandos = new string[tabelas.Length];
            for (int i = 0; i < tabelas.Length; i++)
            {
                comando = "CREATE TABLE IF NOT EXISTS " + tabelas[i] + " (";
                string[,] campos = ObterCampos(tabelas[i]);
                for (int j = 0; j < campos.GetLength(0); j++)
                {
                    comando += campos[j, 0] + " " + campos[j, 1];
                    if (j != campos.GetLength(0) - 1)
                    {
                        comando += ",";
                    }
                }
                comando += ")";
                comandos[i] = comando;
            }
            return comandos;
        }
        public string[] ObterRegras()
        {
            try
            {
                string[] retorno = new string[] {
                    "ALTER TABLE PagamentoConta ADD COLUMN id_pagamento INTEGER REFERENCES Pagamento(id)",
                    "ALTER TABLE Pagamento ADD COLUMN id_fornecedor INTEGER REFERENCES Fornecedor(id_forn)",
                    "ALTER TABLE Pagamento ADD COLUMN id_forma_pagamento INTEGER REFERENCES FormasPagamento(id)"
                };

                return retorno;
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
