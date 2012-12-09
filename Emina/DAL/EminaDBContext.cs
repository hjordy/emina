using System;
using System.Collections.Generic;
using System.Data.Entity;
using Emina.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Emina.Models
{
    public class EminaDBContext : DbContext
    {
        public DbSet<Question> Questions {get; set;}
    }
}