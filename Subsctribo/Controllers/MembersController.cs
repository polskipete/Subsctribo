using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Subsctribo.Models;

namespace Subsctribo.Controllers
{
    public class MembersController : Controller
    {
        private ApplicationDbContext _context;

        public MembersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Members
        [Route("members")]
        public ActionResult Index()
        {
            var members = _context.Members.Include(m => m.MembershipType).ToList();
            return View(members);
        }

        public ActionResult MemberPage (int id)
        {
            var members = _context.Members.SingleOrDefault(member => member.Id == id);
            if (members == null)
                return HttpNotFound();

            return View(members);
        }
    }
}