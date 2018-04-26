using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactTO.Models
{
    public class User
    {
        [Key]
        public int Uid { set; get; }

        public String Name { set; get; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        
    }
}