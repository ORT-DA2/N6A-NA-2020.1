using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oto.Entities
{
    [Table("user")]
    public partial class User
    {
        public User()
        {
            Documents = new HashSet<Document>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty(nameof(Document.User))]
        public virtual ICollection<Document> Documents { get; set; }
    }
}
