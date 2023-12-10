

namespace Library.Model
{
    internal class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Worker> Workers { get; set; } = new();
    }
}
