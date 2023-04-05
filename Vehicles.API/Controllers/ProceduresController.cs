using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data;
using Microsoft.EntityFrameworkCore;


namespace Vehicles.API.Controllers
{
    public class ProceduresController:Controller
    {
        private readonly DataContext _context;

        public ProceduresController(DataContext context)
        {
            _context = context;
        }
        // GET: VehicleTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Procedures.ToListAsync());
        }

       
        private bool VehicleTypeExists(int id)
        {
            return _context.VehicleTypes.Any(e => e.Id == id);
        }
    }
}
