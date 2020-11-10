using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentInsuranceMVC.Models
{
    public class InsuredItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
