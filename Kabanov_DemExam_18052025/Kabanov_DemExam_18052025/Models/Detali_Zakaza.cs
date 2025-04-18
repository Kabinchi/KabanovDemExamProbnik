using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kabanov_DemExam_18052025.Models
{
    public partial class Detali_Zakaza
    {
        public Detali_Zakaza()
        {
            Zakaz = new HashSet<Zakaz>();
        }

        public int Detali_Zakaza_ID { get; set; }
        public int Razmer_Pizza_ID { get; set; }
        public int Pizza_ID { get; set; }
        public int Kolichestvo { get; set; }
        public decimal Price { get; set; }

        public virtual Pizza Pizza_ { get; set; }
        public virtual Razmer_Pizza Razmer_Pizza_ { get; set; }
        public virtual ICollection<Zakaz> Zakaz { get; set; }
    }
}
