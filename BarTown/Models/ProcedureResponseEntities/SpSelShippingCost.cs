using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarTown.Models.ProcedureResponseEntities
{
    public class SpSelShippingCost
    {
        public int FkOriginLocation { get; set; }
        public string OriginLocationName { get; set; }
        public int FkDestinationLocation { get; set; }
        public string DestinationLocationName { get; set; }
        public int FkTruckType1 { get; set; }
        public string TruckType1Name { get; set; }
        public int ShippingCost1 { get; set; }
        public int FkTruckType2 { get; set; }
        public string TruckType2Name { get; set; }
        public int ShippingCost2 { get; set; }
        public int FkTruckType3 { get; set; }
        public string TruckType3Name { get; set; }
        public int ShippingCost3 { get; set; }
        public int FkTruckType4 { get; set; }
        public string TruckType4Name { get; set; }
        public int ShippingCost4 { get; set; }
        public int FkTruckType5 { get; set; }
        public string TruckType5Name { get; set; }
        public int ShippingCost5 { get; set; }
        public int FkTruckType6 { get; set; }
        public string TruckType6Name { get; set; }
    }
}
