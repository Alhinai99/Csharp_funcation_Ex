using System;

namespace Csharp_funcation_Ex
{
    internal class Program
    {
        static double atmBalance = 1000.0;

        // This method is used to print the result of the calculations
        public static void PrintResult(string input)
        {
            Console.WriteLine("\nYour result: " + input);
            Console.ReadLine();
            Console.Clear();
        }



        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("============ Program Menu ============");
                Console.WriteLine("1. Even or Odd Checker");
                Console.WriteLine("2. Largest of Three Numbers");
                Console.WriteLine("3. Temperature Converter");
                Console.WriteLine("4. Discount Calculator");
                Console.WriteLine("5. Grading System");
                Console.WriteLine("6. Swap Two Numbers");
                Console.WriteLine("7. Days to Weeks Converter");
                Console.WriteLine("8. Electricity Bill Calculator");
                Console.WriteLine("9. Factorial of a Number");
                Console.WriteLine("10. Sum of Even and Odd Numbers");
                Console.WriteLine("11. Simple Calculator");
                Console.WriteLine("12. Scientific Calculator");
                Console.WriteLine("13. Geometry Calculator");
                Console.WriteLine("14. Print Triangle Pattern");
                Console.WriteLine("15. Print Pyramid Pattern");
                Console.WriteLine("16. Print Diamond Pattern");
                Console.WriteLine("17. Basic ATM System");
                Console.WriteLine("18. Guess the Number Game");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());
                Console.Clear();

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
                        int n3 = int.Parse(Console.ReadLine());
                        PrintResult(LargestOfThree(n1, n2, n3));
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
                        Console.Write("Enter number: ");
                        PrintResult(Factorial(int.Parse(Console.ReadLine())));
                        break;
                    case 10:
                        Console.Write("Enter number: ");
                        PrintResult(SumEvenOdd(double.Parse(Console.ReadLine())));
                        break;
                    case 11:
                        Console.Write("Enter first number: ");
                        double c1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double c2 = double.Parse(Console.ReadLine());
                        Console.Write("Enter operation (/, *, +, -): ");
                        PrintResult(SimpleCalculator(c1, c2, Console.ReadLine()));
                        break;
                    case 12:
                        Console.WriteLine("1.Sin\n2.Cos\n3.Tan\n4.Sqrt\n5.Log\n6.Pow");
                        Console.Write("Choose operation: ");
                        int op = int.Parse(Console.ReadLine());
                        Console.Write("Enter number: ");
                        double num = double.Parse(Console.ReadLine());
                        PrintResult(ScientificCalculator(num, op));
                        break;
                    case 13:
                        Console.WriteLine("1.Circle\n2.Square\n3.Triangle");
                        Console.Write("Choose shape: ");
                        int shape = int.Parse(Console.ReadLine());
                        PrintResult(GeometryCalculator(shape));
                        break;
                    case 14:
                        Console.Write("Enter size: ");
                        PrintResult(PrintTriangle(int.Parse(Console.ReadLine())));
                        break;
                    case 15:
                        Console.Write("Enter size: ");
                        PrintResult(PrintPyramid(int.Parse(Console.ReadLine())));
                        break;
                    case 16:
                        Console.Write("Enter size: ");
                        PrintResult(PrintDiamond(int.Parse(Console.ReadLine())));
                        break;
                    case 17:
                        PrintResult(BasicATM());
                        break;
                    case 18:
                        PrintResult(GuessGame());
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


        // ========================ATM System==========================
        public static string BasicATM()
        {
            Console.WriteLine("1. Check Balance\n2. Deposit\n3. Withdraw");
            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                return "Your balance is: " + atmBalance;
            }
            else if (choice == 2)
            {
                Console.Write("Enter amount to deposit: ");
                double deposit = double.Parse(Console.ReadLine());
                atmBalance = atmBalance + deposit;
                return "New balance: " + atmBalance;
            }
            else if (choice == 3)
            {
                Console.Write("Enter amount to withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                if (withdraw <= atmBalance)
                {
                    atmBalance = atmBalance - withdraw;
                    return "Withdrawal successful. New balance: " + atmBalance;
                }
                return "Insufficient balance.";
            }
            else
            {
                return "Invalid option.";
            }
        }

