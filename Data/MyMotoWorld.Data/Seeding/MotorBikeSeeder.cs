namespace MyMotoWorld.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore.Internal;
    using MyMotoWorld.Models;
    using MyMotoWorld.Models.Parts;

    public class MotorBikeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.MotorBikes.Any())
            {
                return;
            }

            var data = new List<MotorBike>();

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
                Engine = new Engine { Name = "Four stroke, 90-V-Twin, DOHC, 4 valves per cylinder 650", EngineCapacity = 650, EnginePower = 74, CoolingSystem = new CoolingSystem { Name = "Liquid cooled" } },
                Height = 1090,
                Length = 2045,
                Price = 9000,
                SeatHeight = 800,
                Transmission = new Transmission { Name = "6 Speeds" },
                Weight = 169,
            };

            data.Add(motorBike);

            var motorBike2 = new MotorBike
            {
                BikeType = new BikeType { Name = "Sport", Descrition = "A sportbike, or sports bike, is a motorcycle optimized for speed, acceleration, braking, and cornering on paved roads, typically at the expense of comfort and fuel economy by comparison with other motorcycles." },
                Name = "Suzuki",
                Descrition = "Since its debut in 1999, the Hayabusa's over-the-top styling and prodigious top speed have made it unlike anything else on the street. That the Guinness Book of World Records lists the Hayabusa as the world's fastest production motorcycle doesn't hurt either, especially because Japanese manufacturers have since electronically limited their motorcycles to 299 kph (186 mph), making future comparisons impossible.",
                Model = "Hayabusa",
                FrontBrakes = new FrontBrake { Name = "2 x 310 mm Discs, 4 piston calipers" },
                RearBrakes = new RearBrake { Name = "Single 260 mm disc, 1 piston caliper" },
                FrontSuspension = new FrontSuspension { Name = "Inverted telescopic coil springs, spring preload, rebound and compression damping fully adjustable." },
                RearSuspension = new RearSuspension { Name = "Link type, oil damped, coil springs, spring preload, rebound and compression damping fully adjustable." },
                Engine = new Engine { Name = "Four stroke, transverse four cylinder, DOHC, 4 valves per cylinder 1300", EngineCapacity = 1300, EnginePower = 195, CoolingSystem = new CoolingSystem { Name = "Liquid cooled" } },
                Height = 116,
                Length = 219,
                Price = 14799,
                SeatHeight = 80,
                Transmission = new Transmission { Name = "6 Speeds" },
                Weight = 266,
            };

            data.Add(motorBike2);

            var motorBike3 = new MotorBike
            {
                BikeType = new BikeType { Name = "Sport", Descrition = "A sportbike, or sports bike, is a motorcycle optimized for speed, acceleration, braking, and cornering on paved roads, typically at the expense of comfort and fuel economy by comparison with other motorcycles." },
                Name = "Suzuki",
                Descrition = "Suzuki is bringing some smart updates to its GSX-R 1000 for the 2019 season. The changes a primarily a response to the rule changes in the WorldSBK Championship, with the 2019 Suzuki GSX-R1000 getting some subtle refinements.",
                Model = "GSX-R",
                FrontBrakes = new FrontBrake { Name = "2 x 320mm Discs radial mount Brembo 4-piston calipers" },
                RearBrakes = new RearBrake { Name = "Single 220mm disc, Nissin, 1-piston" },
                FrontSuspension = new FrontSuspension { Name = "43mm Showa Big Piston inverted telescopic forks, coil spring, oil damped" },
                RearSuspension = new RearSuspension { Name = "Link type, single shock, coil spring, oil damped" },
                Engine = new Engine { Name = "Four stroke, transverse four cylinder, DOHC, 4 valves per cylinder, TSCC 1000", EngineCapacity = 1000, EnginePower = 202, CoolingSystem = new CoolingSystem { Name = "Liquid cooled" } },
                Height = 115,
                Length = 207,
                Price = 15599,
                SeatHeight = 82,
                Transmission = new Transmission { Name = "6-speed constant mesh" },
                Weight = 201,
            };

            data.Add(motorBike3);

            var motorBike4 = new MotorBike
            {
                BikeType = new BikeType { Name = "Advanture", Descrition = "Adventure motorcycles, also known as ADV bikes, are larger-displacement multi-cylinder motorcycles developed for on- and off-road travel and are capable of covering great distances while providing the rider with relative comfort." },
                Name = "Suzuki",
                Descrition = "The Suzuki V-Strom was first presented to the world in its 1000cc incarnation. The DL1000 is manufactured in Japan since 2002. It is a V-Twin motorcycle that is capable of a number of things. The design didn´t leave out any influences, so in Suzuki´s words, it´s a sport, adventure tourer.",
                Model = "V-Strom",
                FrontBrakes = new FrontBrake { Name = "2 x 310mm discs,  2 piston calipers" },
                RearBrakes = new RearBrake { Name = "Single 260 mm disc,  1 piston caliper." },
                FrontSuspension = new FrontSuspension { Name = "Telescopic, coil spring, oil damped, 43mm forks" },
                RearSuspension = new RearSuspension { Name = "Swingarm, coil spring, oil damped, adjustable for preload and rebound damping" },
                Engine = new Engine { Name = "Four stroke, 90°-V-twin, DOHC, 4 valves per cylinder 1000", EngineCapacity = 1000, EnginePower = 98, CoolingSystem = new CoolingSystem { Name = "Liquid cooled" } },
                Height = 133,
                Length = 228,
                Price = 9999,
                SeatHeight = 84,
                Transmission = new Transmission { Name = "6-speed constant mesh" },
                Weight = 236,
            };

            data.Add(motorBike4);

            var motorBike5 = new MotorBike
            {
                BikeType = new BikeType { Name = "Cruiser", Descrition = "A cruiser is a motorcycle in the style of American machines from the 1930s to the early 1960s." },
                Name = "Suzuki",
                Descrition = "Flash through the night with 109 cubic inches of pounding muscle! If you're looking for a muscle cruiser that gets your adrenaline flowing with sleek and sporty styling? Look no further than the Suzuki Boulevard M109R B.O.S.S.!",
                Model = "Boulevard",
                FrontBrakes = new FrontBrake { Name = "2 x 310mm discs, 2 piston calipers" },
                RearBrakes = new RearBrake { Name = "Single 274mm disc, 2 piston caliper" },
                FrontSuspension = new FrontSuspension { Name = "Inverted, 46mm stanchions" },
                RearSuspension = new RearSuspension { Name = "Single damper, preload adjustable" },
                Engine = new Engine { Name = "Four stroke, 54° V-Twin 1800", EngineCapacity = 1800, EnginePower = 128, CoolingSystem = new CoolingSystem { Name = "Liquid cooled" } },
                Height = 108,
                Length = 245,
                Price = 9999,
                SeatHeight = 70,
                Transmission = new Transmission { Name = "5 Speed" },
                Weight = 347,
            };

            data.Add(motorBike5);

            await dbContext.MotorBikes.AddRangeAsync(data);
        }
    }
}
