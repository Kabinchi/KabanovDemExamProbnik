using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kabanov_DemExam_18052025.Models
{
    public partial class Clients
    {
        public Clients()
        {
            Zakaz = new HashSet<Zakaz>();
        }

        public int Client_ID { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<Zakaz> Zakaz { get; set; }
    }
}
