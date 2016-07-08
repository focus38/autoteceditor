using System.Collections.Generic;

namespace AutoTecEditor.Models
{
    public class DictionaryViewModel
    {
        public List<BrandEntity> Brands { get; set; }

        public List<ModificationEntity> Modifications { get; set; }

        public List<ModelEntity> Models { get; set; }
    }
}