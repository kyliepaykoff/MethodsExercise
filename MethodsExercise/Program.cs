using System.Diagnostics;

namespace MethodsExercise;

class Program
{
    public static int Sum(int num1, int num2)
    {
        var answer = num1 + num2;
        return answer;
    }

    public static int Multiply(int num1, int num2)
    {
        var answer = num1 * num2;
        return answer;
    }

    public static int Subtract(int num1, int num2)
    {
        var answer = num1 - num2;
        return answer;
    }

    public static int Divide(int num1, int num2)
    {
        var answer = num1 / num2;
        return answer;
    }

    public static int Mod(int num1, int num2)
    {
        var answer = num1 % num2;
        return answer;
    }

    static void Main(string[] args)

    {

        var simpleMathOne = Sum(22, 11);
        var simpleMathTwo = Multiply(22, 11);
        var simpleMathThree = Subtract(22, 11);
        var simpleMathFour = Divide(22, 11);
        var simpleMathFive = Mod(22, 11);



        //-----Exercise 1-----

        Console.WriteLine($"Hello there, what is your name?");
        var userName = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, what is your favorite color {userName}?");
        var color = Console.ReadLine();

        Console.WriteLine($"Cool! I don't have a favorite color, what about your favorite type of animal?");
        var animal = Console.ReadLine();

        Console.WriteLine($"I love {animal} too! One more question, what is your favorite band?");
        var band = Console.ReadLine();

        Console.WriteLine($"It was nice getting to know you a bit {userName}, you rock! " +
            $"I made a short story about our time togehter. " +
            $"Here goes; " +
            $"Today I met {userName} and I learned all kinds of things! Like their favorite color, which is {color}, and band, {band}." +
            $" But the best thing I learned is that we have the same favorite animal! {animal}. It was so nice to talk to {userName}.");
        //-----Exercise 2-----
        Console.WriteLine($"Now, lets do some math. 22 plus 11 is {simpleMathOne}, that multiplied is {simpleMathTwo}." +
            $" Subtracted it is {simpleMathThree}." +
            $" Divided is {simpleMathFour}." +
            $" Lastly, the modulus method answer is {simpleMathFive}.");

    }

    

  }
   