using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}