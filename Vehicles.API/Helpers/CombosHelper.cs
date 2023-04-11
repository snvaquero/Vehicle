using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data;

namespace Vehicles.API.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> GetCombosBrands()
        {
            List<SelectListItem> list = _context.Brands.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                .OrderBy(x => x.Text)
                .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una Marca]",
                Value = "0"

            });
            return list;
        }

        public IEnumerable<SelectListItem> GetCombosDocumentTypes()
        {
            List<SelectListItem> list = _context.DocumentTypes.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                      .OrderBy(x => x.Text)
                      .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un tipo de Documento]",
                Value = "0"

            });
            return list;
        }

        public IEnumerable<SelectListItem> GetCombosProcedures()
        {
            List<SelectListItem> list = _context.Procedures.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                 .OrderBy(x => x.Text)
                 .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un Procedimiento]",
                Value = "0"

            });
            return list;
        }

        public IEnumerable<SelectListItem> GetCombosVehiculeType()
        {
            List<SelectListItem> list = _context.VehicleTypes.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                 .OrderBy(x => x.Text)
                 .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un tipo de Vehiculo]",
                Value = "0"

            });
            return list;
        }
    }
}
