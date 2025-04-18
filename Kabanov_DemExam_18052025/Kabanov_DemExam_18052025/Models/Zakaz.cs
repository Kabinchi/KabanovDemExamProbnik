using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kabanov_DemExam_18052025.Models
{
    public partial class Zakaz
    {
        public int Zakaz_ID { get; set; }
        public int Client_ID { get; set; }
        public int Detali_Zakaza_ID { get; set; }
        public DateTime Data_Zakaza { get; set; }
        public decimal? Stoimost { get; set; }

        public virtual Clients Client_ { get; set; }
        public virtual Detali_Zakaza Detali_Zakaza_ { get; set; }
    }
}
