using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kabanov_DemExam_18052025.Models
{
    public partial class Pizza
    {
        public Pizza()
        {
            Detali_Zakaza = new HashSet<Detali_Zakaza>();
            Pizza_Ingredients = new HashSet<Pizza_Ingredients>();
        }

        public int Pizza_ID { get; set; }
        public string Nazvanie { get; set; }

        public virtual ICollection<Detali_Zakaza> Detali_Zakaza { get; set; }
        public virtual ICollection<Pizza_Ingredients> Pizza_Ingredients { get; set; }
    }
}
