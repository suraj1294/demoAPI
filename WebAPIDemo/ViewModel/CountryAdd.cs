using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.ViewModel
{
    public class CountryAdd
    {
        public int Id { get; set; }
        [Required]
        [StringLength(450)]       
        public string Name { get; set; }
    }
}