using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioDB
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public LocalDBClass db;

        public FicharioDB(string Tabela)
        {
            status = true;

            try
            {
                db = new LocalDBClass();
                tabela = Tabela;
                mensagem = "Conexão com a tabela criada com sucesso!";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com a tabela com erro: " + ex.Message;
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;

            try
            {
                var SQL = "INSERT INTO " + tabela + "(Id, JSON) VALUES ('" + Id + "', '" + jsonUnit + "');";

                db.SQLCommand(SQL);

                mensagem = "Inclusão não permitida porque o identificador já existe: " + Id;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }

        public string Buscar(string Id)
        {
            status = true;

            try
            {
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE Id = '" + Id + "';";
                var dt = db.SQLQuery(SQL);

                if(dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    mensagem = "Busca efetuada com sucesso! Identificador: " + Id;
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existe: " + Id;
                }
               
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o contéudo do identificador: " + ex.Message;
            }

            return "";
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();

            try
            {
                var SQL = "SELECT Id, JSON FROM " + tabela + ";";
                var dt = db.SQLQuery(SQL);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        List.Add(conteudo);
                    }

                    return List;
                }
                else
                {
                    status = false;
                    mensagem = "Não existem clientes na base de dados";
                }

                return List;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o contéudo do identificador: " + ex.Message;
            }
            return List;
        }

        public void Apagar(string Id)
        {
            status = true;

            try
            {
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE Id = '" + Id + "';";
                var dt = db.SQLQuery(SQL);

                if (dt.Rows.Count > 0)
                {
                    SQL = "DELETE FROM " + tabela + " WHERE Id = '" + Id + "';";
                    db.SQLCommand(SQL);
                    mensagem = "Exclusão efetuada com sucesso! Identificador: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existe: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o contéudo do identificador: " + ex.Message;
            }
        }

        public void Alterar(string Id, string jsonUnit)
        {
            status = true;

            try
            {

                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE Id = '" + Id + "';";
                var dt = db.SQLQuery(SQL);

                if (dt.Rows.Count > 0)
                {
                    SQL = "UPDATE " + tabela + " SET JSON = '" + jsonUnit + "' WHERE Id = '" + Id + "';";
                    db.SQLCommand(SQL);
                    mensagem = "Alteração efetuada com sucesso! Identificador: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existe: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o banco com erro: " + ex.Message;
            }
        }
    }
}
