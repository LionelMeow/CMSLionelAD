using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMSLionelAD.Models
{
    public class Container
    {
        public int ContainerID { get; set; }
        [Required]
        public string ContainerName { get; set; }
        [Required]
        public string ContainerDescription { get; set; }

        [Required]
        public double ContainerWeight { get; set; }
    }
}