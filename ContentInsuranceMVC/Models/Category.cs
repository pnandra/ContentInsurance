using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentInsuranceMVC.Models
{
    public class Category
    {
        public Category()
        {
            InsuredItems = new List<InsuredItem>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<InsuredItem> InsuredItems { get; set; }
    }
}
