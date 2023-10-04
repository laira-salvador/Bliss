﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliss_Domain.Entities
{
    public class Expense : Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public ExpenseCategory Category { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
