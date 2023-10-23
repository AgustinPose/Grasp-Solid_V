using Full_GRASP_And_SOLID;
using System;
using System.IO;

public class FilePrinter : IPrinter
{
    public void PrintRecipe(IRecipeTextProvider recipeTextProvider)
    {
        string recipeText = recipeTextProvider.GetRecipeText();
        File.WriteAllText("Recipe.txt", recipeText);
    }
}
