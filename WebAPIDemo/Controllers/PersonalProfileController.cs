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
                userProfile.UserType = (personalProfile.UserType != null) ? personalProfile.UserType : userProfile.UserType;
                userProfile.AdharNumber = (personalProfile.AdharNumber!=null)?personalProfile.AdharNumber:userProfile.AdharNumber;
                userProfile.Country = (personalProfile.Country!=null)?personalProfile.Country:userProfile.Country;
                userProfile.CropArea = (personalProfile.CropArea!=null)?personalProfile.CropArea:userProfile.CropArea;
                userProfile.District = (personalProfile.District!=null)?personalProfile.District:userProfile.District;
                userProfile.DOB = (personalProfile.DOB!=null)?personalProfile.DOB:userProfile.DOB;
                userProfile.FarmerName = (personalProfile.FarmerName!=null)?personalProfile.FarmerName:userProfile.FarmerName;
                userProfile.Gender = (personalProfile.Gender!=null)?personalProfile.Gender:userProfile.Gender;
                userProfile.Language = (personalProfile.Language!=null)?personalProfile.Language:userProfile.Language;
                userProfile.MobileNumber = (personalProfile.MobileNumber!=null)?personalProfile.MobileNumber:userProfile.MobileNumber;
                userProfile.PANNumber = (personalProfile.PANNumber!=null)?personalProfile.PANNumber:userProfile.PANNumber;
                userProfile.State = (personalProfile.State!=null)?personalProfile.State:userProfile.State;
                userProfile.Tehsil = (personalProfile.Tehsil!=null)?personalProfile.Tehsil:userProfile.Tehsil;
                userProfile.UserPhoto = (personalProfile.UserPhoto!=null)?personalProfile.UserPhoto:userProfile.UserPhoto;
                userProfile.Village = (personalProfile.Village!=null)?personalProfile.Village:userProfile.Village;                
                _context.SaveChanges();
                return Ok("Personal Profile Updated!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            
        }

        public PersonalProfile Get(string key)
        {
            return _context.PersonalProfile.SingleOrDefault(a => a.Email == key || a.ApplicationUserId==key);
        }
    }
}
