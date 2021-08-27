namespace BasicWebApp.Services.Data
{
    using System.Threading.Tasks;

    using BasicWebApp.Data.Common.Repositories;
    using BasicWebApp.Data.Models;

    public class UserCardsService : IUserCardsService
    {
        private readonly IDeletableEntityRepository<UserCard> userCardRepo;

        public UserCardsService(IDeletableEntityRepository<UserCard> userCardRepo)
        {
            this.userCardRepo = userCardRepo;
        }

        public async Task AddUserCardEntity(int cardId, string UserId)
        {
            await this.userCardRepo.AddAsync(new UserCard { ApplicationUserId = UserId, CardId = cardId });
            await this.userCardRepo.SaveChangesAsync();
        }
    }
}
