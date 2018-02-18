using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIDemo.ViewModel
{
    public class UserActivityAdd
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}