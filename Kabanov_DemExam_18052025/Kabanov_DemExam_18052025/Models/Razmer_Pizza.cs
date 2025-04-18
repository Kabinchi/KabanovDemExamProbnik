using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kabanov_DemExam_18052025.Models
{
    public partial class Razmer_Pizza
    {
        public Razmer_Pizza()
        {
            Detali_Zakaza = new HashSet<Detali_Zakaza>();
        }

        public int Razmer_Pizza_ID { get; set; }
        public string Razmer_Pizza1 { get; set; }
        public int Ves { get; set; }

        public virtual ICollection<Detali_Zakaza> Detali_Zakaza { get; set; }
    }
}
