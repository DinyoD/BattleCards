namespace BasicWebApp.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BasicWebApp.Data.Common.Models;

    public class Card : BaseDeletableModel<int>
    {
        public Card()
        {
            this.UsersCards = new HashSet<UserCard>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Keyword { get; set; }

        [Range(0, int.MaxValue)]
        public int Attack { get; set; }

        [Range(0, int.MaxValue)]
        public int Health { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public ICollection<UserCard> UsersCards { get; set; }
    }
}
