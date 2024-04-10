using Microsoft.AspNetCore.Mvc;

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
		public IActionResult Index(IFormCollection iformCollection)
		{
            string name = iformCollection["Username"];
			ViewBag.Name = name;
			return View("Views/Teste/Greetings.cshtml");
            //comment here
		}
	}
}
