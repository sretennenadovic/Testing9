using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Discount
    {
        public Discount() { }
        public string DiscountValue { get; set; }
        public string Condition { get; set; }
        public bool Valid { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
