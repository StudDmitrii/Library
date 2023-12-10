using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublicationDate { get; set; }
        public List<Author> Authors { get; set; }
        public List<Genre> Genres { get; set; }
        public int PublisherId { get; set; }
        public Publisher? Publisher { get; set; } = new();
        public List<Entry> Entries { get; set; }
    }
}
