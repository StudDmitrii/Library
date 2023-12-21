

namespace Library.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Contact { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
