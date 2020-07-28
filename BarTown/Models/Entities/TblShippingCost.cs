using System;
using System.Collections.Generic;

namespace BarTown.Models.Entities
{
    public partial class TblShippingCost
    {
        public int PkShippingCost { get; set; }
        public int FkOriginLocation { get; set; }
        public int FkDestinationLocation { get; set; }
        public int FkTruckType { get; set; }
        public int ShippingCost { get; set; }
        public string ShippingCostDesc { get; set; }
    }
}
