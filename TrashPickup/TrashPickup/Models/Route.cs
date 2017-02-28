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
<<<<<<< HEAD

        [ForeignKey("Zip")]
        public int ZipRefId { get; set; }
=======
>>>>>>> 3f37c3f50f7f294c7c8eec2c35a7f96cc596e212

        
        public int ZipId { get; set; }
        [ForeignKey("ZipId")]
        public Zip Zip { get; set; }

    }
}