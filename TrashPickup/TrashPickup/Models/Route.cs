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
        
        public int ZipId { get; set; }
        [ForeignKey("ZipId")]
        public Zip Zip { get; set; }

    }
}