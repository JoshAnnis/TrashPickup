using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashPickup.Models
{
    public class Zip
    {
        [Key]
        public int Id { get; set; }
        public string Zipcode { get; set; }
    }
}