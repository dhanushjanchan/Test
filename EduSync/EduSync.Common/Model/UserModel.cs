﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSync.Common.Model
{
    public class UserModel
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public int? RoleId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? LastLogin { get; set; }

        public bool? IsActive { get; set; }
    }
}



