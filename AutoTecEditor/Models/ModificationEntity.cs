using System.Data.Linq.Mapping;

namespace AutoTecEditor.Models
{
    [Table(Name = "modification")]
    public class ModificationEntity : BaseEntity
    {
        public int ModelId { get; set; }

        public int? StartProdYear { get; set; }

        public int? EndProdYear { get; set; }

        public string ServiceDescription { get; set; }
    }
}