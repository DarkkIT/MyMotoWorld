namespace MyMotoWorld.Services.Data.Contacts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Services.Mapping;
    using MyMotoWorld.Web.ViewModels.Massages;

    public class ContactsService : IContactsService
    {
        private readonly IDeletableEntityRepository<UserMassage> usermassageRepository;
        private readonly IDeletableEntityRepository<ContactMassage> contactMassageRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;

        public ContactsService(
            IDeletableEntityRepository<UserMassage> usermassageRepository,
            IDeletableEntityRepository<ContactMassage> contactMassageRepository,
            IDeletableEntityRepository<ApplicationUser> userRepository)
        {
            this.usermassageRepository = usermassageRepository;
            this.contactMassageRepository = contactMassageRepository;
            this.userRepository = userRepository;
        }

        public async Task AddMassageAsync(NewMassageInputModel input, string userId)
        {
            var user = this.userRepository.All().FirstOrDefault(x => x.Id == userId);

            var contactMassage = new ContactMassage
            {
                Name = input.Name,
                Email = input.Email,
                Subject = input.Subject,
                Massage = input.Massage,
                AnswerMassage = null,
                Status = "NotAnswered",
                SendDate = DateTime.UtcNow,
                AnswerDate = null,
            };

            var userMassage = new UserMassage
            {
                User = user,
                ContactMassage = contactMassage,
            };

            await this.usermassageRepository.AddAsync(userMassage);
            await this.usermassageRepository.SaveChangesAsync();
        }

        public IEnumerable<ContactMassagesViewModel> GetAllContactMassages<T>(int page, int itemsPerPage)
        {
            var model = this.contactMassageRepository.AllWithDeleted().OrderByDescending(x => x.Id).Skip((page - 1) * itemsPerPage).Take(itemsPerPage).To<ContactMassagesViewModel>().ToList();

            return model;
        }

        public int GetCount()
        {
            return this.contactMassageRepository.All().Count();
        }
    }
}
