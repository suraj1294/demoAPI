using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class CountryController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public CountryController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();            
        }
        [HttpPost]
        public IHttpActionResult Country(Country country)
        {
            return Ok();
        }
    }
}
