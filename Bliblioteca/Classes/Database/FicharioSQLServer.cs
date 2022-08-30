using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliblioteca.Classes.Database
{
    public class FicharioSQLServer
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public SQLServerC db;

        public FicharioSQLServer(string Tabela)
        {
            status = true;
            try
            {
                db = new SQLServerC();
                tabela = Tabela;
                mensagem = "Conexão com a Tabela criada com sucesso";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;
            }
        }

        public void Incluir(string Prontuario, string jsonUnit)
        {
            status = true;
            try
            {
                // INSERT INTO CLIENTE (ID, JSON) VALUES ('000001','{...}')

                var SQL = "INSERT INTO " + tabela + " (Prontuario, JSON) VALUES ('" + Prontuario + "', '" + jsonUnit + "')";
                db.SQLCommand(SQL);
                status = true;
                mensagem = "Inclusão efetuada com sucesso. Identificador: " + Prontuario;

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }

        public string Buscar(string Prontuario)
        {
            status = true;
            try
            {
                // SELECT ID, JSON FROM CLIENTE WHERE ID = '000010'

                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Prontuario + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + Prontuario;
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Prontuario;
                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return "";
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                // SELECT ID, JSON FROM CLIENTE'

                var SQL = "SELECT Id, JSON FROM " + tabela;
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
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return List;
        }

        public void Apagar(string Prontuario)
        {
            status = true;
            try
            {
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Prontuario + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {

                    // DELETE FROM CLIENTE WHERE ID = '00010'

                    SQL = "DELETE FROM " + tabela + " WHERE ID = '" + Prontuario + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + Prontuario;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Prontuario;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
        }

        public void Alterar(string Prontuario, string jsonUnit)
        {
            status = true;
            try
            {

                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Prontuario + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {

                    // UPDATE CLIENTE SET JSON = '{...}' WHERE ID = '00010'

                    SQL = "UPDATE " + tabela + " SET JSON = '" + jsonUnit + "' WHERE ID = '" + Prontuario + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Alteração efetuada com sucesso. Identificador: " + Prontuario;
                }
                else
                {
                    status = false;
                    mensagem = "Alteração não permitida porque o identificador não existe: " + Prontuario;
                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }

        }
    }
}
