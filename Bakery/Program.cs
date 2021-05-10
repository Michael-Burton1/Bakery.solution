using System;
using System.Collections.Generic;


namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Bon Pan the world renouned bakery of the stars!");
      Console.WriteLine("__________________________________________________________________");
      Console.WriteLine("We have a couple of specials that we are running today:");
      Console.WriteLine("Bread: buy two loaves($5/each) get the thrird one free.");
      Console.WriteLine("How Many Loaves of bread would you like to order?");
      int numberOfOrderedLoaves= int.Parse(Console.ReadLine());
      Console.WriteLine("Pastries: 1 for $2 or 3 for $5");
      Console.WriteLine("How many pastries would you like to order?");
      int numberOfOrderedPastries= int.Parse(Console.ReadLine());
      Int costForBread = int.BreadCost(numberOfOrderedLoaves);
      Int costForPastries = int.PastryCost(numberOfOrderedPastries);
      int tip= 250;
      int total=tip +costForBread+ costForPastries;
      Console.WriteLine("Thank you for your order.");
      Console.WriteLine($"Amount due for Bread: ${costForBread}" );
      Console.WriteLine($"Amount due for Pastries: ${costForPastries}");
      Console.WriteLine($"Amount left for tip: ${tip} (very generous!)");
      Console.WriteLine($"Total amount owed today: ${total}");


    }
  }
}