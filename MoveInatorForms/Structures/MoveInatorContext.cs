﻿using Microsoft.EntityFrameworkCore;

namespace MoveInatorForms.Structures
{
    public class MoveInatorContext : DbContext
    {
        public MoveInatorContext() { }

        public MoveInatorContext(DbContextOptions options) : base(options) { }
    }
}
