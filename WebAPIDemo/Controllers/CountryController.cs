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
        public IHttpActionResult Country(CountryAdd countryadd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Country country = new Country()
                {
                    Name = countryadd.Name
                };
                _context.Country.Add(country);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            return Ok("Country Added");
        }

        [HttpPost]
        public IHttpActionResult CountryUpdate(CountryAdd countryadd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var country = _context.Country.SingleOrDefault(a => a.Id == countryadd.Id);
            if (country == null)
            {
                return NotFound();
            }
            try
            {
                country.Name = countryadd.Name;                
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            return Ok("Country Updated");
        }

        [HttpPost]
        public IHttpActionResult State(StateAdd stateadd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                State state = new State()
                {
                    Name = stateadd.Name,
                    CountryId = stateadd.CountryId
                };
                _context.State.Add(state);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            return Ok("State added!");
        }

        [HttpPost]
        public IHttpActionResult StateUpdate(StateAdd ObjAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Obj = _context.State.SingleOrDefault(a => a.Id == ObjAdd.Id);
            if (Obj == null)
            {
                return NotFound();
            }
            try
            {
                Obj.Name = ObjAdd.Name;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            return Ok("State updated");
        }

        [HttpPost]
        public IHttpActionResult District(DistrictAdd Distadd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                District dist = new District()
                {
                    Name = Distadd.Name,
                    StateId = Distadd.StateId
                };
                _context.District.Add(dist);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            return Ok("State added!");
        }

        [HttpPost]
        public IHttpActionResult DistrictUpdate(DistrictAdd ObjAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Obj = _context.District.SingleOrDefault(a => a.Id == ObjAdd.Id);
            if (Obj == null)
            {
                return NotFound();
            }
            try
            {
                Obj.Name = ObjAdd.Name;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            return Ok("State updated");
        }

        [HttpPost]
        public IHttpActionResult Tehsil(TehsilAdd Tehsiladd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Tehsil tehsil = new Tehsil()
                {
                    Name = Tehsiladd.Name,
                    DistrictId = Tehsiladd.DistrictId
                };
                _context.Tehsil.Add(tehsil);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            return Ok("State added!");
        }

        [HttpPost]
        public IHttpActionResult TehsilUpdate(TehsilAdd ObjAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Obj = _context.District.SingleOrDefault(a => a.Id == ObjAdd.Id);
            if (Obj == null)
            {
                return NotFound();
            }
            try
            {
                Obj.Name = ObjAdd.Name;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            return Ok("Tehsil updated");
        }
    }
}
