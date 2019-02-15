using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCApp.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RegNo { get; set; }
        public string Address { get; set; }
    }
}
