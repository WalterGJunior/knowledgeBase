using DAL.DAO;
using Microsoft.AspNetCore.Mvc;

namespace knowledgebase.Controllers
{
    //public class LoginController : SessionVariable
    //{
    //    //
    //    // GET: /Login/

    //    //public ActionResult Login()
    //    //{
    //    //    return View();
    //    //}

    //    //public void Deslogar()
    //    //{
    //    //    CodigoUsuarioLogado = 0;
    //    //    NomeUsuarioLogado = string.Empty;

    //    //    Response.Redirect("/Login/Login");
    //    //}

    //    //public ActionResult ValidarLogin(string email_usuario, string senha_usuario)
    //    //{
    //    //    if (email_usuario.Trim() == string.Empty || senha_usuario.Trim() == string.Empty)
    //    //    {
    //    //        ViewBag.Validar = 0;
    //    //    }
    //    //    else
    //    //    {
    //    //        UserDAO objDAO = new UserDAO();
    //    //        tb_usuario objUser = objDAO.ValidarLogin(email_usuario, senha_usuario);

    //    //        if (objUser != null)
    //    //        {
    //    //            CodigoUsuarioLogado = objUser.cod_usuario;
    //    //            NomeUsuarioLogado = objUser.nome_usuario;
    //    //            Response.Redirect("/Home/Home", false);

    //    //        }
    //    //        else
    //    //        {
    //    //            ViewBag.Validar = -1;
    //    //        }

    //    //    }
    //    //    return View("Login");
    //    //}

    //}
}

