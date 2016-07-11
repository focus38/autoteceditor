using System.Data.Linq.Mapping;

namespace AutoTecEditor.Models
{
    [Table(Name = "brand")]
    public class Brand: BaseEntity
    {
        public string ServiceDescription { get; set; }
    }
}