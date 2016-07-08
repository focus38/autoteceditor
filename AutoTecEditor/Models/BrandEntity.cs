using System.Data.Linq.Mapping;

namespace AutoTecEditor.Models
{
    [Table(Name = "brand")]
    public class BrandEntity: BaseEntity
    {
        public string ServiceDescription { get; set; }
    }
}