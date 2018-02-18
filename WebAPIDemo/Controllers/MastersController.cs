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
  //  [Authorize]
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

        [HttpGet]
        public IHttpActionResult userActivities(string key)
        {
            
            var userActivityList = _context.UserActivity.Where(a=>a.ApplicationUserId==key).ToList();
            if (userActivityList == null)
            {
                return NotFound();
            }
            return Ok(userActivityList);
        }

        [HttpPost]
        public IHttpActionResult userActivities(UserActivityAdd useractivityadd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                UserActivity userActivity = new UserActivity
                {
                    ApplicationUserId = useractivityadd.UserId,
                    Name = useractivityadd.Name
                };
                _context.UserActivity.Add(userActivity);
                _context.SaveChanges();
                return Ok(userActivity);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
            
        }

        [HttpGet]
        public IHttpActionResult userCrops(string key)
        {
            var userCropsList = _context.UserCrop.Where(a => a.ApplicationUserId == key).ToList();
            if (userCropsList==null)
            {
                return NotFound();
            }
            return Ok(userCropsList);            
        }

        [HttpPost]
        public IHttpActionResult userCrops(UserCropAdd usercropadd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                UserCrop userCrop = new UserCrop
                {
                    ApplicationUserId = usercropadd.UserId,
                    Name = usercropadd.Name
                };
                _context.UserCrop.Add(userCrop);
                _context.SaveChanges();
                return Ok(userCrop);
            }catch(Exception ex)
            {
                return BadRequest(ex.InnerException.InnerException.Message);
            }
           
            
        }


    }
}
