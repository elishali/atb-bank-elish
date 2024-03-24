using Atbbank.WebUI.Models.Entities;

namespace Atbbank.WebUI.Controllers
{
    internal class IndexViewModel
    {
        public List<Card> cards = new List<Card>();
        public List<UsefulCard> UsefulCards = new List<UsefulCard>();
        public List<Slider> sliders = new List<Slider>();
    }
}