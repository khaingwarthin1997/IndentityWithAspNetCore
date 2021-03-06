﻿using System;
using System.Collections.Generic;
using System.Text;
using ExtendIndentityTesting.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExtendIndentityTesting.Data
{
    public class ApplicationDbContext : IdentityDbContext <ApplicationUser , ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
