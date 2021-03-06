﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class UserCrop
    {
   

        [Key]
        [Column(Order = 0)]
        public string ApplicationUserId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Name { get; set; }

        public ApplicationUser AspNetRoles { get; set; }
    }
}