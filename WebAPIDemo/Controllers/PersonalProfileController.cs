using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;
using WebAPIDemo.ViewModel;

namespace WebAPIDemo.Controllers
{
    public class PersonalProfileController : ApiController
    {
        private ApplicationDbContext _context;
        public PersonalProfileController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public IHttpActionResult Post(PersonalProfileUpdate personalProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            return Ok();
        }

        public PersonalProfile Get(string key)
        {
            return _context.PersonalProfile.SingleOrDefault(a => a.Email == key || a.ApplicationUserId==key);
        }
    }
}
