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

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Entities.User.Documents))]
        public virtual User User { get; set; }
    }
}
