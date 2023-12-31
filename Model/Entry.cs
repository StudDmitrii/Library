﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    internal class Entry
    {
        public int Id { get; set; }
        public DateTime CaptureDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; } = new();
        public int WorkerId { get; set; }
        public Worker? Worker { get; set; } = new();
        public int BookId { get; set; }
        public Book? Book { get; set; } = new();
    }
}
