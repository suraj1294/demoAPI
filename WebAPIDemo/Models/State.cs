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
        [Key, Column(Order = 0)]
        public int Id  { get; set; }
        public string Name { get; set; }
        [Key, Column(Order = 1)]
        public Country Country { get; set; }
    }
}