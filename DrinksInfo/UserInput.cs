using System;
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

            Console.WriteLine("Choose a category:");
            string category = Console.ReadLine();
            while (!Validator.IsStringValid(category))
            {
                Console.WriteLine("\nInvalid category");
                category = Console.ReadLine();
            }

            GetDrinksInput(category);
        }

        private void GetDrinksInput(string? category)
        {
            drinksService.GetDrinksByCategory(category);

        }
    }
}
