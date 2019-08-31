using System;
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
                            {"cnpj_clt","INTEGER NOT NULL UNIQUE" },
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
                            {"terceiro","INTEGER NOT NULL DEFAULT 1" }
                        };
                        break;
                    case "Produto":
                        {
                            campos = new string[,]
                            {
                                { "id_prod","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE"},
                                {"codigo_prod","INTEGER NOT NULL" },
                                {"categoria_prod","TEXT NOT NULL" },
                                {"desc_prod","TEXT NOT NULL" },
                                {"status_prod","INTEGER NOT NULL DEFAULT 1" },
                                {"cor_prod","TEXT NOT NULL" },
                                {"obs_prod","TEXT" }
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
                            break;

                        }
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
                    "Fornecedor"
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
    }
}
