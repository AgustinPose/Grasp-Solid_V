using System;
using Full_GRASP_And_SOLID;

public class ConsolePrinter : IPrinter
{
    public void PrintRecipe(IRecipeTextProvider recipeTextProvider)
    {
        string recipeText = recipeTextProvider.GetRecipeText();
        Console.WriteLine(recipeText);
    }

}
