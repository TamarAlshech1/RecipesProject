﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.repository
{
    public class UserTableDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Fname { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; } = null!;

       // public virtual RecepiTableDTO PasswordNavigation { get; set; } = null!;
    }
}
