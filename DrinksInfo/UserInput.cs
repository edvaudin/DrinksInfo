﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo
{
    internal class UserInput
    {
        DrinksService drinksService = new();

        public void GetCategoriesInput()
        {
            drinksService.GetCategories();
        }
    }
}
