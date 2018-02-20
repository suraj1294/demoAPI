using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIDemo.ViewModel
{
    public class TehsilAdd
    {
        public int Id { get; set; }
        [Required]
        [StringLength(480)]        
        public string Name { get; set; }
        [Required]        
        public int DistrictId { get; set; }
       
    }
}