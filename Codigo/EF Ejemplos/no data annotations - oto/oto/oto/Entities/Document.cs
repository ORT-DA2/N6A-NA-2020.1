using System;
using System.Collections.Generic;

namespace oto.Entities
{
    public partial class Document
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int? UserId { get; set; }

        public virtual User IdNavigation { get; set; }
    }
}
