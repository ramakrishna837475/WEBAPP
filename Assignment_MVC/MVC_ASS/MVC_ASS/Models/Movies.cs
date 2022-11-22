using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_ASS.Models
{
    public class Movies
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime RDate { get; set; }
    }
}