using System.Threading.Tasks;

namespace BasicWebApp.Services.Data
{
    public interface IUserCardsService
    {
        Task AddUserCardEntity(int cardId, string UserId);
    }
}
