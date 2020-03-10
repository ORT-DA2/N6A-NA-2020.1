using System;
using System.Collections.Generic;

namespace oto.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Document Document { get; set; }
    }
}
