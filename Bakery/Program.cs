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
      Console.WriteLine("Thank you for your order. You total comes to: $");

    }
  }
}