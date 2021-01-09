using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RajeshAPI.Contracts;
using RajeshAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.Controllers
{
    [Route("api/vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService vehicleService;
        private readonly IUnitOfWork unitOfWork;

        public VehicleController(IVehicleService vehicleService, IUnitOfWork unitOfWork)
        {
            this.vehicleService = vehicleService;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> AddVehicle([FromBody] VehicleDto vehicleDto)
        {
            await vehicleService.AddVehicle(vehicleDto);
            return Ok();
        }
        
        [HttpGet]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var vehicle = await vehicleService.GetVehicle(id);
            return Ok(vehicle);
        }
    }
}
