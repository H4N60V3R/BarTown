using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarTown.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BarTown.Controllers.Api
{
    public class LocationsController : BaseApiController
    {
        private readonly BarTownContext _context;

        public LocationsController(BarTownContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblLocation>> GetAll() => await _context.TblLocation
            .OrderBy(l => l.LocationName)
            .ToListAsync();
    }
}
