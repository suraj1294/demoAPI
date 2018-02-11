using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Authorize]
    public class MastersController : ApiController
    {
        private ApplicationDbContext _context;
        public MastersController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [HttpGet]
        public string Get()
        {
            return "Specify Master Name to get Master Detais";
        }

        [HttpGet]
         public IEnumerable<Language> Languges()
        {
            return _context.Language.ToList();
        }
        
        [HttpGet]
        public IEnumerable<User> UserType()
        {
            return _context.User.ToList();
        }


    }
}
