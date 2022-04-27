using System.Text;

namespace Learning
{
    internal class Smoothie
    {
        public Smoothie(string[] makeSmoothy)
        {
            AddedIngredients = makeSmoothy;
        }

        public static Dictionary<string, double> priceTable = new Dictionary<string, double>
        {
            ["Strawberries"] = 1.50,
            ["Banana"] = 0.50,
            ["Mango"] = 2.50,
            ["Blueberries"] = 1.00,
            ["Raspberries"] = 1.00,
            ["Apple"] = 1.75,
            ["Pineapple"] = 3.50
        };

        public string[] AddedIngredients { get; set; }

        public string Ingredients()
        {
            return $"{string.Join(", ", AddedIngredients)}";
        }
        public string GetCost()
        {
            var cost = 0.00;

            foreach(var ingredient in AddedIngredients)
            {
                cost += Convert.ToDouble(priceTable[ingredient]);
            }

            return $"£{cost:#0.00}";
        }

        public string GetPrice()
        {
            var finalСost = GetCost();
            var finalСostValue = Convert.ToDouble(finalСost.Substring(1));
            finalСostValue += finalСostValue * 1.50;
            return $"£{finalСostValue:#0.00}";
        }

        public string GetName()
        {
            var replaceString = new StringBuilder();
            Array.Sort(AddedIngredients);

            foreach (var ingredient in AddedIngredients)
            {
                if (ingredient.EndsWith("ies"))
                {
                    replaceString.Append(ingredient.Substring(0, ingredient.Length - 3) + "y ");
                }
                else replaceString.Append(ingredient + " ");
            }
            if (replaceString.Length > 1)
            {
                replaceString.Append("Fusion");
            }

            return replaceString.ToString();
        }
    }
}
