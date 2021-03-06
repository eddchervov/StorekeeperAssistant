﻿using Microsoft.AspNetCore.Mvc;
using StorekeeperAssistant.Api.Models.Warehouse;
using StorekeeperAssistant.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorekeeperAssistant.WebApp.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseRemoteCallService _warehouseRemoteCallService;

        public WarehouseController(IWarehouseRemoteCallService warehouseRemoteCallService)
        {
            _warehouseRemoteCallService = warehouseRemoteCallService;
        }

        [HttpGet("warehouses/get")]
        public async Task<IActionResult> GetWarehousesAsync(GetWarehouseRequest request)
        {
            var response = await _warehouseRemoteCallService.GetWarehousesAsync(request);

            return Json(response);
        }
    }
}
