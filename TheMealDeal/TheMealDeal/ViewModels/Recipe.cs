﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMealDeal.ViewModels
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        public IEnumerable<string> Ingredients { get; set; }

        public string Description { get; set; }
    }
}
