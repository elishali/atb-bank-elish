using Atbbank.WebUI.Models.Entities.Commons;

namespace Atbbank.WebUI.Models.Entities
{
    public class Category :BaseEntity<int>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
