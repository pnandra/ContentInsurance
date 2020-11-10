using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContentInsuranceMVC.Models;

namespace ContentInsuranceMVC.Data
{
    public class ContentInsuranceMVCContext : DbContext
    {
        public ContentInsuranceMVCContext (DbContextOptions<ContentInsuranceMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ContentInsuranceMVC.Models.InsuredItem> InsuredItem { get; set; }
        public DbSet<ContentInsuranceMVC.Models.Category> Category { get; set; }
    }
}
