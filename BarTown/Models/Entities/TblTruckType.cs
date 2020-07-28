using System;
using System.Collections.Generic;

namespace BarTown.Models.Entities
{
    public partial class TblTruckType
    {
        public int PkTruckType { get; set; }
        public string TruckTypeName { get; set; }
        public string TruckTypeDesc { get; set; }
    }
}
