namespace MyMotoWorld.Web.ViewModels.Massages
{
    using System;

    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Services.Mapping;

    public class ContactMassagesViewModel : IMapFrom<ContactMassage>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Massage { get; set; }

        public string Status { get; set; }

        public DateTime SendDate { get; set; }

        public DateTime? AnswerDate { get; set; }
    }
}
