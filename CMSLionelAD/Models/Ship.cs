using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMSLionelAD.Models
{
    public class Ship
    {
        [Key]
        public int ShipID { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string ShipDescription { get; set; }

        [Required]
        public int NumberOfContainersCarried { get; set; }
    }
}