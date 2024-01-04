using Atbbank.WebUI.Models.Entities.Commons;

namespace Atbbank.WebUI.Models.Entities
{
    public class Card :BaseEntity<int>
    {

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