        // ========================Even or Odd ==========================
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            return "Odd";
        }


        // ========================Largest of Three Numbers=========================
        public static string LargestOfThree(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return "Largest: " + a;
            }
            else if (b >= a && b >= c)
            {
                return "Largest: " + b;
            }
            return "Largest: " + c;
        }

        // ========================Temperature Converter=========================
        public static string TemperatureConverter(int celsius)
        {
            double fahrenheit = (celsius * 9.0 / 5.0) + 32;
            return "Fahrenheit: " + fahrenheit;
        }

        // ========================Discount Calculator=========================
        public static string DiscountCalculator(float price)
        {
            float discount = price * 0.1f;
            float finalPrice = price - discount;
            return "Discounted price: " + finalPrice;
        }

        // ========================Grading System=========================
        public static string GradingSystem(int mark)
        {
            if (mark >= 90)
                return "Grade A";
            else if (mark >= 80)
                return "Grade B";
            else if (mark >= 70)
                return "Grade C";
            else if (mark >= 60)
                return "Grade D";
            else
                return "Grade F";
        }

        // ========================Swap Two Numbers=========================
        public static string SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return "Swapped: a = " + a + ", b = " + b;
        }

        // ========================Days to Weeks Converter=========================
        public static string DaysToWeeks(int days)
        {
            int weeks = days / 7;
            int rem = days % 7;
            return weeks + " week(s) and " + rem + " day(s)";
        }

        // ========================Electricity Bill Calculator=========================
        public static string ElectricityBill(double units)
        {
            double rate = 0.0;
            if (units <= 100)
            {
                rate = 1.5;
            }
            else if (units <= 200)
            {
                rate = 2.0;
            }
            else
            {
                rate = 3.0;
            }
            double bill = units * rate;
            return "Total bill: " + bill;
        }

        // ========================Factorial of a Number=========================
        public static string Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i = i + 1)
            {
                result = result * i;
            }
            return "Factorial: " + result;
        }

        // ========================Sum of Even and Odd Numbers=========================
        public static string SumEvenOdd(double limit)
        {
            int even = 0;
            int odd = 0;
            for (int i = 1; i <= limit; i = i + 1)
            {
                if (i % 2 == 0)
                {
                    even = even + i;
                }
                else
                {
                    odd = odd + i;
                }
            }
            return "Sum of Even: " + even + ", Odd: " + odd;
        }

        // ========================Simple Calculator=========================
        public static string SimpleCalculator(double a, double b, string op)
        {
            if (op == "+")
                return "Result: " + (a + b);
            else if (op == "-")
                return "Result: " + (a - b);
            else if (op == "*")
                return "Result: " + (a * b);
            else if (op == "/")
                return b != 0 ? "Result: " + (a / b) : "Division by zero";
            else
                return "Invalid operator";
        }

        // ========================Scientific Calculator=========================
        public static string ScientificCalculator(double num, int op)
        {
            switch (op)
            {
                case 1: 
                    return "Sin: " + Math.Sin(num);
                case 2: 
                    return "Cos: " + Math.Cos(num);
                case 3: 
                    return "Tan: " + Math.Tan(num);
                case 4: 
                    return num >= 0 ? "Sqrt: " + Math.Sqrt(num) : "Invalid input";
                case 5:
                    return num > 0 ? "Log: " + Math.Log(num) : "Invalid input";
                case 6:
                    Console.Write("Enter exponent: ");
                    double pow = double.Parse(Console.ReadLine());
                    return "Pow: " + Math.Pow(num, pow);
                default: 
                    return "Invalid option";
            }
        }

        // ========================Geometry Calculator=========================
        public static string GeometryCalculator(int shape)
        {
            switch (shape)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double r = double.Parse(Console.ReadLine());
                    return "Area of Circle: " + (Math.PI * r * r);
                case 2:
                    Console.Write("Enter side: ");
                    double s = double.Parse(Console.ReadLine());
                    return "Area of Square: " + (s * s);
                case 3:
                    Console.Write("Enter base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double h = double.Parse(Console.ReadLine());
                    return "Area of Triangle: " + (0.5 * b * h);
                default:
                    return "Invalid shape";
            }
        }

        // ========================Print Patterns=========================
        public static string PrintTriangle(int size)
        {
            string result = "";
            for (int i = 1; i <= size; i = i + 1)
            {
                for (int j = 1; j <= i; j = j + 1)
                {
                    result = result + "*";
                }
                result = result + "\n";
            }
            return result;
        }

        // ========================Print Pyramid=========================
        public static string PrintPyramid(int size)
        {
            string result = "";
            for (int i = 1; i <= size; i = i + 1)
            {
                for (int s = 1; s <= size - i; s = s + 1)
                {
                    result = result + " ";
                }
                for (int j = 1; j <= 2 * i - 1; j = j + 1)
                {
                    result = result + "*";
                }
                result = result + "\n";
            }
            return result;
        }

        // ========================Print Diamond=========================
        public static string PrintDiamond(int size)
        {
            string result = "";
            for (int i = 1; i <= size; i = i + 1)
            {
                for (int s = 1; s <= size - i; s = s + 1)
                {
                    result = result + " ";
                }
                for (int j = 1; j <= 2 * i - 1; j = j + 1)
                {
                    result = result + "*";
                }
                result = result + "\n";
            }
            for (int i = size - 1; i >= 1; i = i - 1)
            {
                for (int s = 1; s <= size - i; s = s + 1)
                {
                    result = result + " ";
                }
                for (int j = 1; j <= 2 * i - 1; j = j + 1)
                {
                    result = result + "*";
                }
                result = result + "\n";
            }
            return result;
        }

        // ========================Guess the Number Game=========================
        public static string GuessGame()
        {
            Random rnd = new Random();
            int target = rnd.Next(1, 101);
            int guess = -1;
            while (guess != target)
            {
                Console.Write("Guess a number between 1 and 100: ");
                guess = int.Parse(Console.ReadLine());
                if (guess > target)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guess < target)
                {
                    Console.WriteLine("Too low!");
                }
            }
            return "Congratulations! You guessed the number.";
        }
    }
}