

namespace Library.Model
{
    internal class Worker
    {
        public int Id { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; } = new();
        public List<Entry> Entries { get; set; }
    }
}
