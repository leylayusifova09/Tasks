using System;
using System.Collections.Generic;

namespace Pageination.Models
{
    public partial class Qrup
    {
        public Qrup()
        {
            Telebes = new HashSet<Telebe>();
        }

        public string Id { get; set; } = null!;

        public virtual ICollection<Telebe> Telebes { get; set; }
    }
}
