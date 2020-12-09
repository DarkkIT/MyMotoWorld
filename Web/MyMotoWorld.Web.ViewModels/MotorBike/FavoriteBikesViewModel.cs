namespace MyMotoWorld.Web.ViewModels.MotorBike
{
    using System.Linq;

    using AutoMapper;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Mapping;

    public class FavoriteBikesViewModel : IMapFrom<MotorBike>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public double AvarageVote { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<MotorBike, MotorBikeViewModel>().ForMember(
                m => m.AvarageVote,
                opt => opt.MapFrom(x => x.Votes.Average(x => x.Value)));
        }
    }
}
