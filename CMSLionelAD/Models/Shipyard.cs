using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSLionelAD.Models
{
    public class Shipyard
    {
        public int ShipyardID { get; set; }

        public string ShipYardName { get; set; }

        public int CurrentNumberOfShipsDocked { get; set; }

        public int ShipYardDockNumber { get; set; }

        public int TotalNumberOfContainers { get; set; }
    }
}