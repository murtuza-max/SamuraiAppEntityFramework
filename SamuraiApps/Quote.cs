namespace SamuraiApp.Domain
{
    public class Quote
    {
        public string Id { get; set; }
        public string Text { get; set; }

        public int SamuraiId { get; set; }

        // one to many rel..
        public Samurai Samurai { get; set; }
      
    }
}