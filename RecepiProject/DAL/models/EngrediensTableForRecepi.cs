using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class EngrediensTableForRecepi
    {
        public int IdForRrecepi { get; set; }
        public int IdRecepi { get; set; }
        public int IdEngrediens { get; set; }
        public string? Count { get; set; }

        public virtual EngrediensTable IdEngrediensNavigation { get; set; } = null!;
        public virtual RecepiTablebad IdRecepiNavigation { get; set; } = null!;
    }
}
