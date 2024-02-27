using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using s5l1.Models;

namespace s5l1.Controllers
{
    public class AddEmployeeController : Controller
    {

        [HttpPost]
        public IActionResult Add(string Nome, string Cognome, string Indirizzo, string Codfiscale, bool Coniugato, int Nfigli, string Mansione)
        {
            Database.AddDipendenti(Nome, Cognome, Indirizzo, Codfiscale, Coniugato, Nfigli, Mansione);
            return RedirectToAction("Index");

        }
        public IActionResult Index()
        {
            return View(Database.GetDipendenti());
        }
    }
}
