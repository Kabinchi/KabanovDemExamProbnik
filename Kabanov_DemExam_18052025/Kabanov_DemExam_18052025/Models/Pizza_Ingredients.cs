using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kabanov_DemExam_18052025.Models
{
    public partial class Pizza_Ingredients
    {
        public int Pizza_Ingredients_ID { get; set; }
        public int? Ingredients_ID { get; set; }
        public int? Pizza_ID { get; set; }

        public virtual Ingredients Ingredients_ { get; set; }
        public virtual Pizza Pizza_ { get; set; }
    }
}
