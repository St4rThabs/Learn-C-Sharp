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
    }
}
