namespace Csharp_funcation_Ex
{
    internal class Program
    {
        //===================== print result =========================
        public static void PrintResult(string input)
        {
            Console.WriteLine("Your result: " + input);
            Console.ReadLine();
            Console.Clear();
        }

        //===================== check even or odd =========================
        static string EvenOrOdd(int number)
        {
            return (number % 2 == 0) ? "EVEN" : "ODD";
        }

        //===================== find largest of three numbers =========================
        static string LargestOfThree(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
                return num1 + " is the largest number";
            else if (num2 > num1 && num2 > num3)
                return num2 + " is the largest number";
            else
                return num3 + " is the largest number";
        }

        //===================== convert celsius to fahrenheit =========================
        static string TemperatureConverter(int celsius)
        {
            int fahrenheit = (celsius * 9 / 5) + 32;
            return "Fahrenheit: " + fahrenheit;
        }

        //===================== calculate discount =========================
        static string DiscountCalculator(float price)
        {
            if (price > 100)
            {
                float discount = price * 10 / 100;
                float finalPrice = price - discount;
                return "Discounted price: " + finalPrice;
            }
            return "Original price (no discount): " + price;
        }

        //===================== grading system =========================
        static string GradingSystem(int studentMark)
        {
            if (studentMark > 100)
                return "Error: Mark cannot exceed 100";
            else if (studentMark >= 90)
                return "Grade: A";
            else if (studentMark >= 80)
                return "Grade: B";
            else if (studentMark >= 70)
                return "Grade: C";
            else if (studentMark >= 60)
                return "Grade: D";
            else if (studentMark < 60 && studentMark >= 0)
                return "Grade: F";
            else
                return "Error: Invalid mark";
        }

        //===================== swap two numbers =========================
        static string SwapNumbers(ref int num1, ref int num2)
        {
            int store = num1;
            num1 = num2;
            num2 = store;
            return $"Swapped numbers: {num1}, {num2}";
        }

        //===================== convert days to weeks =========================
        static string DaysToWeeks(int days)
        {
            int weeks = days / 7;
            int remainingDays = days % 7;
            return $"{weeks} weeks and {remainingDays} days";
        }

        //===================== calculate electricity bill =========================
        static string ElectricityBill(double unit)
        {
            if (unit > 300)
                return "Bill: " + (unit * 1) + "$";
            else if (unit > 100)
                return "Bill: " + (unit * 0.75) + "$";
            else if (unit <= 100 && unit > 0)
                return "Bill: " + (unit * 0.5) + "$";
            else
                return "Error: Invalid units";
        }

        //===================== simple calculator =========================
        static string SimpleCalculator(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "/":
                    return "Result: " + (num1 / num2);
                case "*":
                    return "Result: " + (num1 * num2);
                case "+": 
                    return "Result: " + (num1 + num2);
                case "-": 
                    return "Result: " + (num1 - num2);
                default: 
                    return "Error: Invalid operation";
            }
        }

        //===================== show menu =========================
        static void ShowMenu()
        {
            Console.WriteLine("\n============ Menu ============");
            Console.WriteLine("1. Even or Odd Checker");
            Console.WriteLine("2. Largest of Three Numbers");
            Console.WriteLine("3. Temperature Converter");
            Console.WriteLine("4. Discount Calculator");
            Console.WriteLine("5. Grading System");
            Console.WriteLine("6. Swap Two Numbers");
            Console.WriteLine("7. Days to Weeks Converter");
            Console.WriteLine("8. Electricity Bill Calculator");
            Console.WriteLine("9. Simple Calculator");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=============================");
            Console.Write("Enter your choice: ");
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        PrintResult(EvenOrOdd(int.Parse(Console.ReadLine())));
                        break;

                    case 2:
                        Console.Write("Enter first number: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter third number: ");

                        PrintResult(LargestOfThree(n1, n2, int.Parse(Console.ReadLine())));
                        break;

                    case 3:
                        Console.Write("Enter Celsius degree: ");
                        PrintResult(TemperatureConverter(int.Parse(Console.ReadLine())));
                        break;

                    case 4:
                        Console.Write("Enter the price: ");
                        PrintResult(DiscountCalculator(float.Parse(Console.ReadLine())));
                        break;

                    case 5:
                        Console.Write("Enter student mark: ");
                        PrintResult(GradingSystem(int.Parse(Console.ReadLine())));
                        break;

                    case 6:
                        Console.Write("Enter first number: ");
                        int s1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int s2 = int.Parse(Console.ReadLine());
                        PrintResult(SwapNumbers(ref s1, ref s2));
                        break;

                    case 7:
                        Console.Write("Enter number of days: ");
                        PrintResult(DaysToWeeks(int.Parse(Console.ReadLine())));
                        break;

                    case 8:
                        Console.Write("Enter number of units: ");                   
                        PrintResult(ElectricityBill(double.Parse(Console.ReadLine())));
                        break;

                    case 9:
                        Console.Write("Enter first number: ");
                        double c1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double c2 = double.Parse(Console.ReadLine());
                        Console.Write("Enter operation (/, *, +, -): ");
                        PrintResult(SimpleCalculator(c1, c2, Console.ReadLine()));
                        break;

                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        PrintResult("Invalid choice! Please try again.");
                        break;
                }
            } while (choice != 0);
        }
    }
}