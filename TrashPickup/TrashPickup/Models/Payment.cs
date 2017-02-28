using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashPickup.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public int CardName { get; set; }
    }
}