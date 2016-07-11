using System.Data.Linq.Mapping;

namespace AutoTecEditor.Models
{
    [Table(Name = "model")]
    public class Model : BaseEntity
    {
        public int BrandId { get; set; }

        public string ServiceDescription { get; set; }
    }
}