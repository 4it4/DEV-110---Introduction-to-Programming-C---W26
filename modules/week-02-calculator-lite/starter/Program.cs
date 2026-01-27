namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        //Declares variables
        string name;

        int count = 6;

        //Greets
        Console.WriteLine("Enter your name:");

        name = Console.ReadLine();

        Console.WriteLine("Hello {0}! Let's do some calculations!", name);

        //decimals or not
        Console.WriteLine("Use decimal precision?(yes/no)");

        bool choice = Console.ReadLine() == "yes";

        if (choice)
        {
            double d1, d2, sum, difference, product, quotient, remainder, average, percentage;
            //Gets numbers
            // If decimals: use double.Parse()
            // If no decimals: use int.Parse() then cast to double
            Console.WriteLine("Please enter your first number");

            d1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number");

            d2 = double.Parse(Console.ReadLine());

            //Calculations

            sum = d1 + d2;
            difference = d1 - d2;
            product = d1 * d2;
            if (d2 == 0)
            {
                quotient = 0;
                remainder = 0;
            }
            else
            {
                quotient = d1 / d2;
                remainder = d1 % d2;
            }

            average = sum / 2;

            if (d2 == 0)
            {
                percentage = 0;
            }
            else
            {
                percentage = (difference * 100) / d1;
            }

            // TODO: Display results with proper formatting
            // Show 2 decimal places: {value:F2}
            Console.WriteLine("SUM: {0} + {1} = {2:F2}", d1, d2, sum.ToString());
            Console.WriteLine("DIFFERENCE: {0} - {1} = {2:F2}", d1, d2, difference);
            Console.WriteLine("PRODUCT: {0} * {1} = {2:F2}", d1, d2, product.ToString());
            if (d2 == 0)
            {
                Console.WriteLine("QUOTIENT: Cannot calculate (cannot divide by zero)");
                Console.WriteLine("REMAINDER: Cannot calculate (cannot divide by zero)");
            }
            else
            {
                Console.WriteLine("QUOTIENT: {0} / {1} = {2:F2}", d1, d2, quotient.ToString());
                Console.WriteLine("REMAINDER: {0} % {1} = {2:F2}", d1, d2, remainder.ToString());
            }

            Console.WriteLine("AVERAGE: ({0} + {1}) / 2 = {2:F2}", d1, d2, average.ToString());

            if (d2 == 0)
            {
                Console.WriteLine("PERCENTAGE DIFFERENCE: Cannot calculate (cannot divide by zero)");
            }
            else
            {
                Console.WriteLine("PERCENTAGE DIFFERENCE: {0}%", percentage);
            }
        }
        else //NO DECIMAL PRECISION!
        {
            int num1, num2, sum, difference, product, quotient, remainder, average, percentage;
            //Gets numbers
            // If decimals: use double.Parse()
            // If no decimals: use int.Parse() then cast to double
            Console.WriteLine("Please enter your first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            num2 = int.Parse(Console.ReadLine());

            //Calculations
            sum = num1 + num2;
            difference = num1 - num2;
            product = num1 * num2;
            if (num2 == 0)
            {
                quotient = 0;
                remainder = 0;
            }
            else
            {
                quotient = num1 / num2;
                remainder = num1 % num2;
            }

            average = sum / 2;

            if (num2 == 0)
            {
                percentage = 0;
            }
            else
            {
                percentage = (difference * 100) / num1;
            }

            // TODO: Display results with proper formatting
            // Show 2 decimal places: {value:F2}
            Console.WriteLine("SUM: {0} + {1} = {2}", num1, num2, sum.ToString());
            Console.WriteLine("DIFFERENCE: {0} - {1} = {2}", num1, num2, difference);
            Console.WriteLine("PRODUCT: {0} * {1} = {2}", num1, num2, product.ToString());
            if (num2 == 0)
            {
                Console.WriteLine("QUOTIENT: Cannot calculate (cannot divide by zero)");
                Console.WriteLine("REMAINDER: Cannot calculate (cannot divide by zero)");
            }
            else
            {
                Console.WriteLine("QUOTIENT: {0} / {1} = {2}", num1, num2, quotient.ToString());
                Console.WriteLine("REMAINDER: {0} % {1} = {2}", num1, num2, remainder.ToString());
            }

            Console.WriteLine("AVERAGE: ({0} + {1}) / 2 = {2}", num1, num2, average.ToString());

            if (num2 == 0)
            {
                Console.WriteLine("PERCENTAGE DIFFERENCE: Cannot calculate (cannot divide by zero)");
            }
            else
            {
                Console.WriteLine("PERCENTAGE DIFFERENCE: {0}%", percentage);
            }
        }
        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        Console.WriteLine("Performed {0} calculations for {1}!", count, name);

        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
