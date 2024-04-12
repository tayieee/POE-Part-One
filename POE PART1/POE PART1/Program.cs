// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating a new Recioe object
        Recipe recipe = new Recipe();
        while (true)
        {
            // Dsiplay menu options and handle useer input 
            Console.WriteLine("=========================================");
            Console.WriteLine("Press 1 to Enter your recipe details");
            Console.WriteLine("Press 2 to Display the recipe");
            Console.WriteLine("Press 3 to Scale the recipe");
            Console.WriteLine("Press 4 to Reset your quantities");
            Console.WriteLine("Press 5 to Clear your recipe");
            Console.WriteLine("Press 6 to Exit your recipe");
            Console.WriteLine("=========================================");

            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    recipe.EnterData();
                    break;
                case "2":
                    recipe.RecipeDisplay();
                    break;
                case "3":
                    Console.WriteLine("Enter a scale of 0.5, 2 or 3");
                    double scale1 = Convert.ToDouble(Console.ReadLine());
                    recipe.RecipeScale(scale1);
                    break;
                case "4":
                    recipe.ResetRecipe();
                    break;
                case "5":
                    recipe.ClearRecipe();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong value. Please try again");
                    break;

            }
        }
    }
}

class Recipe
{
    // Declare arrays
   
    private string[] ingredients;
    private double[] quantity;
    private string[] unit;
    private string[] steps;
    public Recipe()
    {
        ingredients = new string[0];
        quantity = new double[0];
        unit = new string[0];
        steps = new string[0];
    }
    public void EnterData()
    {

        Console.WriteLine("Enter your recipe details");

        Console.WriteLine("Enter the number of ingredients");


        int ingredientsNo = Convert.ToInt32(Console.ReadLine());

        ingredients = new string[ingredientsNo];
        quantity = new double[ingredientsNo];
        unit = new string[ingredientsNo];

        for (int i = 0; i < ingredientsNo; i++)
        {
            Console.WriteLine($"Ingredient details {1 + 1}:");
            Console.Write("Name:");
            ingredients[i] = Console.ReadLine();

            Console.Write("Quantity: ");
            quantity[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Measuremnet unit: ");
            unit[i] = Console.ReadLine();
        }

        Console.WriteLine(" Enter number of Steps: ");
        int stpNo = Convert.ToInt32(Console.ReadLine());
        steps = new string[stpNo];
        for (int a = 0; a < stpNo; a++)
        {
            Console.Write($"Steps{a + 1}:");
            steps[a] = Console.ReadLine();

        }
    }

    public void RecipeDisplay()
    {
        Console.WriteLine("\nHere is your recipe:");
        Console.WriteLine("Ingredients:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"-{quantity[i]}{unit[0]} of {ingredients[i]}");
        }
        Console.WriteLine("Steps:");
        for (int a = 0; a < steps.Length; a++)
        {
            Console.WriteLine($"-{a + 1} {steps[a]}");
        }
    }
    public void RecipeScale(double scale)
    {
        for (int i = 0; i < quantity.Length; i++)
        {
            quantity[i] *= scale;
        }
    }
    // Method to erase the recipe
    public void ResetRecipe()
    {
        for (int i = 0; i < quantity.Length; i++)
        {
            quantity[i] /= 2;
        }
    }
    // Method to clear recipe
    public void ClearRecipe()
    {
        ingredients = new string[0];
        quantity = new double[0];
        unit = new string[0];
        steps = new string[0];
    }
}
