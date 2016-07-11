using System.Collections.Generic;

namespace AutoTecEditor.Models
{
    public class DictionaryViewModel
    {
        public List<Brand> Brands { get; set; }

        public List<Modification> Modifications { get; set; }

        public List<Model> Models { get; set; }
    }
}