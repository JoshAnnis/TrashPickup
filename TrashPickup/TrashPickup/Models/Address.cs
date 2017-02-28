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
        public string address { get; set; }
        public string address2 { get; set; }
        public string Street { get; set; }
        //Foreign key for State
        public string StateRefId { get; set; }

        [ForeignKey("State")]
        public State State { get; set; }

        //Foreign key for City
        public string CityRefId { get; set; }

        [ForeignKey("City")]
        public City City { get; set; }
        //Foreign key for Zip
        public string ZipRefId { get; set; }

        [ForeignKey("Zip")]
        public Zip Zip { get; set; }




    }
}