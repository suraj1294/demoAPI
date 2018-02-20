using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class State
    {
        
        public int Id  { get; set; }
        [Required]
        [StringLength(480)]
        [Index(Order = 2,IsUnique =true)]
        public string Name { get; set; }
        [Required]        
        [Index(Order = 1, IsUnique = true)]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}