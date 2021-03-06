﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mtm.Entities
{
    [Table("document")]
    public partial class Document
    {
        public Document()
        {
            UserDocument = new HashSet<UserDocument>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("body")]
        [StringLength(100)]
        public string Body { get; set; }

        [InverseProperty("Document")]
        public virtual ICollection<UserDocument> UserDocument { get; set; }
    }
}
