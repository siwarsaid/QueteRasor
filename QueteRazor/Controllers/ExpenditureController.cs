using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QueteRazor.Models;

namespace QueteRazor.Controllers
{
    public class ExpenditureController : Controller
    {
        // GET: ExpenditureController
        public ActionResult Index()
        {
            return View(GetExpenditureModels());
        }

        // GET: ExpenditureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        private IEnumerable<ExpenditureModel> GetExpenditureModels()
        {
            List<ExpenditureModel> expenditureModels = new List<ExpenditureModel>();
            expenditureModels.Add(new ExpenditureModel { Date = DateTime.Now , Name = "Toto" , Price = 100.0});
            expenditureModels.Add(new ExpenditureModel { Date = DateTime.Now, Name = "Toto 1", Price = 110.0 });
            expenditureModels.Add(new ExpenditureModel { Date = DateTime.Now, Name = "Toto 2", Price = 120.0 });
            return expenditureModels;
        }

       
    }
}
