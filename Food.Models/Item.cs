﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string  Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }

    }
}
