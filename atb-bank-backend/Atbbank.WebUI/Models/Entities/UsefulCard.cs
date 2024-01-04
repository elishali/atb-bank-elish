using Atbbank.WebUI.Models.Entities.Commons;

namespace Atbbank.WebUI.Models.Entities
{
    public class UsefulCard : BaseEntity<int>
    {

        public string Title { get; set; }
        public string ImgSrc { get; set; }
        public string Btn { get; set; }
    }
}
