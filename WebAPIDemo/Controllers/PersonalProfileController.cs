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
            var userProfile = _context.PersonalProfile.SingleOrDefault(a => a.ApplicationUserId == personalProfile.UserId);
            if (userProfile == null)
            {
                return NotFound();
            }

            try
            {
                userProfile.UserType = personalProfile.UserType;
                userProfile.AdharNumber = personalProfile.AdharNumber;
                userProfile.Country = personalProfile.Country;
                userProfile.CropArea = personalProfile.CropArea;
                userProfile.District = personalProfile.District;
                userProfile.DOB = personalProfile.DOB;
                userProfile.FarmerName = personalProfile.FarmerName;
                userProfile.Gender = personalProfile.Gender;
                userProfile.Language = personalProfile.Language;
                userProfile.MobileNumber = personalProfile.MobileNumber;
                userProfile.PANNumber = personalProfile.PANNumber;
                userProfile.State = personalProfile.State;
                userProfile.Tehsil = personalProfile.Tehsil;
                userProfile.UserPhoto = personalProfile.UserPhoto;
                userProfile.Village = personalProfile.Village;
                _context.PersonalProfile.Add(userProfile);
                _context.SaveChanges();
                return Ok("Record Updated!");

            }catch(Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            return Ok("Personal Profile Updated!");
        }

        public PersonalProfile Get(string key)
        {
            return _context.PersonalProfile.SingleOrDefault(a => a.Email == key || a.ApplicationUserId==key);
        }
    }
}
