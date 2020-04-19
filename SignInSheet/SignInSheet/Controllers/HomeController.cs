using SignInSheet.Data;
using SignInSheet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace SignInSheet.Controllers
{
    public class HomeController : Controller
    {

        private TableContext db = new TableContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(Signature signatureModel)
        {

            if (ModelState.IsValid)
            {

                signatureModel = new Signature()
                {
                    firstName = signatureModel.firstName,
                    lastName = signatureModel.lastName,
                    email = signatureModel.email

                };


                db.Signatures.Add(signatureModel);

                await db.SaveChangesAsync();

                return RedirectToAction("Index");

            }

            return View();
        }

    }
}
 