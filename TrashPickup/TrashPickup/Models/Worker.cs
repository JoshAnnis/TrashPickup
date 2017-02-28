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
        public int Id { get; set; }
        public string Name { get; set; }
        public int Route { get; set; }


    }
}