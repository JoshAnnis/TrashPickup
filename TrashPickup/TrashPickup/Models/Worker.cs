using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TrashPickup.Models
{
    public class Worker
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

    }
}