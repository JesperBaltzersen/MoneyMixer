﻿using System;

namespace Persistance.Sqlite.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
    }
}