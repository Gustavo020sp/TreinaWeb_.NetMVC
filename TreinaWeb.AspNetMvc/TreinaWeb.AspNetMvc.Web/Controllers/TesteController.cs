using Microsoft.AspNetCore.Mvc;
using TreinaWeb.AspNetMvc.Web.Models;

namespace TreinaWeb.AspNetMvc.Web.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //Metodo abaixo vai ser chamado pelo BeginForm, na view Index
        [HttpPost]
		public IActionResult Index(Person person)
		{
            //string name = person.Name;
            //ViewBag.Name = person.Name;

			return View("Greetings", person);
            //comment here
		}
	}
}
