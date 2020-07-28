using System;
using System.Collections.Generic;

namespace BarTown.Models.Entities
{
    public partial class TblLocation
    {
        public int PkLocation { get; set; }
        public string LocationName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? FkTehranRegion { get; set; }
        public int FkLocationType { get; set; }
    }
}
