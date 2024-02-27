using Microsoft.AspNetCore.Mvc;
using s5l1.Models;

namespace s5l1.Controllers
{
    public class AddPayementsController : Controller
    {

        [HttpPost]
        public IActionResult Add(string cfiscale, DateOnly datainizio, DateOnly datafine, int pagamento, string tipo)
        {
            Database.AddPagamento(cfiscale, datainizio, datafine, pagamento, tipo);
            return RedirectToAction("Index");

        }
        public IActionResult Index()
        {
            return View(Database.GetPagamenti());
        }
    }
}
