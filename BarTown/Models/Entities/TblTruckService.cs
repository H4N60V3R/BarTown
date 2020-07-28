using System;
using System.Collections.Generic;

namespace BarTown.Models.Entities
{
    public partial class TblTruckService
    {
        public int PkTruckService { get; set; }
        public int FkTruckType { get; set; }
        public int LoadingTime { get; set; }
        public int UnLoadingTime { get; set; }
        public int OverLoadCost { get; set; }
        public string TruckServiceDesc { get; set; }
    }
}
