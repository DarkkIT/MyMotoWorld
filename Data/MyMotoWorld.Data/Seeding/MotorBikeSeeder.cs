using Microsoft.EntityFrameworkCore.Internal;
using MyMotoWorld.Models;
using MyMotoWorld.Models.Parts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace MyMotoWorld.Data.Seeding
{
    public class MotorBikeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.MotorBikes.Any())
            {
                return;
            }

            var motorBike = new MotorBike
            {
                BikeType = new BikeType { Name = "Naked", Descrition = "Standards, also called naked bikes or roadsters, are versatile, general-purpose street motorcycles.[1] They are recognized primarily by their upright riding position, partway between the reclining rider posture of the cruisers and the forward leaning sport bikes." },
                Name = "Suzuki",
                Descrition = "Perfect bike for citys and middle trivaling type",
                Model = "SV650",
                FrontBrakes = new FrontBrake { Name = "2 x 290 mm discs, 2 piston calipers" },
                RearBrakes = new RearBrake { Name = "Single 240 mm disc, 2 piston caliper" },
                FrontSuspension = new FrontSuspension { Name = "Telescopic coil spring, oil damper fulli adjustable preload" },
                RearSuspension = new RearSuspension { Name = "Link-type, 7 way adjustable spring preload" },
                Engine = new Engine { Name = "Four stroke, 90-V-Twin, DOHC, 4 valves per cylinder", CoolingSystem = new CoolingSystem { Name = "Liquid cooled" } },
                Height = 1090,
                Length = 2045,
                Price = 9000,
                SeatHeight = 800,
                Transmission = new Transmission { Name = "6 Speeds" },
                Weight = 169,
            };

            await dbContext.MotorBikes.AddAsync(motorBike);
        }
    }
}
