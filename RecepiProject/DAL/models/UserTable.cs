using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class UserTable
    {
        public UserTable()
        {
            RecepiTablebads = new HashSet<RecepiTablebad>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Fname { get; set; }
        public string? Email { get; set; }
        public int Password { get; set; }

        public virtual ICollection<RecepiTablebad> RecepiTablebads { get; set; }
    }
}
