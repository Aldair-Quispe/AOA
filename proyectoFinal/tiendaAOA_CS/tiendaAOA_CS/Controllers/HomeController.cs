using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace TiendaAOA_CS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Producto> productos = new List<Producto>();
            List<ProductoReciente> productosRecientes = new List<ProductoReciente>();
             
            using (var context = new AOAStoreEntities())
            {
                productos = context.Producto.ToList();
                productosRecientes = context.ProductoReciente.ToList();
            }

            ViewBag.galeria = productos;
            ViewBag.recientes = productosRecientes;

            return View();
        }

        // Para mostrar lista de compras en función al Id de usuario

        public ActionResult Compras()
        {   

            //Para nueva lista de compras

            List<Compras> compras = new List<Compras>();

            // Si el usuario no es nulo, que muestre las compras del usuario segun u

            if (Session["userId"] != null)
            {
                long userId = long.Parse(Session["userId"].ToString());
                using (var context = new AOAStoreEntities())
                    compras = context.Compras.Include("Producto").Where(c => c.usuarioId == userId).ToList();
            }

            ViewBag.Message = "Mis Compras.";
            ViewBag.compras = compras;

            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            string username = Request.Form["txtUsername"].ToString();
            string pasword = Request.Form["txtPassword"].ToString();

            using (var context = new AOAStoreEntities())
            {
                Usuario login = context.Usuario.Where(c => c.username == username && c.password == pasword).FirstOrDefault();

                if (login == null)
                {
                    ViewBag.LoginFailed = "Usuario o Contraseña incorrecta.";
                    return View("Compras");
                }
                else
                {
                    Session["userId"] = login.id;
                    Session["username"] = login.username;
                    return RedirectToAction("Compras");
                }
            }
        }

        public ActionResult Logout()
        {
            Session["userId"] = null;

            return RedirectToAction("Compras");
        }
    }
}