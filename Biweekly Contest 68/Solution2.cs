using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biweekly_Contest_68
{
    public class Solution2
    {
        public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
        {
            var result = new List<string>();
            var lSupplies = supplies.ToList();
            bool changed;

            do
            {
                changed = false;
                for (int i = 0; i < recipes.Length; i++)
                {
                    if (result.Contains(recipes[i]))
                        continue;

                    bool canCreate = true;
                    foreach (var ing in ingredients[i])
                        if (!lSupplies.Contains(ing))
                        {
                            canCreate = false;
                            break;
                        }

                    if (canCreate)
                    {
                        lSupplies.Add(recipes[i]);
                        result.Add(recipes[i]);
                        changed = true;
                    }
                }                
            }
            while (changed);


            return result;
        }
    }
}
