using System;

namespace Data_Types
{
    class Program
    {
        static void SaveTheChange()
        {
            Console.WriteLine("How much was the item: ");  double itemPrice = double.Parse(Console.ReadLine());
            int itemPriceRounded = (int)Math.Ceiling(itemPrice);
            Console.WriteLine($"{Math.Round(itemPriceRounded-itemPrice, 2)}p was put into savings.");
        }

        static void Dice()
        {
            Console.WriteLine("How many faces do you want your dice to have?");  int sides = int.Parse(Console.ReadLine());
            Random rnd = new Random(); int randomNumber = rnd.Next(1, sides);
            Console.WriteLine("Your randomly generatred number is " + randomNumber);
        }

        static void Clamp()
        {
            Console.WriteLine("Enter a number: "); double number = double.Parse(Console.ReadLine());
            if (number > 50) { Console.WriteLine("50"); }
            if (number <= 50) { Console.WriteLine(number); }
        }

        static void LeapYear()
        {
            Console.WriteLine("Enter a year: ");  int Year = int.Parse(Console.ReadLine());
            if (Year % 100 == 0) { Console.WriteLine("That is not a leap year."); }
            else if (Year % 4 == 0) { Console.WriteLine("That is a leap year."); }
            else if (Year % 400 == 0) { Console.WriteLine("That is a leap year"); }
            else { Console.WriteLine("That is not a leap year."); }
        }

        static void HoursInADay()
        {
            Console.WriteLine("How many hours: ");  double hours = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Convert.ToString((int)Math.Floor(hours / 24))} days");
        }

        static void DiceGame()
        {
            int score = 0;
            Random rnd = new Random();
            int num1 = rnd.Next(1, 7); int num2 = rnd.Next(1, 7); int num3 = rnd.Next(1, 7);
            Console.WriteLine("Your rolls were: " + num1 + "   " + num2 + "   " + num3);
            if (num1 == num2 && num2 == num3) { score += num1 * num1 * num1; }
            else if (num1 == num2) { score += (num1 * num1) - num3; }
            else if (num1 == num3) { score += (num1 * num1) - num2; }
            else if (num2 == num3) { score += (num2 * num2) - num1; }
            else if (num1 != num2 || num1 != num3 || num2 != num3) {}
            Console.WriteLine("You scored " + score + " points");
        }

        static bool Divisable()
        {
            Console.WriteLine("enter your first number: "); double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your second number: "); double num2 = double.Parse(Console.ReadLine());
            if (num1 == 0 || num2 == 0) { return false; }
            else if (num1 % num2 == 0) { return true; }
            else if (num1 % num2 != 0) { return false; }
            else { return false; }
        }

        static void DogAge()
        {
            Console.WriteLine("Enter the actual age of your dog: ");  double dogAge = double.Parse(Console.ReadLine());
            if (dogAge <= 2) { Console.WriteLine($"Your dogs age is {Math.Round(dogAge * 12, 2)} years"); }
            if (dogAge > 2) { Console.WriteLine($"Your dogs age is {Math.Round(24 + (dogAge * 6) - 2, 2)} years"); }
        }

        static void ChargePoint()
        {
            Console.WriteLine("How many minutes have you been charging your car for? "); int minutes = int.Parse(Console.ReadLine());
            if (1 + (0.2 * minutes) < 4) { Console.WriteLine("You have been charged £4 and have been awarded with 22 points."); }
            Console.WriteLine($"You have been charged £{1 + (0.2 * minutes)} and have been awarded with {Math.Floor(minutes * 1.5)} points.");
        }

        static void Main()
        {
            Console.WriteLine("enter 1 for change calculator, enter 2 for unique dice, enter 3 for clamp, enter 4 for leap year, enter 5 for the amount of days, enter 6 for the dice game, enter 7 for division, enter 8 for dog age, enter 9 for charging point solution");  int decision = int.Parse(Console.ReadLine());
            if (decision == 1) { SaveTheChange(); Console.ReadLine(); }
            if (decision == 2) { Dice(); Console.ReadLine(); }
            if (decision == 3) { Clamp(); Console.ReadLine(); }
            if (decision == 4) { LeapYear(); Console.ReadLine(); }
            if (decision == 5) { HoursInADay(); Console.ReadLine(); }
            if (decision == 6) { DiceGame(); Console.ReadLine(); }
            if (decision == 7) { Console.WriteLine(Divisable()); Console.ReadLine(); }
            if (decision == 8) { DogAge(); Console.ReadLine(); }
            if (decision == 9) { ChargePoint(); Console.ReadLine(); }
        }
    }
}