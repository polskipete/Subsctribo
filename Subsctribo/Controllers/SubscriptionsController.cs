using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Subsctribo.Models;
using Subsctribo.ViewModels;

namespace Subsctribo.Controllers
{
    public class SubscriptionsController : Controller
    {
        // GET: Subscription
        [Route("subscriptions/random")]
        public ActionResult Random()
        {
            var subscription = GetSubscriptions();
            var Members = new List<Members>
            {
                new Members { Name = "Joe"},
                new Members { Name = "Jeff"}
            };

            var viewModel = new RandomSubscriptionViewModel
            {
                Members = Members
            };
            return View(viewModel);
        }
        // return View( subscription );
        // return Content("Check out that noise!");
        // return HttpNotFound();
        // return new EmptyResult();
        // return RedirectToAction("Index", "Home", new { page = 1, sortBy="Name" });

        [Route("subscriptions")]
        public ActionResult Index()
        {
            var subscriptions = GetSubscriptions();

            return View(subscriptions);
        }

        [Route("subscriptions/date/{year:regex(\\d{4}):range(1900,2200)}/{month:regex(\\d{2}):range(01,12)}")]
        public ActionResult BySubscriptionDate(int year, int month)
        {
            return Content(String.Format(year + "/" + month));
        }

        public IEnumerable<Subscription> GetSubscriptions()
        {
            return new List<Subscription>
            {
                new Subscription() {Id = 1, Name = "Amazon" },
                new Subscription() {Id = 2, Name = "Netflix" }

            };
        }

    }
}