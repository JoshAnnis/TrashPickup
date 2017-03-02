using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TrashPickup.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public Address address { get; set; }
        
        
        public int StateId { get; set; }
        [ForeignKey("StateId")]
        public State State { get; set; }

        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public Cities City { get; set; }
        
       public int ZipId { get; set; }
        [ForeignKey("ZipId")]
        public Zip Zip { get; set; }
        
      




    }
}