using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CMSLionelAD.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; }

        [ForeignKey("Ship")]
        public int ShipID { get; set; }
        public Ship Ship { get; set; }

        [ForeignKey("Container")]
        public int ContainerID { get; set; }
        public Container Container { get; set; }


        [DataType(DataType.Currency)]
        public double ChargePrice { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DepartureTime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ArrivalTime { get; set; }


        [ForeignKey("Shipyard")]
        public int DestinationShipyardID { get; set; }
        public virtual Shipyard Shipyard { get; set; }

        [ForeignKey("Shipyard1")]
        public int ArrivalShipyardID { get; set; }
        public virtual Shipyard Shipyard1 { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}