namespace BasicWebApp.Services.Data
{
    using BasicWebApp.Data.Common.Repositories;
    using BasicWebApp.Data.Models;
    using BasicWebApp.Services.Mapping;
    using BasicWebApp.Web.ViewModels.Cards;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CardsService : ICardsService
    {
        private readonly IDeletableEntityRepository<Card> cardRepo;

        public CardsService(IDeletableEntityRepository<Card> cardRepo)
        {
            this.cardRepo = cardRepo;
        }

        public async Task CreateCardAsync(CardsInputModel inputModel)
        {
            var card = new Card
            {
                Name = inputModel.Name,
                ImageUrl = inputModel.ImageUrl,
                Keyword = inputModel.Keyword,
                Attack = inputModel.Attack,
                Health = inputModel.Health,
                Description = inputModel.Description,
            };

            await this.cardRepo.AddAsync(card);
            await this.cardRepo.SaveChangesAsync();

        }

        public ICollection<T> GetAll<T>()
        {
            return this.cardRepo.All().To<T>().ToList();
        }
    }
}
