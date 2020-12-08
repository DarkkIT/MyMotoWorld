namespace MyMotoWorld.Services.Data.News
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Services.Mapping;
    using MyMotoWorld.Web.ViewModels.Admins;
    using MyMotoWorld.Web.ViewModels.News;

    public class NewsService : INewsService
    {
        private readonly IDeletableEntityRepository<News> newsRepository;

        public NewsService(IDeletableEntityRepository<News> newsRepository)
        {
            this.newsRepository = newsRepository;
        }

        public async Task AddNewsAsync(AddNewsInputModel input)
        {
            var news = new News
            {
                Name = input.Name,
                Description = input.Description,
                ImageName = input.ImageName,
                NewsDate = DateTime.UtcNow,
            };

            await this.newsRepository.AddAsync(news);
            await this.newsRepository.SaveChangesAsync();
        }

        public IEnumerable<NewsViewModel> GetAllNews<T>(int page, int itemsPerPage)
        {
            var model = this.newsRepository.All().OrderByDescending(x => x.Id).Skip((page - 1) * itemsPerPage).Take(itemsPerPage).To<NewsViewModel>().ToList();

            return model;
        }

        public NewsViewModel GetById<T>(int id)
        {
            var model = this.newsRepository.All().To<NewsViewModel>().FirstOrDefault(x => x.Id == id);

            return model;
        }

        public int GetCount()
        {
            return this.newsRepository.All().Count();
        }

        public IEnumerable<NewsViewModel> GetLastThreeNews<T>()
        {
            var model = this.newsRepository.All().OrderByDescending(x => x.CreatedOn).Take(3).To<NewsViewModel>().ToList();

            return model;
        }
    }
}
