using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
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

        //Validar token gerado pelo servidor (na página index.cshtml
        [ValidateAntiForgeryToken]
		public IActionResult Index(Person person)
		{
            //string name = person.Name;
            //ViewBag.Name = person.Name;

            //condição abaixo valida o lado servidor (não depende do javascript ativado no browser)
            if (ModelState.IsValid)
            {
                
                return View("Greetings", person);
            }
            else 
            {
                return View(person); 
            }   
            //comment here
		}
	}
}
