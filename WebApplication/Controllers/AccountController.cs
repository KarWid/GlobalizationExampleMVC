namespace WebApplication.Controllers
{
    using System.Web.Mvc;
    using WebApplication.Models.Account;

    public class AccountController : BaseController
    {
        [HttpGet]
        /// In the normal scenario it should display e.g. list of accounts
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get(AccountVM accountVM) 
            // ID should be here as an argument in the "normal" scenario, then I could call it as GetAfterCreation or something like that
        {
            return View(accountVM);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AccountVM accountVM)
        {
            if (!ModelState.IsValid)
            {
                return View(accountVM);
            }

            return RedirectToAction(nameof(Get), accountVM);
        }
    }
}