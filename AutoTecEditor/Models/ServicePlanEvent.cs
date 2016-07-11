using System.Data.Linq.Mapping;

namespace AutoTecEditor.Models
{
    [Table(Name = "ServicePlanEvent")]
    public class ServicePlanEvent : BaseEntity
    {
        public int ServiceId { get; set; }
        public int ModificationId { get; set; }
        public string Description { get; set; }

        public int WorkTypeId { get; set; }

        public int MilageInterval { get; set; }

        public int MonthInterval { get; set; }
        public decimal? NormH { get; set; }

        public bool IsExtra { get; set; }
    }
}