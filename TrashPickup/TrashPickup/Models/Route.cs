using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashPickup.Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Zip")]
        public int ZipRefId { get; set; }

        public Zip Zip { get; set; }
    }
}