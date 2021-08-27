namespace BasicWebApp.Data.Models
{
    using BasicWebApp.Data.Common.Models;

    public class UserCard : BaseDeletableModel<int>
    {
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public int CardId { get; set; }

        public virtual Card Card { get; set; }
    }
}
