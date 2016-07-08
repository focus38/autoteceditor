using System.Data.Linq.Mapping;

namespace AutoTecEditor.Models
{
    public class BaseEntity
    {
        [Column(IsPrimaryKey = true, CanBeNull = false)]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}