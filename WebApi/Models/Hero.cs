using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Hero
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Species { get; set; }
        public string World { get; set; }
        public string Type { get; set; }
    }
}