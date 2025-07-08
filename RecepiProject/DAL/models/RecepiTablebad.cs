using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class RecepiTablebad
    {
        public RecepiTablebad()
        {
            EngrediensTableForRecepis = new HashSet<EngrediensTableForRecepi>();
        }

        public int Id { get; set; }
        public string? Recepiname { get; set; }
        public string? Description { get; set; }
        public string? Pic { get; set; }
        public string? Lavel { get; set; }
        public DateTime? Time { get; set; }
        public int? Nummanot { get; set; }
        public string? Oraot { get; set; }
        public int IdUser { get; set; }

        public virtual UserTable IdUserNavigation { get; set; } = null!;
        public virtual ICollection<EngrediensTableForRecepi> EngrediensTableForRecepis { get; set; }
    }
}
