using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class PersonalProfile
    {
        
        public string ApplicationUserId { get; set; }
        [Key]        
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserPhoto { get; set; }
        public string Language { get; set; }
        public string UserType { get; set; }
        public string FarmerName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string PANNumber { get; set; }
        public string AdharNumber { get; set; }
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Tehsil { get; set; }
        public string Village { get; set; }
        public string CropArea { get; set; }
        public ApplicationUser AspNetRoles { get; set; }

    }
}