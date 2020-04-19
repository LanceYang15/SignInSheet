using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SignInSheet.Models;

namespace SignInSheet.Data
{
    public class TableContext : DbContext
    {
        public TableContext() : base("DefaultConnection")
        {

        }

        public DbSet<Signature> Signatures { get; set; }
    }
}