using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Bliblioteca.Classes.Database
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario(String Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                    mensagem = "Conexao com fichario criada com sucesso.";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexao com o fichario com erro" + ex.Message;
            }

            diretorio = Diretorio;

        }
        public void Incluir(string Prontuario, string jsonUnit)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + Prontuario + ".json"))
                {
                    status = false;
                    mensagem = "Inclusao nao permitida, pois o identificador ja exite " + Prontuario;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Prontuario + ".json", jsonUnit);
                    status = true;
                    mensagem = "Inclusao efetuada com sucesso. Identificador " + Prontuario;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexao com o fichario com erro" + ex.Message;
            }

        }
        public string Buscar(string Prontuario)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Prontuario + ".json")))
                {
                    status = false;
                    mensagem = "Inclusao nao permitida, pois o identificador ja exite " + Prontuario;

                }
                else
                {
                   string conteudo = File.ReadAllText(diretorio + "\\" + Prontuario + ".json");
                    status = true;
                    mensagem = "Inclusao efetuada com sucesso. Identificador " + Prontuario;
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro de busca" + ex.Message;
            }
            return "";

        }


        public void Alterar(string Prontuario, string jsonUnit)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Prontuario + ".json")))
                {
                    status = false;
                    mensagem = "Alteracao nao permitida, pois o identificador ja exite " + Prontuario;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Prontuario + ".json");
                    File.WriteAllText(diretorio + "\\" + Prontuario + ".json", jsonUnit);
                    status = true;
                    mensagem = "Inclusao efetuada com sucesso. Identificador " + Prontuario;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexao com o fichario com erro" + ex.Message;
            }

        }

    }
}
