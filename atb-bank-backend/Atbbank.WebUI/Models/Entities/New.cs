using Atbbank.WebUI.Models.Entities.Commons;

namespace Atbbank.WebUI.Models.Entities
{
    public class New : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
