namespace BasicWebApp.Web.ViewModels.Cards
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using BasicWebApp.Data.Models;
    using BasicWebApp.Services.Mapping;

    public class CardsInCollectionViewModel : IMapFrom<Card>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Keyword { get; set; }

        public int Attack { get; set; }

        public int Health { get; set; }

        public string Description { get; set; }

        public ICollection<string> OwnersId { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Card, CardsInCollectionViewModel>()
                .ForMember(x => x.OwnersId, opt => opt.MapFrom(c => c.UsersCards.Select(b => b.ApplicationUserId)));
        }
    }
}
