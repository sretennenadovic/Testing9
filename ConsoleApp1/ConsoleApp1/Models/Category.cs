﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Category
    {
        public Category() { }

        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
