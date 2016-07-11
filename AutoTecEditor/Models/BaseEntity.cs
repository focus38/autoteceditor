using System.ComponentModel.DataAnnotations.Schema;

namespace AutoTecEditor.Models
{
    public abstract class BaseEntity
    {
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, CanBeNull = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}