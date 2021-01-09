using RajeshAPI.DTOs;
using RajeshAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.Contracts
{
    public interface IVehicleService
    {
        Task AddVehicle(VehicleDto vehicleDto);
        Task UpdateVehicle(int id,VehicleDto vehicleDto);
        Task DeleteVehicle(int id);
        Task<Vehicle> GetVehicle(int id);
    }
}
