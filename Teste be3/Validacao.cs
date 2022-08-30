using System;


namespace Teste_be3

{
    public class Validacao
    {
      
        public static bool ValidaSenha(string pswd)
        {
            if (pswd == "Acesso"){

                return true;
            }
            return false;
        }
    }
}
