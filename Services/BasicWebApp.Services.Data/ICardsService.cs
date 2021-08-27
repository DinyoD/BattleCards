namespace BasicWebApp.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using BasicWebApp.Web.ViewModels.Cards;

    public interface ICardsService
    {
        Task CreateCardAsync(CardsInputModel inputModel);

        ICollection<T> GetAll<T>();
    }
}
