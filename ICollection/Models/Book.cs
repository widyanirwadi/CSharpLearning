﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
