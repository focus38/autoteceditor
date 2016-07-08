using System.Data.Linq.Mapping;

namespace AutoTecEditor.Models
{
    [Table(Name = "model")]
    public class ModelEntity : BaseEntity
    {
        public int BrandId { get; set; }

        public string ServiceDescription { get; set; }
    }
}