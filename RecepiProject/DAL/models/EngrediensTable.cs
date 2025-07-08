using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class EngrediensTable
    {
        public EngrediensTable()
        {
            EngrediensTableForRecepis = new HashSet<EngrediensTableForRecepi>();
        }

        public int IdEngrediens { get; set; }
        public string? NameEngrediens { get; set; }

        public virtual ICollection<EngrediensTableForRecepi> EngrediensTableForRecepis { get; set; }
    }
}
