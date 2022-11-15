﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DrinksInfo.Models
{
    public class Category
    {
        public string strCategory { get; set; }
    }

    public class Categories
    {
        [JsonProperty("Drinks")]
        public List<Category> CategoriesList { get; set; }
    }
}
