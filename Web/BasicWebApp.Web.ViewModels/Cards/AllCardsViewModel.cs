namespace BasicWebApp.Web.ViewModels.Cards
{
    using System.Collections.Generic;

    public class AllCardsViewModel
    {
        public ICollection<CardsInCollectionViewModel> AllCards { get; set; }
    }
}
