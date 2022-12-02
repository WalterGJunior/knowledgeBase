using System;

namespace DAL.DAO
{
    public class UserDAO
    {
        public tb_usuario ValidarLogin(string email_usuario, string senha_usuario)
        {
            Banco objBanco = new Banco();

            tb_usuario objUser = objBanco.tb_usuario.FirstOrDefault(p => p.email_usuario == email_usuario && p.senha_usuario == senha_usuario);
            return objUser;
        }
    }
}
