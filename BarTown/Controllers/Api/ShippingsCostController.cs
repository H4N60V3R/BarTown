using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarTown.Models.Entities;
using BarTown.Models.ProcedureResponseEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BarTown.Controllers.Api
{
    public class ShippingsCostController : BaseApiController
    {
        private readonly BarTownContext _context;

        public ShippingsCostController(BarTownContext context)
        {
            _context = context;
        }

        public async Task<SpSelShippingCost> Get(int fkOriginLocation, int fkDestinationLocation) => (await _context.Set<SpSelShippingCost>()
            .FromSqlRaw("EXECUTE [dbo].[spSelShippingCost] @p0, @p1",
                        fkOriginLocation,
                        fkDestinationLocation)
            .ToListAsync()).FirstOrDefault();
    }
}
