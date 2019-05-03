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
                           {"Id_vendedor","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE"},
                           {"nome_vend","TEXT NOT NULL" },
                           {"login","TEXT NOT NULL" },
                           {"contas","INTEGER" },
                           {"senha_login","TEXT NOT NULL" }
                         };
                        break;
                    case "Cliente":
                        campos = new string[,]
                        {
                            {"id_clt","INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE" },
                            {"cnpj_clt","INTEGER NOT NULL UNIQUE" },
                            {"nome_fantasia_clt","TEXT NOT NULL" },
                            {"razao_social_clt","TEXT NOT NULL" },
                            {"status_clt","INTEGER NOT NULL DEFAULT 0" },
                            {"endereco_clt","TEXT" },
                            {"numero_clt","INTEGER" },
                            {"telefone_clt","INTEGER" },
                            {"nome_contato_clt","TEXT" },
                            {"email_contato_clt","TEXT" }
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
                                {"status_prod","INTEGER NOT NULL DEFAULT 0" },
                                {"cor_prod","TEXT NOT NULL" },
                                {"obs_prod","TEXT" }
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
                    "Produto"
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
