using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class Tehsil
    {        
        public int Id { get; set; }
        [Required]
        [StringLength(480)]
        [Index(IsUnique = true, Order = 2)]
        public string Name { get; set; }
        [Required]
        [Index(IsUnique = true, Order = 1)]
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}