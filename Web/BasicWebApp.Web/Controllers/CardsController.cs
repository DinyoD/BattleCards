namespace BasicWebApp.Web.Controllers
{
    using System.Threading.Tasks;

    using BasicWebApp.Data.Models;
    using BasicWebApp.Services.Data;
    using BasicWebApp.Web.ViewModels.Cards;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class CardsController : BaseController
    {
        private readonly ICardsService cardsService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserCardsService userCardsService;

        public CardsController(
            ICardsService cardsService,
            UserManager<ApplicationUser> userManager,
            IUserCardsService userCardsService)
        {
            this.cardsService = cardsService;
            this.userManager = userManager;
            this.userCardsService = userCardsService;
        }

        [Authorize]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(CardsInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.cardsService.CreateCardAsync(input);

            return this.Redirect("/");
        }

        public IActionResult All()
        {
            var cards = this.cardsService.GetAll<CardsInCollectionViewModel>();
            var viewModel = new AllCardsViewModel { AllCards = cards };

            return this.View(viewModel);
        }
    }
}
