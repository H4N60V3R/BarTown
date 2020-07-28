using System;
using System.Collections.Generic;

namespace BarTown.Models.Entities
{
    public partial class TblConfig
    {
        public int PkConfig { get; set; }
        public int? FkPosition { get; set; }
        public string ConfigDesc1 { get; set; }
        public string ConfigDesc2 { get; set; }
    }
}
