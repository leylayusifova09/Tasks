using System;
using System.Collections.Generic;

namespace Pageination.Models
{
    public partial class Telebe
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? QrupId { get; set; }
        public int Sira { get; set; }
        public virtual Qrup? Qrup { get; set; }
    }
}
