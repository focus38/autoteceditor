using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace AutoTecEditor.Models
{
    [Table(Name="Service")]
    public class Service : BaseEntity
    {
        public string Description { get; set; }
    }
}