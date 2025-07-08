using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.repository
{
    public class RecepiTableDTO
    {
        //public RecepiTableDTO()
        //{
        //    UserTable = new HashSet<RecepiTableDTO>();
        //}

        public string Id { get; set; } = null!;
        public string? Recepiname { get; set; }
        public string? Description { get; set; }
        public string? Pic { get; set; }
        public string? Lavel { get; set; }
        public TimeSpan? Time { get; set; }
        public int? Nummanot { get; set; }
        public string IdUser { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Fname { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; } = null!;

        public virtual ICollection<RecepiTableDTO> UserTables { get; set; }
    }
}
