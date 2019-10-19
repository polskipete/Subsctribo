using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Subsctribo.Models;

namespace Subsctribo.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        [Route("members")]
        public ActionResult Index()
        {
            var members=GetMembers();
            return View(members);
        }

        public ActionResult MemberPage (int id)
        {
            var members = GetMembers().SingleOrDefault(member => member.Id == id);
            if (members == null)
                return HttpNotFound();

            return View(members);
        }

        private IEnumerable<Members> GetMembers()
        {
            return new List<Members>
            {
                new Members { Id = 1, Name = "Borat Sagdiyev" },
                new Members { Id = 2, Name = "Jim Jones" }
            };
        }
    }
}