namespace Pokedex.Api.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
    }
}
