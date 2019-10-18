using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.IO;
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
                    case "Perfil":
                        campos = new string[,]
                        {
                            {"id","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE" },
                            {"descricao", "TEXT NOT NULL" },
                            {"excluido", "INTEGER NOT NULL DEFAULT 0" }
                        };
                        break;
                    case "Usuario":
                        campos = new string[,]
                         {
                           {"id","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE"},
                           {"nome","TEXT NOT NULL" },
                           {"sobrenome","TEXT NOT NULL" },
                           {"codigo","INTEGER" },
                           {"senha_login","TEXT NOT NULL" },                           
                           {"status","TEXT NOT NULL DEFAULT true" },
                           {"cpf","TEXT NOT NULL UNIQUE" },
                           {"operador_cadastro_id","INTEGER" },
                           {"operador_cadastro_nome","TEXT" },
                           {"datahora_cadastro","TEXT" },
                           {"operador_alteracao_id","INTEGER" },
                           {"operador_alteracao_nome","TEXT" },
                           {"datahora_alteracao","TEXT" },
                           {"excluido","INTEGER NOT NULL DEFAULT 0" }
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
                            {"cep","TEXT" },
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
                            {"id","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE" },
                            {"cnpj","TEXT" },
                            {"ie","TEXT" },
                            {"fantasia","TEXT NOT NULL" },
                            {"razao","TEXT NOT NULL" },
                            {"status","INTEGER NOT NULL DEFAULT 1" },
                            {"endereco","TEXT" },
                            {"numero","INTEGER" },
                            {"complemento","TEXT" },
                            {"cidade","TEXT" },
                            {"bairro","TEXT" },
                            {"cep","TEXT" },
                            {"telefone","INTEGER" },
                            {"contato","TEXT" },
                            {"email","TEXT" },
                            {"observacao","TEXT" },
                            {"digito_verificador","TEXT" },
                            {"operador_cadastro_id","INTEGER" },
                            {"operador_cadastro_nome","TEXT" },
                            {"operador_alteracao_id","INTEGER" },
                            {"operador_alteracao_nome","TEXT" },
                            {"datahora_cadastro","TEXT" },
                            {"datahora_alteracao","TEXT" },
                            {"excluido","INTEGER NOT NULL DEFAULT 0" }
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
                    "FormasPagamento",
                    "Perfil"
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
                    "ALTER TABLE Pagamento ADD COLUMN id_forma_pagamento INTEGER REFERENCES FormasPagamento(id)",
                    "ALTER TABLE Usuario ADD COLUMN perfil_id INTEGER REFERENCES Perfil(id)"
                };

                return retorno;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public string[,] ObterAtualizacoes()
        {
            try
            {
                string[,] comandos = new string[,]
            {
                //tabela,coluna,tipo
                {"Fornecedor","ie","TEXT"}
            };

                return comandos;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public bool CriaBd(ProgressBarAdv barraProgresso)
        {
            try
            {
                string[] comando = ObterComandosSql();
                string[] regras = ObterRegras();
                if (File.Exists(utilitarios.caminhoBD) == false)
                {
                    if (Directory.Exists(utilitarios.diretorioBD) == false)
                    {
                        Directory.CreateDirectory(utilitarios.diretorioBD);
                    }
                    barraProgresso.Visible = true;

                    //CRIA TABELAS E CAMPOS
                    barraProgresso.Minimum = 0;
                    barraProgresso.Maximum = comando.Length;
                    for (int i = 0; i < comando.Length; i++)
                    {
                        utilitarios.RealizaConexaoBd(comando[i]);
                        barraProgresso.Value = i + 1;
                        barraProgresso.Refresh();
                    }

                    //CRIA REGRAS
                    barraProgresso.Minimum = 0;
                    barraProgresso.Maximum = regras.Length;
                    for (int i = 0; i < regras.Length; i++)
                    {
                        utilitarios.RealizaConexaoBd(regras[i]);
                        barraProgresso.Value = i + 1;
                        barraProgresso.Refresh();
                    }
                    barraProgresso.Visible = false;
                    return true;
                }
                else
                {
                    //ATUALIZA BANCO
                    string[,] novosCampos = ObterAtualizacoes();
                    for (int i = 0; i < novosCampos.GetLength(0); i++)
                    {
                        barraProgresso.Visible = true;

                        //CRIA TABELAS E CAMPOS
                        barraProgresso.Minimum = 0;
                        barraProgresso.Maximum = novosCampos.GetLength(0);
                        if (utilitarios.VerificaSeColunaExisteNoBd(novosCampos[i, 0], novosCampos[i, 1]) == false)
                        {
                            utilitarios.RealizaConexaoBd("ALTER TABLE " + novosCampos[i, 0] + " ADD COLUMN " + novosCampos[i, 1] + " " + novosCampos[i, 2]);

                            barraProgresso.Value = i + 1;
                            barraProgresso.Refresh();
                        }
                    }
                    barraProgresso.Visible = false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
