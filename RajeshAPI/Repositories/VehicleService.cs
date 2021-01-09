using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RajeshAPI.Contracts;
using RajeshAPI.DatabaseContext;
using RajeshAPI.DTOs;
using RajeshAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.Repositories
{
    public class VehicleService : IVehicleService
    {
        private readonly AppDbContext appDbContext;
        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger<VehicleService> logger;

        public VehicleService(AppDbContext appDbContext,
            IUnitOfWork unitOfWork,
            ILogger<VehicleService> logger
            )
        {
            this.appDbContext = appDbContext;
            this.unitOfWork = unitOfWork;
            this.logger = logger;
        }

        public async Task AddVehicle(VehicleDto vehicleDto)
        {
            try
            {
                var features = new List<Feature>();

                foreach (var feature in vehicleDto.Features)
                {
                    features.Add(new Feature
                    {
                        CreatedDate = DateTime.UtcNow,
                        Name = feature.Name,
                        Id = feature.Id
                    });
                }
                var vehicle = new Vehicle
                {
                    CreatedDate = DateTime.UtcNow,
                    Name = vehicleDto.Name,
                    ModelId = vehicleDto.ModelId,
                    Features = features,
                    ContactDetails = new ContactDetails
                    {
                        CreatedDate = DateTime.UtcNow,
                        Name = vehicleDto.ContactDetails.Name,
                        Phone = vehicleDto.ContactDetails.Phone,
                        Email = vehicleDto.ContactDetails.Email
                    }
                };
                appDbContext.Vehicles.Add(vehicle);
                await unitOfWork.Save();
            }
            catch (Exception e)
            {
                logger.LogInformation("Exception in Add Vehicle", e.Message);
                throw;
            }

        }

        public Task DeleteVehicle(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Vehicle> GetVehicle(int id)
        {
            return await appDbContext.Vehicles
                .Include(x => x.Features)
                .Include(x => x.ContactDetails)
                .Include(x => x.Model)
                .ThenInclude(x => x.Make)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public Task UpdateVehicle(int id, VehicleDto vehicleDto)
        {
            throw new NotImplementedException();
        }
    }
}
