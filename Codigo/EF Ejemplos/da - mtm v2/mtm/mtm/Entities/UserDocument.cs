using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mtm.Entities
{
    [Table("user_document")]
    public partial class UserDocument
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Key]
        [Column("document_id")]
        public int DocumentId { get; set; }

        [ForeignKey(nameof(DocumentId))]
        [InverseProperty("UserDocument")]
        public virtual Document Document { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserDocument")]
        public virtual User User { get; set; }
    }
}
