using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<BookAuthor> BooksLink { get; set; }
    }
}
