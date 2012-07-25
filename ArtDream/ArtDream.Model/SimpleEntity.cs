using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtDream.Model
{
    public class SimpleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SimpleEntity<T> : SimpleEntity
    {
        public T Value { get; set; }
    }
}
