using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kabanov_DemExam_18052025.Models
{
    public partial class Ingredients
    {
        public Ingredients()
        {
            Pizza_Ingredients = new HashSet<Pizza_Ingredients>();
        }

        public int Ingredinets_ID { get; set; }
        public string Nazvanie_Ingredienta { get; set; }

        public virtual ICollection<Pizza_Ingredients> Pizza_Ingredients { get; set; }
    }
}
