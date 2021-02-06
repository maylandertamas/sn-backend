﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnBackendApp.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
