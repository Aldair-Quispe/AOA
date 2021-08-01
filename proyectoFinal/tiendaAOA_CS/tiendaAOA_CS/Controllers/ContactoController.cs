using System.Web.Mvc;

namespace TiendaAOA_CS.Controllers
{
    public class ContactoController : Controller
    {
        public ActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnviarMensaje()
        {
            ViewBag.MensajeEnviado = "Su mensaje ha sido enviado exitosamente.";

            return View("Contacto");
        }
    }
}