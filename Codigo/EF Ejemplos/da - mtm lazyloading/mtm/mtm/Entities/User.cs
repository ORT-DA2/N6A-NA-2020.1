﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace mtm.Entities
{
    [Table("user")]
    public partial class User
    {
        public User()
        {
            UserDocument = new HashSet<UserDocument>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<UserDocument> UserDocument { get; set; }

        [NotMapped]
        public IEnumerable<Document> Documents { get => UserDocument.Select(x => x.Document); }
    }
}
