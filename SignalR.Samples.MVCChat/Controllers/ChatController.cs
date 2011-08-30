using System.Web.Mvc;

namespace SignalR.Samples.MVCChat.Controllers
{
    public class ChatController : Controller
    {
        //
        // GET: /Chat/

        public ActionResult Index()
        {
            return View();
        }

    }
}
