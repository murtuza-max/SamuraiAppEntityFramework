
namespace SamuraiApp.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // one to many rel..
        public List<Quote> Quote { get; set; } = new List<Quote>();
        public List<Battle> Battles { get; set; } = new List<Battle>();

        public Horse Horse { get; set; }
    }
}