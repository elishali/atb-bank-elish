using Atbbank.WebUI.Models.Entities.Commons;

namespace Atbbank.WebUI.Models.Entities
{
    public class Slider :BaseEntity<int>
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgSrc { get; set; }
        public string Btn { get; set; }
        public string Url { get; set; }

    }
}