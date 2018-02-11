using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class District
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Key, Column(Order = 1)]
        public State State { get; set; }
    }
}