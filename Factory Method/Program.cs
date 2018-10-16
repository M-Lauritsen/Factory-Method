using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var turkeySanwich = new TurkeySandwich();
            var dagwood = new Dagwood();

        }

        abstract class Ingredient
        {

        }

        class Bread : Ingredient
        {

        }

        class Turkey : Ingredient
        {

        }

        class Lettuce : Ingredient
        {

        }

        class Mayonaise : Ingredient
        {

        }

        abstract class Sandwich
        {
            public Sandwich()
            {
                CreateIngredients();
            }

            //Factory method
            public abstract void CreateIngredients();

            public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
        }

        class TurkeySandwich : Sandwich
        {
            public override void CreateIngredients()
            {
                Ingredients.Add(new Bread());
                Ingredients.Add(new Mayonaise());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Bread());
            }
        }
        class Dagwood : Sandwich
        {
            public override void CreateIngredients()
            {
                Ingredients.Add(new Bread());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Mayonaise());
                Ingredients.Add(new Bread());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Mayonaise());
                Ingredients.Add(new Bread());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Mayonaise());
                Ingredients.Add(new Bread());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Mayonaise());
                Ingredients.Add(new Bread());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Mayonaise());
                Ingredients.Add(new Bread());
            }
        }

    }
}
