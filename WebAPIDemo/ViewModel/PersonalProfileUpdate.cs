using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIDemo.ViewModel
{
    public class PersonalProfileUpdate
    {
        [Required]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserPhoto { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        public string FarmerName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string PANNumber { get; set; }
        public string AdharNumber { get; set; }
        [Required]
        public DateTime? DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Tehsil { get; set; }
        [Required]
        public string Village { get; set; }
        [Required]
        public string CropArea { get; set; }
    }
}