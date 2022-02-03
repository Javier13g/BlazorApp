using System;
using System.Collections.Generic; 

namespace servicioweb.Models
{
    public partial class Books
    {
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Synopsis { get; set; }
    }
}
