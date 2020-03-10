using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oto.Entities
{
    [Table("document")]
    public partial class Document
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("body")]
        [StringLength(100)]
        public string Body { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(User.Document))]
        public virtual User IdNavigation { get; set; }
    }
}
